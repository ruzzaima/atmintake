namespace SevenH.MMCSB.Atm.Domain
{
    public interface ICryptorService
    {
        byte[] ComputeHash(string salt, string password);
        string ComputeHashInString(string salt, string password);
        string Decrypt(byte[] password);
        string DecryptString(string password);
    }
}
