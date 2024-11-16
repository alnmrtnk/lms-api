using lms_api.Application.Books.Repositories.Interfaces;
using lms_api.Application.Borrows.Models;
using lms_api.Application.Borrows.Repositories.Interfaces;
using lms_api.Application.Reservations.Models;
using lms_api.Application.Reservations.Repositories.Interfaces;
using lms_api.Infrastructure;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace lms_api.Application.Borrows.Repositories.Implementations
{
    public class BorrowRepository(
        LibraryDbContext _dbContext,
        IReservationRepository _reservationRepository,
        IBookRepository _bookRepository
        ) : IBorrowRepository
    {
        public async Task<IEnumerable<Borrow>> GetAll()
        {
            return await _dbContext.Borrows.ToListAsync();
        }

        public async Task<Borrow> GetBorrow(int id)
        {
            return await _dbContext.Borrows.FirstAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Borrow>> GetAllByUserId(int id)
        {
            return await _dbContext.Borrows.Where(b => b.UserId == id).ToListAsync();
        }

        public async Task<IEnumerable<Borrow>> GetAllByBookId(int id)
        {
            return await _dbContext.Borrows.Where(b => b.BookId == id).ToListAsync();
        }

        public async Task<bool> AddBorrow(Borrow borrow)
        {
            var book = await _bookRepository.GetBook(borrow.BookId);
            if (book.CopiesAvailable == 0)
            {
                return false;
            }

            var userHasBookReservation = _reservationRepository.GetAllByUserId(borrow.UserId).Result.Any(r => r.BookId == borrow.BookId && r.IsActive);

            if (!userHasBookReservation)
            {
                var reservedBookCount = _reservationRepository.GetAllByBookId(borrow.BookId).Result.Where(r => r.IsActive).ToList().Count;

                if (reservedBookCount >= book.CopiesAvailable)
                {
                    return false;
                }
            }

            await _dbContext.Borrows.AddAsync(borrow);
            await _dbContext.SaveChangesAsync();

            book.CopiesAvailable -= 1;
            await _bookRepository.UpdateBook(book);

            return true;
        }

        public async Task ReturnBook(Borrow borrow)
        {
            borrow.ReturnDate = DateTime.UtcNow;

            _dbContext.Borrows.Update(borrow);
            await _dbContext.SaveChangesAsync();

            var returnedBook = await _bookRepository.GetBook(borrow.BookId);

            returnedBook.CopiesAvailable += 1;
            await _bookRepository.UpdateBook(returnedBook);
        }
    }
}
