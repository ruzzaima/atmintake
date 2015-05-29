using FluentNHibernate.Mapping;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class CodeItem : DomainObject
    {

        //public virtual Applicant Parent { get; set; }
        

    }


    public class CodeItemtMap : ClassMap<CodeItem>
    {
        //public CodeItemMap()
        //{
        //    //Table("CodeItem");
        //    //Id(x => x.Id).GeneratedBy.Identity();
        //    //Map(x => x.Code);
        //    //Map(x => x.Description);
        //    //Map(x => x.Grouping);

        //}
    }

}
