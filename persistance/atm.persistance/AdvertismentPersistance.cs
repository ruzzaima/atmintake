using System;
using System.Collections.Generic;
using System.Linq;
using SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Atm.Entity.Persistance
{
    class AdvertismentPersistance : IAdvertismentPersistance
    {
        public void Delete(int id)
        {
            if (id == 0) return;
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblAdvertisments where a.Id == id select a).SingleOrDefault();
                if (null == exist) return;
                entities.tblAdvertisments.Remove(exist);
                entities.SaveChanges();
            }
        }

        public int Save(Advertisment advertisment)
        {
            if (advertisment.Id != 0)
                return Update(advertisment);

            using (var entities = new atmEntities())
            {
                var adv = new tblAdvertisment
                {
                    AcquisitionId = advertisment.AcquisitionId,
                    CreatedBy = advertisment.CreatedBy,
                    ServiceCd = advertisment.ServiceCode,
                    Description = advertisment.Description,
                    CreatedDate = DateTime.Now,
                    EndDate = advertisment.EndDate,
                    IntakeLocationId = advertisment.IntakeLocationId,
                    InterviewLocationId = advertisment.InterviewLocationId,
                    IsActive = advertisment.IsActive,
                    ShortDescription = advertisment.ShortDescription,
                    StartDate = advertisment.StartDate,
                    Title = advertisment.Title
                };

                entities.tblAdvertisments.Add(adv);
                if (entities.SaveChanges() > 0) return adv.Id;
            }

            return 0;
        }

        public Advertisment GetById(int id)
        {
            if (id == 0) return null;
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblAdvertisments where a.Id == id select a).SingleOrDefault();
                if (null == exist) return null;
                var adv = new Advertisment
                {
                    Id = exist.Id,
                    AcquisitionId = exist.AcquisitionId ?? 0,
                    CreatedBy = exist.CreatedBy,
                    ServiceCode = exist.ServiceCd,
                    Description = exist.Description,
                    CreatedDate = DateTime.Now,
                    EndDate = exist.EndDate,
                    IntakeLocationId = exist.IntakeLocationId,
                    InterviewLocationId = exist.InterviewLocationId ?? 0,
                    IsActive = exist.IsActive,
                    ShortDescription = exist.ShortDescription,
                    StartDate = exist.StartDate,
                    Title = exist.Title
                };
                return adv;
            }
        }

        public int Update(Advertisment advertisment)
        {
            if (advertisment.Id == 0) return 0;
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblAdvertisments where a.Id == advertisment.Id select a).SingleOrDefault();
                if (null == exist) return 0;
                exist.AcquisitionId = advertisment.AcquisitionId;
                exist.CreatedBy = advertisment.CreatedBy;
                exist.ServiceCd = advertisment.ServiceCode;
                exist.Description = advertisment.Description;
                exist.CreatedDate = DateTime.Now;
                exist.EndDate = advertisment.EndDate;
                exist.IntakeLocationId = advertisment.IntakeLocationId;
                exist.InterviewLocationId = advertisment.InterviewLocationId;
                exist.IsActive = advertisment.IsActive;
                exist.ShortDescription = advertisment.ShortDescription;
                exist.StartDate = advertisment.StartDate;
                exist.Title = advertisment.Title;

                entities.SaveChanges();
                return exist.Id;
            }

        }

        public IEnumerable<Advertisment> GetAdvertisments(bool? isactive, DateTime? enddate)
        {
            var list = new List<Advertisment>();
            using (var entities = new atmEntities())
            {
                var l = from a in entities.tblAdvertisments select a;
                if (isactive.HasValue)
                    l = l.Where(a => a.IsActive == isactive);
                if (enddate.HasValue)
                    l = l.Where(a => a.EndDate <= enddate);

                if (!l.Any()) return list;
                foreach (var exist in l)
                {
                    var adv = new Advertisment
                    {
                        Id = exist.Id,
                        AcquisitionId = exist.AcquisitionId ?? 0,
                        CreatedBy = exist.CreatedBy,
                        ServiceCode = exist.ServiceCd,
                        Description = exist.Description,
                        CreatedDate = DateTime.Now,
                        EndDate = exist.EndDate,
                        IntakeLocationId = exist.IntakeLocationId,
                        InterviewLocationId = exist.InterviewLocationId ?? 0,
                        IsActive = exist.IsActive,
                        ShortDescription = exist.ShortDescription,
                        StartDate = exist.StartDate,
                        Title = exist.Title
                    };
                    list.Add(adv);
                }
            }
            return list;
        }

        public IEnumerable<Advertisment> GetAdvertisments(string servicecode, DateTime? enddate)
        {
            var list = new List<Advertisment>();
            using (var entities = new atmEntities())
            {
                var l = from a in entities.tblAdvertisments where a.ServiceCd == servicecode select a;
               
                if (enddate.HasValue)
                    l = l.Where(a => a.EndDate <= enddate);

                if (!l.Any()) return list;
                foreach (var exist in l)
                {
                    var adv = new Advertisment
                    {
                        Id = exist.Id,
                        AcquisitionId = exist.AcquisitionId ?? 0,
                        CreatedBy = exist.CreatedBy,
                        ServiceCode = exist.ServiceCd,
                        Description = exist.Description,
                        CreatedDate = DateTime.Now,
                        EndDate = exist.EndDate,
                        IntakeLocationId = exist.IntakeLocationId,
                        InterviewLocationId = exist.InterviewLocationId ?? 0,
                        IsActive = exist.IsActive,
                        ShortDescription = exist.ShortDescription,
                        StartDate = exist.StartDate,
                        Title = exist.Title
                    };
                    list.Add(adv);
                }
            }
            return list;
        }
    }
}
