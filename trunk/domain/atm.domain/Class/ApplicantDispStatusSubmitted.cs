namespace SevenH.MMCSB.Atm.Domain
{
    public partial class ApplicantDispStatusSubmitted : DomainObject
    {

        public virtual ApplicantSubmitted Parent { get; set; }
        

    }
}
