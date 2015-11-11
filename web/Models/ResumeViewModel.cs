using System.Collections.Generic;
using SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Atm.Web.Models
{
    public class ResumeViewModel
    {
        public string GenderReadonly { get; set; }
        public int Peribadi { get; set; }
        public int Akademik { get; set; }
        public int Sponsorship { get; set; }
        public int Sport { get; set; }
        public int Pengakuan { get; set; }
        public List<Zone> Zones { get; set; } = new List<Zone>();

        public int AcquisitionId { get; set; }
        public string AcquisitionName { get; set; }
        public int AcquisitionSiri { get; set; }
        public int AcquisitionYear { get; set; }
        public string ServiceCode { get; set; }

        public Acquisition Acquisition { get; set; } = new Acquisition();


        public ApplicantEducation ApplicantEducation { get; set; } = new ApplicantEducation();


        public List<MaritalStatus> MaritalStatuses { get; set; } = new List<MaritalStatus>();


        public string ApplicantInJson { get; set; }
        public ApplicantModel ApplicantModel { get; set; } = new ApplicantModel();
    }
}