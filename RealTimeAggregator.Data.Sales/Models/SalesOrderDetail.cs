using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RealTimeAggregator.Data.Sales.Models
{
    public class SalesOrderDetail
    {
        [Key]
        public int SalesOrderDetailID { get; set; }
        public int SalesOrderID { get; set; }
        public string ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        [ForeignKey("SalesOrderID")]
        public SalesOrder SalesOrder { get; set; }
    }
}
