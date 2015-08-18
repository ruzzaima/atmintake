using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
