using System;
using System.Threading;
using System.Threading.Tasks;
using Confluent.Kafka;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace RealTimeAggregator.Kafka.Services
{
    public class KafkaConsumerService : IKafkaConsumerService, IHostedService
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<KafkaConsumerService> _logger;
        private readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        private Task _consumerTask;

        public event Action<string, string> OnMessageReceived;

        public KafkaConsumerService(IConfiguration configuration, ILogger<KafkaConsumerService> logger)
        {
            _configuration = configuration;
            _logger = logger;
            _logger.LogInformation("KafkaConsumerService constructor called.");
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("KafkaConsumerService StartAsync called.");
            var topicsSection = _configuration.GetSection("Kafka:Topics");
            var topics = topicsSection.GetChildren().Select(x => x.Value).ToArray();
            _logger.LogInformation($"Topics to subscribe: {string.Join(", ", topics)}");
            _consumerTask = Task.Run(() => StartConsumerLoop(topics));
            _logger.LogInformation("Consumer loop task started.");
            return Task.CompletedTask;
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("KafkaConsumerService StopAsync called.");
            _cancellationTokenSource.Cancel();
            if (_consumerTask != null)
            {
                await _consumerTask;
            }
            _logger.LogInformation("Consumer loop stopped.");
        }

       

        public async Task StopConsumerLoop()
        {
            Console.WriteLine("StopConsumerLoop called.");
            _cancellationTokenSource.Cancel();
            if (_consumerTask != null)
            {
                await _consumerTask;
                Console.WriteLine("Consumer task completed.");
            }
        }

        public async Task StartConsumerLoop(string[] topics)
        {
            _logger.LogInformation("Entering StartConsumerLoop.");
            var config = new ConsumerConfig
            {
                BootstrapServers = _configuration["Kafka:BootstrapServers"],
                GroupId = _configuration["Kafka:GroupId"],
                AutoOffsetReset = AutoOffsetReset.Earliest,
                EnableAutoCommit = false
            };

            _logger.LogInformation($"Kafka configuration: BootstrapServers={config.BootstrapServers}, GroupId={config.GroupId}");

            using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
            consumer.Subscribe(topics);
            _logger.LogInformation($"Subscribed to topics: {string.Join(", ", topics)}");

            try
            {
                while (!_cancellationTokenSource.Token.IsCancellationRequested)
                {
                    try
                    {
                        _logger.LogDebug("Attempting to consume message...");
                        var consumeResult = consumer.Consume(TimeSpan.FromMilliseconds(100));
                        if (consumeResult != null)
                        {
                            _logger.LogInformation($"Message consumed from topic: {consumeResult.Topic}, value: {consumeResult.Message.Value}");
                            OnMessageReceived?.Invoke(consumeResult.Topic, consumeResult.Message.Value);
                            consumer.Commit(consumeResult);
                        }
                    }
                    catch (ConsumeException e)
                    {
                        _logger.LogError($"Consume error: {e.Error.Reason}");
                    }
                    catch (OperationCanceledException)
                    {
                        _logger.LogInformation("Cancellation requested, breaking consume loop.");
                        break;
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError($"Unexpected error in consume loop: {ex.Message}");
                    }

                    await Task.Delay(100, _cancellationTokenSource.Token); // Add a small delay between consume attempts
                }
            }
            catch (OperationCanceledException)
            {
                // Normal cancellation, do nothing
            }
            finally
            {
                consumer.Close();
                _logger.LogInformation("Kafka consumer closed.");
            }
        }
    }
}
