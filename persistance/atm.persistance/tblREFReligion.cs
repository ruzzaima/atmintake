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
    
    public partial class tblREFReligion
    {
        public tblREFReligion()
        {
            this.tblApplicants = new HashSet<tblApplicant>();
        }
    
        public string ReligionCd { get; set; }
        public string Religion { get; set; }
        public Nullable<bool> ActiveInd { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDt { get; set; }
        public string LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedDt { get; set; }
    
        public virtual ICollection<tblApplicant> tblApplicants { get; set; }
    }
}