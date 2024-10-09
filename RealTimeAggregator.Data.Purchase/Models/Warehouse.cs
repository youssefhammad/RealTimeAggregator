using System.ComponentModel.DataAnnotations;

namespace RealTimeAggregator.Data.Purchase.Models
{
    public class Warehouse
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string WarehouseName { get; set; }
        [MaxLength(500)]
        public string Location { get; set; }
    }
}
