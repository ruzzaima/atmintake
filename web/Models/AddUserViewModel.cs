using System.Collections.Generic;
using SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Atm.Web.Models
{
    public class AddUserViewModel
    {
        public List<Service> ListOfService { get; set; } = new List<Service>();
        public LoginUser LoginUser { get; set; } = new LoginUser { };
    }
}