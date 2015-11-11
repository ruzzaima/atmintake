using System.Collections.Generic;
using SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Atm.Web.Models
{
    public class AdminViewModel
    {
        public string FinalSupportingDocument { get; set; }
        public string ReportDutySuppotingDocument { get; set; }
        public string FinalSupportingDocumentOriginal { get; set; }
        public string ReportDutySupportingDocumentOriginal { get; set; }
        public AcquisitionAnnouncement Announcement { get; set; } = new AcquisitionAnnouncement();


        public Acquisition Acquisition { get; set; } = new Acquisition();


        public List<State> ListOfState { get; set; } = new List<State>();

        public List<ApplicantSubmitted> ListOfApplicant { get; set; } = new List<ApplicantSubmitted>();
    }
}