using System.Collections.Generic;
using Spring.Context.Support;
using Spring.Objects.Factory;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class Acquisition : DomainObject
    {
        public virtual ICollection<AcquisitionEducationCriteria> AcquisitionEducationCriterias { get; set; }
        public virtual ICollection<AcqQuestionnaire> AcqQuestionnaires { get; set; }
        public virtual Advertisment Advertisment { get; set; }
        public virtual AcquisitionType AcquisitionType { get; set; }
        private IAcquisitionPersistence m_persistence;


        public virtual IAcquisitionPersistence PersistanceLayer
        {
            get
            {
                if (((m_persistence == null)))
                {
                    var ctx = ContextRegistry.GetContext();
                    m_persistence =
                        ((IObjectFactory)ctx).GetObject(Strings.ACQUISITION_PERSISTANCE) as IAcquisitionPersistence;
                }
                return m_persistence;
            }
            set { m_persistence = value; }
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
