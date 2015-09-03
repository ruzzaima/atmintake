using System.Collections.Generic;

namespace SevenH.MMCSB.Atm.Domain.Interface
{
    public interface IApplicantSubmittedPersistence
    {
        //Applicant Submitted
        void Delete(int id);
        int Save(ApplicantSubmitted appl);
        int Update(ApplicantSubmitted applicant);
        ApplicantSubmitted GetApplicant(int applicantid);
        ApplicantSubmitted GetApplicant(string icno, int acquisitionid);
        ApplicantSubmitted GetApplicant(int applicantid, int acquisitionid);
        IEnumerable<ApplicantSubmitted> GetApplicants(string icno);
        IEnumerable<ApplicantSubmitted> GetApplicants(int acquisitionid);
        IEnumerable<ApplicantSubmitted> GetApplicants(int acquisitionid, string racecode);

        int SaveEducation(ApplicantEducationSubmitted education);
        int UpdateEducation(ApplicantEducationSubmitted education);
        IEnumerable<ApplicantEducationSubmitted> GetEducation(int applicantid);

        int SaveEducationSubject(ApplicantEduSubjectSubmitted subject);
        int UpdateEducationSubject(ApplicantEduSubjectSubmitted subject);
        IEnumerable<ApplicantEduSubjectSubmitted> GetEducationSubject(int appeduid);
        ApplicantEduSubjectSubmitted GetSubject(int appeduid, int subjectcode);

        int SaveSkill(ApplicantSkillSubmitted skill);
        int UpdateSkill(ApplicantSkillSubmitted skill);
        IEnumerable<ApplicantSkillSubmitted> GetSkill(int applicantid);
        int SaveSport(ApplicantSportSubmitted sport);
        int UpdateSport(ApplicantSportSubmitted sport);
        IEnumerable<ApplicantSportSubmitted> GetSport(int applicantid);

        ApplicantSubmittedPhoto GetPhoto(int applicantid);
        int SaveApplicantPhoto(ApplicantSubmittedPhoto photo);
        int UpdateApplicantPhoto(ApplicantSubmittedPhoto photo);

        IEnumerable<ApplicantSubmitted> Search(int acquisitionid, string category, string name, string icno, string searchcriteria, bool? invitationfirtselection, bool? firstselection, bool? finalselection, int? take, int? skip, bool? all, out int total);
        IEnumerable<ApplicantSubmitted> Search(int acquisitionid, string searchcriteria, bool? invitationfirtselection, bool? firstselection, bool? finalselection, int? take, int? skip, int? finalselectionlocid, string statecode, string citycode, bool? all, out int total);
        IEnumerable<ApplicantSubmitted> GetByAcademis(string highleveleducd);
    }
}
