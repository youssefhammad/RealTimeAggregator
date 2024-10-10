using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeAggregator.Kafka.Services
{
    public interface IKafkaConsumerService
    {
        event Action<string, string> OnMessageReceived;
        Task StartConsumerLoop(string[] topics);
        Task StopConsumerLoop();
    }
}
