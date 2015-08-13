using System;
using System.Collections;
using System.Collections.Generic;

namespace SevenH.MMCSB.Atm.Domain.Interface
{
    public interface ILoginUserPersistance
    {
        int AddNew(LoginUser loginUser);
        int Update(LoginUser loginUser);
        bool Validate(string username, string password);
        bool ChangePassword(int loginid, string newpassword);
        LoginUser GetByUserName(string username);
        LoginUser GetByIdNumber(string idnumber);
        LoginUser GetById(int id);

        IEnumerable<LoginUser> LoadAllUser(bool internaluser, bool? isactive, string servicecode, string search);

        int LoggingUser(int userid, string statuscode, string by, DateTime bydate);
    }
}
