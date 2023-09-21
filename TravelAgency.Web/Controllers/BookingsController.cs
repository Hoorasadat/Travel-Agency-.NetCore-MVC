

// Developer: Hoora


using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using TravelAgency.BLL.Interfaces;
using TravelAgency.Lib.Models;
using TravelAgency.Web.ViewModel.Bookings;

namespace TravelAgency.Web.Controllers
{
    public class BookingsController : Controller
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public BookingsController(IBookingRepository bookingRepository, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _bookingRepository = bookingRepository;
            _userManager = userManager;
            _signInManager = signInManager;
        }



        // GET: BookingsController
        public async Task<ActionResult> Index()
        {
            if (!_signInManager.IsSignedIn(User))
                return RedirectToAction("Login", "Account");
            var userId = _userManager.GetUserId(User);
            int Id = Convert.ToInt32(userId);
            try
            {
                IList<Booking> bookings = await _bookingRepository.GetAllBookingsByCstmrID(Id);
                IList<BookingIndexViewModel> bookingListVM = new List<BookingIndexViewModel>();

                foreach (var item in bookings)
                {
                    BookingIndexViewModel bookingVM = new BookingIndexViewModel();
                    Booking booking = new Booking();
                    BookingDetail bookingDetail = new BookingDetail();

                    bookingVM.Booking = booking;
                    bookingVM.BookingDetail = bookingDetail;
                    
                    bookingVM.Booking.BookingDate = item.BookingDate;
                    bookingVM.Booking.BookingNo = item.BookingNo;
                    bookingVM.Booking.TravelerCount = item.TravelerCount;

                    TripType tripType = new TripType();
                    tripType.Ttname = item.TripType.Ttname;
                    bookingVM.Booking.TripType = tripType;

                    Package package = new Package();
                    package.PkgName = item.Package == null ? "" : item.Package.PkgName;
                    bookingVM.Booking.Package = package;

                    BookingDetail bookingDetails1 = new BookingDetail();
                    if (item.BookingDetails.Count != 0)
                    {
                        bookingDetails1 = item.BookingDetails.ToList()[0];

                        bookingVM.BookingDetail.ItineraryNo = bookingDetails1.ItineraryNo;
                        bookingVM.BookingDetail.TripStart = bookingDetails1.TripStart;
                        bookingVM.BookingDetail.TripEnd = bookingDetails1.TripEnd;
                        bookingVM.BookingDetail.Description = bookingDetails1.Description;
                        bookingVM.BookingDetail.Destination = bookingDetails1.Destination;
                        bookingVM.BookingDetail.BasePrice = bookingDetails1.BasePrice;
                        bookingVM.BookingDetail.AgencyCommission = bookingDetails1.AgencyCommission;

                        Region region = new Region();
                        region.RegionName = bookingDetails1.Region.RegionName;
                        bookingVM.BookingDetail.Region = region;

                        Fee fee = new Fee();
                        fee.FeeName = bookingDetails1.Fee.FeeName;
                        bookingVM.BookingDetail.Fee = fee;

                        Class @class = new Class();
                        @class.ClassName = bookingDetails1.Class.ClassName;
                        bookingVM.BookingDetail.Class = @class;
                    }
                    else
                    {
                        bookingVM.BookingDetail.ItineraryNo = null;
                        bookingVM.BookingDetail.TripStart = null;
                        bookingVM.BookingDetail.TripEnd = null;
                        bookingVM.BookingDetail.Description = "";
                        bookingVM.BookingDetail.Destination = "";
                        bookingVM.BookingDetail.BasePrice = null;
                        bookingVM.BookingDetail.AgencyCommission = null;

                        Region region = new Region();
                        region.RegionName = "";
                        bookingVM.BookingDetail.Region = region;

                        Fee fee = new Fee();
                        fee.FeeName = "";
                        bookingVM.BookingDetail.Fee = fee;

                        Class @class = new Class();
                        @class.ClassName = "";
                        bookingVM.BookingDetail.Class = @class;
                    }

                    bookingListVM.Add(bookingVM);

                }
                return View(bookingListVM);
            }
            catch (Exception)
            {
                return View();
            }
        }



        // GET: BookingsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BookingsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookingsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookingsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BookingsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookingsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BookingsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
