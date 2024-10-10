using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeAggregator.Kafka.Models
{
    public interface IKafkaMessage
    {
        string Topic { get; }
    }
}
