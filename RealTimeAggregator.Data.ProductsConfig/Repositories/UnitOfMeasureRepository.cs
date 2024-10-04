using RealTimeAggregator.Data.ProductsConfig.Models;

namespace RealTimeAggregator.Data.ProductsConfig.Repositories
{
    public class UnitOfMeasureRepository : CouchbaseRepository<UnitOfMeasure>, IUnitOfMeasureRepository
    {
        public UnitOfMeasureRepository(IProductsConfigDbService dbService)
            : base(dbService, "product_config", "units_of_measure")
        {
        }
    }
}
