using RealTimeAggregator.Data.Sales;
using RealTimeAggregator.Data.Sales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeAggregator.Services
{
    public class SalesService : ISalesService
    {
        private readonly ISalesUnitOfWork _unitOfWork;

        public SalesService(ISalesUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> CreateNewSaleAsync(int customerId, DateTime orderDate, decimal totalAmount, List<SalesOrderDetail> orderDetails)
        {
            using var transaction = await _unitOfWork.BeginTransactionAsync();

            try
            {
                // Create new SalesOrder
                var salesOrder = new SalesOrder
                {
                    CustomerID = customerId,
                    OrderDate = orderDate,
                    TotalAmount = totalAmount
                };

                await _unitOfWork.SalesOrders.AddAsync(salesOrder);
                await _unitOfWork.SaveChangesAsync();

                // Add SalesOrderDetails
                foreach (var detail in orderDetails)
                {
                    detail.SalesOrderID = salesOrder.SalesOrderID;
                    await _unitOfWork.SalesOrderDetails.AddAsync(detail);
                }

                await _unitOfWork.SaveChangesAsync();

                await transaction.CommitAsync();

                return salesOrder.SalesOrderID;
            }
            catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
        {
            return await _unitOfWork.Customers.GetAllAsync();
        }
    }
}
