using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Atm.Web.Models
{
    public class AddUserViewModel
    {
        private LoginUser m_loginUser = new LoginUser() { LoginRole = new LoginRole() };
        private List<Service> m_listOfService = new List<Service>();

        public List<Service> ListOfService
        {
            get { return m_listOfService; }
            set { m_listOfService = value; }
        }


        public LoginUser LoginUser
        {
            get { return m_loginUser; }
            set { m_loginUser = value; }
        }

    }
}