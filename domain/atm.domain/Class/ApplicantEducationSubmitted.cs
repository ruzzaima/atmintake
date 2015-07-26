using System.Collections.Generic;
using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class ApplicantEducationSubmitted : DomainObject
    {
        public virtual int Save()
        {
            return ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence").SaveEducation(this);
        }
    }
}
