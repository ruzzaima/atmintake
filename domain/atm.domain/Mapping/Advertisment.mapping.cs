using FluentNHibernate.Mapping;

namespace SevenH.MMCSB.Atm.Domain
{
    public class AdvertismentMap : ClassMap<Advertisment>
    {
        public AdvertismentMap()
        {
            Table("tblAdvertisment");
            Id(x => x.Id).GeneratedBy.Increment();
            Map(x => x.Title);
            Map(x => x.ShortDescription);
            Map(x => x.Description);
            Map(x => x.CreatedBy);
            Map(x => x.CreatedDate);
            Map(x => x.StartDate);
            Map(x => x.EndDate);
            Map(x => x.LastModifiedBy).Column("ModifiedBy");
            Map(x => x.LastModifiedDate).Column("ModifiedDate");
            Map(x => x.IsActive);
            Map(x => x.IntakeLocationId);
            Map(x => x.InterviewLocationId);
            Map(x => x.ServiceCode).Column("ServiceCd");
            Map(x => x.AcquisitionId);

            HasOne(x => x.Acquisition).ForeignKey("AcquisitionId");
        }
    }

}
