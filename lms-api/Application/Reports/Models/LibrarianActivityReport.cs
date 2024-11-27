namespace lms_api.Application.Reports.Models
{
    public class LibrarianActivityReport
    {
        public string LibrarianName { get; set; } = string.Empty;
        public int BorrowCount { get; set; }
    }
}
