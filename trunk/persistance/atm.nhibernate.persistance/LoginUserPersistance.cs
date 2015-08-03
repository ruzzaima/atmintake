﻿using System.Data;
using NHibernate;
using NHibernate.Engine;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Persistance
{
    public class LoginUserPersistance : ILoginUserPersistance
    {
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
                exist.Email = loginUser.Email;
                exist.AlternativeEmail = loginUser.AlternativeEmail;
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

            Factory.OpenSession().Flush();
            return false;
        }

        public LoginUser GetByUserName(string username)
        {
            var exist = Factory.OpenSession().QueryOver<LoginUser>().Where(a => a.LoginId == username).SingleOrDefault();
            Factory.OpenSession().Flush();
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
            Factory.OpenSession().Flush();
            return false;
        }


        public LoginUser GetByIdNumber(string idnumber)
        {
            var exist = Factory.OpenSession().QueryOver<LoginUser>().Where(a => a.LoginId == idnumber).SingleOrDefault();
            Factory.OpenSession().Flush();
            return exist;
        }
    }
}