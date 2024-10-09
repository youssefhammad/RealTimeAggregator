using System.ComponentModel.DataAnnotations;

namespace RealTimeAggregator.Data.Sales.Models
{
    public class Discount
    {
        [Key]
        public int Id { get; set; }
        public string DiscountName { get; set; }
        public decimal DiscountRate { get; set; }
    }
}
