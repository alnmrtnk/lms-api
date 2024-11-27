using lms_api.Application.Reports.Models;

namespace lms_api.Application.Reports.Repositories.Interfaces
{
    public interface IReportRepository
    {
        Task<IEnumerable<BookBorrowFrequency>> GetBorrowFrequency(string startDate, string endDate);
        Task<IEnumerable<ActiveUserReport>> GetActiveUsers(string startDate, string endDate);
        Task<IEnumerable<LibrarianActivityReport>> GetLibrarianActivity(string startDate, string endDate);

    }
}
