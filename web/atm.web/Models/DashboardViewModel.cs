using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Atm.Web.Models
{
    public class DashboardViewModel
    {
        private Acquisition m_acquisition = new Acquisition();

        public Acquisition Acquisition
        {
            get { return m_acquisition; }
            set { m_acquisition = value; }
        }

        
    }
}