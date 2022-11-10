using AutoMapper;
using Lamorenita.Data_Contexts;
using Lamorenita.Data_Entities;
using Lamorenita.Models;
using Microsoft.EntityFrameworkCore;

namespace Lamorenita.Services.Implementations
{
    public class ProductTypeService : IProductTypeService
    {
        private readonly LamorenitaDbContext _dbContextService;
        private readonly IMapper _mapperService;

        // CONSTRUCTOR 
        public ProductTypeService(LamorenitaDbContext dbContextService, IMapper mapperService)
        {
            _dbContextService = dbContextService;
            _mapperService = mapperService;
        }

        //CREATE METHOD INTO SERVICE
        public async Task<ProductTypeViewModel> CreateProducTypeAsync(ProductTypeCreateModel requestModel)
        {
            var productType = await _dbContextService.ProductType.AddAsync(_mapperService.Map<ProductTypeEntity>(requestModel));
            await _dbContextService.SaveChangesAsync();
            return _mapperService.Map<ProductTypeViewModel>(productType.Entity);
        }

        public async Task<IEnumerable<ProductTypeViewModel>> getAllProductTypeAsync()
        {
            return _mapperService.Map<IEnumerable<ProductTypeViewModel>>(await _dbContextService.ProductType.ToListAsync());
        }
    }
}
