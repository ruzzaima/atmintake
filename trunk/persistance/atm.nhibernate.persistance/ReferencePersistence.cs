using System;
using System.Collections.Generic;
using System.Data;
using NHibernate;
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

        public IEnumerable<CodeItem.Achievement> GetAchievements()
        {
            var returnList = Factory.OpenSession()
                .CreateSQLQuery("select * from tblREFAchievement")
                .AddEntity(typeof(CodeItem.Achievement));
            return returnList.List<CodeItem.Achievement>();
        }

        public IEnumerable<CodeItem.AcquisitionType> GetAcquisitionTypes()
        {
            var returnList = Factory.OpenSession()
                 .CreateSQLQuery("select * from tblREFAcqType")
                 .AddEntity(typeof(CodeItem.AcquisitionType));
            return returnList.List<CodeItem.AcquisitionType>();
        }

        public IEnumerable<CodeItem.BloodType> GetBloodTypes()
        {
            var returnList = Factory.OpenSession()
                .CreateSQLQuery("select * from tblRefBloodType")
                .AddEntity(typeof(CodeItem.BloodType));
            return returnList.List<CodeItem.BloodType>();
        }

        public IEnumerable<CodeItem.City> GetCities(string statecode)
        {
            var returnList = Factory.OpenSession()
                .CreateSQLQuery("SELECT * FROM tblREFCity WHERE StateCd = '" + statecode + "'")
                .AddEntity(typeof(CodeItem.City));
            return returnList.List<CodeItem.City>();
        }


        public IEnumerable<CodeItem.Country> GetCountries()
        {
            var returnList = Factory.OpenSession()
                .CreateSQLQuery("select * from tblREFCountry")
                .AddEntity(typeof(CodeItem.Country));
            return returnList.List<CodeItem.Country>();
        }

        public IEnumerable<CodeItem.Ethnic> GetEthnics(string racecode)
        {
            var returnList = Factory.OpenSession()
               .CreateSQLQuery("SELECT * FROM tblREFEthnic WHERE RaceCd = '" + racecode + "'")
               .AddEntity(typeof(CodeItem.Ethnic));
            return returnList.List<CodeItem.Ethnic>();
        }

        public IEnumerable<CodeItem.Gender> GetGenders()
        {
            var returnList = Factory.OpenSession()
             .CreateSQLQuery("select * from tblREFGender")
             .AddEntity(typeof(CodeItem.Gender));
            return returnList.List<CodeItem.Gender>();
        }

        public IEnumerable<CodeItem.HighEduLevel> GetHighEduLevels()
        {
            var returnList = Factory.OpenSession()
            .CreateSQLQuery("select * from tblREFHighEduLevel")
            .AddEntity(typeof(CodeItem.HighEduLevel));
            return returnList.List<CodeItem.HighEduLevel>();
        }

        public IEnumerable<CodeItem.InstitutionCat> GetInstitutionCats()
        {
            var returnList = Factory.OpenSession()
           .CreateSQLQuery("select * from tblREFInstitutionCat")
           .AddEntity(typeof(CodeItem.InstitutionCat));
            return returnList.List<CodeItem.InstitutionCat>();
        }

        public IEnumerable<CodeItem.Institution> GetInstitutions()
        {
            var returnList = Factory.OpenSession()
          .CreateSQLQuery("select * from tblREFInstitution")
          .AddEntity(typeof(CodeItem.Institution));
            return returnList.List<CodeItem.Institution>();
        }

        public IEnumerable<CodeItem.LoginStatus> GetLoginStatus()
        {
            var returnList = Factory.OpenSession()
          .CreateSQLQuery("select * from tblREFLoginStatus")
          .AddEntity(typeof(CodeItem.LoginStatus));
            return returnList.List<CodeItem.LoginStatus>();
        }

        public IEnumerable<CodeItem.MajorMinor> GetMajorMinors()
        {
            var returnList = Factory.OpenSession()
         .CreateSQLQuery("select * from tblREFMajorMinor")
         .AddEntity(typeof(CodeItem.MajorMinor));
            return returnList.List<CodeItem.MajorMinor>();
        }

        public IEnumerable<CodeItem.MaritalStatus> GetMaritalStatus()
        {
            var returnList = Factory.OpenSession()
         .CreateSQLQuery("select * from tblREFMaritalStatus")
         .AddEntity(typeof(CodeItem.MaritalStatus));
            return returnList.List<CodeItem.MaritalStatus>();
        }

        public IEnumerable<CodeItem.PersonalityType> GetPersonalityTypes()
        {
            var returnList = Factory.OpenSession()
         .CreateSQLQuery("select * from tblREFPersonalityType")
         .AddEntity(typeof(CodeItem.PersonalityType));
            return returnList.List<CodeItem.PersonalityType>();
        }

        public IEnumerable<CodeItem.QuestionnareType> GetQuestionnareTypes()
        {
            var returnList = Factory.OpenSession()
          .CreateSQLQuery("select * from tblREFQuestionnareType")
          .AddEntity(typeof(CodeItem.QuestionnareType));
            return returnList.List<CodeItem.QuestionnareType>();
        }

        public IEnumerable<CodeItem.Race> GetRaces()
        {
            var returnList = Factory.OpenSession()
          .CreateSQLQuery("select * from tblREFRace")
          .AddEntity(typeof(CodeItem.Race));
            return returnList.List<CodeItem.Race>();
        }

        public IEnumerable<CodeItem.Religion> GetReligions()
        {
            var returnList = Factory.OpenSession()
         .CreateSQLQuery("select * from tblREFReligion")
         .AddEntity(typeof(CodeItem.Religion));
            return returnList.List<CodeItem.Religion>();
        }

        public IEnumerable<CodeItem.Service> GetServices()
        {
            var returnList = Factory.OpenSession()
         .CreateSQLQuery("select * from tblREFService")
         .AddEntity(typeof(CodeItem.Service));
            return returnList.List<CodeItem.Service>();
        }

        public IEnumerable<CodeItem.SkillCat> GetSkillCats()
        {
            var returnList = Factory.OpenSession()
         .CreateSQLQuery("select * from tblREFSkillCat")
         .AddEntity(typeof(CodeItem.SkillCat));
            return returnList.List<CodeItem.SkillCat>();
        }

        public IEnumerable<CodeItem.Skill> GetSkills()
        {
            var returnList = Factory.OpenSession()
          .CreateSQLQuery("select * from tblREFSkill")
          .AddEntity(typeof(CodeItem.Skill));
            return returnList.List<CodeItem.Skill>();
        }

        public IEnumerable<CodeItem.SportAndAssociation> GetSportAndAssociations(string type)
        {
            var returnList = Factory.OpenSession()
         .CreateSQLQuery("SELECT * FROM tblREFSportAndAssociation WHERE SportAssociatType = '" + type + "'")
         .AddEntity(typeof(CodeItem.SportAndAssociation));
            return returnList.List<CodeItem.SportAndAssociation>();
        }

        public IEnumerable<CodeItem.State> GetStates(string countrycode)
        {
            var returnList = Factory.OpenSession()
             .CreateSQLQuery("SELECT * FROM tblREFState WHERE CountryCd = '" + countrycode + "'")
             .AddEntity(typeof(CodeItem.State));
            return returnList.List<CodeItem.State>();
        }

        public IEnumerable<CodeItem.SubjectGrade> GetSubjectGrades()
        {
            var returnList = Factory.OpenSession()
           .CreateSQLQuery("select * from tblREFSubjectGrade")
           .AddEntity(typeof(CodeItem.SubjectGrade));
            return returnList.List<CodeItem.SubjectGrade>();
        }

        public IEnumerable<CodeItem.Subject> GetSubjects()
        {
            var returnList = Factory.OpenSession()
           .CreateSQLQuery("select * from tblREFSubject")
           .AddEntity(typeof(CodeItem.Subject));
            return returnList.List<CodeItem.Subject>();
        }


        public IEnumerable<CodeItem.Occupation> GetOccupations()
        {
            var returnList = Factory.OpenSession()
            .CreateSQLQuery("SELECT * FROM tblREFOccupation")
            .AddEntity(typeof(CodeItem.Occupation));
            return returnList.List<CodeItem.Occupation>();
        }
    }


}

