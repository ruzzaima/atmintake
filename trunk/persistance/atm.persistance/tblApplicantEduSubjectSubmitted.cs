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
    
    public partial class tblApplicantEduSubjectSubmitted
    {
        public int EduSubjectId { get; set; }
        public int ApplicantEduId { get; set; }
        public Nullable<int> SubjectCd { get; set; }
        public string GradeCd { get; set; }
        public string Grade { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDt { get; set; }
        public string LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedDt { get; set; }
    
        public virtual tblApplicantEduSubmitted tblApplicantEduSubmitted { get; set; }
        public virtual tblREFSubjectGrade tblREFSubjectGrade { get; set; }
        public virtual tblREFSubject tblREFSubject { get; set; }
    }
}