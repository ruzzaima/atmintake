using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Atm.Web.Models
{
    public class HomeViewModel
    {
        private LoginViewModel m_login = new LoginViewModel();
        private List<Advertisment> m_listOfAdvertisment = new List<Advertisment>();

        public List<Advertisment> ListOfAdvertisment
        {
            get { return m_listOfAdvertisment; }
            set { m_listOfAdvertisment = value; }
        }
        
        

        public LoginViewModel LoginModel
        {
            get { return m_login; }
            set { m_login = value; }
        }

    }
}