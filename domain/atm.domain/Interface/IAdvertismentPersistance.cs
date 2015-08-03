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
        /// <summary>
        /// Get By Is Active Status and where enddate is still open
        /// </summary>
        /// <param name="isactive"></param>
        /// <returns></returns>
        IEnumerable<Advertisment> GetAdvertisments(bool? isactive, DateTime? enddate);
        /// <summary>
        /// By Service code only
        /// </summary>
        /// <param name="servicecode"></param>
        /// <returns></returns>
        IEnumerable<Advertisment> GetAdvertisments(string servicecode, DateTime? enddate);
    }
}
