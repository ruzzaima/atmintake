using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class Acquisition
    {
        public class AcquisitionMap : ClassMap<Acquisition>
        {
            public AcquisitionMap()
            {
                Table("tblAcquisition");
                Id(x => x.AcquisitionId).GeneratedBy.Increment();
                Map(x => x.AcquisitionTypeCd);
                Map(x => x.Year);
                Map(x => x.Siri);
                Map(x => x.Target);
                Map(x => x.NewStatus);
                Map(x => x.NewStatusBy);
                Map(x => x.OpenStatus);
                Map(x => x.OpenStatusBy);
                Map(x => x.CloseStatus);
                Map(x => x.CloseStatusBy);
                Map(x => x.InviteFirstSelStatus);
                Map(x => x.InviteFirstSelStatusBy);
                Map(x => x.SecurityCheckStatus);
                Map(x => x.SecurityCheckStatusBy);
                Map(x => x.FirstSelectionStatus);
                Map(x => x.FirstSelectionStatusBy);
                Map(x => x.InviteFinalSelStatus);
                Map(x => x.InviteFinalSelStatusBy);
                Map(x => x.WrittenTestStatus);
                Map(x => x.WrittenTestStatusBy);
                Map(x => x.FinalSelStatus);
                Map(x => x.FinalSelStatusBy);
                Map(x => x.AssignNoTenteraStatus);
                Map(x => x.AssignNoTenteraStatusBy);
                Map(x => x.CompleteStatus);
                Map(x => x.CompleteStatusBy);
                Map(x => x.ClosingDate);
                Map(x => x.CreatedBy);
                Map(x => x.LastModifiedBy);
                Map(x => x.CreatedDt);
                Map(x => x.LastModifiedDt);

                HasMany<AcquisitionCriteria>(x => x.AcquisitionCriterias).KeyColumn("AcquisitionId").Inverse().Cascade.All();

                HasMany<AcquisitionEducationCriteria>(x => x.AcquisitionEducationCriterias).KeyColumn("AcquisitionId").Inverse().Cascade.All();



            }

            public class AcquisitionCriteriaMap : ClassMap<AcquisitionCriteria>
            {
                public AcquisitionCriteriaMap()
                {
                    Table("tblAcqCriteria");
                    Id(x => x.AcqCriteriaId).GeneratedBy.Increment();
                    Map(x => x.TDHeightM);
                    Map(x => x.TDWeightM);
                    Map(x => x.TDHeightF);
                    Map(x => x.TDWeightF);
                    Map(x => x.TLHeightM);
                    Map(x => x.TLWeightM);
                    Map(x => x.TLHeightF);
                    Map(x => x.TLWeightF);
                    Map(x => x.TUHeightM);
                    Map(x => x.TUWeightM);
                    Map(x => x.TUHeightF);
                    Map(x => x.TUWeightF);
                    Map(x => x.MaleBMIFrom);
                    Map(x => x.MaleBMITo);
                    Map(x => x.FemaleBMIFrom);
                    Map(x => x.FemaleBMITo);
                    Map(x => x.AgeMinimum);
                    Map(x => x.AgeAt);
                    Map(x => x.MaleChestMinimum);
                    Map(x => x.CreatedBy);
                    Map(x => x.LastModifiedBy);
                    Map(x => x.CreatedDt);
                    Map(x => x.LastModifiedDt);

                   References(x => x.Parent, "AcquisitionId").Cascade.All();
                }
            }



            public class AcquisitionEducationCriteriaMap : ClassMap<AcquisitionEducationCriteria>
            {
                public AcquisitionEducationCriteriaMap()
                {
                    Table("tblAcqEducationCriteria");
                    Id(x => x.AcqEduCriteriaId).GeneratedBy.Increment();
                    Map(x => x.HighEduLevelCd);
                    Map(x => x.CreatedBy);
                    Map(x => x.LastModifiedBy);
                    Map(x => x.CreatedDt);
                    Map(x => x.LastModifiedDt);

                    References(x => x.Parent, "AcquisitionId").Cascade.All();
                    HasMany<AcquisitionEducationCriteriaSubject>(x => x.AcquisitionEducationCriteriaSubjects).KeyColumn("AcqEduCriteriaId").Inverse().Cascade.All();
                }
            }

            public class AcquisitionEducationCriteriaSubjectMap : ClassMap<AcquisitionEducationCriteriaSubject>
            {
                public AcquisitionEducationCriteriaSubjectMap()
                {
                    Table("tblAcqEducationCriteriaSubject");
                    Id(x => x.AcqEduCriteriaSubjectId).GeneratedBy.Increment();
                    Map(x => x.SubjectCd);
                    Map(x => x.Subject);
                    Map(x => x.MinimumGradeCd);
                    Map(x => x.Grade);
                    Map(x => x.MainSubjectInd);
                    Map(x => x.CreatedBy);
                    Map(x => x.LastModifiedBy);
                    Map(x => x.CreatedDt);
                    Map(x => x.LastModifiedDt);

                    References(x => x.Parent, "AcqEduCriteriaId").Cascade.All();
                }
            }
           

        }
   

    }
}

