using System.ComponentModel.DataAnnotations;

namespace SevenH.MMCSB.Atm.Web.Models
{
    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "No Kad Pengenalan diperlukan")]
        [Display(Name = "No Kad Pengenalan")]
        public string IdNumber { get; set; }

        [Required(ErrorMessage = "Emel diperlukan"), StringLength(100)]
        [Display(Name = "Emel")]
        [EmailAddress(ErrorMessage = "Emel yang dimasukkan tidak sah")]
        public string Email { get; set; }
    }
}