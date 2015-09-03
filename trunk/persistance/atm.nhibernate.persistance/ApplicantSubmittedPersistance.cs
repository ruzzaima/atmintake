using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Persistance
{
    public class ApplicantSubmittedPersistence : IApplicantSubmittedPersistence
    {
        public void Delete(int id)
        {
            var app = GetApplicant(id);
            Factory.OpenSession().Delete(app);
        }

        public int Save(ApplicantSubmitted appl)
        {
            Factory.OpenSession().SaveOrUpdate(appl);
            Factory.OpenSession().Flush();
            return appl.ApplicantId;
        }

        public int Update(ApplicantSubmitted appl)
        {
            Factory.OpenSession().SaveOrUpdate(appl);
            Factory.OpenSession().Flush();
            return appl.ApplicantId;
        }

        public ApplicantSubmitted GetApplicant(int id)
        {
            var exist = Factory.OpenSession().QueryOver<ApplicantSubmitted>().Where(a => a.ApplicantId == id).SingleOrDefault();
            return exist;
        }

        public ApplicantSubmitted GetApplicant(string icno)
        {
            var exist = Factory.OpenSession().QueryOver<ApplicantSubmitted>().Where(a => a.NewICNo == icno).List().FirstOrDefault();
            return exist;
        }

        public IEnumerable<ApplicantSubmitted> GetApplicants(string icno)
        {
            var exist = Factory.OpenSession().QueryOver<ApplicantSubmitted>().Where(a => a.NewICNo == icno).List();
            return exist;
        }


        public ApplicantSubmittedPhoto GetPhoto(int applicantid)
        {
            return Factory.OpenSession().QueryOver<ApplicantSubmittedPhoto>().Where(a => a.ApplicantId == applicantid).SingleOrDefault();
        }


        public int SaveApplicantPhoto(ApplicantSubmittedPhoto photo)
        {
            Factory.OpenSession().SaveOrUpdate(photo);
            Factory.OpenSession().Flush();
            return photo.ApplicantId;
        }

        public int UpdateApplicantPhoto(ApplicantSubmittedPhoto photo)
        {
            Factory.OpenSession().SaveOrUpdate(photo);
            Factory.OpenSession().Flush();
            return photo.ApplicantId;
        }

        public IEnumerable<ApplicantSubmitted> Search(int acquisitionid, string category, string name, string icno, string searchcriteria,
            bool? invitationfirtselection, bool? firstselection, bool? finalselection, int? take, int? skip, bool? all,
            out int total)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ApplicantSubmitted> Search(int acquisitionid, string searchcriteria, bool? invitationfirtselection, bool? firstselection,
            bool? finalselection, int? take, int? skip, int? finalselectionlocid, string statecode, string citycode, bool? all,
            out int total)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ApplicantSubmitted> Search(int acquisitionid, string category, string name, string icno, string searchcriteria,
            bool? invitationfirtselection, bool? firstselection, bool? finalselection, int? take, int? skip, out int total)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<ApplicantEducationSubmitted> GetEducation(int applicantid)
        {
            var list = Factory.OpenSession().QueryOver<ApplicantEducationSubmitted>().Where(a => a.ApplicantId == applicantid).List();
            if (null != list && list.Any())
            {
                foreach (var edu in list)
                {
                    var high = Factory.OpenSession().QueryOver<HighEduLevel>().Where(a => a.HighEduLevelCd == edu.HighEduLevelCd).SingleOrDefault();
                    edu.HighEduLevel = high.HighestEduLevel;
                    edu.InstCd = !string.IsNullOrWhiteSpace(edu.InstCd) ? edu.InstCd.Trim() : edu.InstCd;
                    var subject = Factory.OpenSession().QueryOver<ApplicantEduSubjectSubmitted>().Where(a => a.ApplicantEduId == edu.ApplicantEduId).List();
                    foreach (var s in subject)
                    {
                        var sc = Factory.OpenSession().QueryOver<Subject>().Where(a => a.SubjectCd == s.SubjectCd).SingleOrDefault();
                        s.Subject = sc.SubjectDescription;
                        s.Grade = !string.IsNullOrWhiteSpace(s.Grade) ? s.Grade.Trim() : s.Grade;
                        s.GradeCd = !string.IsNullOrWhiteSpace(s.GradeCd) ? s.GradeCd.Trim() : s.GradeCd;
                        edu.ApplicantEduSubjectSubmittedCollection.Add(s);
                    }
                }
            }
            return list;
        }

        public IEnumerable<ApplicantEduSubjectSubmitted> GetEducationSubject(int appeduid)
        {
            return Factory.OpenSession().QueryOver<ApplicantEduSubjectSubmitted>().Where(a => a.ApplicantEduId == appeduid).List();
        }

        public ApplicantEduSubjectSubmitted GetSubject(int appeduid, int subjectcode)
        {
            throw new NotImplementedException();
        }

        public int SaveEducation(ApplicantEducationSubmitted education)
        {
            Factory.OpenSession().SaveOrUpdate(education);
            Factory.OpenSession().Flush();
            return education.ApplicantEduId;
        }

        public int SaveEducationSubject(ApplicantEduSubjectSubmitted subject)
        {
            Factory.OpenSession().SaveOrUpdate(subject);
            Factory.OpenSession().Flush();
            return subject.EduSubjectId;
        }

        public int UpdateEducation(ApplicantEducationSubmitted education)
        {
            Factory.OpenSession().SaveOrUpdate(education);
            Factory.OpenSession().Flush();
            return education.ApplicantEduId;
        }

        public int UpdateEducationSubject(ApplicantEduSubjectSubmitted subject)
        {
            Factory.OpenSession().SaveOrUpdate(subject);
            Factory.OpenSession().Flush();
            return subject.EduSubjectId;
        }


        public IEnumerable<ApplicantSkillSubmitted> GetSkill(int applicantid)
        {
            var skills = Factory.OpenSession().QueryOver<ApplicantSkillSubmitted>().Where(a => a.ApplicantId == applicantid).List();
            foreach (var s in skills)
            {
                var sk = Factory.OpenSession().QueryOver<Skill>().Where(a => a.SkillCd == s.SkillCd).SingleOrDefault();
                s.Skill = sk.SkillDescription;
                s.AchievementCd = !string.IsNullOrWhiteSpace(s.AchievementCd) ? s.AchievementCd.Trim() : s.AchievementCd;
            }
            return skills;
        }

        public int SaveSkill(ApplicantSkillSubmitted skill)
        {
            Factory.OpenSession().SaveOrUpdate(skill);
            Factory.OpenSession().Flush();
            return skill.ApplicantSkillId;
        }

        public int UpdateSkill(ApplicantSkillSubmitted skill)
        {
            Factory.OpenSession().SaveOrUpdate(skill);
            Factory.OpenSession().Flush();
            return skill.ApplicantSkillId;
        }
        
        public IEnumerable<ApplicantSportSubmitted> GetSport(int applicantid)
        {
            var sports = Factory.OpenSession().QueryOver<ApplicantSportSubmitted>().Where(a => a.ApplicantId == applicantid).List();
            foreach (var s in sports)
            {
                var sa = Factory.OpenSession().QueryOver<SportAndAssociation>().Where(a => a.SportAssocId == s.SportAssocId).SingleOrDefault();
                s.SportAndAssociation = sa;
                s.AchievementCd = !string.IsNullOrWhiteSpace(s.AchievementCd) ? s.AchievementCd.Trim() : s.AchievementCd;
            }
            return sports;
        }

        public int SaveSport(ApplicantSportSubmitted sport)
        {
            Factory.OpenSession().SaveOrUpdate(sport);
            Factory.OpenSession().Flush();
            return sport.ApplicantSportAssocId;
        }

        void IApplicantSubmittedPersistence.Delete(int id)
        {
            throw new NotImplementedException();
        }

        
        public ApplicantSubmitted GetApplicant(string icno, int acquisitionid)
        {
            var exist = Factory.OpenSession().QueryOver<ApplicantSubmitted>().Where(a => a.NewICNo == icno && a.AcquisitionId == acquisitionid).SingleOrDefault();
            return exist;
        }


        public IEnumerable<ApplicantSubmitted> GetApplicants(int acquisitionid)
        {
            throw new NotImplementedException();
        }


        public ApplicantSubmitted GetApplicant(int applicantid, int acquisitionid)
        {
            throw new NotImplementedException();
        }


        public int UpdateSport(ApplicantSportSubmitted sport)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<ApplicantSubmitted> GetApplicants(int acquisitionid, string racecode)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<ApplicantSubmitted> Search(string category, string name, string icno, string searchcriteria)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<ApplicantSubmitted> Search(int acquisitionid, string category, string name, string icno, string searchcriteria)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<ApplicantSubmitted> GetByAcademis(string highleveleducd)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<ApplicantSubmitted> Search(int acquisitionid, string category, string name, string icno, string searchcriteria, bool? invitationfirtselection, bool? finalivitation)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<ApplicantSubmitted> Search(int acquisitionid, string category, string name, string icno, string searchcriteria, bool? invitationfirtselection, bool? firstselection, bool? finalselection)
        {
            throw new NotImplementedException();
        }


        int IApplicantSubmittedPersistence.Save(ApplicantSubmitted appl)
        {
            throw new NotImplementedException();
        }

        int IApplicantSubmittedPersistence.Update(ApplicantSubmitted applicant)
        {
            throw new NotImplementedException();
        }

        ApplicantSubmitted IApplicantSubmittedPersistence.GetApplicant(int applicantid)
        {
            throw new NotImplementedException();
        }

        ApplicantSubmitted IApplicantSubmittedPersistence.GetApplicant(string icno, int acquisitionid)
        {
            throw new NotImplementedException();
        }

        ApplicantSubmitted IApplicantSubmittedPersistence.GetApplicant(int applicantid, int acquisitionid)
        {
            throw new NotImplementedException();
        }

        IEnumerable<ApplicantSubmitted> IApplicantSubmittedPersistence.GetApplicants(string icno)
        {
            throw new NotImplementedException();
        }

        IEnumerable<ApplicantSubmitted> IApplicantSubmittedPersistence.GetApplicants(int acquisitionid)
        {
            throw new NotImplementedException();
        }

        IEnumerable<ApplicantSubmitted> IApplicantSubmittedPersistence.GetApplicants(int acquisitionid, string racecode)
        {
            throw new NotImplementedException();
        }

        int IApplicantSubmittedPersistence.SaveEducation(ApplicantEducationSubmitted education)
        {
            throw new NotImplementedException();
        }

        int IApplicantSubmittedPersistence.UpdateEducation(ApplicantEducationSubmitted education)
        {
            throw new NotImplementedException();
        }

        IEnumerable<ApplicantEducationSubmitted> IApplicantSubmittedPersistence.GetEducation(int applicantid)
        {
            throw new NotImplementedException();
        }

        int IApplicantSubmittedPersistence.SaveEducationSubject(ApplicantEduSubjectSubmitted subject)
        {
            throw new NotImplementedException();
        }

        int IApplicantSubmittedPersistence.UpdateEducationSubject(ApplicantEduSubjectSubmitted subject)
        {
            throw new NotImplementedException();
        }

        IEnumerable<ApplicantEduSubjectSubmitted> IApplicantSubmittedPersistence.GetEducationSubject(int appeduid)
        {
            throw new NotImplementedException();
        }

        ApplicantEduSubjectSubmitted IApplicantSubmittedPersistence.GetSubject(int appeduid, int subjectcode)
        {
            throw new NotImplementedException();
        }

        int IApplicantSubmittedPersistence.SaveSkill(ApplicantSkillSubmitted skill)
        {
            throw new NotImplementedException();
        }

        int IApplicantSubmittedPersistence.UpdateSkill(ApplicantSkillSubmitted skill)
        {
            throw new NotImplementedException();
        }

        IEnumerable<ApplicantSkillSubmitted> IApplicantSubmittedPersistence.GetSkill(int applicantid)
        {
            throw new NotImplementedException();
        }

        int IApplicantSubmittedPersistence.SaveSport(ApplicantSportSubmitted sport)
        {
            throw new NotImplementedException();
        }

        int IApplicantSubmittedPersistence.UpdateSport(ApplicantSportSubmitted sport)
        {
            throw new NotImplementedException();
        }

        IEnumerable<ApplicantSportSubmitted> IApplicantSubmittedPersistence.GetSport(int applicantid)
        {
            throw new NotImplementedException();
        }

        ApplicantSubmittedPhoto IApplicantSubmittedPersistence.GetPhoto(int applicantid)
        {
            throw new NotImplementedException();
        }

        int IApplicantSubmittedPersistence.SaveApplicantPhoto(ApplicantSubmittedPhoto photo)
        {
            throw new NotImplementedException();
        }

        int IApplicantSubmittedPersistence.UpdateApplicantPhoto(ApplicantSubmittedPhoto photo)
        {
            throw new NotImplementedException();
        }


        IEnumerable<ApplicantSubmitted> IApplicantSubmittedPersistence.GetByAcademis(string highleveleducd)
        {
            throw new NotImplementedException();
        }
    }
}

