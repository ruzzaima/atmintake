using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class ApplicantSportSubmitted : DomainObject
    {

        public virtual ApplicantSubmitted Parent { get; set; }
        public virtual SportAndAssociation SportAndAssociation { get; set; }

        public virtual int Save()
        {
            return ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence").SaveSport(this);
        }
    }
}
