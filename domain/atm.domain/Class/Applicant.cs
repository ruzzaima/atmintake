using System;
using System.Collections.Generic;
using SevenH.MMCSB.Atm.Domain.Interface;
using Spring.Context.Support;
using Spring.Objects.Factory;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class Applicant : DomainObject
    {
        public virtual IList<ApplicantSkill> ApplicantSkillCollection { get; set; }

        public Applicant()
        {
            ApplicantSkillCollection = new List<ApplicantSkill>();
        }

        public virtual int Save()
        {
            if (ApplicantId == 0)
                return ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").Save(this);
            return ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").Update(this);
        }

        public virtual Applicant GetApplicant(int id)
        {
            return ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").GetApplicant(id);
        }
    }


}

