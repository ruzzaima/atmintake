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
    
    public partial class tblREFSubject
    {
        public tblREFSubject()
        {
            this.tblAcqEducationCriteriaSubjects = new HashSet<tblAcqEducationCriteriaSubject>();
            this.tblApplicantEduSubjects = new HashSet<tblApplicantEduSubject>();
        }
    
        public string SubjectCd { get; set; }
        public string Subject { get; set; }
        public Nullable<bool> ActiveInd { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDt { get; set; }
        public string LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedDt { get; set; }
    
        public virtual ICollection<tblAcqEducationCriteriaSubject> tblAcqEducationCriteriaSubjects { get; set; }
        public virtual ICollection<tblApplicantEduSubject> tblApplicantEduSubjects { get; set; }
    }
}
