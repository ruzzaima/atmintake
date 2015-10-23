using FluentNHibernate.Mapping;

namespace SevenH.MMCSB.Atm.Domain
{
    public class CountryMap : ClassMap<Country>
    {
        public CountryMap()
        {
            Table("tblREFCountry");
            Id(x => x.CountryCd).GeneratedBy.Assigned();
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
            Id(x => x.CityCd).GeneratedBy.Assigned();
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
            Id(x => x.BloodTypeCd).GeneratedBy.Assigned();
            Map(x => x.BloodTypeDesc).Column("BloodType");
        }
    }

    public class AcquisitionTypeMap : ClassMap<AcquisitionType>
    {
        public AcquisitionTypeMap()
        {
            Table("tblREFAcqType");
            Id(x => x.AcquisitionTypeCd).GeneratedBy.Assigned();
            Map(x => x.AcquisitionTypeNm);
            Map(x => x.ServiceCd);

            HasOne(x => x.Acquisition).ForeignKey("AcquisitionTypeCd");
        }
    }

    public class AchievementMap : ClassMap<Achievement>
    {
        public AchievementMap()
        {
            Table("tblREFAchievement");
            Id(x => x.AchievementCd).GeneratedBy.Assigned();
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
            Id(x => x.EthnicCd).GeneratedBy.Assigned();
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
            Id(x => x.GenderCd).GeneratedBy.Assigned();
            Map(x => x.GenderDesc).Column("Gender");
        }
    }

    public class HighEduLevelMap : ClassMap<HighEduLevel>
    {
        public HighEduLevelMap()
        {
            Table("tblREFHighEduLevel");
            Id(x => x.HighEduLevelCd).GeneratedBy.Assigned();
            Map(x => x.HighestEduLevel);
            Map(x => x.HighestEduLevelRank);
            Map(x => x.IndexNo);
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
            Id(x => x.InstCd).GeneratedBy.Assigned();
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
            Id(x => x.InstCatCd).GeneratedBy.Assigned();
            Map(x => x.InstCat);
        }
    }

    public class MajorMinorMap : ClassMap<MajorMinor>
    {
        public MajorMinorMap()
        {
            Table("tblREFMajorMinor");
            Id(x => x.MajorMinorCd).GeneratedBy.Assigned();
            Map(x => x.MajorMinorDesc).Column("MajorMinor");
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
            Id(x => x.MrtlStatusCd).GeneratedBy.Assigned();
            Map(x => x.MrtlStatus);
        }
    }

    public class PersonalityTypeMap : ClassMap<PersonalityType>
    {
        public PersonalityTypeMap()
        {
            Table("tblREFPersonalityType");
            Id(x => x.PersonalityTypeCd).GeneratedBy.Assigned();
            Map(x => x.PersonalityTypeDesc).Column("PersonalityType");
        }
    }

    public class QuestionnareTypeMap : ClassMap<QuestionnareType>
    {
        public QuestionnareTypeMap()
        {
            Table("tblREFQuestionnareType");
            Id(x => x.QuestionnaireTypeCd).GeneratedBy.Assigned();
            Map(x => x.QuestionnaireTypeDesc).Column("QuestionnaireType");
        }
    }

    public class RaceMap : ClassMap<Race>
    {
        public RaceMap()
        {
            Table("tblREFRace");
            Id(x => x.RaceCd).GeneratedBy.Assigned();
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
            Id(x => x.ReligionCd).GeneratedBy.Assigned();
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
            Id(x => x.ServiceCd).GeneratedBy.Assigned();
            Map(x => x.ServiceDesc).Column("Service");
        }
    }

    public class SkillMap : ClassMap<Skill>
    {
        public SkillMap()
        {
            Table("tblREFSkill");
            Id(x => x.SkillCd).GeneratedBy.Assigned();
            Map(x => x.SkillDescription).Column("Skill");
            Map(x => x.SkillCategory).Column("SkillCat");
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
            Id(x => x.SkillCatCd).GeneratedBy.Assigned();
            Map(x => x.SkillCatDesc).Column("SkillCat");
        }
    }

    public class SportAndAssociationMap : ClassMap<SportAndAssociation>
    {
        public SportAndAssociationMap()
        {
            Table("tblREFSportAndAssociation");
            Id(x => x.SportAssocId);
            Map(x => x.SportAssociatType);
            Map(x => x.ActiveInd);
            Map(x => x.SportAssociatName);
            Map(x => x.CreatedBy);
            Map(x => x.CreatedDt);
            Map(x => x.LastModifiedBy);
            Map(x => x.LastModifiedDt);

        }
    }

    public class StateMap : ClassMap<State>
    {
        public StateMap()
        {
            Table("tblREFState");
            Id(x => x.StateCd).GeneratedBy.Assigned();
            Map(x => x.StateDesc).Column("State");
            Map(x => x.ICBirthStateCd);
            Map(x => x.CountryCd);
        }
    }

    public class LoginStatusMap : ClassMap<LoginStatus>
    {
        public LoginStatusMap()
        {
            Table("tblREFLoginStatus");
            Id(x => x.LoginStatusCd).GeneratedBy.Assigned();
            Map(x => x.LoginStatusNm);
        }
    }

    public class SubjectnMap : ClassMap<Subject>
    {
        public SubjectnMap()
        {
            Table("tblREFSubject");
            Id(x => x.SubjectCd).GeneratedBy.Assigned();
            Map(x => x.HighEduLevelCd);
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
            Id(x => x.GradeCd).GeneratedBy.Assigned();
            Map(x => x.GradeDescription).Column("Grade");
            Map(x => x.Ranking);
            Map(x => x.ActiveInd);
            Map(x => x.CreatedBy);
            Map(x => x.LastModifiedBy);
            Map(x => x.CreatedDt);
            Map(x => x.LastModifiedDt);
        }
    }

    public class OccupationMap : ClassMap<Occupation>
    {
        public OccupationMap()
        {
            Table("tblREFOccupation");
            Id(x => x.OccupationCd).GeneratedBy.Assigned();
            Map(x => x.OccupationName);
            Map(x => x.CreatedBy);
            Map(x => x.LastModifiedBy);
            Map(x => x.CreatedDt);
            Map(x => x.LastModifiedDt);
        }
    }

    public class ZoneMap : ClassMap<Zone>
    {
        public ZoneMap()
        {
            Table("tblREFLocationZone");
            Id(x => x.ZoneCd).GeneratedBy.Assigned(); ;
            Map(x => x.ZoneNm);
        }
    }

    public class LocationMap : ClassMap<Location>
    {
        public LocationMap()
        {
            Table("tblRefLocation");
            Id(x => x.LocationId).GeneratedBy.Increment();
            Map(x => x.LocationNm);
            Map(x => x.StateCd);
            Map(x => x.CityCd);
            Map(x => x.CreatedBy);
            Map(x => x.CreatedDt);
            Map(x => x.ZoneCd);
            Map(x => x.LastModifiedBy);
            Map(x => x.LastModifiedDt);
            Map(x => x.ActiveInd);

            HasOne(x => x.AcquisitionLocation).ForeignKey();
        }
    }

    public class ExistingMemberStatusMap : ClassMap<ExistingMemberStatus>
    {
        public ExistingMemberStatusMap()
        {
            Table("tblREFExistingMemberStatus");
            Id(x => x.Code).Column("ExistingMemberStatusCd").GeneratedBy.Assigned(); 
            Map(x => x.Status).Column("ExistingMemberStatus");

            HasOne(x => x.ExistingMember).ForeignKey("ExistingMemberStatusCd");
        }
    }
}

