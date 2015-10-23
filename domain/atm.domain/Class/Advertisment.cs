namespace SevenH.MMCSB.Atm.Domain
{
    public partial class Advertisment : DomainObject
    {
        public virtual Acquisition Acquisition { get; set; }
    }
}
