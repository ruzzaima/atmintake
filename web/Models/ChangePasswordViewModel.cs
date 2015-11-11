using System.ComponentModel.DataAnnotations;

namespace SevenH.MMCSB.Atm.Web.Models
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Kata Laluan diperlukan")]
        [DataType(DataType.Password)]
        [Display(Name = "Kata Laluan")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Kata Laluan Baru diperlukan")]
        [DataType(DataType.Password)]
        [Display(Name = "Kata Laluan Baru")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Sahkan Kata Laluan diperlukan")]
        [DataType(DataType.Password)]
        [Display(Name = "Sahkan Kata Laluan")]
        [Compare("NewPassword", ErrorMessage = "Kata laluan yang dimasukkan tidak sama.")]
        public string ConfirmPassword { get; set; }
    }
}