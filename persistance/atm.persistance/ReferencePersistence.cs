using System;
using System.Collections.Generic;
using System.Linq;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Atm.Entity.Persistance
{
    class ReferencePersistence : IReferencePersistence
    {
        public IEnumerable<Achievement> GetAchievements()
        {
            var list = new List<Achievement>();
            using (var entities = new atmEntities())
            {
                var l = from a in entities.tblREFAchievements select a;
                if (l.Any())
                {
                    foreach (var ac in l)
                    {
                        list.Add(new Achievement()
                        {
                            AchievementCd = ac.AchievementCd,
                            AchievementDescription = ac.Achievement,
                            ActiveInd = ac.ActiveInd,
                            CreatedBy = ac.CreatedBy,
                            CreatedDt = ac.CreatedDt,
                            LastModifiedBy = ac.LastModifiedBy,
                            LastModifiedDt = ac.LastModifiedDt
                        });
                    }
                }
            }
            return list;
        }

        public IEnumerable<AcquisitionType> GetAcquisitionTypes()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BloodType> GetBloodTypes()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> GetCities(string statecode)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Country> GetCountries()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ethnic> GetEthnics(string racecode)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Gender> GetGenders()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<HighEduLevel> GetHighEduLevels()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Institution> GetInstitutions()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Institution> GetInstitutions(string category)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InstitutionCat> GetInstitutionCats()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LoginStatus> GetLoginStatus()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MajorMinor> GetMajorMinors()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MaritalStatus> GetMaritalStatus()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonalityType> GetPersonalityTypes()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<QuestionnareType> GetQuestionnareTypes()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Race> GetRaces()
        {
            throw new NotImplementedException();
        }

        public Race GetRace(string racecode)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Religion> GetReligions()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Service> GetServices()
        {
            throw new NotImplementedException();
        }

        public AcquisitionType GetAcquisitionType(int code)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Skill> GetSkills()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Skill> GetSkills(string category)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SkillCat> GetSkillCats()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SportAndAssociation> GetSportAndAssociations(string type)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<State> GetStates(string countrycode)
        {
            throw new NotImplementedException();
        }

        public State GetStatesByBirthStateCode(string birthstatecode)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Subject> GetSubjects()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Subject> GetSubjects(string higheducodelevel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SubjectGrade> GetSubjectGrades()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Occupation> GetOccupations()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Zone> GetZones()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Location> GetLocations()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Location> GetLocations(string zonecode)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AcquisitionLocation> GetAcquisitionLocations(string zonecode)
        {
            throw new NotImplementedException();
        }
    }
}
