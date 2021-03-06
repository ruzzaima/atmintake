﻿using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class LoginUser : DomainObject
    {
        public virtual LoginRole LoginRole { get; set; }

        public virtual int Save()
        {
            if (UserId == 0)
                UserId = ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").AddNew(this);
            else
                UserId = ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").Update(this);

            if (LoginRole != null && !string.IsNullOrWhiteSpace(LoginRole.Roles))
            {
                if (LoginRole.Roles != RolesString.AWAM)
                {
                    LoginRole.UserId = UserId;
                    LoginRole.Save();
                }
            }

            return UserId;
        }

        public virtual bool ChangePasswordFirstTime(string newpassword)
        {
            if (!string.IsNullOrWhiteSpace(newpassword))
                return ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").ChangePasswordFirstTime(UserId, false, newpassword);

            return false;
        }
        public virtual bool ChangePassword(string newpassword)
        {
            if (!string.IsNullOrWhiteSpace(newpassword))
                return ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").ChangePasswordFirstTime(UserId, true, newpassword);

            return false;
        }
    }
}
