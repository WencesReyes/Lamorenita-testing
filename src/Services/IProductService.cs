using Lamorenita.Models;

namespace Lamorenita.Services
{
    public interface IProductService
    {
        Task<ProductViewModel> CreateProductAsync(ProductCreateModel requestModel);
        Task<IEnumerable<ProductViewModel>> GetAllProductAsync();
    }
}
