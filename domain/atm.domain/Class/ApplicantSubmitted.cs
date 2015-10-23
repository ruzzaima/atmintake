using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class ApplicantSubmitted : DomainObject
    {
        public virtual Application Application { get; set; }
        public virtual Acquisition Acquisition { get; set; }
        public virtual int Save()
        {
            if (ApplicantId == 0)
                return ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence").Save(this);
            return ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence").Update(this);
        }

    }

}

