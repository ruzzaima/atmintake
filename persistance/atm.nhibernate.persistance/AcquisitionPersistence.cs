using System.Data;
using NHibernate;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Persistance
{
    public class AcquisitionPersistence : IAcquisitionPersistence
    {

        private static ISession _mSession;
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
            var acq = GetAcquisition(id);
            Factory.OpenSession().Delete(acq);
        }

        public int Save(Acquisition acq)
        {
            acq = SetParent(acq);
            Factory.OpenSession().Save(acq);
            Factory.OpenSession().Flush();
            return acq.AcquisitionId;
        }

        public Acquisition GetAcquisition(int id)
        {
            var acq = Session.Get<Acquisition>(id);
            return acq;
        }


        private Acquisition SetParent(Acquisition acq)
        {
            //toto set child parent


            foreach (var a in acq.AcquisitionCriterias)
            {
                if (a.AcqCriteriaId == 0)
                {
                    a.CreatedDt = acq.CreatedDt;
                    a.CreatedBy = acq.CreatedBy;
                    a.LastModifiedDt = acq.LastModifiedDt;
                    a.LastModifiedBy = acq.LastModifiedBy;
                }
                else
                {
                    a.LastModifiedDt = acq.LastModifiedDt;
                    a.LastModifiedBy = acq.LastModifiedBy;
                }

                a.Parent = acq;
            }

            foreach (var a in acq.AcqQuestionnaires)
            {
                if (a.QuestionnaireId == 0)
                {
                    a.CreatedDt = acq.CreatedDt;
                    a.CreatedBy = acq.CreatedBy;
                    a.LastModifiedDt = acq.LastModifiedDt;
                    a.LastModifiedBy = acq.LastModifiedBy;
                }
                else
                {
                    a.LastModifiedDt = acq.LastModifiedDt;
                    a.LastModifiedBy = acq.LastModifiedBy;
                }

                a.Parent = acq;

                foreach (var b in a.AcqQuestions)
                {
                    if (b.AcqQuestionId == 0)
                    {
                        b.CreatedDt = acq.CreatedDt;
                        b.CreatedBy = acq.CreatedBy;
                        b.LastModifiedDt = acq.LastModifiedDt;
                        b.LastModifiedBy = acq.LastModifiedBy;
                    }
                    else
                    {
                        b.LastModifiedDt = acq.LastModifiedDt;
                        b.LastModifiedBy = acq.LastModifiedBy;
                    }

                    b.Parent = a;
                }

                foreach (var c in a.AcqQuestionnaireScales)
                {
                   c.Parent = a;
                }

            }


            foreach (var a in acq.AcquisitionEducationCriterias)
            {
                if (a.AcqEduCriteriaId == 0)
                {
                    a.CreatedDt = acq.CreatedDt;
                    a.CreatedBy = acq.CreatedBy;
                    a.LastModifiedDt = acq.LastModifiedDt;
                    a.LastModifiedBy = acq.LastModifiedBy;
                }
                else
                {
                    a.LastModifiedDt = acq.LastModifiedDt;
                    a.LastModifiedBy = acq.LastModifiedBy;
                }
                a.Parent = acq;

                foreach (var b in a.AcquisitionEducationCriteriaSubjects)
                {
                    if (b.AcqEduCriteriaSubjectId == 0)
                    {
                        b.CreatedDt = acq.CreatedDt;
                        b.CreatedBy = a.CreatedBy;
                        b.LastModifiedDt = acq.LastModifiedDt;
                        b.LastModifiedBy = acq.LastModifiedBy;
                    }
                    else
                    {
                        b.LastModifiedDt = acq.LastModifiedDt;
                        b.LastModifiedBy = acq.LastModifiedBy;
                    }
                    b.Parent = a;
                }

                foreach (var c in a.AcqEduCriteriaFieldOfStudys)
                {
                    if (c.AcqEduCriFOS == 0)
                    {
                        c.CreatedDt = acq.CreatedDt;
                        c.CreatedBy = acq.CreatedBy;
                        c.LastModifiedDt = acq.LastModifiedDt;
                        c.LastModifiedBy = acq.LastModifiedBy;
                    }
                    else
                    {
                        c.LastModifiedDt = acq.LastModifiedDt;
                        c.LastModifiedBy = acq.LastModifiedBy;
                    }
                    c.Parent = a;
                }

            }

            return acq;
        }


    }






}
