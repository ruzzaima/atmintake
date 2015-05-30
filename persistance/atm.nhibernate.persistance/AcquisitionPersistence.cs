﻿using System;
using System.Data;
using System.Globalization;
using NHibernate;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Persistance
{
    public class AcquisitionPersistence : IAcquisitionPersistence
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
            var acq = GetAcquisition(id);
            Factory.OpenSession().Delete(acq);
        }

        public int Save(Acquisition acq)
        {
            acq=SetParent(acq);
            Factory.OpenSession().Save(acq);
            Factory.OpenSession().Flush();
            return 1;
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
                    a.CreatedDt =  acq.CreatedDt;
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

            foreach (var a in acq.AcquisitionEducationCriterias)
            {
                if (a.AcqEduCriteriaId == 0)
                {
                    a.CreatedDt =  acq.CreatedDt;
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
                        b.LastModifiedBy = a.LastModifiedBy;
                    }
                    else
                    {
                        b.LastModifiedDt = acq.LastModifiedDt;
                        b.LastModifiedBy = a.LastModifiedBy;
                    }
                    b.Parent = a;

                }
            }
            return acq;
        }


    }

   




}