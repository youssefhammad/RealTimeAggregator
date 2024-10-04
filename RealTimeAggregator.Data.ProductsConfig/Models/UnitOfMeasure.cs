using RealTimeAggregator.Core;

namespace RealTimeAggregator.Data.ProductsConfig.Models
{
    public class UnitOfMeasure : IEntity
    {
        public int Id { get; set; }
        public string UnitName { get; set; }  // e.g., "Kilogram", "Centimeter", "Liter"
        public string Symbol { get; set; }    // e.g., "kg", "cm", "L"
        public string Description { get; set; }
    }
}
