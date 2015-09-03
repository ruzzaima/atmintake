namespace SevenH.MMCSB.Atm.Domain
{
    public partial class Application : DomainObject
    {

        public virtual Applicant Parent { get; set; }

        public virtual Acquisition Acquisition { get; set; }
        public virtual Location ReportDutyLocation { get; set; }
        public virtual AcquisitionLocation FinalSelectionLocation { get; set; }

        public virtual int Save()
        {
            if (AppId == 0)
                return ObjectBuilder.GetObject<IApplicationPersistance>("ApplicationPersistance").AddNew(this);
            return ObjectBuilder.GetObject<IApplicationPersistance>("ApplicationPersistance").Update(this);
        }
    }
}
