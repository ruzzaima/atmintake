using System.Collections.Generic;
using SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Atm.Web.Models
{
    public class AdminViewModel
    {
        private List<ApplicantSubmitted> m_listOfApplicant = new List<ApplicantSubmitted>();
        private List<State> m_listOfState = new List<State>();
        private Acquisition m_acquisition = new Acquisition();
        private AcquisitionAnnouncement m_announcement = new AcquisitionAnnouncement();
        public string FinalSupportingDocument { get; set; }
        public string ReportDutySuppotingDocument { get; set; }
        public string FinalSupportingDocumentOriginal { get; set; }
        public string ReportDutySupportingDocumentOriginal { get; set; }
        public AcquisitionAnnouncement Announcement
        {
            get { return m_announcement; }
            set { m_announcement = value; }
        }


        public Acquisition Acquisition
        {
            get { return m_acquisition; }
            set { m_acquisition = value; }
        }


        public List<State> ListOfState
        {
            get { return m_listOfState; }
            set { m_listOfState = value; }
        }

        public List<ApplicantSubmitted> ListOfApplicant
        {
            get { return m_listOfApplicant; }
            set { m_listOfApplicant = value; }
        }
    }
}