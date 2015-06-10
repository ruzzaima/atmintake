namespace SevenH.MMCSB.Atm.Domain.Interface
{
    public interface ILoginUserPersistance
    {
        int AddNew(LoginUser loginUser);
        int Update(LoginUser loginUser);
        bool Validate(string username, string password);
        bool ChangePassword(int loginid, string newpassword);
        LoginUser GetByUserName(string username);
    }
}
