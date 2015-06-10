using System.Collections.Generic;
using NHibernate.Mapping;
using SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Atm.Web.Models
{
    public class ResumeViewModel
    {
        private ApplicantModel _mApplicantModel = new ApplicantModel();
        private List<MaritalStatus> m_listOfMaritalStatus = new List<MaritalStatus>();
        private ApplicantEducation m_applicantEducation = new ApplicantEducation();

        public ApplicantEducation ApplicantEducation
        {
            get { return m_applicantEducation; }
            set { m_applicantEducation = value; }
        }


        public List<MaritalStatus> MaritalStatuses
        {
            get { return m_listOfMaritalStatus; }
            set { m_listOfMaritalStatus = value; }
        }
        
        
        public string ApplicantInJson { get; set; }
        public ApplicantModel ApplicantModel
        {
            get { return _mApplicantModel; }
            set { _mApplicantModel = value; }
        }

        
    }
}