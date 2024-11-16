using lms_api.Application.Borrows.Models;

namespace lms_api.Application.Borrows.Repositories.Interfaces
{
    public interface IBorrowRepository
    {
        Task<IEnumerable<Borrow>> GetAll();

        Task<Borrow> GetBorrow(int id);

        Task<IEnumerable<Borrow>> GetAllByUserId(int id);

        Task<IEnumerable<Borrow>> GetAllByBookId(int id);

        Task<bool> AddBorrow(Borrow borrow);

        Task ReturnBook(Borrow borrow);
    }
}
