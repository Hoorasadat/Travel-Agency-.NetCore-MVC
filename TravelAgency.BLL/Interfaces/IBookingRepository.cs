

// Developer: Hoora


using TravelAgency.Lib.Models;

namespace TravelAgency.BLL.Interfaces
{
    public interface IBookingRepository
    {
        Task<IList<Booking>> GetAllBookingsByCstmrID(int Id);
    }
}
