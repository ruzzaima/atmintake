using System.Collections.Generic;
using Remotion.Linq.Parsing.Structure.IntermediateModel;

namespace SevenH.MMCSB.Atm.Domain.Interface
{
    public interface IAcquisitionPersistence
    {
        void Delete(int id);
        int Save(Acquisition appl);
        Acquisition GetAcquisition(int id);
        IEnumerable<AcquisitionLocation> GetLocations(string zonecode);
    }
}
