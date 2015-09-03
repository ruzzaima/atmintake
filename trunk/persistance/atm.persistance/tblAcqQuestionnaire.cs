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
    
    public partial class tblAcqQuestionnaire
    {
        public tblAcqQuestionnaire()
        {
            this.tblAcqQuestions = new HashSet<tblAcqQuestion>();
            this.tblAcqQuestionnaireScales = new HashSet<tblAcqQuestionnaireScale>();
            this.tblAppQuestionnaireScores = new HashSet<tblAppQuestionnaireScore>();
        }
    
        public int QuestionnaireId { get; set; }
        public Nullable<int> AcquisitionId { get; set; }
        public string QuestionnaireTypeCd { get; set; }
        public Nullable<int> Weightage { get; set; }
        public string PersonalityTypeCd { get; set; }
        public Nullable<int> PersonalityAcceptedMarkFrom { get; set; }
        public Nullable<int> PersonalityAcceptedMarkTo { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDt { get; set; }
        public string LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedDt { get; set; }
        public string QuestionnaireSubTypeCd { get; set; }
        public Nullable<int> SequenceNo { get; set; }
    
        public virtual ICollection<tblAcqQuestion> tblAcqQuestions { get; set; }
        public virtual tblREFPersonalityType tblREFPersonalityType { get; set; }
        public virtual tblREFQuestionnaireSubType tblREFQuestionnaireSubType { get; set; }
        public virtual tblREFQuestionnaireType tblREFQuestionnaireType { get; set; }
        public virtual ICollection<tblAcqQuestionnaireScale> tblAcqQuestionnaireScales { get; set; }
        public virtual ICollection<tblAppQuestionnaireScore> tblAppQuestionnaireScores { get; set; }
        public virtual tblAcquisition tblAcquisition { get; set; }
    }
}