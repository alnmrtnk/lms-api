using lms_api.Application.Users.Models;
using lms_api.Application.Users.Repositories.Interfaces;
using lms_api.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace lms_api.Application.Users.Repositories.Implementations
{
    public class UserRepository(
        LibraryDbContext _context
        ) : IUserRepository
    {
        public async Task AddUserAsync(User user)
        {
            user.PasswordHash = HashPassword(user.PasswordHash);
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User?> GetUserByEmailAsync(string email)
        {
            return await _context.Users.FirstAsync(u => u.Email == email);
        }

        public async Task<bool> ValidateUserCredentialsAsync(string email, string password)
        {
            var user = await GetUserByEmailAsync(email);
            return user != null && user.PasswordHash == HashPassword(password);
        }

        public async Task<IEnumerable<User>> GetReaders()
        {
            return await _context.Users.Where(u => u.Role == "Reader").ToListAsync();
        }

        private string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }
    }
}
