using RealTimeAggregator.Data.ProductsConfig.Models;
using RealTimeAggregator.Data.ProductsConfig.Repositories;
using RealTimeAggregator.Services.ProductsConfig.Interfaces;

namespace RealTimeAggregator.Services.ProductsConfig.Implementations
{
    public class UnitOfMeasureService : IUnitOfMeasureService
    {
        private readonly IUnitOfMeasureRepository _unitOfMeasureRepository;

        public UnitOfMeasureService(IUnitOfMeasureRepository unitOfMeasureRepository)
        {
            _unitOfMeasureRepository = unitOfMeasureRepository;
        }

        public async Task<IEnumerable<UnitOfMeasure>> GetAllUnitOfMeasuresAsync()
        {
            return await _unitOfMeasureRepository.GetAllAsync();
        }

        public async Task<UnitOfMeasure> GetUnitOfMeasureByIdAsync(int id)
        {
            return await _unitOfMeasureRepository.GetByIdAsync(id);
        }

        public async Task<UnitOfMeasure> CreateUnitOfMeasureAsync(UnitOfMeasure unitOfMeasure)
        {
            await _unitOfMeasureRepository.AddAsync(unitOfMeasure);
            return unitOfMeasure;
        }

        public async Task<UnitOfMeasure> UpdateUnitOfMeasureAsync(UnitOfMeasure unitOfMeasure)
        {
            await _unitOfMeasureRepository.UpdateAsync(unitOfMeasure);
            return unitOfMeasure;
        }

        public async Task DeleteUnitOfMeasureAsync(UnitOfMeasure unitOfMeasure)
        {
            await _unitOfMeasureRepository.DeleteAsync(unitOfMeasure);
        }
    }
}
