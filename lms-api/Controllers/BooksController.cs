using lms_api.Application.Books.Models;
using lms_api.Application.Books.Repositories.Interfaces;
using lms_api.Infrastructure;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace lms_api.Controllers
{
    [ApiController]
    [Route("books")]
    public class BooksController(
        IBookRepository _bookRepository
        ) : Controller
    {
        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _bookRepository.GetAll();

            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById(int id)
        {
            var book = await _bookRepository.GetBook(id);

            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> AddBook([FromBody] Book book)
        {
            if (book == null)
            {
                return BadRequest("Invalid book data.");
            }

            await _bookRepository.AddBook(book);
            return CreatedAtAction(nameof(AddBook), new { id = book.Id }, book);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(int id, [FromBody] Book book)
        {
            if (id != book.Id)
            {
                return BadRequest("Book ID mismatch");
            }

            var existingBook = await _bookRepository.GetBook(id);
            if (existingBook == null)
            {
                return NotFound();
            }

            await _bookRepository.UpdateBook(book);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var book = await _bookRepository.GetBook(id);
            if (book == null)
            {
                return NotFound();
            }

            await _bookRepository.DeleteBook(id);
            return NoContent();
        }

        [HttpGet("genres")]
        public IActionResult GetAllGenres()
        {
            var books = _bookRepository.GetAllGenres();

            return Ok(books);
        }
    }
}
