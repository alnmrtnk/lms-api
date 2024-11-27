using lms_api.Application.Books.Repositories.Interfaces;
using lms_api.Application.Borrows.Interfaces;
using lms_api.Application.Borrows.Models;
using lms_api.Application.Reservations.Repositories.Interfaces;
using lms_api.Infrastructure;

namespace lms_api.Application.Borrows.Contexts
{
    public class BorrowContext
    {
        private IBorrowStrategy _borrowStrategy;

        public void SetStrategy(IBorrowStrategy borrowStrategy)
        {
            _borrowStrategy = borrowStrategy;
        }

        public async Task<int?> ExecuteBorrowAsync(BorrowDto borrowDto, LibraryDbContext dbContext, IReservationRepository reservationRepository, IBookRepository bookRepository)
        {
            if (_borrowStrategy == null)
            {
                throw new InvalidOperationException("Borrow strategy not set.");
            }

            return await _borrowStrategy.ExecuteBorrowAsync(borrowDto, dbContext, reservationRepository, bookRepository);
        }
    }

}
