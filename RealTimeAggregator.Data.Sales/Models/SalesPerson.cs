using System.ComponentModel.DataAnnotations;

namespace RealTimeAggregator.Data.Sales.Models
{
    public class SalesPerson
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }
    }
}
