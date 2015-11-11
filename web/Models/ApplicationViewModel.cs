using System.Collections.Generic;
using SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Atm.Web.Models
{
    public class ApplicationViewModel
    {
        public List<Advertisment> ListOfAdvertisment { get; set; } = new List<Advertisment>();
    }
}