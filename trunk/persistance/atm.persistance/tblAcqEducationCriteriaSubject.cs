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
    
    public partial class tblAcqEducationCriteriaSubject
    {
        public int AcqEduCriteriaSubjectId { get; set; }
        public Nullable<int> AcqEduCriteriaId { get; set; }
        public string SubjectCd { get; set; }
        public string Subject { get; set; }
        public string MinimumGradeCd { get; set; }
        public string Grade { get; set; }
        public Nullable<bool> MainSubjectInd { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDt { get; set; }
        public string LastModifiedBy { get; set; }
        public System.DateTime LastModifiedDt { get; set; }
    
        public virtual tblAcqEducationCriteria tblAcqEducationCriteria { get; set; }
        public virtual tblREFSubject tblREFSubject { get; set; }
        public virtual tblREFSubjectGrade tblREFSubjectGrade { get; set; }
    }
}
