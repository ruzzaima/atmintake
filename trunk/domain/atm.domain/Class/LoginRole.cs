namespace SevenH.MMCSB.Atm.Domain
{
    public partial class LoginRole : DomainObject
    {
        public virtual LoginUser LoginUser { get; set; }
    }
}
