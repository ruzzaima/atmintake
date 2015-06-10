namespace SevenH.MMCSB.Atm.Domain.Interface
{
    public interface IApplicantPersistence
    {
        void Delete(int id);
        int Save(Applicant appl);
     
        Applicant GetApplicant(int id);

        int Update(Applicant applicant);
    }
}
