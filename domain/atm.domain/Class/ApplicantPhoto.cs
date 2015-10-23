namespace SevenH.MMCSB.Atm.Domain
{
    public partial class ApplicantPhoto : DomainObject
    {
        public virtual void Save()
        {
            if (Id == 0)
                ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").SaveApplicantPhoto(this);
            ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").UpdateApplicantPhoto(this);
        }
    }
}
