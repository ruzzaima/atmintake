using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenH.MMCSB.Atm.Domain
{
    public interface IAdvertismentPersistance
    {
        void Delete(int id);
        int Save(Advertisment advertisment);
        Advertisment GetById(int id);
        int Update(Advertisment advertisment);
        IEnumerable<Advertisment> GetAdvertisments(bool? isactive);
    }
}
