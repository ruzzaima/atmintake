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
    
    public partial class tblREFSubjectGrade
    {
        public tblREFSubjectGrade()
        {
            this.tblAcqEducationCriteriaSubjects = new HashSet<tblAcqEducationCriteriaSubject>();
            this.tblAcqMeritScores = new HashSet<tblAcqMeritScore>();
            this.tblApplicantEduSubjects = new HashSet<tblApplicantEduSubject>();
            this.tblApplicantEduSubjectSubmitteds = new HashSet<tblApplicantEduSubjectSubmitted>();
        }
    
        public string GradeCd { get; set; }
        public string Grade { get; set; }
        public Nullable<int> Ranking { get; set; }
        public Nullable<bool> ActiveInd { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDt { get; set; }
        public string LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedDt { get; set; }
    
        public virtual ICollection<tblAcqEducationCriteriaSubject> tblAcqEducationCriteriaSubjects { get; set; }
        public virtual ICollection<tblAcqMeritScore> tblAcqMeritScores { get; set; }
        public virtual ICollection<tblApplicantEduSubject> tblApplicantEduSubjects { get; set; }
        public virtual ICollection<tblApplicantEduSubjectSubmitted> tblApplicantEduSubjectSubmitteds { get; set; }
    }
}
