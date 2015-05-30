using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class Country
    {

        public class CountryMap : ClassMap<Country>
        {
            public CountryMap()
            {
                Table("tblREFCountry");
                Id(x => x.CountryCd);
                Map(x => x.CountryName).Column("Country");
                Map(x => x.ActiveInd);
                Map(x => x.CreatedBy);
                Map(x => x.LastModifiedBy);
                Map(x => x.CreatedDt);
                Map(x => x.LastModifiedDt);
            }
        }

        public class CityMap : ClassMap<City>
        {
            public CityMap()
            {
                Table("tblREFCity");
                Id(x => x.CityCd);
                Map(x => x.CityName).Column("City");
                Map(x => x.StateCd);
                Map(x => x.StateCapitalInd);
                Map(x => x.MainCityInd);

            }
        }

        public class BloodTypeMap : ClassMap<BloodType>
        {
            public BloodTypeMap()
            {
                Table("tblRefBloodType");
                Id(x => x.BloodTypeCd);
                Map(x => x.BloodTypeDesc).Column("BloodType"); ;
            }
        }

        public class AcquisitionTypeMap : ClassMap<AcquisitionType>
        {
            public AcquisitionTypeMap()
            {
                Table("tblREFAcqType");
                Id(x => x.AcquisitionTypeCd);
                Map(x => x.AcquisitionTypeNm);
                Map(x => x.ServiceCd);
            }
        }

        public class AchievementMap : ClassMap<Achievement>
        {
            public AchievementMap()
            {
                Table("tblREFAchievement");
                Id(x => x.AchievementCd);
                Map(x => x.AchievementDescription).Column("Achievement");
                Map(x => x.ActiveInd);
                Map(x => x.CreatedBy);
                Map(x => x.LastModifiedBy);
                Map(x => x.CreatedDt);
                Map(x => x.LastModifiedDt);
            }
        }

        public class EthnicMap : ClassMap<Ethnic>
        {
            public EthnicMap()
            {
                Table("tblREFEthnic");
                Id(x => x.EthnicCd);
                Map(x => x.EthnicDescription).Column("Ethnic");
                Map(x => x.EthnicParentCd);
                Map(x => x.RaceCd);
                Map(x => x.ActiveInd);
                Map(x => x.CreatedBy);
                Map(x => x.LastModifiedBy);
                Map(x => x.CreatedDt);
                Map(x => x.LastModifiedDt);
            }
        }

        public class GenderMap : ClassMap<Gender>
        {
            public GenderMap()
            {
                Table("tblREFGender");
                Id(x => x.GenderCd);
                Map(x => x.GenderDesc).Column("Gender");
            }
        }

        public class HighEduLevelMap : ClassMap<HighEduLevel>
        {
            public HighEduLevelMap()
            {
                Table("tblREFHighEduLevel");
                Id(x => x.HighEduLevelCd);
                Map(x => x.HighestEduLevel);
                Map(x => x.HighestEduLevelRank);
                Map(x => x.ActiveInd);
                Map(x => x.CreatedBy);
                Map(x => x.LastModifiedBy);
                Map(x => x.CreatedDt);
                Map(x => x.LastModifiedDt);
            }
        }


        public class InstitutionMap : ClassMap<Institution>
        {
            public InstitutionMap()
            {
                Table("tblREFInstitution");
                Id(x => x.InstCd);
                Map(x => x.InstNm);
                Map(x => x.MQAStatus);
                Map(x => x.InstCatCd);
                Map(x => x.ActiveInd);
                Map(x => x.CreatedBy);
                Map(x => x.LastModifiedBy);
                Map(x => x.CreatedDt);
                Map(x => x.LastModifiedDt);
            }
        }

        public class InstitutionCatMap : ClassMap<InstitutionCat>
        {
            public InstitutionCatMap()
            {
                Table("tblREFInstitutionCat");
                Id(x => x.InstCatCd);
                Map(x => x.InstCat);
            }
        }


        public class MajorMinorMap : ClassMap<MajorMinor>
        {
            public MajorMinorMap()
            {
                Table("tblREFMajorMinor");
                Id(x => x.MajorMinorCd);
                Map(x => x.ActiveInd);
                Map(x => x.CreatedBy);
                Map(x => x.LastModifiedBy);
                Map(x => x.CreatedDt);
                Map(x => x.LastModifiedDt);
            }
        }

        public class MaritalStatusMap : ClassMap<MaritalStatus>
        {
            public MaritalStatusMap()
            {
                Table("tblREFMaritalStatus");
                Id(x => x.MrtlStatusCd);
                Map(x => x.MrtlStatus);
            }
        }

        public class PersonalityTypeMap : ClassMap<PersonalityType>
        {
            public PersonalityTypeMap()
            {
                Table("tblREFPersonalityType");
                Id(x => x.PersonalityTypeCd);
                Map(x => x.PersonalityTypeDesc).Column("PersonalityType");
            }
        }


        public class QuestionnareTypeMap : ClassMap<QuestionnareType>
        {
            public QuestionnareTypeMap()
            {
                Table("tblREFQuestionnareType");
                Id(x => x.QuestionnaireTypeCd);
                Map(x => x.QuestionnaireTypeDesc).Column("QuestionnaireType");
            }
        }

        public class RaceMap : ClassMap<Race>
        {
            public RaceMap()
            {
                Table("tblREFRace");
                Id(x => x.RaceCd);
                Map(x => x.RaceDescription).Column("Race");
                Map(x => x.ActiveInd);
                Map(x => x.CreatedBy);
                Map(x => x.LastModifiedBy);
                Map(x => x.CreatedDt);
                Map(x => x.LastModifiedDt);
            }
        }

        public class ReligionMap : ClassMap<Religion>
        {
            public ReligionMap()
            {
                Table("tblREFReligion");
                Id(x => x.ReligionCd);
                Map(x => x.ReligionDescription).Column("Religion");
                Map(x => x.ActiveInd);
                Map(x => x.CreatedBy);
                Map(x => x.LastModifiedBy);
                Map(x => x.CreatedDt);
                Map(x => x.LastModifiedDt);
            }
        }

        public class ServiceMap : ClassMap<Service>
        {
            public ServiceMap()
            {
                Table("tblREFService");
                Id(x => x.ServiceCd);
                Map(x => x.ServiceDesc).Column("Service");
            }
        }

        public class SkillMap : ClassMap<Skill>
        {
            public SkillMap()
            {
                Table("tblREFReligion");
                Id(x => x.SkillCd);
                Map(x => x.SkillDescription).Column("Skill");
                Map(x => x.ActiveInd);
                Map(x => x.CreatedBy);
                Map(x => x.LastModifiedBy);
                Map(x => x.CreatedDt);
                Map(x => x.LastModifiedDt);
            }
        }

        public class SkillCatMap : ClassMap<SkillCat>
        {
            public SkillCatMap()
            {
                Table("tblREFSkillCat");
                Id(x => x.SkillCatCd);
                Map(x => x.SkillCatDesc).Column("Skill");
            }
        }

        public class ApplicantSportMap : ClassMap<ApplicantSport>
        {
            public ApplicantSportMap()
            {
                Table("tblREFSportAndAssociation");
                Id(x => x.ApplicantSportAssocId);
                Map(x => x.SportAssocId);
                Map(x => x.AchievementCd);
                Map(x => x.CreatedBy);
                Map(x => x.LastModifiedBy);
                Map(x => x.CreatedDt);
                Map(x => x.LastModifiedDt);
            }
        }

        public class StateMap : ClassMap<State>
        {
            public StateMap()
            {
                Table("tblREFState");
                Id(x => x.StateCd);
                Map(x => x.StateDesc).Column("State");
            }
        }

        public class LoginStatusMap : ClassMap<LoginStatus>
        {
            public LoginStatusMap()
            {
                Table("tblREFLoginStatus");
                Id(x => x.LoginStatusCd);
                Map(x => x.LoginStatusNm);
            }
        }


        public class SubjectnMap : ClassMap<Subject>
        {
            public SubjectnMap()
            {
                Table("tblREFSubject");
                Id(x => x.SubjectCd);
                Map(x => x.SubjectDescription).Column("Subject");
                Map(x => x.ActiveInd);
                Map(x => x.CreatedBy);
                Map(x => x.LastModifiedBy);
                Map(x => x.CreatedDt);
                Map(x => x.LastModifiedDt);
            }
        }

        public class SubjectGradenMap : ClassMap<SubjectGrade>
        {
            public SubjectGradenMap()
            {
                Table("tblREFSubjectGrade");
                Id(x => x.GradeCd);
                Map(x => x.GradeDescription).Column("Grade");
                Map(x => x.Ranking);
                Map(x => x.ActiveInd);
                Map(x => x.CreatedBy);
                Map(x => x.LastModifiedBy);
                Map(x => x.CreatedDt);
                Map(x => x.LastModifiedDt);
            }
        }

        public class LoginUserMap : ClassMap<LoginUser>
        {
            public LoginUserMap()
            {
                Table("tblUser");
                Id(x => x.LoginId).Column("UserId");
                Map(x => x.UserName);
                Map(x => x.UserPassword);
                Map(x => x.Email);
                Map(x => x.AlternativeEmail);
                Map(x => x.ServiceCd);
                Map(x => x.CreatedBy);
                Map(x => x.CreatedDt);
                Map(x => x.ModifiedBy);
                Map(x => x.ModifiedDt);
            }
        }

      


    }
}

