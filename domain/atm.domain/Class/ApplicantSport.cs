using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class ApplicantSport : DomainObject
    {
        public virtual Applicant Applicant { get; set; }
        public virtual SportAndAssociation SportAndAssociation { get; set; }

        public virtual int Save()
        {
            return ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").SaveSport(this);
        }

        public virtual bool Delete()
        {
            return ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").DeleteApplicantSport(this.ApplicantSportAssocId);
        }
    }
}
