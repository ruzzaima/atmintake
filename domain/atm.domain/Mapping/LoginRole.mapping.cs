using FluentNHibernate.Mapping;

namespace SevenH.MMCSB.Atm.Domain
{
    public class LoginRoleMap : ClassMap<LoginRole>
    {
        public LoginRoleMap()
        {
            Table("tblUserRoles");
            Id(x => x.UserId).GeneratedBy.Assigned();
            Map(x => x.Roles);

            //HasOne(x => x.LoginUser).ForeignKey("UserId");
        }
    }
}
