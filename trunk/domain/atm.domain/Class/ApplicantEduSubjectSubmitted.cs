using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class ApplicantEduSubjectSubmitted : DomainObject
    {
        public virtual int Save()
        {
            return ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence").SaveEducationSubject(this);
        }
    }
}
