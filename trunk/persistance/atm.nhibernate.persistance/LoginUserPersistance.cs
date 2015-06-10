using System.Data;
using NHibernate;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Persistance
{
    public class LoginUserPersistance : ILoginUserPersistance
    {
        private static ISession _mSession;
        public ISession Session
        {
            get
            {
                if ((_mSession == null))
                {
                    _mSession = Factory.OpenSession();
                }
                if (_mSession.Connection.State == ConnectionState.Closed)
                {
                    _mSession.Connection.Open();
                }

                return _mSession;
            }
        }

        public int AddNew(LoginUser loginUser)
        {
            Factory.OpenSession().Save(loginUser);
            Factory.OpenSession().Flush();
            return loginUser.UserId;
        }

        public int Update(LoginUser loginUser)
        {
            var exist = Factory.OpenSession().QueryOver<LoginUser>().Where(a => a.LoginId == loginUser.LoginId).SingleOrDefault();
            if (null != exist)
            {
                exist.ApplicantId = loginUser.ApplicantId;
                exist.LastLoginDt = loginUser.LastLoginDt;
                exist.ServiceCd = loginUser.ServiceCd;
                exist.IsLocked = loginUser.IsLocked;
                Factory.OpenSession().SaveOrUpdate(exist);
                Factory.OpenSession().Flush();
            }
            return loginUser.UserId;
        }

        public bool Validate(string username, string password)
        {
            var exist = Factory.OpenSession().QueryOver<LoginUser>().Where(a => a.LoginId == username).SingleOrDefault();
            if (null != exist)
            {
                if (exist.Password == password)
                    return true;
            }

            return false;
        }

        public LoginUser GetByUserName(string username)
        {
            var exist = Factory.OpenSession().QueryOver<LoginUser>().Where(a => a.LoginId == username).SingleOrDefault();
            return exist;
        }

        public bool ChangePassword(int loginid, string newpassword)
        {
            var exist = Factory.OpenSession().QueryOver<LoginUser>().Where(a => a.UserId == loginid).SingleOrDefault();
            if (null != exist)
            {
                exist.Password = newpassword;
                Factory.OpenSession().SaveOrUpdate(exist);
                Factory.OpenSession().Flush();
                return true;
            }
            return false;
        }
    }
}
