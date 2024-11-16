using lms_api.Application.Books.Models;

namespace lms_api.Application.Books.Repositories.Interfaces
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAll();

        IEnumerable<string> GetAllGenres();

        Task<Book> GetBook(int id);

        Task AddBook(Book book);

        Task UpdateBook(Book book);

        Task DeleteBook(int id);
    }
}
