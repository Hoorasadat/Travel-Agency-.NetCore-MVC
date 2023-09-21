

// Developer: Hoora


using TravelAgency.BLL.Interfaces;
using TravelAgency.Data.Data;
using TravelAgency.Lib.Models;

namespace TravelAgency.BLL.Repositories
{
    public class SQLCustomerRepository : ICustomerRepository
    {
        private readonly TravelExpertsContext _context;

        public SQLCustomerRepository(TravelExpertsContext context)
        {
            _context = context;
        }
        public async Task<Customer> AddCustomer(Customer customer)
        {
            var newCustomer = await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();

            return newCustomer.Entity;
        }
    }
}
