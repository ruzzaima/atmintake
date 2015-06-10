//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace SevenH.MMCSB.Atm.Persistance
{
    public partial class tblUser
    {
        public tblUser()
        {
            this.tblUserLogs = new HashSet<tblUserLog>();
        }
    
        public int UserId { get; set; }
        public Nullable<int> ApplicantId { get; set; }
        public string LoginId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string AlternativeEmail { get; set; }
        public string ServiceCd { get; set; }
        public string UserPassword { get; set; }
        public Nullable<DateTime> LastLoginDt { get; set; }
        public DateTime CreatedDt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDt { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual tblApplicant tblApplicant { get; set; }
        public virtual tblREFService tblREFService { get; set; }
        public virtual ICollection<tblUserLog> tblUserLogs { get; set; }
    }
}
