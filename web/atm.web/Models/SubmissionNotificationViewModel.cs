using System;
using SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Atm.Web.Models
{
    public class SubmissionNotificationViewModel
    {
        public string Service { get; set; }
        public string Name { get; set; }
        public string IdNumber { get; set; }
        public DateTime RegisteredDateTime { get; set; }
        public string Siri { get; set; }
        public string Year { get; set; }
        private Acquisition m_acquisition = new Acquisition();

        public Acquisition Acquisition
        {
            get { return m_acquisition; }
            set { m_acquisition = value; }
        }


    }
}