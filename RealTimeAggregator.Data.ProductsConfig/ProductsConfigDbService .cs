using Couchbase;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeAggregator.Data.ProductsConfig
{
    public class ProductsConfigDbService : IProductsConfigDbService
    {
        private readonly ProductsConfigDbConfiguration _configuration;
        private ICluster _cluster;

        public ProductsConfigDbService(IOptions<ProductsConfigDbConfiguration> configuration)
        {
            _configuration = configuration.Value;
        }

        public async Task<ICluster> GetClusterAsync()
        {
            if (_cluster == null)
            {
                var options = new ClusterOptions()
                    .WithCredentials(_configuration.Username, _configuration.Password)
                    .WithConnectionString(_configuration.ConnectionString);

                _cluster = await Cluster.ConnectAsync(options);
            }

            return _cluster;
        }

        public async Task<IBucket> GetBucketAsync()
        {
            var cluster = await GetClusterAsync();
            return await cluster.BucketAsync(_configuration.BucketName);
        }
    }
}
