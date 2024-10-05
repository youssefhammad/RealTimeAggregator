using Microsoft.EntityFrameworkCore.Storage;
using RealTimeAggregator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeAggregator.Data.Purchase
{
    public class PurchaseUnitOfWork : IUnitOfWork
    {
        private readonly PurchaseDbContext _context;

        public PurchaseUnitOfWork(PurchaseDbContext context)
        {
            _context = context;
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
