using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenH.MMCSB.Atm.Domain
{
    public interface IStatisticPersistance
    {
        int Count(int acquisitionid, string[] birthstatecode, string gendercode, string highleveleducode, string racecode, string ethniccode, string religioncode);
    }
}
