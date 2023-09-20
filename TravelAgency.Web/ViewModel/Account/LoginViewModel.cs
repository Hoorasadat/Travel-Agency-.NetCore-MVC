

// Developer: Hoora


using System.ComponentModel.DataAnnotations;

namespace TravelAgency.Web.ViewModel.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Username is required!")]
        [MaxLength(100)]
        public string Username { get; set; }



        [Required(ErrorMessage = "Password is required!")]
        [MaxLength(100)]
        [DataType(DataType.Password)]
        public string Password { get; set; }



        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
