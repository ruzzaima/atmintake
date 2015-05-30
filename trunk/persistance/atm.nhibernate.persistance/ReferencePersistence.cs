using System;
using System.Data;
using NHibernate;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;
using CodeItem = SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Persistance
{
    public class ReferencePersistence : IReferencePersistence
    {

        private static NHibernate.ISession _mSession;
        public ISession Session
        {
            get
            {
                if ((_mSession == null))
                {

                    _mSession = Factory.OpenSession();
                }
                if (_mSession.Connection.State == ConnectionState.Closed)
                {
                    _mSession.Connection.Open();
                }

                return _mSession;
            }
        }

   
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<Achievement> GetAchievements()
        {
            var returnList = Factory.OpenSession()
                .CreateSQLQuery("select * from tblREFAchievement")
                .AddEntity(typeof(Achievement));
            return returnList.List<Achievement>();
        }

        public System.Collections.Generic.IEnumerable<AcquisitionType> GetAcquisitionTypes()
        {
            var returnList = Factory.OpenSession()
                 .CreateSQLQuery("select * from tblREFAcqType")
                 .AddEntity(typeof(AcquisitionType));
            return returnList.List<AcquisitionType>();
        }

        public System.Collections.Generic.IEnumerable<BloodType> GetBloodTypes()
        {
            var returnList = Factory.OpenSession()
                .CreateSQLQuery("select * from tblRefBloodType")
                .AddEntity(typeof(BloodType));
            return returnList.List<BloodType>();
        }

        public System.Collections.Generic.IEnumerable<City> GetCities()
        {
            var returnList = Factory.OpenSession()
                .CreateSQLQuery("select * from tblREFCity")
                .AddEntity(typeof(City));
            return returnList.List<City>();
        }


        public System.Collections.Generic.IEnumerable<Country> GetCountries()
        {
            var returnList = Factory.OpenSession()
                .CreateSQLQuery("select * from tblREFCountry")
                .AddEntity(typeof(Country));
            return returnList.List<Country>();
        }

        public System.Collections.Generic.IEnumerable<Ethnic> GetEthnics()
        {
            var returnList = Factory.OpenSession()
               .CreateSQLQuery("select * from tblREFEthnic")
               .AddEntity(typeof(Ethnic));
            return returnList.List<Ethnic>();
        }

        public System.Collections.Generic.IEnumerable<Gender> GetGenders()
        {
            var returnList = Factory.OpenSession()
             .CreateSQLQuery("select * from tblREFGender")
             .AddEntity(typeof(Gender));
            return returnList.List<Gender>();
        }

        public System.Collections.Generic.IEnumerable<HighEduLevel> GetHighEduLevels()
        {
            var returnList = Factory.OpenSession()
            .CreateSQLQuery("select * from tblREFHighEduLevel")
            .AddEntity(typeof(HighEduLevel));
            return returnList.List<HighEduLevel>();
        }

        public System.Collections.Generic.IEnumerable<InstitutionCat> GetInstitutionCats()
        {
            var returnList = Factory.OpenSession()
           .CreateSQLQuery("select * from tblREFInstitutionCat")
           .AddEntity(typeof(InstitutionCat));
            return returnList.List<InstitutionCat>();
        }

        public System.Collections.Generic.IEnumerable<Institution> GetInstitutions()
        {
            var returnList = Factory.OpenSession()
          .CreateSQLQuery("select * from tblREFInstitution")
          .AddEntity(typeof(Institution));
            return returnList.List<Institution>();
        }

        public System.Collections.Generic.IEnumerable<LoginStatus> GetLoginStatus()
        {
            var returnList = Factory.OpenSession()
          .CreateSQLQuery("select * from tblREFLoginStatus")
          .AddEntity(typeof(LoginStatus));
            return returnList.List<LoginStatus>();
        }

        public System.Collections.Generic.IEnumerable<MajorMinor> GetMajorMinors()
        {
            var returnList = Factory.OpenSession()
         .CreateSQLQuery("select * from tblREFMajorMinor")
         .AddEntity(typeof(MajorMinor));
            return returnList.List<MajorMinor>();
        }

        public System.Collections.Generic.IEnumerable<MaritalStatus> GetMaritalStatus()
        {
            var returnList = Factory.OpenSession()
         .CreateSQLQuery("select * from tblREFMaritalStatus")
         .AddEntity(typeof(MaritalStatus));
            return returnList.List<MaritalStatus>();
        }

        public System.Collections.Generic.IEnumerable<PersonalityType> GetPersonalityTypes()
        {
            var returnList = Factory.OpenSession()
         .CreateSQLQuery("select * from tblREFPersonalityType")
         .AddEntity(typeof(PersonalityType));
            return returnList.List<PersonalityType>();
        }

        public System.Collections.Generic.IEnumerable<QuestionnareType> GetQuestionnareTypes()
        {
            var returnList = Factory.OpenSession()
          .CreateSQLQuery("select * from tblREFQuestionnareType")
          .AddEntity(typeof(QuestionnareType));
            return returnList.List<QuestionnareType>();
        }

        public System.Collections.Generic.IEnumerable<Race> GetRaces()
        {
            var returnList = Factory.OpenSession()
          .CreateSQLQuery("select * from tblREFRace")
          .AddEntity(typeof(Race));
            return returnList.List<Race>();
        }

        public System.Collections.Generic.IEnumerable<Religion> GetReligions()
        {
            var returnList = Factory.OpenSession()
         .CreateSQLQuery("select * from tblREFReligion")
         .AddEntity(typeof(Religion));
            return returnList.List<Religion>();
        }

        public System.Collections.Generic.IEnumerable<Service> GetServices()
        {
            var returnList = Factory.OpenSession()
         .CreateSQLQuery("select * from tblREFService")
         .AddEntity(typeof(Service));
            return returnList.List<Service>();
        }

        public System.Collections.Generic.IEnumerable<SkillCat> GetSkillCats()
        {
            var returnList = Factory.OpenSession()
         .CreateSQLQuery("select * from tblREFSkillCat")
         .AddEntity(typeof(SkillCat));
            return returnList.List<SkillCat>();
        }

        public System.Collections.Generic.IEnumerable<Skill> GetSkills()
        {
            var returnList = Factory.OpenSession()
          .CreateSQLQuery("select * from tblREFSkill")
          .AddEntity(typeof(Skill));
            return returnList.List<Skill>();
        }

        public System.Collections.Generic.IEnumerable<ApplicantSport> GetSportAndAssociations()
        {
            var returnList = Factory.OpenSession()
         .CreateSQLQuery("select * from tblREFSportAndAssociation")
         .AddEntity(typeof(ApplicantSport));
            return returnList.List<ApplicantSport>();
        }

        public System.Collections.Generic.IEnumerable<State> GetStates()
        {
            var returnList = Factory.OpenSession()
             .CreateSQLQuery("select * from tblREFState")
             .AddEntity(typeof(State));
                return returnList.List<State>();
        }

        public System.Collections.Generic.IEnumerable<SubjectGrade> GetSubjectGrades()
        {
            var returnList = Factory.OpenSession()
           .CreateSQLQuery("select * from tblREFSubjectGrade")
           .AddEntity(typeof(SubjectGrade));
                return returnList.List<SubjectGrade>();
        }

        public System.Collections.Generic.IEnumerable<Subject> GetSubjects()
        {
            var returnList = Factory.OpenSession()
           .CreateSQLQuery("select * from tblREFSubject")
           .AddEntity(typeof(Subject));
            return returnList.List<Subject>();
        }

       
    }


}

