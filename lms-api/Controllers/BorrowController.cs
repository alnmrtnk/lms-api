
using lms_api.Application.Books.Models;
using lms_api.Application.Borrows.Models;
using lms_api.Application.Borrows.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace lms_api.Controllers
{
    [ApiController]
    [Route("borrows")]
    public class BorrowController(
        IBorrowRepository _borrowRepository
        ) : Controller
    {
        [HttpGet]
        public async Task<IActionResult> GetAllBorrows()
        {
            var borrows = await _borrowRepository.GetAll();
            return Ok(borrows);
        }

        [HttpGet("/user{id}")]
        public async Task<IActionResult> GetAllBorrowsByUserId(int id)
        {
            var borrows = await _borrowRepository.GetAllByUserId(id);
            return Ok(borrows);
        }

        [HttpGet("/book{id}")]
        public async Task<IActionResult> GetAllBorrowsByBookId(int id)
        {
            var borrows = await _borrowRepository.GetAllByBookId(id);
            return Ok(borrows);
        }

        [HttpPost]
        public async Task<IActionResult> AddBorrow([FromBody] Borrow borrow)
        {
            if (borrow == null)
            {
                return BadRequest("Invalid book data.");
            }

            await _borrowRepository.AddBorrow(borrow);
            return CreatedAtAction(nameof(AddBorrow), new { id = borrow.Id }, borrow);
        }

        [HttpPut("/return{id}")]
        public async Task<IActionResult> ReturnBook(int id)
        {
            var borrow = await _borrowRepository.GetBorrow(id);

            if (borrow == null)
            {
                return NotFound();
            }

            await _borrowRepository.ReturnBook(borrow);

            return NoContent();
        }
    }
}
