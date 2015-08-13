using System.Collections.Generic;
using Remotion.Linq.Parsing.Structure.IntermediateModel;

namespace SevenH.MMCSB.Atm.Domain
{
    public interface IAcquisitionPersistence
    {
        void Delete(int id);
        int Save(Acquisition appl);
        int Update(Acquisition appl);
        Acquisition GetAcquisition(int id);
        IEnumerable<AcquisitionLocation> GetLocations(string zonecode);
        IEnumerable<Acquisition> GetAllAcquisition(bool? isactive, string servicecode);
    }
}
