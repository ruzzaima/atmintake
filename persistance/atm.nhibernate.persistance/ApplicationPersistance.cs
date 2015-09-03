using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Util;
using NHibernate;
using SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Persistance
{
    class ApplicationPersistance : IApplicationPersistance
    {
        public Application GetByApplicantIdAndAcquisitionId(int applicantid, int acquisitionid)
        {
            var exist = Factory.OpenSession().QueryOver<Application>().Where(a => a.ApplicantId == applicantid && a.AcquisitionId == acquisitionid).SingleOrDefault();
            return exist;
        }

        public IEnumerable<Application> GetAllByApplicantId(int applicantid)
        {
            var list = Factory.OpenSession().QueryOver<Application>().Where(a => a.ApplicantId == applicantid).List();
            return list;
        }

        public Application GetById(int id)
        {
            var exist = Factory.OpenSession().QueryOver<Application>().Where(a => a.AppId == id).SingleOrDefault();
            return exist;
        }

        public int AddNew(Application application)
        {
            Factory.OpenSession().SaveOrUpdate(application);
            Factory.OpenSession().Flush();
            return application.AppId;
        }

        public int Update(Application application)
        {
            Factory.OpenSession().SaveOrUpdate(application);
            Factory.OpenSession().Flush();
            return application.AppId;
        }


        public IEnumerable<Application> GetAllByApplicantIdNumber(string idnumber)
        {
            var returnapps = new List<Application>();
            var applicant = Factory.OpenSession().QueryOver<ApplicantSubmitted>().Where(a => a.NewICNo == idnumber).List();
            foreach (var appl in applicant)
            {
                if (null != appl)
                {
                    var appl1 = appl;
                    var apps = Factory.OpenSession().QueryOver<Application>().Where(a => a.ApplicantId == appl1.ApplicantId).List();
                    returnapps.AddRange(apps);
                }
            }
            return null;
        }


        public bool IsSubmitted(int applicantid, int acquisitionid, out int applicationid)
        {
            var valid = Factory.OpenSession().QueryOver<Application>().Where(a => a.AcquisitionId == acquisitionid && a.ApplicantId == applicantid).SingleOrDefault();
            if (null != valid)
            {
                applicationid = valid.AppId;
                return true;
            }
            else
            {
                applicationid = 0;
                return false;
            }
        }

        public bool IsSubmitted(string icno, int acquisitionid, out int applicationid)
        {
            var valid = Factory.OpenSession().QueryOver<ApplicantSubmitted>().Where(a => a.AcquisitionId == acquisitionid && a.NewICNo == icno).SingleOrDefault();
            if (null != valid)
            {
                var app = Factory.OpenSession().QueryOver<Application>().Where(a => a.ApplicantId == valid.ApplicantId && a.AcquisitionId == acquisitionid).SingleOrDefault();
                if (null != app)
                {
                    applicationid = app.AppId;
                    return true;
                }
            }
            applicationid = 0;
            return false;
        }

        public int UpdateStatus(int acquisitionid, int applicantid, bool? firstinvitation, bool? firstselection, bool? finalselection, bool? lastselection, string modifiedby)
        {
            throw new NotImplementedException();
        }


        public int UpdateFirstInvitationStatus(int acquisitionid, int applicantid, bool? firstinvitation, string modifiedby)
        {
            throw new NotImplementedException();
        }

        public int UpdateFirstSelectionStatus(int acquisitionid, int applicantid, bool? firstselection, string modifiedby)
        {
            throw new NotImplementedException();
        }

        public int UpdateLastSelectionStatus(int acquisitionid, int applicantid, bool? finalselection, bool? interview, string modifiedby)
        {
            throw new NotImplementedException();
        }

        public int UpdateFirstSelectionLocationAndDateTime(int acquisitionid, int applicantid, int? locationid, DateTime? startdate,
            DateTime? enddate, string modifiedby)
        {
            throw new NotImplementedException();
        }

        public int UpdateFirstSelectionLocationAndDateTime(int acquisitionid, int applicantid, int locationid, DateTime startdate,
            DateTime enddate, string modifiedby)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<State> GetSubmittedApplicationStates(int acquisitionid, bool? firstselection, bool? finalselection)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> GetSubmittedApplicationCities(int acquisitionid, string statecode, bool? firstselection,
            bool? finalselection)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<State> GetSubmittedApplicationStates(int acquisitionid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> GetSubmittedApplicationCities(int acquisitionid, string statecode)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> GetSubmittedApplicationCities(int acquisitionid)
        {
            throw new NotImplementedException();
        }
    }
}
