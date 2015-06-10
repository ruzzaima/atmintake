using SevenH.MMCSB.Atm.Domain.Interface;
using Spring.Context.Support;
using Spring.Objects.Factory;

namespace SevenH.MMCSB.Atm.Domain
{
    public partial class LoginUser : DomainObject
    {

        private ILoginUserPersistance _mPersistence;

        public virtual ILoginUserPersistance PersistanceLayer
        {
            get
            {
                if (((_mPersistence == null)))
                {
                    var ctx = ContextRegistry.GetContext();
                    _mPersistence = ((IObjectFactory)ctx).GetObject("LoginUserPersistance") as ILoginUserPersistance;
                }
                return _mPersistence;
            }
            set { _mPersistence = value; }
        }

        public virtual int Save()
        {
            if (UserId == 0)
                return PersistanceLayer.AddNew(this);
            return PersistanceLayer.Update(this);
        }

        public virtual bool ChangePasswordFirstTime(string newpassword)
        {
            if (!string.IsNullOrWhiteSpace(newpassword))
                return PersistanceLayer.ChangePassword(UserId, newpassword);

            return false;
        }
    }
}
