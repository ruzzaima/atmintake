using System;
using SevenH.MMCSB.Atm.Domain.Interface;
using Spring.Context.Support;
using Spring.Objects.Factory;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class LoginUser : DomainObject
    {
        public virtual LoginRole LoginRole { get; set; }

        public virtual int Save()
        {
            if (UserId == 0)
                return ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").AddNew(this);
            return ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").Update(this);
        }

        public virtual bool ChangePasswordFirstTime(string newpassword)
        {
            if (!string.IsNullOrWhiteSpace(newpassword))
                return ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").ChangePassword(UserId, newpassword);

            return false;
        }
    }
}
