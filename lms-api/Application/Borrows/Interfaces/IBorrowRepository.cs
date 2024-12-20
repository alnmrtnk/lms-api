﻿using lms_api.Application.Borrows.Models;

namespace lms_api.Application.Borrows.Interfaces
{
    public interface IBorrowRepository
    {
        Task<IEnumerable<Borrow>> GetAll();

        Task<Borrow> GetBorrow(int id);

        Task<Borrow> GetBorrowByDetails(int userId, int bookId);

        Task<IEnumerable<Borrow>> GetAllByUserId(int id);

        Task<IEnumerable<Borrow>> GetAllByBookId(int id);

        Task<int?> AddBorrow(BorrowDto borrow);

        Task ReturnBook(Borrow borrow);
    }
}
