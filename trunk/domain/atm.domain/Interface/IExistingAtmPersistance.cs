using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenH.MMCSB.Atm.Domain
{
    public interface IExistingAtmPersistance
    {
        int AddNew(ExistingMember existingMember);
        int Update(ExistingMember existingMember);
        bool Delete(int existingid);
        IEnumerable<ExistingMember> Search(string statuscd, string searchcriteria, int armyno);
    }
}
