using System.ComponentModel.DataAnnotations;

namespace SevenH.MMCSB.Atm.Web.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Nama Penuh diperlukan"), StringLength(100)]
        [Display(Name = "Nama Penuh")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "No Kad Pengenalan diperlukan"), StringLength(15)]
        [Display(Name = "No Kad Pengenalan")]
        public string IdNumber { get; set; }

        [Required(ErrorMessage = "Emel diperlukan"), StringLength(100)]
        [Display(Name = "Emel")]
        [EmailAddress(ErrorMessage = "Emel yang dimasukkan tidak sah")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Emel Alternatif diperlukan"), StringLength(100)]
        [Display(Name = "Emel Alternatif")]
        [EmailAddress(ErrorMessage = "Emel Alternatif yang dimasukkan tidak sah")]
        public string AlternateEmail { get; set; }
    }
}