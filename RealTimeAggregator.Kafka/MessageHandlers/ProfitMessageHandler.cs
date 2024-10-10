using RealTimeAggregator.Kafka.Models;

namespace RealTimeAggregator.Kafka.MessageHandlers
{
    public class ProfitMessageHandler : BaseMessageHandler<ProfitMessage>
    {
        public override string Topic => "profit_topic";
    }
}
