using System.Collections.Generic;

namespace SevenH.MMCSB.Atm.Domain
{
    public interface IRoleProvider
    {
        int AddRoles(int userid, string roles);
        void DeleteRoles(LoginUser user, List<string> roles);
        bool CheckUserIsInRole(string username, string role);
        string GetRoles(int userid);
    }
}
