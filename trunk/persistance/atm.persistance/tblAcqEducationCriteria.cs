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
    
    public partial class tblAcqEducationCriteria
    {
        public tblAcqEducationCriteria()
        {
            this.tblAcqEducationCriteriaSubjects = new HashSet<tblAcqEducationCriteriaSubject>();
            this.tblAcqEduCriteriaFieldOfStudies = new HashSet<tblAcqEduCriteriaFieldOfStudy>();
        }
    
        public int AcqEduCriteriaId { get; set; }
        public Nullable<int> AcquisitionId { get; set; }
        public string HighEduLevelCd { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDt { get; set; }
        public string LastModifiedBy { get; set; }
        public System.DateTime LastModifiedDt { get; set; }
        public Nullable<bool> MandatoriInd { get; set; }
    
        public virtual ICollection<tblAcqEducationCriteriaSubject> tblAcqEducationCriteriaSubjects { get; set; }
        public virtual ICollection<tblAcqEduCriteriaFieldOfStudy> tblAcqEduCriteriaFieldOfStudies { get; set; }
        public virtual tblAcquisition tblAcquisition { get; set; }
    }
}
