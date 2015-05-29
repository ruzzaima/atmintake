using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate;
using FluentNHibernate.Mapping;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;
using Spring.Context.Support;
using Spring.Objects.Factory;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class Applicant : DomainObject
    {

        public virtual ICollection<ApplicantEducation> ApplicantEducations { get; set; }
        public virtual ICollection<ApplicantSkill> ApplicantSkills { get; set; }
        public virtual ICollection<SportAndAssociation> SportAndAssociations { get; set; }
        public virtual ICollection<Application> Applications { get; set; }
        public virtual ICollection<ApplicantDispStatus> ApplicantDispStatuses { get; set; }


        private IApplicantPersistence _mPersistence;

        public virtual IApplicantPersistence PersistanceLayer
        {
            get
            {
                if (((_mPersistence == null)))
                {
                    var ctx = ContextRegistry.GetContext();
                    _mPersistence = ((IObjectFactory)ctx).GetObject("ApplicantPersistence;") as IApplicantPersistence;
                }
                return _mPersistence;
            }
            set { _mPersistence = value; }
        }

        public virtual int Save()
        {
            return (int)PersistanceLayer.Save(this);
        }

        public virtual Applicant GetApplicant(int id)
        {
            return (Applicant)PersistanceLayer.GetApplicant(id);
        }
     }


}

