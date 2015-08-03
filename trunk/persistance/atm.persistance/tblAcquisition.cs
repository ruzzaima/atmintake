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
    
    public partial class tblAcquisition
    {
        public tblAcquisition()
        {
            this.tblAcqAnnouncements = new HashSet<tblAcqAnnouncement>();
            this.tblAcqCriterias = new HashSet<tblAcqCriteria>();
            this.tblAcqEducationCriterias = new HashSet<tblAcqEducationCriteria>();
            this.tblAcqLocations = new HashSet<tblAcqLocation>();
            this.tblAcqMerits = new HashSet<tblAcqMerit>();
            this.tblAcqQuestionnaires = new HashSet<tblAcqQuestionnaire>();
            this.tblAdvertisments = new HashSet<tblAdvertisment>();
            this.tblAppApplicantMeritScores = new HashSet<tblAppApplicantMeritScore>();
            this.tblApplications = new HashSet<tblApplication>();
        }
    
        public int AcquisitionId { get; set; }
        public Nullable<int> AcquisitionTypeCd { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<int> Siri { get; set; }
        public Nullable<System.DateTime> ClosingDate { get; set; }
        public Nullable<int> Target { get; set; }
        public Nullable<bool> NewStatus { get; set; }
        public string NewStatusBy { get; set; }
        public Nullable<bool> OpenStatus { get; set; }
        public string OpenStatusBy { get; set; }
        public Nullable<bool> CloseStatus { get; set; }
        public string CloseStatusBy { get; set; }
        public Nullable<bool> InviteFirstSelStatus { get; set; }
        public string InviteFirstSelStatusBy { get; set; }
        public Nullable<bool> SecurityCheckStatus { get; set; }
        public string SecurityCheckStatusBy { get; set; }
        public Nullable<bool> DocumentStatus { get; set; }
        public string DocumentStatusBy { get; set; }
        public Nullable<bool> FirstSelectionStatus { get; set; }
        public string FirstSelectionStatusBy { get; set; }
        public Nullable<bool> InviteFinalSelStatus { get; set; }
        public string InviteFinalSelStatusBy { get; set; }
        public Nullable<bool> WrittenTestStatus { get; set; }
        public string WrittenTestStatusBy { get; set; }
        public Nullable<bool> FinalSelStatus { get; set; }
        public string FinalSelStatusBy { get; set; }
        public Nullable<bool> AssignNoTenteraStatus { get; set; }
        public string AssignNoTenteraStatusBy { get; set; }
        public Nullable<bool> CompleteStatus { get; set; }
        public string CompleteStatusBy { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDt { get; set; }
        public string LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedDt { get; set; }
        public Nullable<bool> InviteFirstSelNominated { get; set; }
        public string InviteFirstSelNominatedBy { get; set; }
        public Nullable<bool> PhysicalHealthStatus { get; set; }
        public string PhysicalHealthStatusBy { get; set; }
        public Nullable<bool> ToFinalSelNominated { get; set; }
        public string ToFinalSelNominatedBy { get; set; }
        public Nullable<bool> FirstSelShortlisProcessInd { get; set; }
        public Nullable<bool> FinalSelShortlisProcessInd { get; set; }
        public Nullable<bool> ShortlistMeritInd { get; set; }
        public Nullable<int> ArmyNumberFrom { get; set; }
        public Nullable<int> ArmyNumberTo { get; set; }
    
        public virtual ICollection<tblAcqAnnouncement> tblAcqAnnouncements { get; set; }
        public virtual ICollection<tblAcqCriteria> tblAcqCriterias { get; set; }
        public virtual ICollection<tblAcqEducationCriteria> tblAcqEducationCriterias { get; set; }
        public virtual ICollection<tblAcqLocation> tblAcqLocations { get; set; }
        public virtual ICollection<tblAcqMerit> tblAcqMerits { get; set; }
        public virtual ICollection<tblAcqQuestionnaire> tblAcqQuestionnaires { get; set; }
        public virtual tblAcqFinalShorlistCriteria tblAcqFinalShorlistCriteria { get; set; }
        public virtual ICollection<tblAdvertisment> tblAdvertisments { get; set; }
        public virtual ICollection<tblAppApplicantMeritScore> tblAppApplicantMeritScores { get; set; }
        public virtual ICollection<tblApplication> tblApplications { get; set; }
    }
}