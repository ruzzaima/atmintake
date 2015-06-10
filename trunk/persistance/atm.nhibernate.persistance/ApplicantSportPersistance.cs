using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Persistance
{
   public class ApplicantSportPersistance : IApplicantSportPersistence
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

        public int AddNew(Atm.Domain.ApplicantSport appl)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Atm.Domain.ApplicantSport GetApplicantSport(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Atm.Domain.ApplicantSport appl)
        {
            throw new NotImplementedException();
        }
    }
}
