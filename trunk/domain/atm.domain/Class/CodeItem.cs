using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;
using Spring.Context.Support;
using Spring.Objects.Factory;

namespace SevenH.MMCSB.Atm.Domain
{
    public  partial  class CodeItem : DomainObject
    {
          private ICodeItemPersistence _mPersistence;


          public virtual ICodeItemPersistence PersistanceLayer
         {
             get
             {
                 if (((_mPersistence == null)))
                 {
                     var ctx = ContextRegistry.GetContext();
                     _mPersistence = ((IObjectFactory)ctx).GetObject("CodeItemPersistence") as ICodeItemPersistence;
                 }
                 return _mPersistence;
             }
             set { _mPersistence = value; }
         }

          public virtual int Save()
          {
              return (int)PersistanceLayer.Save(this);
          }

    }

   

    public  class  CodeItemMap : ClassMap<CodeItem>
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
