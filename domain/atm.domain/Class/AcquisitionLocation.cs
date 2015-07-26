using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class AcquisitionLocation : DomainObject
    {
        public virtual Location Location { get; set; }
    }
}
