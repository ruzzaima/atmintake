using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI.WebControls;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Transform;
using NHibernate.Util;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Persistance
{
    public class ApplicantPersistence : IApplicantPersistence
    {
        public void Delete(int id)
        {
            var app = GetApplicant(id);
            Factory.OpenSession().Delete(app);
        }

        public int Save(Applicant appl)
        {
            Factory.OpenSession().SaveOrUpdate(appl);
            Factory.OpenSession().Flush();
            return appl.ApplicantId;
        }

        public int Update(Applicant appl)
        {
            Factory.OpenSession().SaveOrUpdate(appl);
            Factory.OpenSession().Flush();
            return appl.ApplicantId;
        }

        public Applicant GetApplicant(int id)
        {
            var exist = Factory.OpenSession().QueryOver<Applicant>().Where(a => a.ApplicantId == id).SingleOrDefault();
            Factory.OpenSession().Flush();
            return exist;
        }


        public ApplicantPhoto GetPhoto(int applicantid)
        {
            return Factory.OpenSession().QueryOver<ApplicantPhoto>().Where(a => a.ApplicantId == applicantid).SingleOrDefault();
        }


        public int SaveApplicantPhoto(ApplicantPhoto photo)
        {
            Factory.OpenSession().SaveOrUpdate(photo);
            Factory.OpenSession().Flush();
            return photo.ApplicantId.Value;
        }

        public int UpdateApplicantPhoto(ApplicantPhoto photo)
        {
            Factory.OpenSession().SaveOrUpdate(photo);
            Factory.OpenSession().Flush();
            return photo.ApplicantId.Value;
        }


        public IEnumerable<ApplicantEducation> GetEducation(int applicantid)
        {
            var list = Factory.OpenSession().QueryOver<ApplicantEducation>().Where(a => a.ApplicantId == applicantid).List();
            if (null != list && EnumerableExtensions.Any(list))
            {
                foreach (var edu in list)
                {
                    var high = Factory.OpenSession().QueryOver<HighEduLevel>().Where(a => a.HighEduLevelCd == edu.HighEduLevelCd).SingleOrDefault();
                    edu.HighEduLevel = high.HighestEduLevel;
                    edu.InstCd = !string.IsNullOrWhiteSpace(edu.InstCd) ? edu.InstCd.Trim() : edu.InstCd;

                    //ICriteria criteria = Factory.OpenSession().CreateCriteria(typeof(ApplicantEduSubject));
                    //criteria.SetProjection(
                    //    Projections.Distinct(Projections.ProjectionList()
                    //        .Add(Projections.Alias(Projections.Property("ApplicantEduId"), "ApplicantEduId"))
                    //        .Add(Projections.Alias(Projections.Property("SubjectCd"), "SubjectCd"))));
                    //criteria.SetResultTransformer(
                    //    new AliasToBeanResultTransformer(typeof(ApplicantEduSubject)));

                    //var subs = criteria.List();

                    //var decisions = Factory.OpenSession().QueryOver<ApplicantEduSubject>()
                    //    .Where(a => a.ApplicantEduId == edu.ApplicantEduId)
                    //    .Fetch(a => a.SubjectCd)
                    //    .Eager
                    //    .List();

                    var subject = Factory.OpenSession().QueryOver<ApplicantEduSubject>().Where(a => a.ApplicantEduId == edu.ApplicantEduId).TransformUsing(Transformers.DistinctRootEntity).List();
                    foreach (var s in subject)
                    {
                        var sc = Factory.OpenSession().QueryOver<Subject>().Where(a => a.SubjectCd == s.SubjectCd).SingleOrDefault();
                        s.Subject = sc.SubjectDescription;
                        s.Grade = !string.IsNullOrWhiteSpace(s.Grade) ? s.Grade.Trim() : s.Grade;
                        s.GradeCd = !string.IsNullOrWhiteSpace(s.GradeCd) ? s.GradeCd.Trim() : s.GradeCd;
                        if (!edu.ApplicantEduSubjectCollection.Any(a => a.SubjectCd == s.SubjectCd))
                            edu.ApplicantEduSubjectCollection.Add(s);
                    }
                }
            }
            return list;
        }

        public IEnumerable<ApplicantEduSubject> GetEducationSubject(int appeduid)
        {
            return Factory.OpenSession().QueryOver<ApplicantEduSubject>().Where(a => a.ApplicantEduId == appeduid).TransformUsing(Transformers.DistinctRootEntity).List();
        }

        public ApplicantEduSubject GetSubject(int appeduid, int subjectcode)
        {
            return Enumerable.LastOrDefault(Factory.OpenSession().QueryOver<ApplicantEduSubject>().Where(a => a.ApplicantEduId == appeduid && a.SubjectCd == subjectcode).List());
        }

        public int SaveEducation(ApplicantEducation education)
        {
            Factory.OpenSession().SaveOrUpdate(education);
            Factory.OpenSession().Flush();
            return education.ApplicantEduId;
        }

        public int SaveEducationSubject(ApplicantEduSubject subject)
        {
            Factory.OpenSession().SaveOrUpdate(subject);
            Factory.OpenSession().Flush();
            return subject.EduSubjectId;
        }

        public int UpdateEducation(ApplicantEducation education)
        {
            Factory.OpenSession().SaveOrUpdate(education);
            Factory.OpenSession().Flush();
            return education.ApplicantEduId;
        }

        public int UpdateEducationSubject(ApplicantEduSubject subject)
        {
            Factory.OpenSession().SaveOrUpdate(subject);
            Factory.OpenSession().Flush();
            return subject.EduSubjectId;
        }

        public IEnumerable<ApplicantSkill> GetSkill(int applicantid)
        {
            var skills = Factory.OpenSession().QueryOver<ApplicantSkill>().Where(a => a.ApplicantId == applicantid).List();
            foreach (var s in skills)
            {
                var sk = Factory.OpenSession().QueryOver<Skill>().Where(a => a.SkillCd == s.SkillCd).SingleOrDefault();
                s.Skill = sk.SkillDescription;
                s.AchievementCd = !string.IsNullOrWhiteSpace(s.AchievementCd) ? s.AchievementCd.Trim() : s.AchievementCd;
            }
            return skills;
        }

        public int SaveSkill(ApplicantSkill skill)
        {
            Factory.OpenSession().SaveOrUpdate(skill);
            Factory.OpenSession().Flush();
            return skill.ApplicantSkillId;
        }

        public int UpdateSkill(ApplicantSkill skill)
        {
            Factory.OpenSession().SaveOrUpdate(skill);
            Factory.OpenSession().Flush();
            return skill.ApplicantSkillId;
        }


        public int UpdateSport(ApplicantSport sport)
        {
            Factory.OpenSession().SaveOrUpdate(sport);
            Factory.OpenSession().Flush();
            return sport.ApplicantSportAssocId;
        }

        public IEnumerable<ApplicantSport> GetSport(int applicantid)
        {
            var sports = Factory.OpenSession().QueryOver<ApplicantSport>().Where(a => a.ApplicantId == applicantid).List();
            foreach (var s in sports)
            {
                var sa = Factory.OpenSession().QueryOver<SportAndAssociation>().Where(a => a.SportAssocId == s.SportAssocId).SingleOrDefault();
                s.SportAndAssociation = sa;
                s.AchievementCd = !string.IsNullOrWhiteSpace(s.AchievementCd) ? s.AchievementCd.Trim() : s.AchievementCd;
            }
            return sports;
        }

        public int SaveSport(ApplicantSport sport)
        {
            Factory.OpenSession().SaveOrUpdate(sport);
            Factory.OpenSession().Flush();
            return sport.ApplicantSportAssocId;
        }

        public bool CheckingExistingAtmMember(string idnumber)
        {
            var exist = Factory.OpenSession().QueryOver<ExistingMember>().Where(a => a.IdNumber == idnumber).SingleOrDefault();
            Factory.OpenSession().Flush();
            return exist != null;
        }


        public ExistingMember ExistingAtmMember(string idnumber)
        {
            var exist = Factory.OpenSession().QueryOver<ExistingMember>().Where(a => a.IdNumber == idnumber).SingleOrDefault();
            Factory.OpenSession().Flush();
            return exist;
        }


        public bool CheckingExistingAtmMemberByArmyNo(int armyno)
        {
            var exist = Factory.OpenSession().QueryOver<ExistingMember>().Where(a => a.ArmyNo == armyno).SingleOrDefault();
            Factory.OpenSession().Flush();
            return exist != null;
        }

        public ExistingMember ExistingAtmMemberByArmyNo(int armyno)
        {
            var exist = Factory.OpenSession().QueryOver<ExistingMember>().Where(a => a.ArmyNo == armyno).SingleOrDefault();
            Factory.OpenSession().Flush();
            return exist;
        }


        public IEnumerable<Applicant> Search(string category, string name, string icno, string searchcriteria)
        {
            throw new System.NotImplementedException();
        }
    }


}

