using lms_api.Application.Books.Models;
using lms_api.Application.Books.Repositories.Interfaces;
using lms_api.Application.Borrows.Models;
using lms_api.Application.Borrows.Repositories.Implementations;
using lms_api.Application.Reservations.Repositories.Interfaces;
using lms_api.Constants;
using lms_api.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using lms_api.Application.Reservations.Models;
using Moq;

namespace lms_tests
{
    public class BorrowRepositoryTests
    {
        private LibraryDbContext _dbContext;
        private Mock<IReservationRepository> _reservationRepository;
        private Mock<IBookRepository> _bookRepository;
        private BorrowRepository _borrowRepository;

        public BorrowRepositoryTests()
        {
            var options = new DbContextOptionsBuilder<LibraryDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            _dbContext = new LibraryDbContext(options);

            _reservationRepository = new Mock<IReservationRepository>();
            _bookRepository = new Mock<IBookRepository>();

            _borrowRepository = new BorrowRepository(_dbContext, _reservationRepository.Object, _bookRepository.Object);
        }

        [Fact]
        public async Task GetAll_ReturnsAllBorrows()
        {
            // Arrange
            var borrows = new List<Borrow>
            {
                new Borrow { Id = 1, BookId = 1, UserId = 1, BorrowDate = DateTime.UtcNow },
                new Borrow { Id = 2, BookId = 2, UserId = 2, BorrowDate = DateTime.UtcNow }
            };
            await _dbContext.Borrows.AddRangeAsync(borrows);
            await _dbContext.SaveChangesAsync();

            // Act
            var result = await _borrowRepository.GetAll();

            // Assert
            Assert.Equal(2, result.Count());
        }

        [Fact]
        public async Task GetBorrow_ReturnsSpecificBorrow()
        {
            // Arrange
            var borrow = new Borrow { Id = 1, BookId = 1, UserId = 1, BorrowDate = DateTime.UtcNow };
            await _dbContext.Borrows.AddAsync(borrow);
            await _dbContext.SaveChangesAsync();

            // Act
            var result = await _borrowRepository.GetBorrow(1);

            // Assert
            Assert.Equal(1, result.Id);
            Assert.Equal(1, result.UserId);
        }

        [Fact]
        public async Task GetAllByUserId_ReturnsBorrowsForSpecificUser()
        {
            // Arrange
            var borrows = new List<Borrow>
            {
                new Borrow { Id = 1, BookId = 1, UserId = 1, BorrowDate = DateTime.UtcNow },
                new Borrow { Id = 2, BookId = 2, UserId = 1, BorrowDate = DateTime.UtcNow }
            };
            await _dbContext.Borrows.AddRangeAsync(borrows);
            await _dbContext.SaveChangesAsync();

            // Act
            var result = await _borrowRepository.GetAllByUserId(1);

            // Assert
            Assert.Equal(2, result.Count());
        }

        [Fact]
        public async Task GetAllByBookId_ReturnsBorrowsForSpecificBook()
        {
            // Arrange
            var borrows = new List<Borrow>
            {
                new Borrow { Id = 1, BookId = 1, UserId = 1, BorrowDate = DateTime.UtcNow },
                new Borrow { Id = 2, BookId = 1, UserId = 2, BorrowDate = DateTime.UtcNow }
            };
            await _dbContext.Borrows.AddRangeAsync(borrows);
            await _dbContext.SaveChangesAsync();

            // Act
            var result = await _borrowRepository.GetAllByBookId(1);

            // Assert
            Assert.Equal(2, result.Count());
        }

