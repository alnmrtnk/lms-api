using System.Data;

namespace lms_api.Application.Users.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string PasswordHash { get; set; }
        public required string Email { get; set; }
        public required string Role { get; set; }
    }
}
