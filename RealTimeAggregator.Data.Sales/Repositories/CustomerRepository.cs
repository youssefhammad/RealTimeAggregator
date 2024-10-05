using RealTimeAggregator.Data.Sales.Models;

namespace RealTimeAggregator.Data.Sales.Repositories
{
    public class CustomerRepository : SalesRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(SalesDbContext context) : base(context) { }

        // Implement any Customer-specific methods here
    }
}
