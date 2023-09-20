

// Developer: Hoora


using System.ComponentModel.DataAnnotations;

namespace TravelAgency.Web.ViewModel.Account
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Email is Required!")]
        [MaxLength(100)]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$", ErrorMessage = "Invalid Email format!")]
        public string Email { get; set; }



        [Required(ErrorMessage = "Username is Required!")]
        [Display(Name = "Username")]
        [MaxLength(100)]
        public string Username { get; set; }



        [Required(ErrorMessage = "Password is Required!")]
        [MaxLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }



        [Required(ErrorMessage = "Confirm Password is Required!")]
        [Display(Name = "Confirm Password")]
        [MaxLength(50)]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and Confirm Password must mach!")]
        public string ConfirmPassword { get; set; }
    }
}
