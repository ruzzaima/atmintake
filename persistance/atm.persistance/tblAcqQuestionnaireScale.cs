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
    
    public partial class tblAcqQuestionnaireScale
    {
        public tblAcqQuestionnaireScale()
        {
            this.tblAppQuestionFeedbacks = new HashSet<tblAppQuestionFeedback>();
        }
    
        public int QuestionnaireScaleId { get; set; }
        public Nullable<int> QuestionnaireId { get; set; }
        public Nullable<int> Scale { get; set; }
        public string ScaleRemark { get; set; }
        public Nullable<int> MeritMark { get; set; }
    
        public virtual tblAcqQuestionnaire tblAcqQuestionnaire { get; set; }
        public virtual ICollection<tblAppQuestionFeedback> tblAppQuestionFeedbacks { get; set; }
    }
}
