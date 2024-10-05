using Couchbase.Query;
using Newtonsoft.Json;
using RealTimeAggregator.Core;
using RealTimeAggregator.Data.ProductsConfig.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeAggregator.Data.ProductsConfig
{
    public class CouchbaseRepository<T> : IRepository<T> where T : class, IEntity
    {
        protected readonly IProductsConfigDbService _dbService;
        protected readonly string _bucketName;
        protected readonly string _collectionName;

        public CouchbaseRepository(IProductsConfigDbService dbService, string bucketName, string collectionName)
        {
            _dbService = dbService;
            _bucketName = bucketName;
            _collectionName = collectionName;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                var cluster = await _dbService.GetClusterAsync();
                var properties = typeof(T).GetProperties()
                    .Where(p => p.GetCustomAttribute<JsonPropertyAttribute>()?.PropertyName != "type")
                    .Select(p =>
                    {
                        var jsonProperty = p.GetCustomAttribute<JsonPropertyAttribute>();
                        return jsonProperty != null ? jsonProperty.PropertyName : p.Name;
                    })
                    .ToList();

                string fieldsString = string.Join(", ", properties);
                string query = $"SELECT {fieldsString} FROM `{_bucketName}`.`_default`.`{_collectionName}`";

                var result = await cluster.QueryAsync<T>(query);
                var resultList = await result.Rows.ToListAsync();

                foreach (var item in resultList)
                {
                    Console.WriteLine($"Retrieved item: {JsonConvert.SerializeObject(item)}");
                }

                return resultList;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllAsync: {ex.Message}");
                throw;
            }
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var bucket = await _dbService.GetBucketAsync();
            var collection = await bucket.CollectionAsync(_collectionName);
            var result = await collection.GetAsync(id.ToString());
            return result.ContentAs<T>();
        }

        public async Task AddAsync(T entity)
        {
            var bucket = await _dbService.GetBucketAsync();
            var collection = await bucket.CollectionAsync(_collectionName);
            await collection.InsertAsync(entity.Id.ToString(), entity);
        }

        public async Task UpdateAsync(T entity)
        {
            var bucket = await _dbService.GetBucketAsync();
            var collection = await bucket.CollectionAsync(_collectionName);
            await collection.ReplaceAsync(entity.Id.ToString(), entity);
        }

        public async Task DeleteAsync(T entity)
        {
            var bucket = await _dbService.GetBucketAsync();
            var collection = await bucket.CollectionAsync(_collectionName);
            await collection.RemoveAsync(entity.Id.ToString());
        }
    }
}
