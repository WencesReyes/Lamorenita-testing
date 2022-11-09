using Lamorenita.Models;

namespace Lamorenita.Services
{
    public interface IProductTypeService
    {
        Task<ProductTypeViewModel> CreateProducTypeAsync(ProductTypeCreateModel requestModel);
        Task<IEnumerable<ProductTypeViewModel>> getAllProductTypeAsync();
    }
}
