namespace SevenH.MMCSB.Atm.Domain.Interface
{
    public interface IApplicantSportSubmittedPersistence
    {
        void Delete(int id);
        int AddNew(ApplicantSportSubmitted appl);
        int Update(ApplicantSportSubmitted appl);
     
        ApplicantSportSubmitted GetApplicantSport(int id);

    }
}
