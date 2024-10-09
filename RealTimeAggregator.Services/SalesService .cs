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

        public async Task<int> CreateNewSaleAsync(int customerId, DateTime orderDate, List<SalesOrderDetail> orderDetails)
        {
            using var transaction = await _unitOfWork.BeginTransactionAsync();

            try
            {
                // Calculate total amount
                decimal totalAmount = orderDetails.Sum(detail => detail.Price * detail.Quantity);

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
                    var salesOrderDetail = new SalesOrderDetail
                    {
                        SalesOrderID = salesOrder.Id,
                        ProductID = detail.ProductID,
                        Quantity = detail.Quantity,
                        Price = detail.Price
                    };
                    await _unitOfWork.SalesOrderDetails.AddAsync(salesOrderDetail);
                }

                await _unitOfWork.SaveChangesAsync();

                await transaction.CommitAsync();

                return salesOrder.Id;
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
