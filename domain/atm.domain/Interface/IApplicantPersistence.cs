using System.Collections.Generic;

namespace SevenH.MMCSB.Atm.Domain.Interface
{
    public interface IApplicantPersistence
    {
        void Delete(int id);
        int Save(Applicant appl);
        int Update(Applicant applicant);
        Applicant GetApplicant(int id);

        int SaveEducation(ApplicantEducation education);
        int UpdateEducation(ApplicantEducation education);
        IEnumerable<ApplicantEducation> GetEducation(int applicantid);

        int SaveEducationSubject(ApplicantEduSubject subject);
        int UpdateEducationSubject(ApplicantEduSubject subject);
        IEnumerable<ApplicantEduSubject> GetEducationSubject(int appeduid);
        ApplicantEduSubject GetSubject(int appeduid, string subjectcode);

        int SaveSkill(ApplicantSkill skill);
        int UpdateSkill(ApplicantSkill skill);
        IEnumerable<ApplicantSkill> GetSkill(int applicantid);
        int SaveSport(ApplicantSport sport);
        IEnumerable<ApplicantSport> GetSport(int applicantid);

        ApplicantPhoto GetPhoto(int applicantid);
        int SaveApplicantPhoto(ApplicantPhoto photo);
        int UpdateApplicantPhoto(ApplicantPhoto photo);
        bool CheckingExistingAtmMember(string idnumber);
        ExistingMember ExistingAtmMember(string idnumber);
    }
}
