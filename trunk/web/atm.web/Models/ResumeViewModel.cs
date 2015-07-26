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
        private List<Zone> m_zones = new List<Zone>();
        public string GenderReadonly { get; set; }
        public int Peribadi { get; set; }
        public int Akademik { get; set; }
        public int Sponsorship { get; set; }
        public int Sport { get; set; }
        public int Pengakuan { get; set; }
        public List<Zone> Zones
        {
            get { return m_zones; }
            set { m_zones = value; }
        }

        public int AcquisitionId { get; set; }
        public string AcquisitionName { get; set; }
        public int AcquisitionSiri { get; set; }
        public int AcquisitionYear { get; set; }
        public string ServiceCode { get; set; }

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