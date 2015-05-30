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

            var acq = new Acquisition().GetAcquisition(9);
            appLi.AcquisitionId = acq.AcquisitionId;
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