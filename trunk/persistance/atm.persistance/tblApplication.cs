//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SevenH.MMCSB.Atm.Entity.Persistance
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblApplication
    {
        public tblApplication()
        {
            this.tblAppApplicantDentalExaminations = new HashSet<tblAppApplicantDentalExamination>();
            this.tblAppApplicantMeritScores = new HashSet<tblAppApplicantMeritScore>();
            this.tblAppApplicantPhysicalExaminations = new HashSet<tblAppApplicantPhysicalExamination>();
            this.tblAppApplicantPhysicalTests = new HashSet<tblAppApplicantPhysicalTest>();
            this.tblAppDocumentStatus = new HashSet<tblAppDocumentStatu>();
            this.tblAppQuestionFeedbacks = new HashSet<tblAppQuestionFeedback>();
            this.tblAppQuestionnaireScores = new HashSet<tblAppQuestionnaireScore>();
        }
    
        public int AppId { get; set; }
        public Nullable<int> ApplicantId { get; set; }
        public Nullable<int> AcquisitionId { get; set; }
        public Nullable<int> SelectionCenterId { get; set; }
        public Nullable<bool> FirstSelectionInd { get; set; }
        public Nullable<bool> FinalSelectionInd { get; set; }
        public Nullable<bool> ApplicationStatus { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDt { get; set; }
        public string LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedDt { get; set; }
        public Nullable<int> SelectedAcqLocationId { get; set; }
        public Nullable<bool> InvitationFirstSel { get; set; }
        public Nullable<bool> FirstSelectionAttdnInd { get; set; }
        public Nullable<int> FirstSelActualAcqLocationId { get; set; }
        public Nullable<System.DateTime> FirstSelectionDate { get; set; }
        public Nullable<bool> WrittenTest { get; set; }
        public Nullable<bool> SecurityStatus { get; set; }
        public Nullable<bool> SecurityPDRM { get; set; }
        public string SecurityPDRMRemark { get; set; }
        public Nullable<bool> SecurityAADK { get; set; }
        public string SecurityAADKRemark { get; set; }
        public Nullable<bool> SecurityJPN { get; set; }
        public string SecurityJPNRemark { get; set; }
        public Nullable<bool> SecurityKPM { get; set; }
        public string SecurityKPMRemark { get; set; }
        public Nullable<bool> SecurityBSPP { get; set; }
        public string SecurityBSPPRemark { get; set; }
        public Nullable<bool> PhysicalExamination { get; set; }
        public Nullable<bool> MedicalExamine { get; set; }
        public Nullable<bool> DentalExamine { get; set; }
        public Nullable<bool> SuppDocumentReview { get; set; }
        public Nullable<bool> PhysicalTest { get; set; }
        public string FinalSelectionRemark { get; set; }
        public Nullable<int> ReportDuty { get; set; }
        public Nullable<bool> Urine { get; set; }
        public Nullable<int> FirstShortlistedInd { get; set; }
        public Nullable<int> FinalShortlistedInd { get; set; }
        public Nullable<int> Panel1Score { get; set; }
        public Nullable<int> Panel2Score { get; set; }
        public Nullable<int> Panel3Score { get; set; }
        public string ArmyNo { get; set; }
        public Nullable<int> FinalSelActualAcqLocationId { get; set; }
        public Nullable<System.DateTime> FinalSelectionStartDate { get; set; }
        public Nullable<System.DateTime> FinalSelectionEndDate { get; set; }
        public Nullable<System.DateTime> ReportDutyDate { get; set; }
        public Nullable<int> ReportDutyLocId { get; set; }
    
        public virtual tblAcqLocation tblAcqLocation { get; set; }
        public virtual tblAcqLocation tblAcqLocation1 { get; set; }
        public virtual ICollection<tblAppApplicantDentalExamination> tblAppApplicantDentalExaminations { get; set; }
        public virtual ICollection<tblAppApplicantMeritScore> tblAppApplicantMeritScores { get; set; }
        public virtual ICollection<tblAppApplicantPhysicalExamination> tblAppApplicantPhysicalExaminations { get; set; }
        public virtual ICollection<tblAppApplicantPhysicalTest> tblAppApplicantPhysicalTests { get; set; }
        public virtual ICollection<tblAppDocumentStatu> tblAppDocumentStatus { get; set; }
        public virtual tblApplicationStatu tblApplicationStatu { get; set; }
        public virtual ICollection<tblAppQuestionFeedback> tblAppQuestionFeedbacks { get; set; }
        public virtual ICollection<tblAppQuestionnaireScore> tblAppQuestionnaireScores { get; set; }
        public virtual tblAcquisition tblAcquisition { get; set; }
        public virtual tblREFReportDutyLoc tblREFReportDutyLoc { get; set; }
    }
}
