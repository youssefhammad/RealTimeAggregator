using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RealTimeAggregator.Data.Purchase.Models
{
    public class PurchaseOrder
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Supplier")]
        public int SupplierID { get; set; }
        public DateTime OrderDate { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
