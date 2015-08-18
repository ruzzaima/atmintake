using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenH.MMCSB.Atm.Domain
{
    public interface IApplicationPersistance
    {
        int AddNew(Application application);
        int Update(Application application);
        Application GetById(int id);
        Application GetByApplicantIdAndAcquisitionId(int applicantid, int acquisitionid);
        IEnumerable<Application> GetAllByApplicantId(int applicantid);
        IEnumerable<Application> GetAllByApplicantIdNumber(string idnumber);
        bool IsSubmitted(int applicantid, int acquisitionid, out int applicationid);
        bool IsSubmitted(string icno, int acquisitionid, out int applicationid);
    }
}
