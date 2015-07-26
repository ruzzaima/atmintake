using System.Collections.Generic;

namespace SevenH.MMCSB.Atm.Domain.Interface
{
    public interface IReferencePersistence
    {
        IEnumerable<Achievement> GetAchievements();
        IEnumerable<AcquisitionType> GetAcquisitionTypes();
        IEnumerable<BloodType> GetBloodTypes();
        IEnumerable<City> GetCities(string statecode);
        IEnumerable<Country> GetCountries();
        IEnumerable<Ethnic> GetEthnics(string racecode);
        IEnumerable<Gender> GetGenders();
        IEnumerable<HighEduLevel> GetHighEduLevels();
        IEnumerable<Institution> GetInstitutions();
        IEnumerable<Institution> GetInstitutions(string category);
        IEnumerable<InstitutionCat> GetInstitutionCats();
        IEnumerable<LoginStatus> GetLoginStatus();
        IEnumerable<MajorMinor> GetMajorMinors();
        IEnumerable<MaritalStatus> GetMaritalStatus();
        IEnumerable<PersonalityType> GetPersonalityTypes();
        IEnumerable<QuestionnareType> GetQuestionnareTypes();
        IEnumerable<Race> GetRaces();
        IEnumerable<Religion> GetReligions();
        IEnumerable<Service> GetServices();
        AcquisitionType GetAcquisitionType(int code);
        IEnumerable<Skill> GetSkills();
        IEnumerable<Skill> GetSkills(string category);
        IEnumerable<SkillCat> GetSkillCats();
        IEnumerable<SportAndAssociation> GetSportAndAssociations(string type);
        IEnumerable<State> GetStates(string countrycode);
        State GetStatesByBirthStateCode(string birthstatecode);
        IEnumerable<Subject> GetSubjects();
        IEnumerable<Subject> GetSubjects(string higheducodelevel);
        IEnumerable<SubjectGrade> GetSubjectGrades();
        IEnumerable<Occupation> GetOccupations();
        IEnumerable<Zone> GetZones();
        IEnumerable<Location> GetLocations();
        IEnumerable<Location> GetLocations(string zonecode);
        IEnumerable<AcquisitionLocation> GetAcquisitionLocations(string zonecode);
        
    }
}
