namespace SevenH.MMCSB.Atm.Domain
{
    public partial class ApplicantSkill : DomainObject
    {
        public virtual Applicant Applicant { get; set; }

        public virtual int Save()
        {
            return ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").SaveSkill(this);
        }

    }
}
