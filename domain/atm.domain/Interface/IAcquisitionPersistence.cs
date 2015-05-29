namespace SevenH.MMCSB.Atm.Domain.Interface
{
    public interface IAcquisitionPersistence
    {
       
        void Delete(int id);
        int Save(Acquisition appl);
      
        Acquisition GetAcquisition(int id);

    }
}
