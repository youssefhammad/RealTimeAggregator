using RealTimeAggregator.Data.Sales.Models;

namespace RealTimeAggregator.Data.Sales.Repositories
{
    public class SalesOrderRepository : SalesRepository<SalesOrder>, ISalesOrderRepository
    {
        public SalesOrderRepository(SalesDbContext context) : base(context) { }

        // Implement any SalesOrder-specific methods here
    }
}
