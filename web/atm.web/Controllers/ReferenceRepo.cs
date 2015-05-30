using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;
using Spring.Context.Support;
using Spring.Objects.Factory;

namespace SevenH.MMCSB.Atm.Web.Controllers
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

        public IEnumerable<City> GetCities()
        {
            return PersistanceLayer.GetCities();
        }

        public IEnumerable<Country> GetCountries()
        {
            return PersistanceLayer.GetCountries();
        }

        public IEnumerable<Ethnic> GetEthnics()
        {
            return PersistanceLayer.GetEthnics();
        }

        public IEnumerable<Gender> GetGenders()
        {
            return PersistanceLayer.GetGenders();
        }

        public IEnumerable<HighEduLevel> GetHighEduLevels()
        {
            return PersistanceLayer.GetHighEduLevels();
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

        public IEnumerable<ApplicantSport> GetSportAndAssociations()
        {
            return PersistanceLayer.GetSportAndAssociations();
        }

        public IEnumerable<State> GetStates()
        {
            return PersistanceLayer.GetStates();
        }

        public IEnumerable<Subject> GetSubjects()
        {
            return PersistanceLayer.GetSubjects();
        }

        public IEnumerable<SubjectGrade> GetSubjectGrades()
        {
            return PersistanceLayer.GetSubjectGrades();
        }

    }
}