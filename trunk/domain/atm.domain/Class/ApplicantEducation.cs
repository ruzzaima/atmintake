using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class ApplicantEducation : DomainObject
    {

        public virtual Applicant Parent { get; set; }

        public virtual ICollection<ApplicantEduSubject> ApplicantEduSubjects { get; set; }


    }
}
