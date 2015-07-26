using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using NHibernate.Cfg;

namespace SevenH.MMCSB.Atm.Domain
{
    public class LoginRoleMap : ClassMap<LoginRole>
    {
        public LoginRoleMap()
        {
            Table("tblUserRoles");
            Id(x => x.UserId).GeneratedBy.Assigned();
            Map(x => x.Roles);

            HasOne(x => x.LoginUser).ForeignKey("UserId");
        }
    }
}
