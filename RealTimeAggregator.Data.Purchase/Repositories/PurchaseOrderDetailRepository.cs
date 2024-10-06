using RealTimeAggregator.Data.Purchase.Models;

namespace RealTimeAggregator.Data.Purchase.Repositories
{
    public class PurchaseOrderDetailRepository : PurchaseRepository<PurchaseOrderDetail>, IPurchaseOrderDetailRepository
    {
        public PurchaseOrderDetailRepository(PurchaseDbContext context) : base(context)
        {
        }
    }
}
