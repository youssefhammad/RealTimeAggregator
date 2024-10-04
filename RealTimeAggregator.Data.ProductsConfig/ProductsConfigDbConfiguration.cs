using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeAggregator.Data.ProductsConfig
{
    public class ProductsConfigDbConfiguration
    {
        public string ConnectionString { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string BucketName { get; set; }
    }
}
