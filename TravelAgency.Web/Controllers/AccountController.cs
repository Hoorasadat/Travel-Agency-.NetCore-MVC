

// Developer: Hoora


using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TravelAgency.Data.Data;
using TravelAgency.Web.ViewModel.Account;

namespace TravelAgency.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
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
            if (!ModelState.IsValid)
                return View();

            IdentityUser user = new IdentityUser()
            {
                //Email = (registerVM.Email ? registerVM.Email : null),
                UserName = registerVM.Username
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
