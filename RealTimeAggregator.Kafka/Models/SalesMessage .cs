using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RealTimeAggregator.Kafka.Models
{
    public class SalesMessage : IKafkaMessage
    {
        [JsonPropertyName("TOTALAMOUNTSUM")]
        public decimal TotalSales { get; set; }

        public string Topic => "sales_total_amount_topic";
    }
}
