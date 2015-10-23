using System;
using System.Collections.Generic;

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
        int UpdateStatus(int acquisitionid, int applicantid, bool? firstinvitation, bool? firstselection, bool? finalselection, bool? lastselection, string modifiedby);
        int UpdateFirstInvitationStatus(int acquisitionid, int applicantid, bool? firstinvitation, string modifiedby);
        int UpdateFirstSelectionStatus(int acquisitionid, int applicantid, bool? firstselection, string modifiedby);
        int UpdateLastSelectionStatus(int acquisitionid, int applicantid, bool? finalselection, bool? interview, string modifiedby);
        int UpdateFirstSelectionLocationAndDateTime(int acquisitionid, int applicantid, int? locationid, DateTime? startdate, DateTime? enddate, string modifiedby);
        int UpdateReportDutyLocationAndDateTime(int acquisitionid, int applicantid, int? locationid, DateTime? reportdutydate, string modifiedby, string selectedservice);
        IEnumerable<State> GetSubmittedApplicationStates(int acquisitionid, bool? firstselection, bool? finalselection);
        IEnumerable<City> GetSubmittedApplicationCities(int acquisitionid, string statecode, bool? firstselection, bool? finalselection);
        IEnumerable<ReportDutyLocation> GetReportDutyLocations();
    }
}
