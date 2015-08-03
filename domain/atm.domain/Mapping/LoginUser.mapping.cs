using FluentNHibernate.Mapping;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class LoginUser
    {
        public class LoginUserMap : ClassMap<LoginUser>
        {
            public LoginUserMap()
            {
                Table("tblUser");
                Id(x => x.UserId).GeneratedBy.Increment();
                Map(x => x.FullName);
                Map(x => x.UserName);
                Map(x => x.ApplicantId);
                Map(x => x.AlternativeEmail);
                Map(x => x.Email);
                Map(x => x.CreatedBy);
                Map(x => x.CreatedDt);
                Map(x => x.IsLocked);
                Map(x => x.LastLoginDt);
                Map(x => x.Salt);
                Map(x => x.Password);
                Map(x => x.ServiceCd);
                Map(x => x.LoginId).Unique();
                Map(x => x.FirstTime);

               // References(x => x.LoginRole, "UserId").Unique();
            }
        }
    }
}
