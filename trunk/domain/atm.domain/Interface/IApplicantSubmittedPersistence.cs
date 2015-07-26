using System.Collections.Generic;

namespace SevenH.MMCSB.Atm.Domain.Interface
{
    public interface IApplicantSubmittedPersistence
    {
        void Delete(int id);
        int Save(ApplicantSubmitted appl);
        int Update(ApplicantSubmitted applicant);
        ApplicantSubmitted GetApplicant(int id);

        ApplicantSubmitted GetApplicant(string icno);

        IEnumerable<ApplicantSubmitted> GetApplicants(string icno);
        int SaveEducation(ApplicantEducationSubmitted education);
        int UpdateEducation(ApplicantEducationSubmitted education);
        IEnumerable<ApplicantEducationSubmitted> GetEducation(int applicantid);

        int SaveEducationSubject(ApplicantEduSubjectSubmitted subject);
        int UpdateEducationSubject(ApplicantEduSubjectSubmitted subject);
        IEnumerable<ApplicantEduSubjectSubmitted> GetEducationSubject(int appeduid);

        int SaveSkill(ApplicantSkillSubmitted skill);
        int UpdateSkill(ApplicantSkillSubmitted skill);
        IEnumerable<ApplicantSkillSubmitted> GetSkill(int applicantid);
        int SaveSport(ApplicantSportSubmitted sport);
        IEnumerable<ApplicantSportSubmitted> GetSport(int applicantid);

        ApplicantSubmittedPhoto GetPhoto(int applicantid);
        int SaveApplicantPhoto(ApplicantSubmittedPhoto photo);
        int UpdateApplicantPhoto(ApplicantSubmittedPhoto photo);
    }
}
