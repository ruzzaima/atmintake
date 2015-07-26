using System.Collections.Generic;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;
using Spring.Context.Support;
using Spring.Objects.Factory;

namespace SevenH.MMCSB.Atm.Web
{
    public class ReferenceRepo 
    {

        private IReferencePersistence _mPersistence;

        public virtual IReferencePersistence PersistanceLayer
        {
            get
            {
                if (((_mPersistence != null))) return _mPersistence;
                var ctx = ContextRegistry.GetContext();
                _mPersistence = ((IObjectFactory)ctx).GetObject("ReferencePersistence") as IReferencePersistence;
                return _mPersistence;
            }
            set { _mPersistence = value; }
        }

        public IEnumerable<Achievement> GetAchievements()
        {
            return PersistanceLayer.GetAchievements();
        }

        public IEnumerable<AcquisitionType> GetAcquisitionTypes()
        {
            return PersistanceLayer.GetAcquisitionTypes();
        }

        public IEnumerable<BloodType> GetBloodTypes()
        {
            return PersistanceLayer.GetBloodTypes();
        }

        public IEnumerable<City> GetCities(string statecode)
        {
            return PersistanceLayer.GetCities(statecode);
        }

        public IEnumerable<Country> GetCountries()
        {
            return PersistanceLayer.GetCountries();
        }

        public IEnumerable<Ethnic> GetEthnics(string racecode)
        {
            return PersistanceLayer.GetEthnics(racecode);
        }

        public IEnumerable<Gender> GetGenders()
        {
            return PersistanceLayer.GetGenders();
        }

        public IEnumerable<HighEduLevel> GetHighEduLevels()
        {
            return PersistanceLayer.GetHighEduLevels();
        }

        public IEnumerable<Institution> GetInstitutions(string category)
        {
            return PersistanceLayer.GetInstitutions(category);
        }

        public IEnumerable<Institution> GetInstitutions()
        {
            return PersistanceLayer.GetInstitutions();
        }

        public IEnumerable<InstitutionCat> GetInstitutionCats()
        {
            return PersistanceLayer.GetInstitutionCats();
        }

        public IEnumerable<LoginStatus> GetLoginStatus()
        {
            return PersistanceLayer.GetLoginStatus();
        }

        public IEnumerable<MajorMinor> GetMajorMinors()
        {
            return PersistanceLayer.GetMajorMinors();
        }

        public IEnumerable<MaritalStatus> GetMaritalStatus()
        {
            return PersistanceLayer.GetMaritalStatus();
        }

        public IEnumerable<PersonalityType> GetPersonalityTypes()
        {
            return PersistanceLayer.GetPersonalityTypes();
        }

        public IEnumerable<QuestionnareType> GetQuestionnareTypes()
        {
            return PersistanceLayer.GetQuestionnareTypes();
        }

        public IEnumerable<Race> GetRaces()
        {
            return PersistanceLayer.GetRaces();
        }

        public IEnumerable<Religion> GetReligions()
        {
            return PersistanceLayer.GetReligions();
        }

        public IEnumerable<Service> GetServices()
        {
            return PersistanceLayer.GetServices();
        }

        public IEnumerable<Skill> GetSkills()
        {
            return PersistanceLayer.GetSkills();
        }

        public IEnumerable<SkillCat> GetSkillCats()
        {
            return PersistanceLayer.GetSkillCats();
        }

        public IEnumerable<SportAndAssociation> GetSportAndAssociations(string type)
        {
            return PersistanceLayer.GetSportAndAssociations(type);
        }

        public IEnumerable<State> GetStates(string countrycode)
        {
            return PersistanceLayer.GetStates(countrycode);
        }

        public IEnumerable<Subject> GetSubjects()
        {
            return PersistanceLayer.GetSubjects();
        }

        public IEnumerable<Subject> GetSubjects(string highedulevelcode)
        {
            return PersistanceLayer.GetSubjects(highedulevelcode);
        }

        public IEnumerable<SubjectGrade> GetSubjectGrades()
        {
            return PersistanceLayer.GetSubjectGrades();
        }

        public IEnumerable<Occupation> GetOccupations()
        {
            return PersistanceLayer.GetOccupations();
        }

        public IEnumerable<Skill> GetSkills(string category)
        {
            return PersistanceLayer.GetSkills(category);
        }

        public IEnumerable<Zone> GetZones()
        {
            return PersistanceLayer.GetZones();
        }

        public IEnumerable<Location> GetLocations(string zone)
        {
            return PersistanceLayer.GetLocations(zone);
        }

        public IEnumerable<AcquisitionLocation> GetAcquisitionLocations(string zone)
        {
            return PersistanceLayer.GetAcquisitionLocations(zone);
        }
    }
}