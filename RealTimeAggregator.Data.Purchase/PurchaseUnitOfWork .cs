using Microsoft.EntityFrameworkCore.Storage;
using RealTimeAggregator.Core;
using RealTimeAggregator.Data.Purchase.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeAggregator.Data.Purchase
{
    public class PurchaseUnitOfWork : IPurchasesUnitOfWork
    {
        private readonly PurchaseDbContext _context;

        public IPurchaseOrderRepository PurchaseOrder { get; }

        public IPurchaseOrderDetailRepository PurchaseOrderDetail { get; }

        public ISupplierRepository Supplier { get; }

        public PurchaseUnitOfWork(PurchaseDbContext context)
        {
            _context = context;
            PurchaseOrder = new PurchaseOrderrepository(_context);
            PurchaseOrderDetail = new PurchaseOrderDetailRepository(_context);
            Supplier = new SupplierRepository(_context);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public async Task<IDbContextTransaction> BeginTransactionAsync()
        {
            return await _context.Database.BeginTransactionAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
