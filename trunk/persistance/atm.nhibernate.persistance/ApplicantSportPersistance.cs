using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Persistance
{
   public class ApplicantSportPersistance : IApplicantSportPersistence
    {
        public int AddNew(Atm.Domain.ApplicantSport appl)
        {
            Factory.OpenSession().SaveOrUpdate(appl);
            Factory.OpenSession().Flush();
            return appl.ApplicantSportAssocId;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Atm.Domain.ApplicantSport GetApplicantSport(int id)
        {
            return
                Factory.OpenSession()
                    .QueryOver<ApplicantSport>()
                    .Where(a => a.ApplicantSportAssocId == id)
                    .SingleOrDefault();
        }

        public int Update(Atm.Domain.ApplicantSport appl)
        {
            Factory.OpenSession().SaveOrUpdate(appl);
            Factory.OpenSession().Flush();
            return appl.ApplicantSportAssocId;
        }
    }
}
