using Newtonsoft.Json;
using RealTimeAggregator.Core;

namespace RealTimeAggregator.Data.ProductsConfig.Models
{
    public class Product : IEntity
    {
        public Product() 
        {
            Id = Guid.NewGuid().ToString();
        }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }
        [JsonProperty("productName")]
        public string ProductName { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("unitOfMeasureId")]
        public string UnitOfMeasureId { get; set; }  // Reference to UnitOfMeasure
        [JsonProperty("quantity")]
        public decimal Quantity { get; set; }
        public List<ProductAttribute> Attributes { get; set; } = new List<ProductAttribute>();
    }
}
