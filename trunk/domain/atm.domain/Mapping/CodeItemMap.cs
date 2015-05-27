using FluentNHibernate.Mapping;
using CodeItem = SevenH.MMCSB.Atm.Domain.CodeItem;

namespace SevenH.MMCSB.Atm.Domain.Mapping
{
    public class CodeItemMap : ClassMap<CodeItem>
    {
        public CodeItemMap()
        {
            Table("codeitem");
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Code);
            Map(x => x.Description);
            Map(x => x.Grouping);

        }
    }
}