using Microsoft.EntityFrameworkCore;
using RealTimeAggregator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeAggregator.Data.Sales
{
    public class SalesRepository<T> : IRepository<T> where T : class, IEntity
    {
        protected readonly SalesDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public SalesRepository(SalesDbContext context)
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
