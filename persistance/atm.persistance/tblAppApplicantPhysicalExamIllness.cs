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
    
    public partial class tblAppApplicantPhysicalExamIllness
    {
        public int AppApplicantPhysicalExamIllnessId { get; set; }
        public Nullable<int> AppApplicantPhysicalId { get; set; }
        public string MedDiseaseCd { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDt { get; set; }
        public string LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedDt { get; set; }
    
        public virtual tblAppApplicantPhysicalExamination tblAppApplicantPhysicalExamination { get; set; }
        public virtual tblREFMedDisease tblREFMedDisease { get; set; }
    }
}
