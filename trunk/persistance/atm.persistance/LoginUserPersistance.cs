using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Atm.Entity.Persistance
{
    class LoginUserPersistance : ILoginUserPersistance
    {
        public int AddNew(LoginUser loginUser)
        {
            if (null != loginUser)
            {
                using (var entities = new atmEntities())
                {
                    var u = new tblUser()
                    {
                        UserName = loginUser.UserName,
                        AlternativeEmail = loginUser.AlternativeEmail,
                        ApplicantId = loginUser.ApplicantId,
                        Email = loginUser.Email,
                        FullName = loginUser.FullName,
                        Password = loginUser.Password,
                        Salt = loginUser.Salt,
                        LoginId = loginUser.LoginId,
                        FirstTime = loginUser.FirstTime,
                        IsLocked = loginUser.IsLocked,
                        LastLoginDt = loginUser.LastLoginDt,
                        ServiceCd = loginUser.ServiceCd,
                        CreatedBy = loginUser.CreatedBy,
                        CreatedDt = loginUser.CreatedDt ?? DateTime.Now,
                        ModifiedBy = loginUser.ModifiedBy,
                        ModifiedDt = loginUser.ModifiedDt
                    };

                    entities.tblUsers.Add(u);
                    if (entities.SaveChanges() != 0)
                        return u.UserId;
                }
            }
            return 0;
        }

        public int Update(LoginUser loginUser)
        {
            if (null != loginUser)
            {
                using (var entities = new atmEntities())
                {
                    var exist = (from a in entities.tblUsers where a.UserId == loginUser.UserId select a).SingleOrDefault();
                    if (null != exist)
                    {
                        exist.UserName = loginUser.UserName;
                        exist.ServiceCd = loginUser.ServiceCd;
                        exist.ModifiedBy = loginUser.ModifiedBy;
                        exist.ModifiedDt = DateTime.Now;
                        exist.IsLocked = loginUser.IsLocked;
                        exist.LastLoginDt = loginUser.LastLoginDt;
                        exist.FullName = loginUser.FullName;
                        exist.AlternativeEmail = loginUser.AlternativeEmail;
                        exist.Email = loginUser.Email;
                        exist.FirstTime = loginUser.FirstTime;

                        entities.SaveChanges();

                        return exist.UserId;
                    }
                }
            }
            return 0;
        }

        public bool Validate(string username, string password)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblUsers where a.LoginId == username select a).SingleOrDefault();
                if (null != exist)
                    return exist.Password == password;
            }
            return false;
        }

        public bool ChangePassword(int loginid, string newpassword)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblUsers where a.UserId == loginid select a).SingleOrDefault();
                if (null != exist)
                {
                    exist.Password = newpassword;
                    exist.ModifiedDt = DateTime.Now;

                    return entities.SaveChanges() > 0;
                }
            }
            return false;
        }

        public LoginUser GetByUserName(string username)
        {
            if (!string.IsNullOrWhiteSpace(username))
            {
                using (var entities = new atmEntities())
                {
                    var exist = (from a in entities.tblUsers where a.LoginId == username select a).SingleOrDefault();
                    if (null != exist)
                    {
                        var log = new LoginUser()
                        {
                            UserId = exist.UserId,
                            Email = exist.Email,
                            LoginId = exist.LoginId,
                            ModifiedBy = exist.ModifiedBy,
                            CreatedDt = exist.CreatedDt,
                            CreatedBy = exist.CreatedBy,
                            FirstTime = exist.FirstTime ?? false,
                            FullName = exist.FullName,
                            ApplicantId = exist.ApplicantId,
                            AlternativeEmail = exist.AlternativeEmail,
                            IsLocked = exist.IsLocked ?? false,
                            LastLoginDt = exist.LastLoginDt,
                            ModifiedDt = exist.ModifiedDt,
                            ServiceCd = exist.ServiceCd,
                            UserName = exist.UserName
                        };

                        if (!string.IsNullOrWhiteSpace(exist.ServiceCd))
                        {
                            var svc = (from a in entities.tblREFServices where a.ServiceCd == exist.ServiceCd select a).SingleOrDefault();
                            if (null != svc)
                                log.ServiceName = svc.Service;
                        }

                        var rol = (from a in entities.tblUserRoles where a.UserId == exist.UserId select a).SingleOrDefault();
                        if (null != rol)
                        {
                            log.LoginRole = new LoginRole()
                            {
                                UserId = rol.UserId,
                                Roles = rol.Roles
                            };
                        }

                        return log;
                    }
                }
            }
            return null;
        }

        public LoginUser GetByIdNumber(string username)
        {
            if (!string.IsNullOrWhiteSpace(username))
            {
                using (var entities = new atmEntities())
                {
                    var exist = (from a in entities.tblUsers where a.LoginId == username select a).SingleOrDefault();
                    if (null != exist)
                    {
                        var log = new LoginUser()
                        {
                            UserId = exist.UserId,
                            Email = exist.Email,
                            LoginId = exist.LoginId,
                            ModifiedBy = exist.ModifiedBy,
                            CreatedDt = exist.CreatedDt,
                            CreatedBy = exist.CreatedBy,
                            FirstTime = exist.FirstTime ?? false,
                            FullName = exist.FullName,
                            ApplicantId = exist.ApplicantId,
                            AlternativeEmail = exist.AlternativeEmail,
                            IsLocked = exist.IsLocked ?? false,
                            LastLoginDt = exist.LastLoginDt,
                            ModifiedDt = exist.ModifiedDt,
                            ServiceCd = exist.ServiceCd,
                            UserName = exist.UserName
                        };

                        if (!string.IsNullOrWhiteSpace(exist.ServiceCd))
                        {
                            var svc = (from a in entities.tblREFServices where a.ServiceCd == exist.ServiceCd select a).SingleOrDefault();
                            if (null != svc)
                                log.ServiceName = svc.Service;
                        }

                        var rol = (from a in entities.tblUserRoles where a.UserId == exist.UserId select a).SingleOrDefault();
                        if (null != rol)
                        {
                            log.LoginRole = new LoginRole()
                            {
                                UserId = rol.UserId,
                                Roles = rol.Roles
                            };
                        }

                        return log;
                    }
                }
            }
            return null;
        }

        public IEnumerable<LoginUser> LoadAllUser(bool internaluser, bool? isactive, string servicecode, string search)
        {
            var list = new List<LoginUser>();

            using (var entities = new atmEntities())
            {
                var l = from a in entities.tblUsers join b in entities.tblUserRoles on a.UserId equals b.UserId select new { user = a, role = b };

                //if (internaluser)
                //    l = l.Where(a => a.role != null);
                //if (isactive.HasValue)
                //    l = l.Where(a => a.user.IsLocked == isactive.Value);
                //if (!string.IsNullOrWhiteSpace(servicecode))
                //    l = l.Where(a => a.user.ServiceCd == servicecode);
                //if (!string.IsNullOrWhiteSpace(search))
                //    l = l.Where(a => a.user.FullName.Contains(search) || a.user.LoginId.Contains(search));

                if (l.Any())
                    foreach (var exist in l.ToList())
                    {
                        var log = new LoginUser()
                        {
                            UserId = exist.user.UserId,
                            Email = exist.user.Email,
                            LoginId = exist.user.LoginId,
                            ModifiedBy = exist.user.ModifiedBy,
                            CreatedDt = exist.user.CreatedDt,
                            CreatedBy = exist.user.CreatedBy,
                            FirstTime = exist.user.FirstTime ?? false,
                            FullName = exist.user.FullName,
                            ApplicantId = exist.user.ApplicantId,
                            AlternativeEmail = exist.user.AlternativeEmail,
                            IsLocked = exist.user.IsLocked ?? false,
                            LastLoginDt = exist.user.LastLoginDt,
                            ModifiedDt = exist.user.ModifiedDt,
                            ServiceCd = exist.user.ServiceCd,
                            UserName = exist.user.UserName
                        };

                        if (!string.IsNullOrWhiteSpace(exist.user.ServiceCd))
                        {
                            var svc = (from a in entities.tblREFServices where a.ServiceCd == exist.user.ServiceCd select a).SingleOrDefault();
                            if (null != svc)
                                log.ServiceName = svc.Service;
                        }

                        if (null != exist.role)
                        {
                            log.LoginRole = new LoginRole()
                            {
                                UserId = exist.role.UserId,
                                Roles = exist.role.Roles
                            };
                        }

                        list.Add(log);
                    }
            }

            return list;
        }


        public int LoggingUser(int userid, string statuscode, string by, DateTime bydate)
        {
            if (userid != 0 && !string.IsNullOrWhiteSpace(statuscode))
            {
                using (var entities = new atmEntities())
                {
                    var log = new tblUserLog()
                    {
                        UserId = userid,
                        LoginStatusCd = statuscode,
                        ModifiedBy = by,
                        ModifiedDt = DateTime.Now
                    };

                    entities.tblUserLogs.Add(log);
                    var id = entities.SaveChanges();
                    if (id != 0) return id;
                }
            }
            return 0;
        }


        public LoginUser GetById(int id)
        {
            if (id != 0)
            {
                using (var entities = new atmEntities())
                {
                    var exist = (from a in entities.tblUsers where a.UserId == id select a).SingleOrDefault();
                    if (null != exist)
                    {
                        var log = new LoginUser()
                        {
                            UserId = exist.UserId,
                            Email = exist.Email,
                            LoginId = exist.LoginId,
                            ModifiedBy = exist.ModifiedBy,
                            CreatedDt = exist.CreatedDt,
                            CreatedBy = exist.CreatedBy,
                            FirstTime = exist.FirstTime ?? false,
                            FullName = exist.FullName,
                            ApplicantId = exist.ApplicantId,
                            AlternativeEmail = exist.AlternativeEmail,
                            IsLocked = exist.IsLocked ?? false,
                            LastLoginDt = exist.LastLoginDt,
                            ModifiedDt = exist.ModifiedDt,
                            ServiceCd = exist.ServiceCd,
                            UserName = exist.UserName
                        };

                        if (!string.IsNullOrWhiteSpace(exist.ServiceCd))
                        {
                            var svc = (from a in entities.tblREFServices where a.ServiceCd == exist.ServiceCd select a).SingleOrDefault();
                            if (null != svc)
                                log.ServiceName = svc.Service;
                        }

                        var rol = (from a in entities.tblUserRoles where a.UserId == exist.UserId select a).SingleOrDefault();
                        if (null != rol)
                        {
                            log.LoginRole = new LoginRole()
                            {
                                UserId = rol.UserId,
                                Roles = rol.Roles
                            };
                        }

                        return log;
                    }
                }
            }
            return null;
        }
    }
}
