using RealTimeAggregator.Kafka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeAggregator.Kafka.MessageProcessor
{
    public interface IMessageProcessor
    {
        event Action<IKafkaMessage> OnMessageProcessed;
        void Initialize();
    }
}
