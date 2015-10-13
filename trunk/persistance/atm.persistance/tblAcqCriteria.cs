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
    
    public partial class tblAcqCriteria
    {
        public int AcqCriteriaId { get; set; }
        public Nullable<int> AcquisitionId { get; set; }
        public Nullable<decimal> TDHeightM { get; set; }
        public Nullable<decimal> TDWeightM { get; set; }
        public Nullable<decimal> TDHeightF { get; set; }
        public Nullable<decimal> TDWeightF { get; set; }
        public Nullable<decimal> TLHeightM { get; set; }
        public Nullable<decimal> TLWeightM { get; set; }
        public Nullable<decimal> TLHeightF { get; set; }
        public Nullable<decimal> TLWeightF { get; set; }
        public Nullable<decimal> TUHeightM { get; set; }
        public Nullable<decimal> TUWeightM { get; set; }
        public Nullable<decimal> TUHeightF { get; set; }
        public Nullable<decimal> TUWeightF { get; set; }
        public Nullable<decimal> MaleBMIFrom { get; set; }
        public Nullable<decimal> MaleBMITo { get; set; }
        public Nullable<decimal> FemaleBMIFrom { get; set; }
        public Nullable<decimal> FemaleBMITo { get; set; }
        public Nullable<int> AgeMinimum { get; set; }
        public Nullable<int> AgeMaximum { get; set; }
        public Nullable<System.DateTime> AgeAt { get; set; }
        public Nullable<decimal> MaleChestMinimum { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDt { get; set; }
        public string LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedDt { get; set; }
    
        public virtual tblAcquisition tblAcquisition { get; set; }
    }
}