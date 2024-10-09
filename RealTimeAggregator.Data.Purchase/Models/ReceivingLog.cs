using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RealTimeAggregator.Data.Purchase.Models
{
    public class ReceivingLog
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("PurchaseOrder")]
        public int PurchaseOrderID { get; set; }
        public DateTime ReceiveDate { get; set; }

        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}
