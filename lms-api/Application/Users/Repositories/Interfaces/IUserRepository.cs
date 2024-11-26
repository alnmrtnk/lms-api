using lms_api.Application.Users.Models;

namespace lms_api.Application.Users.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task AddUserAsync(User user);
        Task<User?> GetUserByEmailAsync(string username);
        Task<bool> ValidateUserCredentialsAsync(string email, string password);

        Task<IEnumerable<User>> GetReaders();
    }
}
