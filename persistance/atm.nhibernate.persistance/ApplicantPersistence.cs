using System;
using System.Data;
using NHibernate;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Persistance
{
    public class ApplicantPersistence : IApplicantPersistence
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

        public int Save(Applicant appl)
        {
            Factory.OpenSession().Save(appl);
            Factory.OpenSession().Flush();
            return 1;
        }

        public Applicant GetApplicant(int id)
        {
            var app = Session.Get<Applicant>(id);
            return app;
        }



        private Applicant SetParent(Applicant app)
        {
            //toto set child parent


            return app;
        }
    }


}
