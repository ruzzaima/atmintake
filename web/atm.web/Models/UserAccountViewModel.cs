using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SevenH.MMCSB.Atm.Web.Models
{
    public class UserAccountViewModel
    {
        public string FullName { get; set; }
        public string IdNumber { get; set; }

        [Required(ErrorMessage = "Emel diperlukan"), StringLength(100)]
        [Display(Name = "Emel")]
        [EmailAddress(ErrorMessage = "Emel yang dimasukkan tidak sah")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Emel Alternatif diperlukan"), StringLength(100)]
        [Display(Name = "Emel Alternatif")]
        [EmailAddress(ErrorMessage = "Emel Alternatif yang dimasukkan tidak sah")]
        public string AlternateEmail { get; set; }
        public int Id { get; set; }
    }
}