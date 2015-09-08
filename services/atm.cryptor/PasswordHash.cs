using SevenH.DCA.Domain;

namespace SevenH.Cryptor
{
    class PasswordHash : ICryptorService
    {
        public byte[] ComputeHash(string salt, string password)
        {
            var cryptor = new AESCrypto();
            return cryptor.Encrypt(salt + password);
        }

        public string Decrypt(byte[] password)
        {
            var cryptor = new AESCrypto();
            return cryptor.Decrypt(password);
        }
        
        public string DecryptString(string password)
        {
            var cryptor = new AESCrypto();
            return cryptor.DecryptString(password);
        }
        
        public string ComputeHashInString(string salt, string password)
        {
            var cryptor = new AESCrypto();
            return cryptor.EncryptToString(salt + password);
        }
    }
}
