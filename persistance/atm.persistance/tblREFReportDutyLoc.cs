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
    
    public partial class tblREFReportDutyLoc
    {
        public tblREFReportDutyLoc()
        {
            this.tblApplications = new HashSet<tblApplication>();
        }
    
        public int ReportDutyLocId { get; set; }
        public string ReportDutyLoc { get; set; }
        public Nullable<int> BUID { get; set; }
    
        public virtual ICollection<tblApplication> tblApplications { get; set; }
    }
}