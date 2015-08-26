using System.Collections.Generic;
using System.Data;
using NHibernate;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Persistance
{
    public class AcquisitionPersistence : IAcquisitionPersistence
    {
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
            var acq = Factory.OpenSession().Get<Acquisition>(id);
            //if (null != acq)
            //    acq.AcquisitionType = ObjectBuilder.GetObject<IReferencePersistence>("ReferencePersistence").GetAcquisitionType(acq.AcquisitionTypeCd);
            return acq;
        }


        private Acquisition SetParent(Acquisition acq)
        {
            //toto set child parent
            //foreach (var a in acq.AcquisitionCriterias)
            //{
            //    if (a.AcqCriteriaId == 0)
            //    {
            //        a.CreatedDt = acq.CreatedDt;
            //        a.CreatedBy = acq.CreatedBy;
            //        a.LastModifiedDt = acq.LastModifiedDt;
            //        a.LastModifiedBy = acq.LastModifiedBy;
            //    }
            //    else
            //    {
            //        a.LastModifiedDt = acq.LastModifiedDt;
            //        a.LastModifiedBy = acq.LastModifiedBy;
            //    }

            //    a.Parent = acq;
            //}

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

        public IEnumerable<AcquisitionLocation> GetLocations(string zonecode)
        {
            return Factory.OpenSession().QueryOver<AcquisitionLocation>().Where(a => a.ZoneCd == zonecode).List();
        }


        public IEnumerable<Acquisition> GetAllAcquisition(bool? isactive, string servicecode)
        {
            return Factory.OpenSession().QueryOver<Acquisition>().Where(a => a.AcquisitionType.ServiceCd == servicecode && a.OpenStatus == isactive).List();
        }


        public int Update(Acquisition appl)
        {
            throw new System.NotImplementedException();
        }
    }






}
