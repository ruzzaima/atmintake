using System;
using System.Collections.Generic;
using System.Linq;
using SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Persistance
{
    class AdvertismentPersistance : IAdvertismentPersistance
    {

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Advertisment> GetAdvertisments(bool? isactive, DateTime? enddate)
        {
            if (null == isactive)
            {
                var exist = Factory.OpenSession().CreateCriteria<Advertisment>().List<Advertisment>();
                if (null != exist && exist.Any())
                {
                    foreach (var ad in exist)
                    {
                        var acq = Factory.OpenSession().QueryOver<Acquisition>().Where(a => a.AcquisitionId == ad.AcquisitionId).SingleOrDefault();
                        ad.Acquisition = acq;
                    }
                }
                return exist;
            }
            else
            {
                var exist = Factory.OpenSession().QueryOver<Advertisment>().List();
                return exist;
            }
        }

        public Advertisment GetById(int id)
        {
            var exist = Factory.OpenSession().QueryOver<Advertisment>().Where(a => a.Id == id).SingleOrDefault();
            var acq = Factory.OpenSession().QueryOver<Acquisition>().Where(a => a.AcquisitionId == exist.AcquisitionId).SingleOrDefault();
            exist.Acquisition = acq;
            return exist;
        }

        public int Save(Advertisment advertisment)
        {
            throw new NotImplementedException();
        }

        public int Update(Advertisment advertisment)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Advertisment> GetAdvertisments(string servicecode, DateTime? enddate)
        {
            var exist = Factory.OpenSession().QueryOver<Advertisment>().Where(a => a.ServiceCode == servicecode).List();
            if (enddate.HasValue) exist = exist.Where(a => a.EndDate > enddate).ToList();
            if (exist.Any())
            {
                foreach (var advertisment in exist)
                {
                    var acq = Factory.OpenSession().QueryOver<Acquisition>().Where(a => a.AcquisitionId == advertisment.AcquisitionId).SingleOrDefault();
                    advertisment.Acquisition = acq;
                }
            }
            return exist;
        }
    }
}
