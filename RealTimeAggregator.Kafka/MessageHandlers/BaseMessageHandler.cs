using RealTimeAggregator.Kafka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RealTimeAggregator.Kafka.MessageHandlers
{
    public abstract class BaseMessageHandler<T> : IMessageHandler where T : IKafkaMessage
    {
        public event Action<IKafkaMessage> OnMessageProcessed;

        public abstract string Topic { get; }

        public void HandleMessage(string message)
        {
            var kafkaMessage = JsonSerializer.Deserialize<T>(message);
            OnMessageProcessed?.Invoke(kafkaMessage);
        }
    }
}
