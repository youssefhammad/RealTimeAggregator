using RealTimeAggregator.Data.Purchase.Models;
using RealTimeAggregator.Data.Sales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeAggregator.Services
{
    public interface IPurchaseService
    {
        Task<int> CreateNewPurchaseAsync(int supplierId, DateTime orderDate, List<PurchaseOrderDetail> orderDetails);
        Task<IEnumerable<Supplier>> GetAllSuppliersAsync();
    }
}
