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
            return await _dbContext.Borrows.Include(x => x.Reader).Include(x => x.Librarian).Include(x => x.Book).ToListAsync();
        }

        public async Task<Borrow> GetBorrow(int id)
        {
            return await _dbContext.Borrows.Include(x => x.Reader).Include(x => x.Librarian).Include(x => x.Book).FirstAsync(x => x.Id == id);
        }

        public async Task<Borrow> GetBorrowByDetails(int readerId, int bookId)
        {
            return await _dbContext.Borrows.Include(x => x.Reader).Include(x => x.Librarian).Include(x => x.Book).FirstAsync(r => r.ReaderId == readerId && r.BookId == bookId);
        }

        public async Task<IEnumerable<Borrow>> GetAllByUserId(int id)
        {
            return await _dbContext.Borrows.Include(x => x.Reader).Include(x => x.Librarian).Include(x => x.Book).Where(b => b.ReaderId == id).ToListAsync();
        }

        public async Task<IEnumerable<Borrow>> GetAllByBookId(int id)
        {
            return await _dbContext.Borrows.Include(x => x.Reader).Include(x => x.Librarian).Include(x => x.Book).Where(b => b.BookId == id).ToListAsync();
        }

        public async Task<int?> AddBorrow(BorrowDto borrow)
        {
            var book = await _bookRepository.GetBook(borrow.BookId);
            if (book.CopiesAvailable == 0)
            {
                return null;
            }

     
            var activeReservation = _reservationRepository.GetAllByUserId(borrow.ReaderId).Result.FirstOrDefault(r => r.BookId == borrow.BookId && r.IsActive);


            if (activeReservation != null)
            {
                var cancelSuccess = await _reservationRepository.CancelReservation(activeReservation.Id);
                if (!cancelSuccess)
                {
                    return null;
                }
            }

            var newBorrow = new Borrow
            {
                ReaderId = borrow.ReaderId,
                BookId = borrow.BookId,
                LibrarianId = borrow.LibrarianId,
                BorrowDate = DateTime.UtcNow
            };

            await _dbContext.Borrows.AddAsync(newBorrow);
            await _dbContext.SaveChangesAsync();

            book.CopiesAvailable -= 1;
            await _bookRepository.UpdateBook(book);

            return newBorrow.Id;
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
