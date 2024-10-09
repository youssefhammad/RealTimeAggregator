using System.ComponentModel.DataAnnotations;

namespace RealTimeAggregator.Data.Sales.Models
{
    public class ProductPrice
    {
        [Key]
        public int Id { get; set; }
        public int ProductID { get; set; }
        public decimal Price { get; set; }
        public DateTime EffectiveDate { get; set; }
    }
}
