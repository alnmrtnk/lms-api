using lms_api.Application.Books.Models;
using lms_api.Application.Borrows.Models;
using lms_api.Application.Reservations.Models;
using lms_api.Application.Users.Models;
using lms_api.Constants;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace lms_api.Infrastructure
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Borrow> Borrows { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", PublishedDate = new DateTime(1925, 4, 10), ISBN = "9780743273565", CopiesAvailable = 5, Genre = GenreConstants.Genres[0] },
                new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", PublishedDate = new DateTime(1960, 7, 11), ISBN = "9780061120084", CopiesAvailable = 3, Genre = GenreConstants.Genres[0] },
                new Book { Id = 3, Title = "1984", Author = "George Orwell", PublishedDate = new DateTime(1949, 6, 8), ISBN = "9780451524935", CopiesAvailable = 4, Genre = GenreConstants.Genres[2] },
                new Book { Id = 4, Title = "The Hobbit", Author = "J.R.R. Tolkien", PublishedDate = new DateTime(1937, 9, 21), ISBN = "9780547928227", CopiesAvailable = 6, Genre = GenreConstants.Genres[3] },
                new Book { Id = 5, Title = "The Da Vinci Code", Author = "Dan Brown", PublishedDate = new DateTime(2003, 3, 18), ISBN = "9780307474278", CopiesAvailable = 2, Genre = GenreConstants.Genres[4] }
            );

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "admin", PasswordHash = HashPassword("Admin123!"), Email = "admin@library.com", Role = "Admin" },
                new User { Id = 2, Username = "librarian", PasswordHash = HashPassword("Librarian123!"), Email = "librarian@library.com", Role = "Librarian" },
                new User { Id = 3, Username = "reader1", PasswordHash = HashPassword("Reader123!"), Email = "reader1@library.com", Role = "Reader" },
                new User { Id = 4, Username = "reader2", PasswordHash = HashPassword("Reader456!"), Email = "reader2@library.com", Role = "Reader" }
            );

            modelBuilder.Entity<Borrow>().HasData(
                new Borrow { Id = 1, UserId = 3, BookId = 1, BorrowDate = DateTime.UtcNow.AddDays(-10), ReturnDate = DateTime.UtcNow.AddDays(-2) },
                new Borrow { Id = 2, UserId = 4, BookId = 3, BorrowDate = DateTime.UtcNow.AddDays(-5) }
            );

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation { Id = 1, UserId = 3, BookId = 2, ReservationDate = DateTime.UtcNow.AddDays(-1), ExpirationDate = DateTime.UtcNow.AddHours(24) },
                new Reservation { Id = 2, UserId = 4, BookId = 4, ReservationDate = DateTime.UtcNow.AddHours(-30), ExpirationDate = DateTime.UtcNow.AddHours(18) }
            );
        }

        private string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }
    }
}
