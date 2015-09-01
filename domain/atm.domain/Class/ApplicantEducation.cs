using System.Collections.Generic;
using System.Security.AccessControl;
using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class ApplicantEducation : DomainObject
    {
        public virtual HighEduLevel HighEduLevelRef { get; set; }
        public virtual int Save()
        {
            return ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").SaveEducation(this);
        }
    }
}
