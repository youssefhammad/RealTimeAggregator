using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RealTimeAggregator.Data.Sales.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        public int SalesOrderID { get; set; }
        public decimal Amount { get; set; }

        [ForeignKey("SalesOrderID")]
        public SalesOrder SalesOrder { get; set; }
    }
}
