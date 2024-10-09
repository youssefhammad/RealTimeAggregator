using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RealTimeAggregator.Data.Purchase.Models
{
    public class QualityControl
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("ReceivingLog")]
        public int ReceivingID { get; set; }
        [MaxLength(255)]
        public string InspectionResult { get; set; }

        public virtual ReceivingLog ReceivingLog { get; set; }
    }
}
