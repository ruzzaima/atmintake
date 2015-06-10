using System.Collections.Generic;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class AcquisitionEducationCriteria : DomainObject
    {

        public virtual Acquisition Parent { get; set; }

        public virtual ICollection<AcquisitionEducationCriteriaSubject> AcquisitionEducationCriteriaSubjects { get; set; }
        public virtual ICollection<AcqEduCriteriaFieldOfStudy> AcqEduCriteriaFieldOfStudys { get; set; }
    }
}
