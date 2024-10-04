using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RealTimeAggregator.Data.Sales.Models
{
    public class Shipping
    {
        [Key]
        public int ShippingID { get; set; }
        public int SalesOrderID { get; set; }
        public DateTime ShippingDate { get; set; }

        [ForeignKey("SalesOrderID")]
        public SalesOrder SalesOrder { get; set; }
    }
}
