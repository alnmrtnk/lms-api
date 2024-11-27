namespace lms_api.Application.Borrows.Models
{
    public class BorrowDto
    {
        public int ReaderId { get; set; }
        public int BookId { get; set; }
        public int LibrarianId { get; set; }
        public bool IsPriority { get; set; } = false;
    }
}
