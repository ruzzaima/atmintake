using System.ComponentModel.DataAnnotations;

namespace SevenH.MMCSB.Atm.Web.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Id Pengguna diperlukan")]
        [Display(Name = "Id Pengguna")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Kata Laluan diperlukan")]
        [DataType(DataType.Password)]
        [Display(Name = "Kata Laluan")]
        public string Password { get; set; }

        [Display(Name = "Ingat Saya?")]
        public bool RememberMe { get; set; }
    }
}