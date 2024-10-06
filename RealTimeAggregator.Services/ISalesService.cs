using RealTimeAggregator.Data.Sales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeAggregator.Services
{
    public interface ISalesService
    {
        Task<int> CreateNewSaleAsync(int customerId, DateTime orderDate, List<SalesOrderDetail> orderDetails);
        Task<IEnumerable<Customer>> GetAllCustomersAsync();
    }
}
