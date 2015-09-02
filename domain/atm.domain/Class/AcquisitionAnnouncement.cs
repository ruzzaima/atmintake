using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class AcquisitionAnnouncement : DomainObject
    {
        public virtual int Save()
        {
            if (AcqAnnouncementId == 0)
                return ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").AddAnnouncement(this);
            return ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").UpdateAnnouncement(this);
        }
    }
}
