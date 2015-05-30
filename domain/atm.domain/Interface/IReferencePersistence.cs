using System.Collections.Generic;

namespace SevenH.MMCSB.Atm.Domain.Interface
{
    public interface IReferencePersistence
    {
        IEnumerable<Achievement> GetAchievements();
        IEnumerable<AcquisitionType> GetAcquisitionTypes();
        IEnumerable<BloodType> GetBloodTypes();
        IEnumerable<City> GetCities();
        IEnumerable<Country> GetCountries();
        IEnumerable<Ethnic> GetEthnics();
        IEnumerable<Gender> GetGenders();
        IEnumerable<HighEduLevel> GetHighEduLevels();
        IEnumerable<Institution> GetInstitutions();
        IEnumerable<InstitutionCat> GetInstitutionCats();
        IEnumerable<LoginStatus> GetLoginStatus();
        IEnumerable<MajorMinor> GetMajorMinors();
        IEnumerable<MaritalStatus> GetMaritalStatus();
        IEnumerable<PersonalityType> GetPersonalityTypes();
        IEnumerable<QuestionnareType> GetQuestionnareTypes();
        IEnumerable<Race> GetRaces();
        IEnumerable<Religion> GetReligions();
        IEnumerable<Service> GetServices();
        IEnumerable<Skill> GetSkills();
        IEnumerable<SkillCat> GetSkillCats();
        IEnumerable<ApplicantSport> GetSportAndAssociations();
        IEnumerable<State> GetStates();
        IEnumerable<Subject> GetSubjects();
        IEnumerable<SubjectGrade> GetSubjectGrades();
        void Delete(int id);
      

    }
}
