using System.ComponentModel.DataAnnotations;

namespace SevenH.MMCSB.Atm.Web.Models
{

    public class ManageUserViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class FirstTimeViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Kata Laluan")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Sahkan Kata Laluan")]
        [Compare("Password", ErrorMessage = "Kata laluan yang dimasukkan tidak sama.")]
        public string ConfirmPassword { get; set; }
    }

    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Kata Laluan")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Kata Laluan Baru")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Sahkan Kata Laluan")]
        [Compare("NewPassword", ErrorMessage = "Kata laluan yang dimasukkan tidak sama.")]
        public string ConfirmPassword { get; set; }
    }

    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Nama Penuh diperlukan")]
        [Display(Name = "Nama Penuh")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "No Kad Pengenalan diperlukan")]
        [Display(Name = "No Kad Pengenalan")]
        public string IdNumber { get; set; }

        [Required(ErrorMessage = "Emel diperlukan")]
        [Display(Name = "Emel")]
        [EmailAddress(ErrorMessage = "Emel yang dimasukkan tidak sah")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Emel Alternatif diperlukan")]
        [Display(Name = "Emel Alternatif")]
        [EmailAddress(ErrorMessage = "Emel Alternatif yang dimasukkan tidak sah")]
        public string AlternateEmail { get; set; }
    }
}
