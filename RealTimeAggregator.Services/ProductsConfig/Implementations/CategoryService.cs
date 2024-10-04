using RealTimeAggregator.Data.ProductsConfig.Models;
using RealTimeAggregator.Data.ProductsConfig.Repositories;
using RealTimeAggregator.Services.ProductsConfig.Interfaces;

namespace RealTimeAggregator.Services.ProductsConfig.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await _categoryRepository.GetAllAsync();
        }

        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            return await _categoryRepository.GetByIdAsync(id);
        }

        public async Task<Category> CreateCategoryAsync(Category category)
        {
            await _categoryRepository.AddAsync(category);
            return category;
        }

        public async Task<Category> UpdateCategoryAsync(Category category)
        {
            await _categoryRepository.UpdateAsync(category);
            return category;
        }

        public async Task DeleteCategoryAsync(Category category)
        {
            await _categoryRepository.DeleteAsync(category);
        }
    }
}
