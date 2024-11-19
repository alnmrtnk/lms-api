﻿using lms_api.Application.Books.Models;
using lms_api.Application.Books.Repositories.Interfaces;
using lms_api.Constants;
using lms_api.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace lms_api.Application.Books.Repositories.Implementations
{
    public class BookRepository(
        LibraryDbContext _dbContext
        ) : IBookRepository
    {
        public async Task<IEnumerable<Book>> GetAll()
        {
            return await _dbContext.Books.ToListAsync();
        }

        public IEnumerable<string> GetAllGenres()
        {
            return GenreConstants.Genres;
        }

        public async Task<Book> GetBook(int id)
        {
            return await _dbContext.Books.FirstAsync(x => x.Id == id);
        }

        public async Task AddBook(Book book)
        {
            await _dbContext.Books.AddAsync(book);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateBook(Book book)
        {
            _dbContext.Books.Update(book);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteBook(int id)
        {
            var book = await _dbContext.Books.FirstOrDefaultAsync(x => x.Id == id);
            if (book != null)
            {
                _dbContext.Books.Remove(book);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}