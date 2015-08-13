using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenH.MMCSB.Atm.Domain
{
    public interface IMembershipProvider
    {
        int Update(LoginUser user, List<string> messages);
        bool CustomChangePassword(string username, string oldpassword, string newpassword);
        bool CustomResetPassword(string username, string password);
        /// <summary>
        /// This function will set some compulsory value with default value
        /// </summary>
        /// <param name="user"></param>
        /// <param name="messages"></param>
        /// <returns></returns>
        int CreateNewUser(LoginUser user, List<string> messages);
        /// <summary>
        /// This one is not set value with default one
        /// </summary>
        /// <param name="user"></param>
        /// <param name="messages"></param>
        /// <returns></returns>
        int CreateNew(LoginUser user, List<string> messages);
        bool VerifyUser(string username, string guid);
        int CreateNewUserVerification(string username, string guid);
        bool DeleteUser(LoginUser user);
        List<LoginUser> LoadAll();
        LoginUser LoadByUserName(string username);
        LoginUser LoadById(int id);
        IEnumerable<LoginUser> LoadAllByStatus(string status);
        IEnumerable<LoginUser> LoadAllIsOnline();
        bool IsExist(string username);
        bool IsOauthExist(string username);
        int AddNewOauthProfile(string username);
        bool IsOnline(string username);
    }
}
