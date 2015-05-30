using System;
using System.Collections.Generic;
using System.Web.Mvc;
using SevenH.MMCSB.Atm.Domain;


namespace SevenH.MMCSB.Atm.Web.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var acq = new Acquisition()
            {
                AcquisitionTypeCd = "1",
                AssignNoTenteraStatus = true,
                Bil = 1,
                CloseStatus = false,
                Year = 2011,
                Siri = 1,
                ClosingDate = DateTime.Today,
                Target = 1,
                NewStatus = true,
                OpenStatus = false,
                OpenStatusBy = "rodin",
                CloseStatusBy = "rodin2",
                InviteFirstSelStatus = true,
                InviteFirstSelStatusBy = "rodin3",
                SecurityCheckStatus = true,
                SecurityCheckStatusBy = "rodin4",
                FirstSelectionStatus = true,
                FirstSelectionStatusBy = "rodin5",
                InviteFinalSelStatus = true,
                InviteFinalSelStatusBy = "rodin6",
                WrittenTestStatus = true,
                WrittenTestStatusBy = "rodin7",
                FinalSelStatus = true,
                FinalSelStatusBy = "rodin8",
                AssignNoTenteraStatusBy = "rodin9",
                CompleteStatus = true,
                CompleteStatusBy = "rodin10",
                CreatedBy = "admin",
                CreatedDt = DateTime.Today,
                LastModifiedBy = "admin",
                LastModifiedDt = DateTime.Today,
            };

            var acqCri = new AcquisitionCriteria()
            {
                TDHeightM = (decimal)1.0,
                TDWeightM = (decimal)1.0,
                TDHeightF = (decimal)1.0,
                TDWeightF = (decimal)1.0,
                TLHeightF = (decimal)1.0,
                TLWeightF = (decimal)1.0,
                TLHeightM = (decimal)1.0,
                TLWeightM = (decimal)1.0,
                TUHeightF = (decimal)1.0,
                TUWeightF = (decimal)1.0,
                TUHeightM = (decimal)1.0,
                TUWeightM = (decimal)1.0,
                MaleBMIFrom = (decimal)1.0,
                MaleBMITo = (decimal)1.0,
                FemaleBMIFrom = (decimal)1.0,
                FemaleBMITo = (decimal)1.0,
                AgeMinimum = 20,
                AgeAt = DateTime.Today,
                MaleChestMinimum = (decimal)1.0,

            };
            acq.AcquisitionCriterias = new List<AcquisitionCriteria>
            {
                acqCri
            };

            var acqEdu = new AcquisitionEducationCriteria()
            {
                HighEduLevelCd = "1",
            };

            acq.AcquisitionEducationCriterias = new List<AcquisitionEducationCriteria>
            {
                acqEdu
            };

            var acqEduSub = new AcquisitionEducationCriteriaSubject()
            {
                SubjectCd = "1",
                Subject = "PILIHLAH",
                MinimumGradeCd = "2",
                Grade = "A",
                MainSubjectInd = true,
            };
            
            acqEdu.AcquisitionEducationCriteriaSubjects = new List<AcquisitionEducationCriteriaSubject>
            {
                acqEduSub,
            };

            var acqField = new AcqEduCriteriaFieldOfStudy()
            {
                MajorMinorCd = "01"
            };

            acqEdu.AcqEduCriteriaFieldOfStudys = new List<AcqEduCriteriaFieldOfStudy>
            {
                acqField,
            };

            // acq.AcquisitionEducationCriterias.Add(acqEdu);

            var res2 = acq.Save();

            

            var app = new Applicant()
            {
                NewICNo="AA11221212",
                NoTentera="AZAZAZAZAZ",
                BirthDt=DateTime.Now,
                FullName="RODIN",
                MrtlStatusCd = "1",
                GenderCd = "L",
                Height=(decimal)5.1,
                Weight = (decimal)5.1,
                BMI = (decimal)5.1,
                NationalityCd = "1",
                NationalityCertNo = "A11222",
                BirthCertNo="VVVVaasa1212",
                ReligionCd = "01",
                RaceCd="01",
                EthnicCd = "0101",
                BirthCityCd = "0101",
                BirthCountryCd = "AFG",
                BirthStateCd = "01",
                BirthPlace="Pahang",
                BloodTypeCd="3",
                SpectaclesUserInd = true,
                ColorBlindInd = true,
                ResidenceTypeInd = "1",
                CorresponAddr1 = "AAAAAAAAAAAAAAAAAAA",
                CorresponAddr2 = "VVVVVVVVVVVVVVVVVVV",
                CorresponAddr3 = "CCCCCCCCCCCCCCCCCCC",
                CorresponAddrCityCd = "0101",
                CorresponAddrCountryCd = "AFG",
                CorresponAddrStateCd = "01",
                CorresponAddrPostCd = "43220",
                MobilePhoneNo = "12121212",
                HomePhoneNo = "9999999999999",
                Email = "rr@aa.com",
                ChildNo = 2,
                NoOfSibling = 3,
                MomName = "zaliah",
                MomICNo = "1111111",
                MomNationalityCd = "AFG",
                MomOccupation = "Doktor",
                MomSalary = 9000,
                DadName = "Radeonnnn",
                DadICNo = "AAA1212121",
                DadNationalityCd = "AFG",
                DadOccupation = "Doktorr asas",
                DadSalary = 10000,
                GuardianICNo = "1111112",
                GuardianName = "AHMAND",
                GuardianNationalityCd = "111",
                GuardianOccupation = "BOSSS",
                GuardianSalary = 87000,
                FamilyHighestEduLevel = "1",
                CurrentOccupation = "Cheer",
                CurrentOrganisation = "PERNAMA",
                CurrentSalary = 5000,
                PalapesInd = true,
                PalapesYear = 2013,
                PalapesArmyNo="ASasa11212",
                PalapesInstitution = "ZAXAXXAXAXAXXXAXAXA",
                PalapesTauliahEndDt = DateTime.Now,
                PalapesRemark = "asasasxacacaccdcdcd",
                ScholarshipInd = true,
                ScholarshipBody = true,
                ScholarshipBodyAddr = "ASASASASASASASAS",
                ScholarshipNoOfYrContract = "3",
                ScholarshipContractStDate = DateTime.Today,
                ArmySelectionInd = true,
                ArmySelectionDt = DateTime.Today,
                ArmySelectionVenue = "KAJANG",
                ArmyServiceInd = true,
                ArmyServiceYrOfServ = "44",
                ArmyServiceResignRemark = "MALAS",
                SelectionTD = 1,
                SelectionTL=2,
                SelectionTU=3,
                ComputerMSWord=true,
                ComputerMSExcel=true,
                ComputerMSPwrPoint=true,
                ComputerICT=true,
                ComputerOthers = "POMEN",
                CrimeInvolvement=true,
                DrugCaseInvolvement=true,
                CreatedBy="admin",
                CreatedDt=DateTime.Today,
                LastModifiedBy="admin",
                LastModifiedDt=DateTime.Today
            };

            var appEdu = new ApplicantEducation()
            {
                HighEduLevelCd = "01",
                EduCertTitle = "Master",
                OverallGrade = "4",
                OverSeaInd=true,
                SKMLevel=1,
                ConfermentYr = 2011,
                InstCd="1",
                InstitutionName="ITM",
                MajorMinorCd="2",
              
            };


            var appeduSub = new ApplicantEduSubject()
            {
                SubjectCd = "01",
                GradeCd = "01",
                Grade = "A",
            };

            appEdu.ApplicantEduSubjects = new List<ApplicantEduSubject>
            {
                appeduSub
            };


            app.ApplicantEducations = new List<ApplicantEducation>
            {
                appEdu
            };

            var appSkil = new ApplicantSkill()
            {
               SkillCd="0001",
               SkillCatCd="H",
               LanguageSkillSpeak = true,
               LanguageSkillWrite = true,
               AchievementCd = "04",
               Others = "ASASASASASAS",
             
            };

            app.ApplicantSkills = new List<ApplicantSkill>
            {
                appSkil
            };


            var appSport = new ApplicantSport()
            {
              SportAssocId = 1,
              AchievementCd = "01",
             
            };

            app.SportAndAssociations = new List<ApplicantSport>
            {
                appSport
            };

            var appLi = new Application()
            {
               SelectionCenterId=1,
              
            };

            var acq2 = new Acquisition().GetAcquisition(9);
            appLi.AcquisitionId = acq2.AcquisitionId;
            app.Applications = new List<Application>
            {
                appLi
            };

            var appDisp = new ApplicantDispStatus()
            {
                Disciplinary = "asasa asasasa",
               
            };

            app.ApplicantDispStatuses = new List<ApplicantDispStatus>
            {
                appDisp
            };

            


            
            var res = app.Save();

            return View();
        }

    }
}