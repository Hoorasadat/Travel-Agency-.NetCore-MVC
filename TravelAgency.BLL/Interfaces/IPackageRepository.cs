

// Developer: Jashish


using TravelAgency.Lib.Models;

namespace TravelAgency.BLL.Interfaces
{
    public interface IPackageRepository
    {
        Task<IList<Package>> GetAllPackages();
    }
}
