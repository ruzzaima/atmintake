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
    
    public partial class tblREFExistingMemberStatu
    {
        public tblREFExistingMemberStatu()
        {
            this.tblExistingAtmMembers = new HashSet<tblExistingAtmMember>();
        }
    
        public string ExistingMemberStatusCD { get; set; }
        public string ExistingMemberStatus { get; set; }
    
        public virtual ICollection<tblExistingAtmMember> tblExistingAtmMembers { get; set; }
    }
}