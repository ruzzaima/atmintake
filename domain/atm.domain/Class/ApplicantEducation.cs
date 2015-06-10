using System.Collections.Generic;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class ApplicantEducation : DomainObject
    {

        public virtual Applicant Parent { get; set; }

        public virtual ICollection<ApplicantEduSubject> ApplicantEduSubjects { get; set; }


    }
}
