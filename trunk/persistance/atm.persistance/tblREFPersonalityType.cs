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
    
    public partial class tblREFPersonalityType
    {
        public tblREFPersonalityType()
        {
            this.tblAcqQuestionnaires = new HashSet<tblAcqQuestionnaire>();
        }
    
        public string PersonalityTypeCd { get; set; }
        public string PersonalityType { get; set; }
    
        public virtual ICollection<tblAcqQuestionnaire> tblAcqQuestionnaires { get; set; }
    }
}
