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
    
    public partial class tblAcqLocation
    {
        public tblAcqLocation()
        {
            this.tblApplications = new HashSet<tblApplication>();
            this.tblApplications1 = new HashSet<tblApplication>();
        }
    
        public int AcqLocationId { get; set; }
        public Nullable<int> AcquisitionId { get; set; }
        public string ZoneCd { get; set; }
        public Nullable<int> LocationId { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDt { get; set; }
        public string LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedDt { get; set; }
    
        public virtual tblAcquisition tblAcquisition { get; set; }
        public virtual tblRefLocation tblRefLocation { get; set; }
        public virtual tblREFLocationZone tblREFLocationZone { get; set; }
        public virtual ICollection<tblApplication> tblApplications { get; set; }
        public virtual ICollection<tblApplication> tblApplications1 { get; set; }
    }
}
