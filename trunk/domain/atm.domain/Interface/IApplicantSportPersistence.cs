namespace SevenH.MMCSB.Atm.Domain.Interface
{
    public interface IApplicantSportPersistence
    {
        void Delete(int id);
        int AddNew(ApplicantSport appl);
        int Update(ApplicantSport appl);
     
        ApplicantSport GetApplicantSport(int id);

    }
}
