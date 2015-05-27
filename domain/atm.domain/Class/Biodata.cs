using System.Collections.Generic;
using FluentNHibernate.Mapping;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class Biodata : DomainObject
    {
        public virtual ICollection<Address> AddressCollection { get; set; }
    }

    public class BiodataMap : ClassMap<Biodata>
    {
        public BiodataMap()
        {
            Table("");
           // Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.DateOfBirth);
            Map(x => x.Department);
            Map(x => x.Designation);
            Map(x => x.Email);
            Map(x => x.FaxNo);
            Map(x => x.FullName);
            Map(x => x.IDNumber);
            Map(x => x.IDType);
            Map(x => x.MobilePhoneNo);
            Map(x => x.Nationality);
            Map(x => x.PassportNo);
            Map(x => x.PhoneNo);
            Map(x => x.SalutationName);

            HasMany<Address>(x => x.AddressCollection).KeyColumn("BiodataId").Inverse().Cascade.All();

        }
    }


    public class AddressMap : ClassMap<Address>
    {
        public AddressMap()
        {
            Table("");
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Address1);
            Map(x => x.Address2);
            Map(x => x.Address3);
            Map(x => x.City);
            Map(x => x.CityId);
            Map(x => x.Country);
            Map(x => x.CountryId);
            Map(x => x.FaxNo);
            Map(x => x.MobilePhoneNo);
            Map(x => x.PhoneNo);
            Map(x => x.Postcode);
            Map(x => x.State);
            Map(x => x.StateId);

            References(x => x.Parent, "BiodataId").Cascade.All();
        }
    }


}
