using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeAggregator.Data.Purchase.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; }
        [Required]
        [MaxLength(255)]
        public string SupplierName { get; set; }
        [MaxLength(255)]
        public string ContactInfo { get; set; }
        [MaxLength(500)]
        public string Address { get; set; }
    }
}
