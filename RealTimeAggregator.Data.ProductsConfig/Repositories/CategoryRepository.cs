using RealTimeAggregator.Data.ProductsConfig.Models;

namespace RealTimeAggregator.Data.ProductsConfig.Repositories
{
    public class CategoryRepository : CouchbaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(IProductsConfigDbService dbService)
            : base(dbService, "product_config", "categories")
        {
        }
    }
}
