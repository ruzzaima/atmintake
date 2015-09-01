using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace SevenH.MMCSB.Atm.Domain.Interface
{
    public interface ILoginUserPersistance
    {
        int AddNew(LoginUser loginUser);
        int Update(LoginUser loginUser);
        bool Validate(string username, string password);
        bool ChangePassword(int loginid, string newpassword);
        /// <summary>
        /// Changing password for first time. Must set the is first time to false. meaning it is already not first time
        /// </summary>
        /// <param name="loginid"></param>
        /// <param name="firsttime"></param>
        /// <param name="newpassword"></param>
        /// <returns></returns>
        bool ChangePasswordFirstTime(int loginid, bool firsttime, string newpassword);
        LoginUser GetByUserName(string username);
        LoginUser GetByIdNumber(string idnumber);
        LoginUser GetById(int id);

        IEnumerable<LoginUser> LoadAllUser(bool internaluser, bool? isactive, string servicecode, string search, int? take, int? skip);

        int LoggingUser(int userid, string statuscode, string by, DateTime bydate);

        bool Delete(int userid);
        string GetPassword(int userid);
    }
}
