using RealTimeAggregator.Kafka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeAggregator.Kafka.MessageHandlers
{
    public interface IMessageHandler
    {
        event Action<IKafkaMessage> OnMessageProcessed;
        void HandleMessage(string message);
        string Topic { get; }
    }
}
