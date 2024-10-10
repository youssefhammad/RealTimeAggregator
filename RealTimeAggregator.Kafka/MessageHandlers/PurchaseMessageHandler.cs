using RealTimeAggregator.Kafka.Models;

namespace RealTimeAggregator.Kafka.MessageHandlers
{
    public class PurchaseMessageHandler : BaseMessageHandler<PurchaseMessage>
    {
        public override string Topic => "purchase_total_amount_topic";
    }
}
