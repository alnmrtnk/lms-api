using lms_api.Application.Reservations.Models;
using lms_api.Application.Reservations.Repositories.Interfaces;
using lms_api.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lms_api.Application.Reservations.Repositories.Implementations
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly LibraryDbContext _dbContext;

        public ReservationRepository(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Reservation>> GetAll()
        {
            return await _dbContext.Reservations.Include(x => x.User).Include(x => x.Book).ToListAsync();
        }

        public async Task<Reservation> GetReservation(int id)
        {
            return await _dbContext.Reservations.FirstAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Reservation>> GetAllByUserId(int id)
        {
            return await _dbContext.Reservations.Where(b => b.UserId == id).ToListAsync();
        }

        public async Task<IEnumerable<Reservation>> GetAllByBookId(int id)
        {
            return await _dbContext.Reservations.Where(b => b.BookId == id).ToListAsync();
        }

        public async Task<Reservation> GetReservationByDetails(int userId, int bookId)
        {
            return await _dbContext.Reservations.FirstAsync(r => r.UserId == userId && r.BookId == bookId);
        }

        public async Task<bool> AddReservation(ReservationDto reservationDto)
        {
            var book = await _dbContext.Books.FindAsync(reservationDto.BookId);
            if (book == null || book.CopiesAvailable <= 0)
            {
                return false;
            }

            var activeReservationsCount = _dbContext.Reservations
                .AsEnumerable()
                .Count(r => r.BookId == reservationDto.BookId && r.IsActive);

            if (activeReservationsCount >= book.CopiesAvailable)
            {
                return false;
            }

            var reservation = new Reservation
            {
                UserId = reservationDto.UserId,
                BookId = reservationDto.BookId,
                ReservationDate = DateTime.UtcNow,
                ExpirationDate = DateTime.UtcNow.AddHours(48)
            };

            await _dbContext.Reservations.AddAsync(reservation);
            await _dbContext.SaveChangesAsync();

            return true;
        }


        public async Task<bool> CancelReservation(int id)
        {
            var reservation = await _dbContext.Reservations
                .FirstOrDefaultAsync(r => r.Id == id);

            if (reservation == null)
            {
                return false;
            }

            if (!reservation.IsActive)
            {
                return false;
            }

            reservation.ExpirationDate = DateTime.UtcNow;
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
