using System;
using System.Collections.Generic;
using NHibernate.Mapping;
using SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Atm.Web.Models
{
    public class ApplicantModel
    {
        public ApplicantModel()
        {

        }

        public ApplicantModel(Applicant app)
        {
            ApplicantId = app.ApplicantId;
            NewIcNo = app.NewICNo;
            NoTentera = app.NoTentera;
            FullName = app.FullName;
            MrtlStatusCd = app.MrtlStatusCd;
            GenderCd = app.GenderCd;
            Height = app.Height;
            Weight = app.Weight;
            Bmi = app.BMI;
            NationalityCd = app.NationalityCd;
            NationalityCertNo = app.NationalityCertNo;
            BirthCertNo = app.BirthCertNo;
            ReligionCd = app.ReligionCd;
            RaceCd = app.RaceCd;
            EthnicCd = app.EthnicCd;
            BirthCountryCd = app.BirthCountryCd;
            BirthStateCd = app.BirthStateCd;
            BirthCityCd = app.BirthCityCd;
            BirthPlace = app.BirthPlace;
            BloodTypeCd = app.BloodTypeCd;
            SpectaclesUserInd = app.SpectaclesUserInd;
            ColorBlindInd = app.ColorBlindInd;
            ResidenceTypeInd = app.ResidenceTypeInd;
            CorresponAddr1 = app.CorresponAddr1;
            CorresponAddr2 = app.CorresponAddr2;
            CorresponAddr3 = app.CorresponAddr3;
            CorresponAddrPostCd = app.CorresponAddrPostCd;
            CorresponAddrCityCd = app.CorresponAddrCityCd;
            CorresponAddrStateCd = app.CorresponAddrStateCd;
            CorresponAddrCountryCd = app.CorresponAddrCountryCd;
            MobilePhoneNo = app.MobilePhoneNo;
            HomePhoneNo = app.HomePhoneNo;
            Email = app.Email;
            ChildNo = app.ChildNo;
            NoOfSibling = app.NoOfSibling;
            MomName = app.MomName;
            MomIcNo = app.MomICNo;
            MomNationalityCd = app.MomNationalityCd;
            MomOccupation = app.MomOccupation;
            MomSalary = app.MomSalary;
            DadName = app.DadName;
            DadIcNo = app.DadICNo;
            DadNationalityCd = app.DadNationalityCd;
            DadOccupation = app.DadOccupation;
            DadSalary = app.DadSalary;
            GuardianName = app.GuardianName;
            GuardianIcNo = app.GuardianICNo;
            GuardianNationalityCd = app.GuardianNationalityCd;
            GuardianOccupation = app.GuardianOccupation;
            GuardianSalary = app.GuardianSalary;
            FamilyHighestEduLevel = app.FamilyHighestEduLevel;
            Photo = app.Photo;
            CurrentOccupation = app.CurrentOccupation;
            CurrentOrganisation = app.CurrentOrganisation;
            CurrentSalary = app.CurrentSalary;
            PalapesInd = app.PalapesInd;
            PalapesYear = app.PalapesYear;
            PalapesArmyNo = app.PalapesArmyNo;
            PalapesInstitution = app.PalapesInstitution;
            PalapesRemark = app.PalapesRemark;
            ScholarshipInd = app.ScholarshipInd;
            ScholarshipBody = app.ScholarshipBody;
            ScholarshipBodyAddr = app.ScholarshipBodyAddr;
            ScholarshipNoOfYrContract = app.ScholarshipNoOfYrContract;
            ArmySelectionInd = app.ArmySelectionInd;
            ArmySelectionVenue = app.ArmySelectionVenue;
            ArmyServiceInd = app.ArmyServiceInd;
            ArmyServiceYrOfServ = app.ArmyServiceYrOfServ;
            ArmyServiceResignRemark = app.ArmyServiceResignRemark;
            SelectionTd = app.SelectionTD;
            SelectionTl = app.SelectionTL;
            SelectionTu = app.SelectionTU;
            ComputerMsWord = app.ComputerMSWord;
            ComputerMsExcel = app.ComputerMSExcel;
            ComputerMsPwrPoint = app.ComputerMSPwrPoint;
            ComputerIct = app.ComputerICT;
            ComputerOthers = app.ComputerOthers;
            CrimeInvolvement = app.CrimeInvolvement;
            DrugCaseInvolvement = app.DrugCaseInvolvement;
            CreatedBy = app.CreatedBy;
            LastModifiedBy = app.LastModifiedBy;
            CreatedDateTime = app.CreatedDt;
            LastModifiedDatetTime = app.LastModifiedDt;
            BirthDate = app.BirthDt;
        }

        public int ApplicantId { get; set; }
        public string NewIcNo { get; set; }
        public string NoTentera { get; set; }
        public string FullName { get; set; }
        public string MrtlStatusCd { get; set; }
        public string GenderCd { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public decimal Bmi { get; set; }
        public string NationalityCd { get; set; }
        public string NationalityCertNo { get; set; }
        public string BirthCertNo { get; set; }
        public string ReligionCd { get; set; }
        public string RaceCd { get; set; }
        public string EthnicCd { get; set; }
        public string BirthCountryCd { get; set; }
        public string BirthStateCd { get; set; }
        public string BirthCityCd { get; set; }
        public string BirthPlace { get; set; }
        public string BloodTypeCd { get; set; }
        public bool SpectaclesUserInd { get; set; }
        public bool ColorBlindInd { get; set; }
        public string ResidenceTypeInd { get; set; }
        public string CorresponAddr1 { get; set; }
        public string CorresponAddr2 { get; set; }
        public string CorresponAddr3 { get; set; }
        public string CorresponAddrPostCd { get; set; }
        public string CorresponAddrCityCd { get; set; }
        public string CorresponAddrStateCd { get; set; }
        public string CorresponAddrCountryCd { get; set; }
        public string MobilePhoneNo { get; set; }
        public string HomePhoneNo { get; set; }
        public string Email { get; set; }
        public int ChildNo { get; set; }
        public int NoOfSibling { get; set; }
        public string MomName { get; set; }
        public string MomIcNo { get; set; }
        public string MomNationalityCd { get; set; }
        public string MomOccupation { get; set; }
        public decimal MomSalary { get; set; }
        public string DadName { get; set; }
        public string DadIcNo { get; set; }
        public string DadNationalityCd { get; set; }
        public string DadOccupation { get; set; }
        public decimal DadSalary { get; set; }
        public string GuardianName { get; set; }
        public string GuardianIcNo { get; set; }
        public string GuardianNationalityCd { get; set; }
        public string GuardianOccupation { get; set; }
        public decimal GuardianSalary { get; set; }
        public string FamilyHighestEduLevel { get; set; }
        public byte[] Photo { get; set; }
        public string CurrentOccupation { get; set; }
        public string CurrentOrganisation { get; set; }
        public decimal CurrentSalary { get; set; }
        public bool PalapesInd { get; set; }
        public int PalapesYear { get; set; }
        public string PalapesArmyNo { get; set; }
        public string PalapesInstitution { get; set; }
        public string PalapesRemark { get; set; }
        public bool ScholarshipInd { get; set; }
        public string ScholarshipBody { get; set; }
        public string ScholarshipBodyAddr { get; set; }
        public string ScholarshipNoOfYrContract { get; set; }
        public bool ArmySelectionInd { get; set; }
        public string ArmySelectionVenue { get; set; }
        public bool ArmyServiceInd { get; set; }
        public string ArmyServiceYrOfServ { get; set; }
        public string ArmyServiceResignRemark { get; set; }
        public int SelectionTd { get; set; }
        public int SelectionTl { get; set; }
        public int SelectionTu { get; set; }
        public bool ComputerMsWord { get; set; }
        public bool ComputerMsExcel { get; set; }
        public bool ComputerMsPwrPoint { get; set; }
        public bool ComputerIct { get; set; }
        public string ComputerOthers { get; set; }
        public bool CrimeInvolvement { get; set; }
        public bool DrugCaseInvolvement { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public DateTime? LastModifiedDatetTime { get; set; }
        public DateTime? BirthDate { get; set; }

        private List<ApplicantEducation> m_applicantEducationCollection = new List<ApplicantEducation>();

        public List<ApplicantEducation> ApplicantEducations
        {
            get { return m_applicantEducationCollection; }
            set { m_applicantEducationCollection = value; }
        }

        
    }
}