

// Developer: Jashish


using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using TravelAgency.BLL.Interfaces;
using TravelAgency.Lib.Models;
using TravelAgency.Web.ViewModel.Packages;

namespace TravelAgency.Web.Controllers
{
    public class PackagesController : Controller
    {
        private readonly IPackageRepository _PackageRepository;

        public PackagesController(IPackageRepository PackageRepository)
        {
            _PackageRepository = PackageRepository;
        }



        // GET: PackagesController
        public async Task<ActionResult> Index()
        {
            try
            {
                IList<Package> Packages = await _PackageRepository.GetAllPackages();
                IList<PackageIndexVM> PackageListVM = new List<PackageIndexVM>();

                foreach (var item in Packages)
                {
                    decimal base_p = item.PkgBasePrice;
                    decimal agency_p = item.PkgAgencyCommission ?? 0;
                    // Making sure user is never surprised
                    decimal total_price = Math.Round(base_p + agency_p, 2, MidpointRounding.AwayFromZero);

                    PackageIndexVM PackageVM = new PackageIndexVM()
                    {
                        PkgName = item.PkgName,
                        PkgDesc = item.PkgDesc,
                        PkgStartDate = item.PkgStartDate,
                        PkgEndDate = item.PkgEndDate,
                        //Putting only 2 decimal places
                        PkgTotPrice = "$ "+total_price.ToString("N2"),
                    };
                    PackageListVM.Add(PackageVM);

                }
                return View(PackageListVM);
            }
            catch (Exception)
            {
                return View();
            }
        }



        //// GET: PackagesController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: PackagesController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: PackagesController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: PackagesController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: PackagesController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: PackagesController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: PackagesController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
