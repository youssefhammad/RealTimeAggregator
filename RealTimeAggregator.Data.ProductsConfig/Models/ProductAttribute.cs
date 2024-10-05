using Newtonsoft.Json;

namespace RealTimeAggregator.Data.ProductsConfig.Models
{
    public class ProductAttribute
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
