using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using NHibernate;
using SevenH.MMCSB.Atm.Domain.Interface;
using CodeItem = SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Persistance
{
    public class ReferencePersistence : IReferencePersistence
    {

        public IEnumerable<CodeItem.Achievement> GetAchievements()
        {
            var returnList = Factory.OpenSession().QueryOver<CodeItem.Achievement>().List();
            return returnList;
        }

        public IEnumerable<CodeItem.AcquisitionType> GetAcquisitionTypes()
        {
            var returnList = Factory.OpenSession().QueryOver<CodeItem.AcquisitionType>().List();
            return returnList;
        }

        public IEnumerable<CodeItem.BloodType> GetBloodTypes()
        {
            var returnList = Factory.OpenSession().QueryOver<CodeItem.BloodType>().List();
            return returnList;
        }

        public IEnumerable<CodeItem.City> GetCities(string statecode)
        {
            var returnList = Factory.OpenSession().QueryOver<CodeItem.City>().Where(a => a.StateCd == statecode).List();
            return returnList;
        }


        public IEnumerable<CodeItem.Country> GetCountries()
        {
            var returnList = Factory.OpenSession().QueryOver<CodeItem.Country>().List();
            return returnList;
        }

        public IEnumerable<CodeItem.Ethnic> GetEthnics(string racecode)
        {
            var returnList = Factory.OpenSession().QueryOver<CodeItem.Ethnic>().Where(a => a.RaceCd == racecode).List();
            return returnList;
        }

        public IEnumerable<CodeItem.Gender> GetGenders()
        {
            var returnList = Factory.OpenSession().QueryOver<CodeItem.Gender>().List();
            return returnList;
        }

        public IEnumerable<CodeItem.HighEduLevel> GetHighEduLevels()
        {
            var returnList = Factory.OpenSession().QueryOver<CodeItem.HighEduLevel>().List();
            return returnList;
        }

        public IEnumerable<CodeItem.InstitutionCat> GetInstitutionCats()
        {
            var returnList = Factory.OpenSession().QueryOver<CodeItem.InstitutionCat>().List();
            return returnList;
        }

        public IEnumerable<CodeItem.Institution> GetInstitutions()
        {
            var returnList = Factory.OpenSession().QueryOver<CodeItem.Institution>().Where(a => a.MQAStatus).List();
            return returnList;
        }

        public IEnumerable<CodeItem.LoginStatus> GetLoginStatus()
        {
            var returnList = Factory.OpenSession().QueryOver<CodeItem.LoginStatus>().List();
            return returnList;
        }

        public IEnumerable<CodeItem.MajorMinor> GetMajorMinors()
        {
            var returnList = Factory.OpenSession().QueryOver<CodeItem.MajorMinor>().List();
            return returnList;
        }

        public IEnumerable<CodeItem.MaritalStatus> GetMaritalStatus()
        {
            var returnList = Factory.OpenSession().QueryOver<CodeItem.MaritalStatus>().List();
            return returnList;
        }

        public IEnumerable<CodeItem.PersonalityType> GetPersonalityTypes()
        {
            var returnList = Factory.OpenSession().QueryOver<CodeItem.PersonalityType>().List();
            return returnList;
        }

        public IEnumerable<CodeItem.QuestionnareType> GetQuestionnareTypes()
        {
            var returnList = Factory.OpenSession().QueryOver<CodeItem.QuestionnareType>().List();
            return returnList;
        }

        public IEnumerable<CodeItem.Race> GetRaces()
        {
            var returnList = Factory.OpenSession().QueryOver<CodeItem.Race>().List();
            return returnList;
        }

        public IEnumerable<CodeItem.Religion> GetReligions()
        {
            var returnList =
                Factory.OpenSession().QueryOver<CodeItem.Religion>().Where(a => a.ReligionDescription != null).List();
            return returnList;
        }

        public IEnumerable<CodeItem.Service> GetServices()
        {
            var returnList = Factory.OpenSession().QueryOver<CodeItem.Service>().List();
            return returnList;
        }

        public IEnumerable<CodeItem.SkillCat> GetSkillCats()
        {
            var returnList = Factory.OpenSession().QueryOver<CodeItem.SkillCat>().List();
            return returnList;
        }

        public IEnumerable<CodeItem.Skill> GetSkills()
        {
            var returnList = Factory.OpenSession().QueryOver<CodeItem.Skill>().List();
            return returnList;
        }

        public IEnumerable<CodeItem.SportAndAssociation> GetSportAndAssociations(string type)
        {
            var returnList =
                Factory.OpenSession()
                    .QueryOver<CodeItem.SportAndAssociation>()
                    .Where(a => a.SportAssociatType == type)
                    .List();
            return returnList;
        }

        public IEnumerable<CodeItem.State> GetStates(string countrycode)
        {
            var returnList =
                Factory.OpenSession().QueryOver<CodeItem.State>().Where(a => a.CountryCd == countrycode).List();
            return returnList;
        }

        public IEnumerable<CodeItem.SubjectGrade> GetSubjectGrades()
        {
            var returnList = Factory.OpenSession().QueryOver<CodeItem.SubjectGrade>().List();
            return returnList;
        }

        public IEnumerable<CodeItem.Subject> GetSubjects()
        {
            var returnList = Factory.OpenSession().QueryOver<CodeItem.Subject>().List();
            return returnList;
        }

        public IEnumerable<CodeItem.Occupation> GetOccupations()
        {
            var returnList = Factory.OpenSession().QueryOver<CodeItem.Occupation>().List();
            return returnList;
        }

        public IEnumerable<CodeItem.Subject> GetSubjects(string higheducodelevel)
        {
            var list =
                Factory.OpenSession()
                    .QueryOver<CodeItem.Subject>()
                    .Where(a => a.HighEduLevelCd == higheducodelevel)
                    .List();
            return list;
        }


        public CodeItem.State GetStatesByBirthStateCode(string birthstatecode)
        {
            var states = Factory.OpenSession().QueryOver<CodeItem.State>().Where(a => a.ICBirthStateCd != null).List();
            return states.FirstOrDefault(s => s.ICBirthStateCd.Contains(birthstatecode));
        }


        public IEnumerable<CodeItem.Skill> GetSkills(string category)
        {
            return Factory.OpenSession().QueryOver<CodeItem.Skill>().Where(a => a.SkillCategory == category).List();
        }


        public CodeItem.AcquisitionType GetAcquisitionType(int code)
        {
            var acqtype =
                Factory.OpenSession()
                    .QueryOver<CodeItem.AcquisitionType>()
                    .Where(a => a.AcquisitionTypeCd == code)
                    .SingleOrDefault();
            return acqtype;
        }


        public IEnumerable<CodeItem.Location> GetLocations(string zonecode)
        {
            if (!string.IsNullOrWhiteSpace(zonecode))
                return Factory.OpenSession().QueryOver<CodeItem.Location>().Where(a => a.ZoneCd == zonecode).List();

            return null;
        }

        public IEnumerable<CodeItem.Location> GetLocations()
        {
            var list = Factory.OpenSession().QueryOver<CodeItem.Location>().List();
            return list;
        }

        public IEnumerable<CodeItem.Zone> GetZones()
        {
            var list = Factory.OpenSession().QueryOver<CodeItem.Zone>().List();
            return list;
        }

        public IEnumerable<CodeItem.AcquisitionLocation> GetAcquisitionLocations(string zonecode)
        {
            var list = Factory.OpenSession().QueryOver<CodeItem.AcquisitionLocation>().Where(a => a.ZoneCd == zonecode).List();
            return list;
        }


        public IEnumerable<CodeItem.Institution> GetInstitutions(string category)
        {
            var returnList = Factory.OpenSession().QueryOver<CodeItem.Institution>().Where(a => a.InstCatCd == category).List();
            return returnList;
        }
    }
}