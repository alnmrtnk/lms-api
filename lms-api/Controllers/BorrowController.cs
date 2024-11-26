
using lms_api.Application.Books.Models;
using lms_api.Application.Borrows.Models;
using lms_api.Application.Borrows.Repositories.Interfaces;
using lms_api.Application.Reservations.Models;
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

        [HttpGet("user/{id}")]
        public async Task<IActionResult> GetAllBorrowsByUserId(int id)
        {
            var borrows = await _borrowRepository.GetAllByUserId(id);
            return Ok(borrows);
        }

        [HttpGet("book/{id}")]
        public async Task<IActionResult> GetAllBorrowsByBookId(int id)
        {
            var borrows = await _borrowRepository.GetAllByBookId(id);
            return Ok(borrows);
        }

        [HttpPost]
        public async Task<IActionResult> AddBorrow([FromBody] BorrowDto borrowDto)
        {
            if (borrowDto == null)
            {
                return BadRequest("Invalid reservation data.");
            }

            var success = await _borrowRepository.AddBorrow(borrowDto);

            if (!success)
            {
                return BadRequest("Borrow could not be created due to availability constraints.");
            }

            var newReservation = await _borrowRepository.GetBorrowByDetails(borrowDto.ReaderId, borrowDto.BookId);
            return CreatedAtAction(nameof(AddBorrow), new { id = newReservation.Id }, newReservation);
        }

        [HttpPut("return/{id}")]
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
