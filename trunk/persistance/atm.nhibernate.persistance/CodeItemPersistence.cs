using System;
using System.Data;
using NHibernate;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Persistance
{
    public class CodeItemPersistence : ICodeItemPersistence
    {

        private static NHibernate.ISession _mSession;
        public ISession Session
        {
            get
            {
                if ((_mSession == null))
                {

                    _mSession = Factory.OpenSession();
                }
                if (_mSession.Connection.State == ConnectionState.Closed)
                {
                    _mSession.Connection.Open();
                }

                return _mSession;
            }
        }


        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Save(CodeItem cd)
        {
            Factory.OpenSession().Save(cd);
            Factory.OpenSession().Flush();
            return 1;
        }

        CodeItem ICodeItemPersistence.GetCode(int id)
        {
            var cd = Session.Get<CodeItem>(id);
            return cd;
        }

       
        //public IEnumerable<DeSCo.Models.CodeItem> GetCodeItems()
        //{
        //    var returnList = Factory.OpenSession().CreateSQLQuery("select * from Codeitem").AddEntity(typeof(CodeItem));
        //    return returnList.List<CodeItem>();
        //}


    }


}
