using AutoMapper;
using Lamorenita.Data_Contexts;
using Lamorenita.Data_Entities;
using Lamorenita.Models;
using Microsoft.EntityFrameworkCore;

namespace Lamorenita.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly LamorenitaDbContext _dbContextService;
        private readonly IMapper _mapperService;

        public UserService(LamorenitaDbContext dbContextService, IMapper mapperService)
        {
            _dbContextService = dbContextService;
            _mapperService = mapperService;
        }

        public async Task<UserViewModel> CreateUserAsync(UserCreateModel requestModel)
        {
            var user = await _dbContextService.User.AddAsync(_mapperService.Map<UserEntity>(requestModel));
            await _dbContextService.SaveChangesAsync();
            return _mapperService.Map<UserViewModel>(user.Entity);

        }

        public async Task<IEnumerable<UserViewModel>> getAllUsersAsync()
        {
            return _mapperService.Map<IEnumerable<UserViewModel>>(await _dbContextService.User.ToListAsync());
        }
    }
}
