using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Atm.Entity.Persistance
{
    class ExistingAtmPersistance : IExistingAtmPersistance
    {
        public int AddNew(ExistingMember existingMember)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblExistingAtmMembers where a.ICNOBaru == existingMember.IdNumber select a).SingleOrDefault();
                if (null != exist)
                {
                    exist.COID = exist.COID;
                    return Update(existingMember);
                }

                var atm = new tblExistingAtmMember()
                {
                    COID = existingMember.CoId,
                    CONm = existingMember.Name,
                    ICNOBaru = existingMember.IdNumber,
                    NoTentera = existingMember.ArmyNo,
                    ExistingMemberStatusCd = existingMember.Status
                };

                entities.tblExistingAtmMembers.Add(atm);
                if (entities.SaveChanges() > 0)
                    return atm.COID;
            }
            return 0;
        }

        public int Update(ExistingMember existingMember)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblExistingAtmMembers where a.COID == existingMember.CoId select a).SingleOrDefault();
                if (null != exist)
                {
                    exist.CONm = existingMember.Name;
                    exist.ICNOBaru = existingMember.IdNumber;
                    exist.NoTentera = existingMember.ArmyNo;
                    exist.ExistingMemberStatusCd = existingMember.Status;
                    if (entities.SaveChanges() > 0)
                        return exist.COID;
                }
            }
            return 0;
        }

        public bool Delete(int existingid)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblExistingAtmMembers where a.COID == existingid select a).SingleOrDefault();
                if (null != exist)
                {
                    entities.tblExistingAtmMembers.Remove(exist);
                    return entities.SaveChanges() > 0;
                }
            }
            return false;
        }

        public IEnumerable<ExistingMember> Search(string status, string searchcriteria, int armyno)
        {
            var list = new List<ExistingMember>();
            using (var entities = new atmEntities())
            {
                var l = from a in entities.tblExistingAtmMembers select a;
                if (!string.IsNullOrWhiteSpace(status))
                    l = l.Where(a => a.ExistingMemberStatusCd == status);
                if (!string.IsNullOrWhiteSpace(searchcriteria))
                    l = l.Where(a => a.CONm.Contains(searchcriteria) || a.ICNOBaru.Contains(searchcriteria));
                if (armyno != 0)
                    l = l.Where(a => a.NoTentera == armyno);
                foreach (var atm in l)
                {
                    var ea = new ExistingMember()
                    {
                        CoId = atm.COID,
                        ArmyNo = atm.NoTentera,
                        IdNumber = atm.ICNOBaru,
                        Name = atm.CONm
                    };

                    if (!string.IsNullOrWhiteSpace(atm.ExistingMemberStatusCd))
                    {
                        ea.ExistingMemberStatus = new ExistingMemberStatus()
                        {
                            Code = atm.tblREFExistingMemberStatu.ExistingMemberStatusCD,
                            Status = atm.tblREFExistingMemberStatu.ExistingMemberStatus
                        };
                    }

                    list.Add(ea);
                }
            }
            return list;
        }
    }
}
