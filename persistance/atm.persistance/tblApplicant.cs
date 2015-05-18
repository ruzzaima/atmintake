//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SevenH.MMCSB.Atm.Persistance
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblApplicant
    {
        public tblApplicant()
        {
            this.tblApplicantDispStatus = new HashSet<tblApplicantDispStatu>();
            this.tblApplicantEdus = new HashSet<tblApplicantEdu>();
            this.tblApplicantSkills = new HashSet<tblApplicantSkill>();
            this.tblApplicantSportAssocs = new HashSet<tblApplicantSportAssoc>();
            this.tblApplications = new HashSet<tblApplication>();
            this.tblUsers = new HashSet<tblUser>();
        }
    
        public int ApplicantId { get; set; }
        public string NewICNo { get; set; }
        public string NoTentera { get; set; }
        public System.DateTime BirthDt { get; set; }
        public string FullName { get; set; }
        public string MrtlStatusCd { get; set; }
        public string GenderCd { get; set; }
        public Nullable<decimal> Height { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public decimal BMI { get; set; }
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
        public Nullable<bool> SpectaclesUserInd { get; set; }
        public Nullable<bool> ColorBlindInd { get; set; }
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
        public Nullable<int> ChildNo { get; set; }
        public Nullable<int> NoOfSibling { get; set; }
        public string MomName { get; set; }
        public string MomICNo { get; set; }
        public string MomNationalityCd { get; set; }
        public string MomOccupation { get; set; }
        public Nullable<decimal> MomSalary { get; set; }
        public string DadName { get; set; }
        public string DadICNo { get; set; }
        public string DadNationalityCd { get; set; }
        public string DadOccupation { get; set; }
        public Nullable<decimal> DadSalary { get; set; }
        public string GuardianName { get; set; }
        public string GuardianICNo { get; set; }
        public string GuardianNationalityCd { get; set; }
        public string GuardianOccupation { get; set; }
        public Nullable<decimal> GuardianSalary { get; set; }
        public string FamilyHighestEduLevel { get; set; }
        public byte[] Photo { get; set; }
        public string CurrentOccupation { get; set; }
        public string CurrentOrganisation { get; set; }
        public Nullable<decimal> CurrentSalary { get; set; }
        public Nullable<bool> PalapesInd { get; set; }
        public Nullable<int> PalapesYear { get; set; }
        public string PalapesArmyNo { get; set; }
        public string PalapesInstitution { get; set; }
        public Nullable<System.DateTime> PalapesTauliahEndDt { get; set; }
        public string PalapesRemark { get; set; }
        public Nullable<bool> ScholarshipInd { get; set; }
        public string ScholarshipBody { get; set; }
        public string ScholarshipBodyAddr { get; set; }
        public string ScholarshipNoOfYrContract { get; set; }
        public Nullable<System.DateTime> ScholarshipContractStDate { get; set; }
        public Nullable<bool> ArmySelectionInd { get; set; }
        public Nullable<System.DateTime> ArmySelectionDt { get; set; }
        public string ArmySelectionVenue { get; set; }
        public Nullable<bool> ArmyServiceInd { get; set; }
        public string ArmyServiceYrOfServ { get; set; }
        public string ArmyServiceResignRemark { get; set; }
        public Nullable<int> SelectionTD { get; set; }
        public Nullable<int> SelectionTL { get; set; }
        public Nullable<int> SelectionTU { get; set; }
        public Nullable<bool> ComputerMSWord { get; set; }
        public Nullable<bool> ComputerMSExcel { get; set; }
        public Nullable<bool> ComputerMSPwrPoint { get; set; }
        public Nullable<bool> ComputerICT { get; set; }
        public string ComputerOthers { get; set; }
        public Nullable<bool> CrimeInvolvement { get; set; }
        public Nullable<bool> DrugCaseInvolvement { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDt { get; set; }
        public string LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedDt { get; set; }
    
        public virtual tblRefBloodType tblRefBloodType { get; set; }
        public virtual tblREFCity tblREFCity { get; set; }
        public virtual tblREFCountry tblREFCountry { get; set; }
        public virtual tblREFCountry tblREFCountry1 { get; set; }
        public virtual tblREFCountry tblREFCountry2 { get; set; }
        public virtual tblREFCountry tblREFCountry3 { get; set; }
        public virtual tblREFEthnic tblREFEthnic { get; set; }
        public virtual tblREFGender tblREFGender { get; set; }
        public virtual tblREFMaritalStatu tblREFMaritalStatu { get; set; }
        public virtual tblREFRace tblREFRace { get; set; }
        public virtual tblREFReligion tblREFReligion { get; set; }
        public virtual tblREFState tblREFState { get; set; }
        public virtual ICollection<tblApplicantDispStatu> tblApplicantDispStatus { get; set; }
        public virtual ICollection<tblApplicantEdu> tblApplicantEdus { get; set; }
        public virtual ICollection<tblApplicantSkill> tblApplicantSkills { get; set; }
        public virtual ICollection<tblApplicantSportAssoc> tblApplicantSportAssocs { get; set; }
        public virtual ICollection<tblApplication> tblApplications { get; set; }
        public virtual ICollection<tblUser> tblUsers { get; set; }
    }
}
