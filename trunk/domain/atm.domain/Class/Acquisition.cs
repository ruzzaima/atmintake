using System.Collections.Generic;
using SevenH.MMCSB.Atm.Domain.Interface;
using Spring.Context.Support;
using Spring.Objects.Factory;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class Acquisition : DomainObject
    {
        public virtual ICollection<AcquisitionCriteria> AcquisitionCriterias { get; set; }
        public virtual ICollection<AcquisitionEducationCriteria> AcquisitionEducationCriterias { get; set; }

        public virtual ICollection<AcqQuestionnaire> AcqQuestionnaires { get; set; }

        public virtual Advertisment Advertisment { get; set; }

        public virtual AcquisitionType AcquisitionType { get; set; }

        private IAcquisitionPersistence _mPersistence;


        public virtual IAcquisitionPersistence PersistanceLayer
        {
            get
            {
                if (((_mPersistence == null)))
                {
                    var ctx = ContextRegistry.GetContext();
                    _mPersistence =
                        ((IObjectFactory)ctx).GetObject("AcquisitionPersistence") as IAcquisitionPersistence;
                }
                return _mPersistence;
            }
            set { _mPersistence = value; }
        }

        public virtual int Save()
        {
            if (AcquisitionId == 0)
                return PersistanceLayer.Save(this);
            return PersistanceLayer.Update(this);
        }


        public virtual Acquisition GetAcquisition(int id)
        {
            return (Acquisition)PersistanceLayer.GetAcquisition(id);

        }
    }
}
