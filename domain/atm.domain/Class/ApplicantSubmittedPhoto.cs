using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class ApplicantSubmittedPhoto : DomainObject
    {
        public virtual void Save()
        {
            if (Id == 0)
                ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence").SaveApplicantPhoto(this);
            ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence").UpdateApplicantPhoto(this);
        }
    }
}
