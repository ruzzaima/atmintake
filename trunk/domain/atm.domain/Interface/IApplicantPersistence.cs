using System.Collections.Generic;

namespace SevenH.MMCSB.Atm.Domain
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
        ApplicantEduSubject GetSubject(int appeduid, int subjectcode);

        int SaveSkill(ApplicantSkill skill);
        int UpdateSkill(ApplicantSkill skill);
        IEnumerable<ApplicantSkill> GetSkill(int applicantid);
        int SaveSport(ApplicantSport sport);
        int UpdateSport(ApplicantSport sport);
        IEnumerable<ApplicantSport> GetSport(int applicantid);
        ApplicantSport GetApplicantSportAndKokos(int applicantsportid);
        bool DeleteApplicantSport(int applicantsportid);

        ApplicantPhoto GetPhoto(int applicantid);
        int SaveApplicantPhoto(ApplicantPhoto photo);
        int UpdateApplicantPhoto(ApplicantPhoto photo);
        /// <summary>
        /// Checking by ICNo
        /// </summary>
        /// <param name="idnumber"></param>
        /// <returns></returns>
        bool CheckingExistingAtmMember(string idnumber);
        /// <summary>
        /// Checking by ICNO
        /// </summary>
        /// <param name="idnumber"></param>
        /// <returns></returns>
        ExistingMember ExistingAtmMember(string idnumber);
        /// <summary>
        /// Checking by Army No
        /// </summary>
        /// <param name="armyno"></param>
        /// <returns></returns>
        bool CheckingExistingAtmMemberByArmyNo(string armyno);
        /// <summary>
        /// Checking by Army No
        /// </summary>
        /// <param name="armyno"></param>
        /// <returns></returns>
        ExistingMember ExistingAtmMemberByArmyNo(string armyno);

        IEnumerable<Applicant> Search(string category, string name, string icno, string searchcriteria);
        IEnumerable<Applicant> ExecuteQuery(string sql);

    }
}
