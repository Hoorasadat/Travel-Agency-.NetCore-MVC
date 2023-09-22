

// Developer: Hoora


using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TravelAgency.BLL.Interfaces;
using TravelAgency.Lib.Models;
using TravelAgency.Web.ViewModel.Account;

namespace TravelAgency.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ICustomerRepository _customerRepository;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, ICustomerRepository customerRepository)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _customerRepository = customerRepository;
        }




        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <ActionResult> Register(RegisterViewModel registerVM)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View();

                // since we do not asking the user to enter their info while registering and because
                // the id in customer table is of type int but the id in user table is of type string,
                // we want to replace the id in user table with a real customer id.
                // Therefore, we create a general customer for getting an id out of it.

                Customer customer = new Customer()
                {
                    CustFirstName = "First Name",
                    CustLastName = "Last Name",
                    CustAddress = "Address",
                    CustCity = "City",
                    CustProv = "PV",
                    CustPostal = "Postal",
                    CustBusPhone = "Phone",
                    CustEmail = registerVM.Email
                };

                Customer newCustomer = await _customerRepository.AddCustomer(customer);

                IdentityUser user = new IdentityUser()
                {
                    Email = registerVM.Email,
                    UserName = registerVM.Username,
                    Id = newCustomer.CustomerId.ToString()
                };

                IdentityResult result = await _userManager.CreateAsync(user, registerVM.Password);

                if (result.Succeeded)
                    return RedirectToAction("Login", "Account");

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View();
            }
            catch (Exception)
            {
                return View();
            }
        }




        [HttpGet]
        public ActionResult Login() 
        { 
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel loginVM)
        {
            var result = await _signInManager.PasswordSignInAsync(loginVM.Username, loginVM.Password, loginVM.RememberMe, false);
            
            if (result.Succeeded)
                return RedirectToAction("Index", "Bookings");

            ModelState.AddModelError(string.Empty, "Invalid login attempt!");
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
