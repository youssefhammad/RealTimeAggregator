using RealTimeAggregator.Kafka.MessageHandlers;
using RealTimeAggregator.Kafka.Models;
using RealTimeAggregator.Kafka.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeAggregator.Kafka.MessageProcessor
{
    public class MessageProcessor : IMessageProcessor
    {
        private readonly IKafkaConsumerService _kafkaConsumerService;
        private readonly IEnumerable<IMessageHandler> _messageHandlers;

        public event Action<IKafkaMessage> OnMessageProcessed;

        public MessageProcessor(
            IKafkaConsumerService kafkaConsumerService,
            IEnumerable<IMessageHandler> messageHandlers)
        {
            _kafkaConsumerService = kafkaConsumerService;
            _messageHandlers = messageHandlers;
        }

        public void Initialize()
        {
            _kafkaConsumerService.OnMessageReceived += HandleMessage;

            foreach (var handler in _messageHandlers)
            {
                handler.OnMessageProcessed += message => OnMessageProcessed?.Invoke(message);
            }
        }

        private void HandleMessage(string topic, string message)
        {
            var handler = _messageHandlers.FirstOrDefault(h => h.Topic == topic);
            handler?.HandleMessage(message);
        }
    }
}
