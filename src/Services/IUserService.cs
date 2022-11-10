using Lamorenita.Models;

namespace Lamorenita.Services
{
    public interface IUserService
    {
        Task<UserViewModel> CreateUserAsync(UserCreateModel requestModel);
        Task<IEnumerable<UserViewModel>> getAllUsersAsync();
    }
}