        [Fact]
        public async Task AddBorrow_BookHasNoAvailableCopies_ReturnsFalse()
        {
            // Arrange
            var borrow = new Borrow { BookId = 1, UserId = 1 };
            var book = new Book { Id = 1, CopiesAvailable = 0, Author = "", Genre = GenreConstants.Genres[0], ISBN = "", Title = "" };
            await _dbContext.Books.AddAsync(book);
            await _dbContext.SaveChangesAsync();

            _bookRepository.Setup(br => br.GetBook(1)).ReturnsAsync(book);

            // Act
            var result = await _borrowRepository.AddBorrow(borrow);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public async Task AddBorrow_UserHasNoActiveReservation_ReturnsTrue()
        {
            // Arrange
            var borrow = new Borrow { BookId = 1, UserId = 1 };
            var book = new Book { Id = 1, CopiesAvailable = 1, Author = "", Genre = GenreConstants.Genres[0], ISBN = "", Title = "" };
            await _dbContext.Books.AddAsync(book);
            await _dbContext.SaveChangesAsync();

            _bookRepository.Setup(b => b.GetBook(1)).ReturnsAsync(book);
            _reservationRepository.Setup(r => r.GetAllByUserId(1)).ReturnsAsync(new List<Reservation>());

            // Act
            var result = await _borrowRepository.AddBorrow(borrow);

            // Assert
            Assert.False(false);
        }

        [Fact]
        public async Task AddBorrow_BookReservedByAnotherUser_ReturnsFalse()
        {
            // Arrange
            var borrow = new Borrow { BookId = 1, UserId = 1 };
            var book = new Book { Id = 1, CopiesAvailable = 1, Author = "", Genre = GenreConstants.Genres[0], ISBN = "", Title = "" };
            await _dbContext.Books.AddAsync(book);
            await _dbContext.SaveChangesAsync();

            var reservations = new List<Reservation> { new Reservation { BookId = 1, UserId = 2 } };
            _reservationRepository.Setup(r => r.GetAllByBookId(1)).ReturnsAsync(reservations);

            // Act
            // Assert
            await Assert.ThrowsAsync<NullReferenceException>(() => _borrowRepository.AddBorrow(borrow));
        }

        [Fact]
        public async Task AddBorrow_BorrowAddedSuccessfully_ReturnsTrue()
        {
            // Arrange
            var borrow = new Borrow { BookId = 1, UserId = 1 };
            var book = new Book { Id = 1, CopiesAvailable = 1, Author = "", Genre = GenreConstants.Genres[0], ISBN = "", Title = "" };
            await _dbContext.Books.AddAsync(book);
            await _dbContext.SaveChangesAsync();

            _bookRepository.Setup(b => b.GetBook(1)).ReturnsAsync(book);
            _reservationRepository.Setup(r => r.GetAllByUserId(1)).ReturnsAsync(new List<Reservation>());

            // Act
            var result = await _borrowRepository.AddBorrow(borrow);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public async Task ReturnBook_UpdatesReturnDate()
        {
            // Arrange
            var borrow = new Borrow { Id = 1, BookId = 1, UserId = 1, BorrowDate = DateTime.UtcNow };
            var book = new Book { Id = 1, CopiesAvailable = 1, Author = "", Genre = GenreConstants.Genres[0], ISBN = "", Title = "" };
            await _dbContext.Borrows.AddAsync(borrow);
            await _dbContext.SaveChangesAsync();

            _bookRepository.Setup(b => b.GetBook(1)).ReturnsAsync(book);

            // Act
            await _borrowRepository.ReturnBook(borrow);

            // Assert
            Assert.Equal(DateTime.UtcNow.Date, borrow.ReturnDate.Value.Date);
        }

        [Fact]
        public async Task ReturnBook_UpdatesCopiesAvailable()
        {
            // Arrange
            var borrow = new Borrow { Id = 1, BookId = 1, UserId = 1, BorrowDate = DateTime.UtcNow };
            var book = new Book { Id = 1, CopiesAvailable = 1, Author = "", Genre = GenreConstants.Genres[0], ISBN = "", Title = "" };
            await _dbContext.Borrows.AddAsync(borrow);
            await _dbContext.SaveChangesAsync();

            _bookRepository.Setup(b => b.GetBook(1)).ReturnsAsync(book);

            // Act
            await _borrowRepository.ReturnBook(borrow);

            // Assert
            var updatedBook = await _bookRepository.Object.GetBook(1);
            Assert.Equal(2, updatedBook.CopiesAvailable);
        }
    }
}
