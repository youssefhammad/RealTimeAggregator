using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RealTimeAggregator.Data.Purchase.Models
{
    public class PurchaseOrderDetail
    {
        [Key]
        public int PurchaseOrderDetailID { get; set; }
        [ForeignKey("PurchaseOrder")]
        public int PurchaseOrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }

        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}
