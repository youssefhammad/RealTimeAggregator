using RealTimeAggregator.Data.Purchase.Models;

namespace RealTimeAggregator.Data.Purchase.Repositories
{
    public class PurchaseOrderrepository : PurchaseRepository<PurchaseOrder>, IPurchaseOrderRepository
    {
        public PurchaseOrderrepository(PurchaseDbContext context) : base(context)
        {
        }
    }
}
