using AutoMapper;
using Lamorenita.Data_Contexts;
using Lamorenita.Data_Entities;
using Lamorenita.Models;
using Microsoft.EntityFrameworkCore;

namespace Lamorenita.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly LamorenitaDbContext _dbContextService;
        private readonly IMapper _mapperService;

        public ProductService(LamorenitaDbContext dbContextService, IMapper mapperService)
        {
            _dbContextService = dbContextService;
            _mapperService = mapperService;
        }

        public async Task<ProductViewModel> CreateProductAsync(ProductCreateModel requestModel)
        {
            var product = await _dbContextService.Product.AddAsync(_mapperService.Map<ProductEntity>(requestModel));
            await _dbContextService.SaveChangesAsync();
            return _mapperService.Map<ProductViewModel>(product.Entity);
        }

        public async Task<IEnumerable<ProductViewModel>> GetAllProductAsync()
        {
            return _mapperService.Map<IEnumerable<ProductViewModel>>(await _dbContextService.Product.ToListAsync());
        }
    }
}
