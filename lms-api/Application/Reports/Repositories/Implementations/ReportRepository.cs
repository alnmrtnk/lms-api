using lms_api.Application.Books.Repositories.Interfaces;
using lms_api.Application.Borrows.Repositories.Interfaces;
using lms_api.Application.Reports.Models;
using lms_api.Application.Reports.Repositories.Interfaces;
using lms_api.Application.Reservations.Repositories.Interfaces;
using lms_api.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace lms_api.Application.Reports.Repositories.Implementations
{
    public class ReportRepository(
        LibraryDbContext _context
        ) : IReportRepository
    {
        public async Task<IEnumerable<BookBorrowFrequency>> GetBorrowFrequency(string startDate, string endDate)
        {
            DateTime start = string.IsNullOrEmpty(startDate) ? DateTime.MinValue : DateTime.Parse(startDate).ToUniversalTime();
            DateTime end = string.IsNullOrEmpty(endDate) ? DateTime.MaxValue : DateTime.Parse(endDate).ToUniversalTime();

            var query = _context.Borrows
                .Where(b => (startDate == null || b.BorrowDate >= start) &&
                            (endDate == null || b.BorrowDate <= end))
                .GroupBy(b => b.BookId)
                .Select(g => new BookBorrowFrequency
                {
                    BookName = g.FirstOrDefault()!.Book!.Title,
                    BorrowCount = g.Count()
                });

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<ActiveUserReport>> GetActiveUsers(string startDate, string endDate)
        {
            DateTime start = string.IsNullOrEmpty(startDate) ? DateTime.MinValue : DateTime.Parse(startDate).ToUniversalTime();
            DateTime end = string.IsNullOrEmpty(endDate) ? DateTime.MaxValue : DateTime.Parse(endDate).ToUniversalTime();

            var query = _context.Borrows
                .Where(b => (startDate == null || b.BorrowDate >= start) &&
                            (endDate == null || b.BorrowDate <= end))
                .GroupBy(b => b.ReaderId)
                .Select(g => new ActiveUserReport
                {
                    UserName = g.FirstOrDefault()!.Reader!.Username,
                    BorrowCount = g.Count()
                });

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<LibrarianActivityReport>> GetLibrarianActivity(string startDate, string endDate)
        {
            DateTime start = string.IsNullOrEmpty(startDate) ? DateTime.MinValue : DateTime.Parse(startDate).ToUniversalTime();
            DateTime end = string.IsNullOrEmpty(endDate) ? DateTime.MaxValue : DateTime.Parse(endDate).ToUniversalTime();

            var query = _context.Borrows
                .Where(b => b.BorrowDate >= start && b.BorrowDate <= end)
                .GroupBy(b => b.LibrarianId)
                .Select(g => new LibrarianActivityReport
                {
                    BorrowCount = g.Count(),
                    LibrarianName = g.FirstOrDefault()!.Librarian!.Username
                });

            return await query.ToListAsync();
        }

    }
}
