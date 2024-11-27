namespace lms_api.Application.Reports.Models
{
    public class BookBorrowFrequency
    {
        public string BookName { get; set; } = string.Empty;
        public int BorrowCount { get; set; }
    }
}
