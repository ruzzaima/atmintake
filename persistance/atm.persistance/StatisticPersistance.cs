using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Atm.Entity.Persistance
{
    class StatisticPersistance : IStatisticPersistance
    {
        public int Count(int acquisitionid, string[] birthstatecode, string gendercode, string highleveleducode, string racecode, string ethniccode, string religioncode)
        {
            if (acquisitionid != 0)
            {
                using (var entities = new atmEntities())
                {
                    var app = from a in entities.tblApplicantSubmiteds where a.AcquisitionId == acquisitionid select a;
                    if (birthstatecode.Any())
                        app = app.Where(a => birthstatecode.Contains(a.BirthStateCd));
                    if (!string.IsNullOrWhiteSpace(gendercode))
                        app = app.Where(a => a.GenderCd == gendercode);
                    if (!string.IsNullOrWhiteSpace(highleveleducode))
                        app = app.Where(a => a.tblApplicantEduSubmitteds.Any(b => b.HighEduLevelCd == highleveleducode));
                    if (!string.IsNullOrWhiteSpace(racecode))
                        app = app.Where(a => a.RaceCd == racecode);
                    if (!string.IsNullOrWhiteSpace(ethniccode))
                        app = app.Where(a => a.EthnicCd == ethniccode);
                    if (!string.IsNullOrWhiteSpace(religioncode))
                        app = app.Where(a => a.ReligionCd == religioncode);

                    return app.Count();
                }
            }
            return 0;
        }
    }
}
