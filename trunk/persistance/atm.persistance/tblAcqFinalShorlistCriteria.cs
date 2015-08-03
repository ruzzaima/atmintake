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
    
    public partial class tblAcqFinalShorlistCriteria
    {
        public Nullable<int> AcqFinalShortlistCriteriaId { get; set; }
        public int AcquisitionId { get; set; }
        public string GenderValue { get; set; }
        public string MaritalStatusValue { get; set; }
        public Nullable<bool> PassPhysicalExamination { get; set; }
        public Nullable<bool> PassMedicalExamine { get; set; }
        public Nullable<bool> PassPhysicalTest { get; set; }
        public Nullable<bool> PassDentalExamine { get; set; }
        public Nullable<bool> PassEducationCriteria { get; set; }
        public Nullable<bool> PassSuppDocumentReview { get; set; }
        public Nullable<bool> PassSecurityCheck { get; set; }
        public string MaleRun { get; set; }
        public string FemaleRun { get; set; }
        public string MaleBroadJump { get; set; }
        public string FemaleBroadJump { get; set; }
        public string MaleMendagu { get; set; }
        public string FemaleMendagu { get; set; }
        public string MaleJump { get; set; }
        public string FemaleJump { get; set; }
        public string MaleSitUp { get; set; }
        public string FemaleSitUp { get; set; }
        public string MalePushUp { get; set; }
        public string FemalePushUp { get; set; }
        public string CTKProfiling { get; set; }
        public string TDIQTest { get; set; }
        public string TDPsychologyTest { get; set; }
        public string TLSKMTest { get; set; }
        public string TUResilienceTest { get; set; }
        public Nullable<bool> TUPsikotismeTest { get; set; }
        public Nullable<bool> TUNeurotismeTest { get; set; }
        public Nullable<bool> TUEkstrovertTest { get; set; }
        public Nullable<bool> TUELieTest { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDt { get; set; }
        public string LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedDt { get; set; }
    
        public virtual tblAcquisition tblAcquisition { get; set; }
    }
}