using lms_api.Application.Reservations.Models;
using lms_api.Application.Reservations.Repositories.Implementations;
using lms_api.Application.Reservations.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace lms_api.Controllers
{
    [ApiController]
    [Route("reservations")]
    public class ReservationController(
        IReservationRepository _reservarionRepository
        ) : Controller
    {
        [HttpGet]
        public async Task<IActionResult> GetAllReservations()
        {
            var reservations = await _reservarionRepository.GetAll();
            return Ok(reservations);
        }

        [HttpGet("user/{id}")]
        public async Task<IActionResult> GetAllReservationsByUserId(int id)
        {
            var reservations = await _reservarionRepository.GetAllByUserId(id);
            return Ok(reservations);
        }

        [HttpGet("book/{id}")]
        public async Task<IActionResult> GetAllReservationsByBookId(int id)
        {
            var reservations = await _reservarionRepository.GetAllByBookId(id);
            return Ok(reservations);
        }

        [HttpPost]
        public async Task<IActionResult> AddReservation([FromBody] ReservationDto reservationDto)
        {
            if (reservationDto == null)
            {
                return BadRequest(new { message = "Invalid reservation data." });
            }

            var reservationId = await _reservarionRepository.AddReservation(reservationDto);

            if (reservationId == null)
            {
                return BadRequest(new { message = "Reservation could not be created due to availability constraints." });
            }

            var newReservation = await _reservarionRepository.GetReservation((int)reservationId);
            return CreatedAtAction(nameof(AddReservation), new { id = newReservation.Id }, newReservation);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> CancelReservation(int id)
        {
            var success = await _reservarionRepository.CancelReservation(id);

            return Ok(success);
        }
    }
}
