using lms_api.Application.Borrows.Models;
using lms_api.Application.Reservations.Models;

namespace lms_api.Application.Reservations.Repositories.Interfaces
{
    public interface IReservationRepository
    {
        Task<IEnumerable<Reservation>> GetAll();

        Task<Reservation> GetReservation(int id);

        Task<IEnumerable<Reservation>> GetAllByUserId(int id);

        Task<IEnumerable<Reservation>> GetAllByBookId(int id);

        Task<Reservation> GetReservationByDetails(int userId, int bookId);

        Task<int?> AddReservation(ReservationDto reservation);

        Task<bool> CancelReservation(int id);
    }
}
