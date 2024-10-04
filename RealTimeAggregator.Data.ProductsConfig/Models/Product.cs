using RealTimeAggregator.Core;

namespace RealTimeAggregator.Data.ProductsConfig.Models
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int UnitOfMeasureId { get; set; }  // Reference to UnitOfMeasure
        public decimal Quantity { get; set; }
        public List<ProductAttribute> Attributes { get; set; } = new List<ProductAttribute>();
    }
}
