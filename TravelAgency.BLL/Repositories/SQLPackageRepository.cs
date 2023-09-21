

// Developer: Jashish


using Microsoft.EntityFrameworkCore;
using TravelAgency.BLL.Interfaces;
using TravelAgency.Data.Data;
using TravelAgency.Lib.Models;

namespace TravelAgency.BLL.Repositories
{
    public class SQLPackageRepository : IPackageRepository
    {
        private readonly TravelExpertsContext _context;

        public SQLPackageRepository(TravelExpertsContext context)
        {
            _context = context;
        }

        public async Task<IList<Package>> GetAllPackages()
        {
            return await _context.Packages.ToListAsync();
        }
    }
}
