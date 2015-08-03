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
    
    public partial class tblRefLocation
    {
        public tblRefLocation()
        {
            this.tblAcqLocations = new HashSet<tblAcqLocation>();
        }
    
        public int LocationId { get; set; }
        public string LocationNm { get; set; }
        public string CityCd { get; set; }
        public string StateCd { get; set; }
        public string ZoneCd { get; set; }
        public Nullable<bool> ActiveInd { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDt { get; set; }
        public string LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedDt { get; set; }
    
        public virtual ICollection<tblAcqLocation> tblAcqLocations { get; set; }
        public virtual tblREFCity tblREFCity { get; set; }
        public virtual tblREFState tblREFState { get; set; }
    }
}
