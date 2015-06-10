using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SevenH.MMCSB.Atm.Web.Models
{
    public class UserAccountViewModel
    {
        public string FullName { get; set; }
        public string IdNumber { get; set; }
        public string Email { get; set; }
        public string AlternateEmail { get; set; }
        public int Id { get; set; }
    }
}