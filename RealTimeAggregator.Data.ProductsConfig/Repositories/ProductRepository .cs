using RealTimeAggregator.Data.ProductsConfig.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeAggregator.Data.ProductsConfig.Repositories
{
    public class ProductRepository : CouchbaseRepository<Product>, IProductRepository
    {
        public ProductRepository(IProductsConfigDbService dbService)
            : base(dbService, "product_config", "products")
        {
        }
    }
}
