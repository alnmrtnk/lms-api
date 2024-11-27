namespace lms_api.Application.Reports.Models
{
    public class ActiveUserReport
    {
        public string UserName { get; set; } = string.Empty;
        public int BorrowCount { get; set; }
    }
}
