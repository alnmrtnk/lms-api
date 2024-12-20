﻿using lms_api.Application.Books.Models;
using lms_api.Application.Users.Models;

namespace lms_api.Application.Borrows.Models
{
    public class Borrow
    {
        public int Id { get; set; }
        public int ReaderId { get; set; }
        public int LibrarianId {  get; set; }
        public int BookId { get; set; }
        public DateTime BorrowDate { get; set; } = DateTime.UtcNow;
        public DateTime? ReturnDate { get; set; }
        public bool IsReturned => ReturnDate.HasValue;

        
        public virtual User? Reader { get; set; }
        public virtual Book? Book { get; set; }
        public virtual User? Librarian { get; set; }
    }
}
