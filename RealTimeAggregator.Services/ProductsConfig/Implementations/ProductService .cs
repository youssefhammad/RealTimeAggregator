using RealTimeAggregator.Data.ProductsConfig.Models;
using RealTimeAggregator.Data.ProductsConfig.Repositories;
using RealTimeAggregator.Services.ProductsConfig.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeAggregator.Services.ProductsConfig.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _productRepository.GetByIdAsync(id);
        }

        public async Task<Product> CreateProductAsync(Product product)
        {
            await _productRepository.AddAsync(product);
            return product;
        }

        public async Task<Product> UpdateProductAsync(Product product)
        {
            await _productRepository.UpdateAsync(product);
            return product;
        }

        public async Task DeleteProductAsync(Product product)
        {
            await _productRepository.DeleteAsync(product);
        }
    }
}
