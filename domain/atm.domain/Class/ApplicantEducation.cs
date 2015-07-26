using System.Collections.Generic;
using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class ApplicantEducation : DomainObject
    {
        public virtual int Save()
        {
            return ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").SaveEducation(this);
        }
    }
}
