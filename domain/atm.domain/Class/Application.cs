namespace SevenH.MMCSB.Atm.Domain
{
    public partial class Application : DomainObject
    {

        public virtual Applicant Parent { get; set; }

        public virtual Acquisition Acquisition { get; set; }

    }
}
