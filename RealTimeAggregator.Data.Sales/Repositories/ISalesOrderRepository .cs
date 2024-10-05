using RealTimeAggregator.Core;
using RealTimeAggregator.Data.Sales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeAggregator.Data.Sales.Repositories
{
    public interface ISalesOrderRepository : IRepository<SalesOrder>
    {
        // Add any SalesOrder-specific methods here
    }
}
