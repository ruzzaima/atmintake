using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace SevenH.MMCSB.Atm.Domain
{
    public class ExistingMemberMap : ClassMap<ExistingMember>
    {
        public ExistingMemberMap()
        {
            Table("tblExistingAtmMember");
            Id(x => x.CoId);
            Map(x => x.IdNumber).Column("ICNOBaru");
            Map(x => x.Name).Column("CONm");
            Map(x => x.ArmyNo).Column("NoTentera");
            Map(x => x.Status).Column("ExistingMemberStatusCd");

            References(x => x.ExistingMemberStatus, "ExistingMemberStatusCd").Unique();
        }
    }
}
