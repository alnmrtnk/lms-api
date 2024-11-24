using lms_api.Application.Books.Models;
using lms_api.Application.Users.Models;

namespace lms_api.Application.Reservations.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime ReservationDate { get; set; } = DateTime.UtcNow;
        public DateTime ExpirationDate { get; set; }
        public bool IsActive => ExpirationDate > DateTime.UtcNow;

        public virtual User User { get; set; } = null!;
        public virtual Book Book { get; set; } = null!;
    }
}
