using RealTimeAggregator.Data.ProductsConfig.Models;

namespace RealTimeAggregator.Services.ProductsConfig.Interfaces
{
    public interface IUnitOfMeasureService
    {
        Task<IEnumerable<UnitOfMeasure>> GetAllUnitOfMeasuresAsync();
        Task<UnitOfMeasure> GetUnitOfMeasureByIdAsync(int id);
        Task<UnitOfMeasure> CreateUnitOfMeasureAsync(UnitOfMeasure unitOfMeasure);
        Task<UnitOfMeasure> UpdateUnitOfMeasureAsync(UnitOfMeasure unitOfMeasure);
        Task DeleteUnitOfMeasureAsync(UnitOfMeasure unitOfMeasure);
    }
}
