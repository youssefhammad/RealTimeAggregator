using Couchbase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeAggregator.Data.ProductsConfig
{
    public interface IProductsConfigDbService
    {
        Task<IBucket> GetBucketAsync();
        Task<ICluster> GetClusterAsync();
    }
}
