using Microsoft.EntityFrameworkCore;
using RealTimeAggregator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeAggregator.Data.Purchase
{
    public class PurchaseRepository<T> : IRepository<T> where T : class
    {
        protected readonly PurchaseDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public PurchaseRepository(PurchaseDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public Task AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        // Implement IRepository methods
    }

}
