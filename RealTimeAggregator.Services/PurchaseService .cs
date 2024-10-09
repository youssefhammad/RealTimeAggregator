using RealTimeAggregator.Data.Purchase;
using RealTimeAggregator.Data.Purchase.Models;
using RealTimeAggregator.Data.Sales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeAggregator.Services
{
    public class PurchaseService : IPurchaseService
    {
        private readonly PurchaseUnitOfWork _unitOfWork;

        public PurchaseService(PurchaseUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> CreateNewPurchaseAsync(int supplierId, DateTime orderDate, List<PurchaseOrderDetail> orderDetails)
        {
            using var transaction = await _unitOfWork.BeginTransactionAsync();

            try
            {
                // Calculate total amount
                decimal totalAmount = orderDetails.Sum(detail => detail.Price * detail.Quantity);

                // Create new SalesOrder
                var purchase = new PurchaseOrder
                {
                    SupplierID = supplierId,
                    OrderDate = orderDate,
                    TotalAmount = totalAmount
                };

                await _unitOfWork.PurchaseOrder.AddAsync(purchase);
                await _unitOfWork.SaveChangesAsync();

                // Add SalesOrderDetails
                foreach (var detail in orderDetails)
                {
                    var purchaseOrderDetail = new PurchaseOrderDetail
                    {
                        PurchaseOrderID = purchase.Id,
                        ProductID = detail.ProductID,
                        Quantity = detail.Quantity,
                        Price = detail.Price
                    };
                    await _unitOfWork.PurchaseOrderDetail.AddAsync(purchaseOrderDetail);
                }

                await _unitOfWork.SaveChangesAsync();

                await transaction.CommitAsync();

                return purchase.Id;
            }
            catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        public async Task<IEnumerable<Supplier>> GetAllSuppliersAsync()
        {
            return await _unitOfWork.Supplier.GetAllAsync();
        }
    }
}
