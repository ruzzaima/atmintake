using FluentNHibernate.Mapping;
using NHibernate.Type;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class ApplicantSubmitted
    {
        public class ApplicantSubmittedMap : ClassMap<ApplicantSubmitted>
        {
            public ApplicantSubmittedMap()
            {
                Table("tblApplicantSubmited");
                Id(x => x.ApplicantId).GeneratedBy.Increment();
                Map(x => x.AcquisitionId);
                Map(x => x.NewICNo);
                Map(x => x.NoTentera);
                Map(x => x.FullName);
                Map(x => x.MrtlStatusCd);
                Map(x => x.GenderCd);
                Map(x => x.Height);
                Map(x => x.Weight);
                Map(x => x.BMI);
                Map(x => x.NationalityCd);
                Map(x => x.NationalityCertNo);
                Map(x => x.BirthCertNo);
                Map(x => x.ReligionCd);
                Map(x => x.RaceCd);
                Map(x => x.EthnicCd);
                Map(x => x.BirthCountryCd);
                Map(x => x.BirthStateCd);
                Map(x => x.BirthCityCd);
                Map(x => x.BirthPlace);
                Map(x => x.BloodTypeCd);
                Map(x => x.SpectaclesUserInd);
                Map(x => x.ColorBlindInd);
                Map(x => x.ResidenceTypeInd);
                Map(x => x.CorresponAddr1);
                Map(x => x.CorresponAddr2);
                Map(x => x.CorresponAddr3);
                Map(x => x.CorresponAddrPostCd);
                Map(x => x.CorresponAddrCityCd);
                Map(x => x.CorresponAddrStateCd);
                Map(x => x.CorresponAddrCountryCd);
                Map(x => x.MobilePhoneNo);
                Map(x => x.HomePhoneNo);
                Map(x => x.Email);
                Map(x => x.ChildNo);
                Map(x => x.NoOfSibling);
                Map(x => x.MomName);
                Map(x => x.MomICNo);
                Map(x => x.MomNationalityCd);
                Map(x => x.MomOccupation);
                Map(x => x.MomSalary);
                Map(x => x.MomPhoneNo);
                Map(x => x.DadName);
                Map(x => x.DadICNo);
                Map(x => x.DadNationalityCd);
                Map(x => x.DadOccupation);
                Map(x => x.DadSalary);
                Map(x => x.DadPhoneNo);
                Map(x => x.GuardianName);
                Map(x => x.GuardianICNo);
                Map(x => x.GuardianNationalityCd);
                Map(x => x.GuardianOccupation);
                Map(x => x.GuardianSalary);
                Map(x => x.GuardianPhoneNo);
                Map(x => x.FamilyHighestEduLevel);
                Map(x => x.CurrentOccupation);
                Map(x => x.CurrentOrganisation);
                Map(x => x.CurrentSalary);
                Map(x => x.PalapesInd);
                Map(x => x.PalapesYear);
                Map(x => x.PalapesArmyNo);
                Map(x => x.PalapesServices);
                Map(x => x.PalapesInstitution);
                Map(x => x.PalapesRemark);
                Map(x => x.ScholarshipInd);
                Map(x => x.ScholarshipBody);
                Map(x => x.ScholarshipBodyAddr);
                Map(x => x.ScholarshipNoOfYrContract);
                Map(x => x.ArmySelectionInd);
                Map(x => x.ArmySelectionVenue);
                Map(x => x.ArmyServiceInd);
                Map(x => x.ArmyServiceYrOfServ);
                Map(x => x.ArmyServiceResignRemark);
                Map(x => x.SelectionTD);
                Map(x => x.SelectionTL);
                Map(x => x.SelectionTU);
                Map(x => x.ComputerMSWord);
                Map(x => x.ComputerMSExcel);
                Map(x => x.ComputerMSPwrPoint);
                Map(x => x.ComputerICT);
                Map(x => x.ComputerOthers);
                Map(x => x.CrimeInvolvement);
                Map(x => x.DrugCaseInvolvement);
                Map(x => x.CreatedBy);
                Map(x => x.LastModifiedBy);
                Map(x => x.BirthDt);
                Map(x => x.PalapesTauliahEndDt);
                Map(x => x.ScholarshipContractStDate);
                Map(x => x.ArmySelectionDt);
                Map(x => x.CreatedDt);
                Map(x => x.LastModifiedDt);
                Map(x => x.CronicIlnessInd);
                Map(x => x.EmployeeAggreeInd);
                Map(x => x.PelepasanDocument);
                Map(x => x.OriginalPelepasanDocument);
            }
        }


        public class ApplicantEducationSubmittedMap : ClassMap<ApplicantEducationSubmitted>
        {
            public ApplicantEducationSubmittedMap()
            {
                Table("tblApplicantEduSubmitted");
                Id(x => x.ApplicantEduId).GeneratedBy.Increment();
                Map(x => x.EduCertTitle);
                Map(x => x.OverallGrade);
                Map(x => x.SKMLevel);
                Map(x => x.ConfermentYr);
                Map(x => x.InstCd);
                Map(x => x.InstitutionName);
                Map(x => x.OverSeaInd);
                Map(x => x.MajorMinorCd);
                Map(x => x.CreatedBy);
                Map(x => x.LastModifiedBy);
                Map(x => x.CreatedDt);
                Map(x => x.LastModifiedDt);
                Map(x => x.HighEduLevelCd).Not.Nullable().UniqueKey("AE_HLCS_AID");
                Map(x => x.ApplicantId).Not.Nullable().UniqueKey("AE_HLCS_AID"); 

            }
        }

        public class ApplicantEducationSubjectSubmittedMap : ClassMap<ApplicantEduSubjectSubmitted>
        {
            public ApplicantEducationSubjectSubmittedMap()
            {
                Table("tblApplicantEduSubjectSubmitted");
                Id(x => x.EduSubjectId).GeneratedBy.Increment();
                Map(x => x.GradeCd);
                Map(x => x.CreatedBy);
                Map(x => x.LastModifiedBy);
                Map(x => x.CreatedDt);
                Map(x => x.LastModifiedDt);
                Map(x => x.SubjectCd).Not.Nullable().UniqueKey("AES_SCS_AESC");
                Map(x => x.ApplicantEduId).Not.Nullable().UniqueKey("AES_SCS_AESC"); 
            }
        }

        public class ApplicantSkillSubmittedMap : ClassMap<ApplicantSkillSubmitted>
        {
            public ApplicantSkillSubmittedMap()
            {
                Table("tblApplicantSkillSubmitted");
                Id(x => x.ApplicantSkillId).GeneratedBy.Increment();
                Map(x => x.SkillCatCd);
                Map(x => x.LanguageSkillSpeak);
                Map(x => x.LanguageSkillWrite);
                Map(x => x.Others);
                Map(x => x.CreatedBy);
                Map(x => x.LastModifiedBy);
                Map(x => x.CreatedDt);
                Map(x => x.LastModifiedDt);
                Map(x => x.SkillCd).Not.Nullable().UniqueKey("AS_SCS_AID");
                Map(x => x.ApplicantId).Not.Nullable().UniqueKey("AS_SCS_AID"); 
            }
        }

        public class ApplicantSportSubmittedMap : ClassMap<ApplicantSportSubmitted>
        {
            public ApplicantSportSubmittedMap()
            {
                Table("tblApplicantSportAssocSubmitted");
                Id(x => x.ApplicantSportAssocId).GeneratedBy.Increment();
                Map(x => x.AchievementCd);
                Map(x => x.CreatedBy);
                Map(x => x.LastModifiedBy);
                Map(x => x.CreatedDt);
                Map(x => x.LastModifiedDt);
                Map(x => x.Others);
                Map(x => x.ApplicantId).Not.Nullable().UniqueKey("UK_SAS_ApplicantId");
                Map(x => x.SportAssocId).Not.Nullable().UniqueKey("UK_SAS_SportAssocId");
            }
        }


        public class ApplicantDispStatusSubmittedMap : ClassMap<ApplicantDispStatusSubmitted>
        {
            public ApplicantDispStatusSubmittedMap()
            {
                Table("tblApplicantDispStatus");
                Id(x => x.ApplicantDispStatusId).GeneratedBy.Increment();
                Map(x => x.Disciplinary);
                Map(x => x.CreatedBy);
                Map(x => x.LastModifiedBy);
                Map(x => x.CreatedDt);
                Map(x => x.LastModifiedDt);
            }
        }
        public class ApplicantSubmittedPhotoMap : ClassMap<ApplicantSubmittedPhoto>
        {
            public ApplicantSubmittedPhotoMap()
            {
                Table("tblApplicantSubmittedPhoto");
                Id(x => x.Id).GeneratedBy.Increment();
                Map(x => x.Photo).CustomType<BinaryBlobType>();
                Map(x => x.PhotoExt);
                Map(x => x.CreatedBy);
                Map(x => x.LastModifiedBy);
                Map(x => x.CreatedDate).Column("CreatedDt");
                Map(x => x.LastModifiedDate).Column("LastModifiedDt");
                Map(x => x.ApplicantId).UniqueKey("APS_APID");
            }
        }
    }
}

