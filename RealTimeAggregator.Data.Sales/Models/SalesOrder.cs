using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RealTimeAggregator.Data.Sales.Models
{
    public class SalesOrder
    {
        [Key]
        public int Id { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; }
    }
}
