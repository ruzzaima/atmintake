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
    
    public partial class tblREFEyeStatu
    {
        public tblREFEyeStatu()
        {
            this.tblAppApplicantPhysicalExaminations = new HashSet<tblAppApplicantPhysicalExamination>();
        }
    
        public string EyeStatusCd { get; set; }
        public string EyeStatus { get; set; }
    
        public virtual ICollection<tblAppApplicantPhysicalExamination> tblAppApplicantPhysicalExaminations { get; set; }
    }
}
