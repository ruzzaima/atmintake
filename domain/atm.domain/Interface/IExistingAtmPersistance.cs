using System.Collections.Generic;

namespace SevenH.MMCSB.Atm.Domain
{
    public interface IExistingAtmPersistance
    {
        int AddNew(ExistingMember existingMember);
        int Update(ExistingMember existingMember);
        bool Delete(int existingid);
        IEnumerable<ExistingMember> Search(string statuscd, string searchcriteria, string armyno);
    }
}
