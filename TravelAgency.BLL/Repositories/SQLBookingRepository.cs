

// Developer: Hoora


using Microsoft.EntityFrameworkCore;
using TravelAgency.BLL.Interfaces;
using TravelAgency.Data.Data;
using TravelAgency.Lib.Models;

namespace TravelAgency.BLL.Repositories
{
    public class SQLBookingRepository : IBookingRepository
    {
        private readonly TravelExpertsContext _context;

        public SQLBookingRepository(TravelExpertsContext context)
        {
            _context = context;
        }
        public async Task<IList<Booking>> GetAllBookingsByCstmrID(int Id)
        {
            return await _context.Bookings.Where(b => b.CustomerId == Id)
                .Include(b => b.TripType).Include(b => b.Package)
                .Include(b => b.BookingDetails).ThenInclude(bd => bd.Region)
                .Include(b => b.BookingDetails).ThenInclude(bd => bd.Class)
                .Include(b => b.BookingDetails).ThenInclude(bd => bd.Fee)
                .ToListAsync();
        }
    }
}
