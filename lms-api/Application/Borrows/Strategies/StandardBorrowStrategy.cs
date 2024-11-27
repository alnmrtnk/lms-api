using lms_api.Application.Books.Repositories.Interfaces;
using lms_api.Application.Borrows.Interfaces;
using lms_api.Application.Borrows.Models;
using lms_api.Application.Reservations.Repositories.Interfaces;
using lms_api.Infrastructure;

namespace lms_api.Application.Borrows.Strategies
{
    public class StandardBorrowStrategy : IBorrowStrategy
    {
        public async Task<int?> ExecuteBorrowAsync(BorrowDto borrowDto, LibraryDbContext dbContext, IReservationRepository reservationRepository, IBookRepository bookRepository)
        {
            var book = await bookRepository.GetBook(borrowDto.BookId);
            if (book.CopiesAvailable == 0)
            {
                return null;
            }

            var activeReservation = reservationRepository.GetAllByUserId(borrowDto.ReaderId)
                .Result.FirstOrDefault(r => r.BookId == borrowDto.BookId && r.IsActive);

            if (activeReservation != null)
            {
                var cancelSuccess = await reservationRepository.CancelReservation(activeReservation.Id);
                if (!cancelSuccess)
                {
                    return null;
                }
            }

            var newBorrow = new Borrow
            {
                ReaderId = borrowDto.ReaderId,
                BookId = borrowDto.BookId,
                LibrarianId = borrowDto.LibrarianId,
                BorrowDate = DateTime.UtcNow
            };

            await dbContext.Borrows.AddAsync(newBorrow);
            await dbContext.SaveChangesAsync();

            book.CopiesAvailable -= 1;
            await bookRepository.UpdateBook(book);

            return newBorrow.Id;
        }
    }

}
