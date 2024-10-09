using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RealTimeAggregator.Data.Purchase.Models
{
    public class PurchaseOrderDetail
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("PurchaseOrder")]
        public int PurchaseOrderID { get; set; }
        public string ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}
