using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RealTimeAggregator.Kafka.Models
{
    public class ProfitMessage : IKafkaMessage
    {
        [JsonPropertyName("PROFIT")]
        public decimal NetProfit { get; set; }

        public string Topic => "profit_topic";
    }
}
