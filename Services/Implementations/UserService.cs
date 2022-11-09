using Lamorenita.Data_Contexts;
using Lamorenita.Models;

namespace Lamorenita.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly LamorenitaDbContext _dbContextService;

        public UserService(LamorenitaDbContext dbContextService)
        {
            _dbContextService = dbContextService;
        }

        public async Task<UserViewModel> CreateUserAsync(UserCreateModel requestMo)
        {

        }
    }
}
