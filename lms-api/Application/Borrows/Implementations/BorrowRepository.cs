using lms_api.Application.Books.Repositories.Interfaces;
using lms_api.Application.Borrows.Contexts;
using lms_api.Application.Borrows.Interfaces;
using lms_api.Application.Borrows.Models;
using lms_api.Application.Borrows.Strategies;
using lms_api.Application.Reservations.Models;
using lms_api.Application.Reservations.Repositories.Interfaces;
using lms_api.Infrastructure;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace lms_api.Application.Borrows.Implementations
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


        public async Task<int?> AddBorrow(BorrowDto borrowDto)
        {
            var borrowContext = new BorrowContext();

            if ((bool)borrowDto.IsPriority)
            {
                borrowContext.SetStrategy(new PriorityBorrowStrategy());
            }
            else
            {
                borrowContext.SetStrategy(new StandardBorrowStrategy());
            }

            return await borrowContext.ExecuteBorrowAsync(borrowDto, _dbContext, _reservationRepository, _bookRepository);
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
