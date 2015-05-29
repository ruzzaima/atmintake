using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class AcquisitionEducationCriteria : DomainObject
    {

        public virtual Acquisition Parent { get; set; }

        public virtual ICollection<AcquisitionEducationCriteriaSubject> AcquisitionEducationCriteriaSubjects { get; set; }

    }
}
