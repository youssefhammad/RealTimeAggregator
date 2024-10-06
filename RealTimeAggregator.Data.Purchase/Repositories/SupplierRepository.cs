using RealTimeAggregator.Data.Purchase.Models;

namespace RealTimeAggregator.Data.Purchase.Repositories
{
    public class SupplierRepository : PurchaseRepository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(PurchaseDbContext context) : base(context)
        {
        }
    }
}
