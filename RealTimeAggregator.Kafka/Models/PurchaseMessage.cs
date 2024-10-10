using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RealTimeAggregator.Kafka.Models
{
    public class PurchaseMessage : IKafkaMessage
    {
        [JsonPropertyName("TOTALAMOUNTSUM")]
        public decimal TotalPurchases { get; set; }

        public string Topic => "purchase_total_amount_topic";
    }
}
