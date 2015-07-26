using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class ApplicantPhoto : DomainObject
    {
        public virtual void Save()
        {
            if (Id == 0)
                ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").SaveApplicantPhoto(this);
            ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").UpdateApplicantPhoto(this);
        }
    }
}
