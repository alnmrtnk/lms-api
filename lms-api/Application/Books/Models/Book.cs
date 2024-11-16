namespace lms_api.Application.Books.Models
{
    public class Book
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Author { get; set; }
        public DateTime PublishedDate { get; set; }
        public required string ISBN { get; set; }
        public int CopiesAvailable { get; set; }
        public required string Genre { get; set; }
    }
}
