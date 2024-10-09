using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeAggregator.Data.Sales.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string ContactInfo { get; set; }
        public string Address { get; set; }
    }
}
