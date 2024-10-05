using RealTimeAggregator.Data.Sales.Models;

namespace RealTimeAggregator.Data.Sales.Repositories
{
    public class SalesOrderDetailRepository : SalesRepository<SalesOrderDetail>, ISalesOrderDetailRepository
    {
        public SalesOrderDetailRepository(SalesDbContext context) : base(context) { }

        // Implement any SalesOrderDetail-specific methods here
    }
}
