using RealTimeAggregator.Kafka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeAggregator.Kafka.MessageHandlers
{
    public class SalesMessageHandler : BaseMessageHandler<SalesMessage>
    {
        public override string Topic => "sales_total_amount_topic";
    }
}
