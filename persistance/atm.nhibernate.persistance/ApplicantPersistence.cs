using System;
using System.Data;
using NHibernate;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Persistance
{
    public class ApplicantPersistence : IApplicantPersistence
    {

        private static NHibernate.ISession _mSession;
        public ISession Session
        {
            get
            {
                if ((_mSession == null))
                {

                    _mSession = Factory.OpenSession();
                }
                if (_mSession.Connection.State == ConnectionState.Closed)
                {
                    _mSession.Connection.Open();
                }

                return _mSession;
            }
        }


        public void Delete(int id)
        {
            var app = GetApplicant(id);
            Factory.OpenSession().Delete(app);
        }

        public int Save(Applicant appl)
        {
            appl = SetParent(appl);
            Factory.OpenSession().Save(appl);
            Factory.OpenSession().Flush();
            return 1;
        }

        public Applicant GetApplicant(int id)
        {
            var app = Session.Get<Applicant>(id);
            return app;
        }


        private Applicant SetParent(Applicant app)
        {
            //toto set child parent

            foreach (var a in app.ApplicantEducations)
            {
                if (a.ApplicantEduId == 0)
                {
                    a.CreatedDt = app.CreatedDt;
                    a.CreatedBy = app.CreatedBy;
                    a.LastModifiedDt = app.LastModifiedDt;
                    a.LastModifiedBy = app.LastModifiedBy;
                }
                else
                {
                    a.LastModifiedDt = app.LastModifiedDt;
                    a.LastModifiedBy = app.LastModifiedBy;
                }

                foreach (var b in a.ApplicantEduSubjects)
                {
                    if (b.EduSubjectId == 0)
                    {
                        a.CreatedDt = app.CreatedDt;
                        a.CreatedBy = app.CreatedBy;
                        a.LastModifiedDt = app.LastModifiedDt;
                        a.LastModifiedBy = app.LastModifiedBy;
                    }
                    else
                    {
                        a.LastModifiedDt = app.LastModifiedDt;
                        a.LastModifiedBy = app.LastModifiedBy;
                    }

                    b.Parent = a;
                }


                a.Parent = app;
            }

            foreach (var a in app.ApplicantSkills)
            {
                if (a.ApplicantSkillId == 0)
                {
                    a.CreatedDt = app.CreatedDt;
                    a.CreatedBy = app.CreatedBy;
                    a.LastModifiedDt = app.LastModifiedDt;
                    a.LastModifiedBy = app.LastModifiedBy;
                }
                else
                {
                    a.LastModifiedDt = app.LastModifiedDt;
                    a.LastModifiedBy = app.LastModifiedBy;
                }

                a.Parent = app;
            }

            foreach (var a in app.SportAndAssociations)
            {
                if (a.SportAssocId == 0)
                {
                    a.CreatedDt = app.CreatedDt;
                    a.CreatedBy = app.CreatedBy;
                    a.LastModifiedDt = app.LastModifiedDt;
                    a.LastModifiedBy = app.LastModifiedBy;
                }
                else
                {
                    a.LastModifiedDt = app.LastModifiedDt;
                    a.LastModifiedBy = app.LastModifiedBy;
                }

                a.Parent = app;
            }

            foreach (var a in app.Applications)
            {
                if (a.AppId == 0)
                {
                    a.CreatedDt = app.CreatedDt;
                    a.CreatedBy = app.CreatedBy;
                    a.LastModifiedDt = app.LastModifiedDt;
                    a.LastModifiedBy = app.LastModifiedBy;
                }
                else
                {
                    a.LastModifiedDt = app.LastModifiedDt;
                    a.LastModifiedBy = app.LastModifiedBy;
                }

                a.Parent = app;
            }

            foreach (var a in app.ApplicantDispStatuses)
            {
                if (a.ApplicantDispStatusId == 0)
                {
                    a.CreatedDt = app.CreatedDt;
                    a.CreatedBy = app.CreatedBy;
                    a.LastModifiedDt = app.LastModifiedDt;
                    a.LastModifiedBy = app.LastModifiedBy;
                }
                else
                {
                    a.LastModifiedDt = app.LastModifiedDt;
                    a.LastModifiedBy = app.LastModifiedBy;
                }

                a.Parent = app;
            }

            return app;
        }
    }


}

