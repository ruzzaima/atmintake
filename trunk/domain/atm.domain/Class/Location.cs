using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class Location : DomainObject
    {
        public virtual AcquisitionLocation AcquisitionLocation { get; set; }
    }
}
