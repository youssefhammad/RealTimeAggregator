using RealTimeAggregator.Core;
using RealTimeAggregator.Data.Purchase.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeAggregator.Data.Purchase
{
    public interface IPurchasesUnitOfWork : IUnitOfWork
    {
        IPurchaseOrderRepository PurchaseOrder { get; }
        IPurchaseOrderDetailRepository PurchaseOrderDetail{ get; }
        ISupplierRepository Supplier { get; }
    }
}
