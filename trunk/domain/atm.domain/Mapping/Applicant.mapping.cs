using FluentNHibernate.Mapping;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class Applicant 
    {
        public class ApplicantMap : ClassMap<Applicant>
        {
            public ApplicantMap()
            {
                Table("tblApplicant");
                Id(x => x.ApplicantId).GeneratedBy.Increment();
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
                Map(x => x.DadName);
                Map(x => x.DadICNo);
                Map(x => x.DadNationalityCd);
                Map(x => x.DadOccupation);
                Map(x => x.DadSalary);
                Map(x => x.GuardianName);
                Map(x => x.GuardianICNo);
                Map(x => x.GuardianNationalityCd);
                Map(x => x.GuardianOccupation);
                Map(x => x.GuardianSalary);
                Map(x => x.FamilyHighestEduLevel);
                //Map(x => x.Photo);
                Map(x => x.CurrentOccupation);
                Map(x => x.CurrentOrganisation);
                Map(x => x.CurrentSalary);
                Map(x => x.PalapesInd);
                Map(x => x.PalapesYear);
                Map(x => x.PalapesArmyNo);
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

                HasMany<ApplicantEducation>(x => x.ApplicantEducations).KeyColumn("ApplicantId").Inverse().Cascade.All();
                HasMany<ApplicantSkill>(x => x.ApplicantSkills).KeyColumn("ApplicantId").Inverse().Cascade.All();
                HasMany<ApplicantSport>(x => x.SportAndAssociations).KeyColumn("ApplicantId").Inverse().Cascade.All();
                HasMany<Application>(x => x.Applications).KeyColumn("ApplicantId").Inverse().Cascade.All();
                HasMany<ApplicantDispStatus>(x => x.ApplicantDispStatuses).KeyColumn("ApplicantId").Inverse().Cascade.All();


            }
        }


        public class ApplicantEducationMap : ClassMap<ApplicantEducation>
        {
            public ApplicantEducationMap()
            {
                Table("tblApplicantEdu");
                Id(x => x.ApplicantEduId).GeneratedBy.Increment();
                Map(x => x.HighEduLevelCd);
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

                References(x => x.Parent, "ApplicantId").Cascade.All();
                HasMany<ApplicantEduSubject>(x => x.ApplicantEduSubjects).KeyColumn("ApplicantEduId").Inverse().Cascade.All();


            }
        }

        public class ApplicantEducationSubjectMap : ClassMap<ApplicantEduSubject>
        {
            public ApplicantEducationSubjectMap()
            {
                Table("tblApplicantEduSubject");
                Id(x => x.EduSubjectId).GeneratedBy.Increment();
                Map(x => x.SubjectCd);
                Map(x => x.GradeCd);
                Map(x => x.CreatedBy);
                Map(x => x.LastModifiedBy);
                Map(x => x.CreatedDt);
                Map(x => x.LastModifiedDt);

                References(x => x.Parent, "ApplicantEduId").Cascade.All();
            }
        }



        public class ApplicantSkillMap : ClassMap<ApplicantSkill>
        {
            public ApplicantSkillMap()
            {
                Table("tblApplicantSkill");
                Id(x => x.ApplicantSkillId).GeneratedBy.Increment();
                Map(x => x.SkillCd);
                Map(x => x.SkillCatCd);
                Map(x => x.LanguageSkillSpeak);
                Map(x => x.LanguageSkillWrite);
                Map(x => x.Others);
                Map(x => x.CreatedBy);
                Map(x => x.LastModifiedBy);
                Map(x => x.CreatedDt);
                Map(x => x.LastModifiedDt);

                References(x => x.Parent, "ApplicantId").Cascade.All();
            }
        }

        public class ApplicantSportMap : ClassMap<ApplicantSport>
        {
            public ApplicantSportMap()
            {
                Table("tblApplicantSportAssoc");
                Id(x => x.ApplicantSportAssocId).GeneratedBy.Increment();
                Map(x => x.AchievementCd);
                Map(x => x.CreatedBy);
                Map(x => x.LastModifiedBy);
                Map(x => x.CreatedDt);
                Map(x => x.LastModifiedDt);

                References(x => x.Parent, "ApplicantId").Cascade.All();
            }
        }


        public class ApplicantDispStatusMap : ClassMap<ApplicantDispStatus>
        {
            public ApplicantDispStatusMap()
            {
                Table("tblApplicantDispStatus");
                Id(x => x.ApplicantDispStatusId).GeneratedBy.Increment();
                Map(x => x.Disciplinary);
                Map(x => x.CreatedBy);
                Map(x => x.LastModifiedBy);
                Map(x => x.CreatedDt);
                Map(x => x.LastModifiedDt);

                References(x => x.Parent, "ApplicantId").Cascade.All();
            }
        }

        public class ApplicationMap : ClassMap<Application>
        {
            public ApplicationMap()
            {
                Table("tblApplication");
                Id(x => x.AppId).GeneratedBy.Increment();
                Map(x => x.AcquisitionId);
                Map(x => x.SelectionCenterId);
                Map(x => x.CreatedBy);
                Map(x => x.LastModifiedBy);
                Map(x => x.CreatedDt);
                Map(x => x.LastModifiedDt);
              

                References(x => x.Parent, "ApplicantId").Cascade.All();
            }
        }

       
    }
}

