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
    
    public partial class tblREFInstitutionCat
    {
        public tblREFInstitutionCat()
        {
            this.tblREFInstitutions = new HashSet<tblREFInstitution>();
        }
    
        public string InstCatCd { get; set; }
        public string InstCat { get; set; }
    
        public virtual ICollection<tblREFInstitution> tblREFInstitutions { get; set; }
    }
}