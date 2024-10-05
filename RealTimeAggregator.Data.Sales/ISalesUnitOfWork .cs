using Microsoft.EntityFrameworkCore.Storage;
using RealTimeAggregator.Core;
using RealTimeAggregator.Data.Sales.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeAggregator.Data.Sales
{
    public interface ISalesUnitOfWork : IUnitOfWork
    {
        ISalesOrderRepository SalesOrders { get; }
        ISalesOrderDetailRepository SalesOrderDetails { get; }
        ICustomerRepository Customers { get; }
    }
}
