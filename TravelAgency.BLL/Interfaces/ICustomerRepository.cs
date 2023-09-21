 

// Developer: Hoora


using TravelAgency.Lib.Models;

namespace TravelAgency.BLL.Interfaces
{
    public interface ICustomerRepository
    {
        Task<Customer> AddCustomer(Customer customer);
    }
}
