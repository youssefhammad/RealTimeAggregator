using Newtonsoft.Json;
using RealTimeAggregator.Core;

namespace RealTimeAggregator.Data.ProductsConfig.Models
{
    public class UnitOfMeasure : IEntity
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("unitName")]
        public string UnitName { get; set; }  // e.g., "Kilogram", "Centimeter", "Liter"

        [JsonProperty("symbol")]
        public string Symbol { get; set; }    // e.g., "kg", "cm", "L"

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
