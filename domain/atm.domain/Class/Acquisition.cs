using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SevenH.MMCSB.Atm.Domain.Interface;
using Spring.Context.Support;
using Spring.Objects.Factory;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class Acquisition : DomainObject
    {
        public virtual ICollection<AcquisitionCriteria> AcquisitionCriterias { get; set; }
        public virtual ICollection<AcquisitionEducationCriteria> AcquisitionEducationCriterias { get; set; }

        private IAcquisitionPersistence _mPersistence;


        public virtual IAcquisitionPersistence PersistanceLayer
        {
            get
            {
                if (((_mPersistence == null)))
                {
                    var ctx = ContextRegistry.GetContext();
                    _mPersistence = ((IObjectFactory)ctx).GetObject("AcquisitionPersistence") as IAcquisitionPersistence;
                }
                return _mPersistence;
            }
            set { _mPersistence = value; }
        }

        public virtual int Save()
        {
            return (int)PersistanceLayer.Save(this);
        }
        

    }
}
