using System.Collections.Generic;
using SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Atm.Web.Models
{
    public class ApplicationViewModel
    {
        private List<Advertisment> m_listOfAdvertisment = new List<Advertisment>();

        public List<Advertisment> ListOfAdvertisment
        {
            get { return m_listOfAdvertisment; }
            set { m_listOfAdvertisment = value; }
        }

    }
}