using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class ApplicantEduSubject : DomainObject
    {

        public virtual int Save()
        {
            return ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").SaveEducationSubject(this);
        }
    }
}
