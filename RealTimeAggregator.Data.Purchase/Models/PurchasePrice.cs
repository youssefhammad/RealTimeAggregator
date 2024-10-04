using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RealTimeAggregator.Data.Purchase.Models
{
    public class PurchasePrice
    {
        [Key]
        public int PurchasePriceID { get; set; }
        public int ProductID { get; set; }
        [ForeignKey("Supplier")]
        public int SupplierID { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
