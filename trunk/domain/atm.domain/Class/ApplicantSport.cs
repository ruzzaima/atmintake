using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class ApplicantSport : DomainObject
    {

        public virtual Applicant Parent { get; set; }

        public virtual int Save()
        {
            if (ApplicantSportAssocId == 0)
                return ObjectBuilder.GetObject<IApplicantSportPersistence>("ApplicantSportPersistence").AddNew(this);
            return ObjectBuilder.GetObject<IApplicantSportPersistence>("ApplicantSportPersistence").Update(this);
        }
    }
}
