using lms_api.Application.Books.Repositories.Interfaces;
using lms_api.Application.Borrows.Models;
using lms_api.Application.Reservations.Repositories.Interfaces;
using lms_api.Infrastructure;

namespace lms_api.Application.Borrows.Interfaces
{
    public interface IBorrowStrategy
    {
        Task<int?> ExecuteBorrowAsync(BorrowDto borrowDto, LibraryDbContext dbContext, IReservationRepository reservationRepository, IBookRepository bookRepository);
    }

}
