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
    public class SalesUnitOfWork : ISalesUnitOfWork
    {
        private readonly SalesDbContext _context;

        public ISalesOrderRepository SalesOrders { get; }
        public ISalesOrderDetailRepository SalesOrderDetails { get; }
        public ICustomerRepository Customers { get; }

        public SalesUnitOfWork(SalesDbContext context)
        {
            _context = context;
            SalesOrders = new SalesOrderRepository(_context);
            SalesOrderDetails = new SalesOrderDetailRepository(_context);
            Customers = new CustomerRepository(_context);
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
