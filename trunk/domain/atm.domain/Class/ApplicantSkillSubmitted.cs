using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class ApplicantSkillSubmitted : DomainObject
    {
        public virtual int Save()
        {
            return ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence").SaveSkill(this);
        }
    }
}
