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
    
    public partial class tblREFAchievement
    {
        public tblREFAchievement()
        {
            this.tblAcqMeritScores = new HashSet<tblAcqMeritScore>();
            this.tblApplicantSkills = new HashSet<tblApplicantSkill>();
            this.tblApplicantSkillSubmitteds = new HashSet<tblApplicantSkillSubmitted>();
            this.tblApplicantSportAssocs = new HashSet<tblApplicantSportAssoc>();
            this.tblApplicantSportAssocSubmitteds = new HashSet<tblApplicantSportAssocSubmitted>();
        }
    
        public string AchievementCd { get; set; }
        public string Achievement { get; set; }
        public Nullable<bool> ActiveInd { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDt { get; set; }
        public string LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedDt { get; set; }
    
        public virtual ICollection<tblAcqMeritScore> tblAcqMeritScores { get; set; }
        public virtual ICollection<tblApplicantSkill> tblApplicantSkills { get; set; }
        public virtual ICollection<tblApplicantSkillSubmitted> tblApplicantSkillSubmitteds { get; set; }
        public virtual ICollection<tblApplicantSportAssoc> tblApplicantSportAssocs { get; set; }
        public virtual ICollection<tblApplicantSportAssocSubmitted> tblApplicantSportAssocSubmitteds { get; set; }
    }
}