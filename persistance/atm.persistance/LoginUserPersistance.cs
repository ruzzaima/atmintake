using System;
using System.Collections.Generic;
using System.Linq;
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
                    // check existing
                    var exist = (from a in entities.tblUsers where a.LoginId == loginUser.LoginId select a).SingleOrDefault();
                    if (null != exist)
                    {
                        loginUser.UserId = exist.UserId;
                        return Update(loginUser);
                    }

                    var u = new tblUser
                    {
                        UserName = loginUser.UserName,
                        AlternativeEmail = loginUser.AlternativeEmail,
                        ApplicantId = loginUser.ApplicantId,
                        Email = loginUser.Email,
                        FullName = loginUser.FullName.ToUpper(),
                        Password = loginUser.Password,
                        Salt = loginUser.Salt,
                        LoginId = loginUser.LoginId,
                        FirstTime = loginUser.FirstTime,
                        IsLocked = loginUser.IsLocked,
                        LastLoginDt = loginUser.LastLoginDt,
                        LastLoginDt2 = loginUser.LastLoginDt2,
                        ServiceCd = loginUser.ServiceCd,
                        CreatedBy = loginUser.CreatedBy,
                        CreatedDt = DateTime.Now,
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
                        exist.LastLoginDt2 = loginUser.LastLoginDt2;
                        exist.FullName = loginUser.FullName.ToUpper();
                        exist.Email = loginUser.Email;
                        exist.AlternativeEmail = loginUser.AlternativeEmail;
                        exist.FirstTime = loginUser.FirstTime;
                        exist.ApplicantId = loginUser.ApplicantId;

                        if (loginUser.LoginRole != null)
                        {
                            if (loginUser.LoginRole.Roles != RolesString.AWAM)
                            {
                                // can update roles
                                var role = (from a in entities.tblUserRoles where a.UserId == loginUser.UserId select a).SingleOrDefault();
                                if (null != role)
                                {
                                    role.Roles = loginUser.LoginRole.Roles;
                                }
                            }
                        }

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
                        var log = new LoginUser
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
                            LastLoginDt2 = exist.LastLoginDt2,
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
                            log.LoginRole = new LoginRole
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
                        var log = new LoginUser
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
                            LastLoginDt2 = exist.LastLoginDt2,
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
                            log.LoginRole = new LoginRole
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

        public IEnumerable<LoginUser> LoadAllUser(bool internaluser, bool? isactive, string servicecode, string search, int? take, int? skip)
        {
            var list = new List<LoginUser>();

            using (var entities = new atmEntities())
            {
                var l = from a in entities.tblUsers select a;

                if (internaluser)
                    l = from c in entities.tblUsers join b in entities.tblUserRoles on c.UserId equals b.UserId select c;
                else
                {
                    var uroles = from a in entities.tblUserRoles select a;
                    if (uroles.Any())
                    {
                        var uss = uroles.Select(a => a.UserId).ToArray();
                        l = l.Where(a => !uss.Contains(a.UserId));
                    }
                }
                //if (isactive.HasValue)
                //    l = l.Where(a => a.user.IsLocked == isactive.Value);
                //if (!string.IsNullOrWhiteSpace(servicecode))
                //    l = l.Where(a => a.user.ServiceCd == servicecode);
                //if (skip.HasValue && skip.Value != 0)
                //    l = l.Skip(skip.Value);
                //if (take.HasValue)
                //    l = l.Take(take.Value);
                if (!string.IsNullOrWhiteSpace(search))
                    l = l.Where(a => a.FullName.Contains(search) || a.LoginId.Contains(search));

                if (l.Any())
                    foreach (var exist in l.ToList())
                    {
                        var log = new LoginUser
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
                            LastLoginDt2 = exist.LastLoginDt2,
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

                        if (internaluser)
                        {
                            var role = (from a in entities.tblUserRoles where a.UserId == exist.UserId select a).SingleOrDefault();
                            if (null != role)
                            {
                                log.LoginRole = new LoginRole
                                {
                                    UserId = role.UserId,
                                    Roles = role.Roles
                                };
                            }
                        }
                        else
                        {
                            log.LoginRole = new LoginRole
                            {
                                Roles = RolesString.AWAM
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
                    var log = new tblUserLog
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
                        var log = new LoginUser
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
                            LastLoginDt2 = exist.LastLoginDt2,
                            ModifiedDt = exist.ModifiedDt,
                            ServiceCd = exist.ServiceCd,
                            UserName = exist.UserName,
                            Status = exist.IsLocked.HasValue ? exist.IsLocked.Value ? "Tidak Aktif" : "Aktif" : "Aktif"
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
                            log.LoginRole = new LoginRole
                            {
                                UserId = rol.UserId,
                                Roles = rol.Roles
                            };
                        }
                        else
                        {
                            log.LoginRole = new LoginRole
                            {
                                Roles = RolesString.AWAM
                            };
                        }

                        return log;
                    }
                }
            }
            return null;
        }


        public bool ChangePasswordFirstTime(int loginid, bool firsttime, string newpassword)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblUsers where a.UserId == loginid select a).SingleOrDefault();
                if (null != exist)
                {
                    exist.Password = newpassword;
                    exist.FirstTime = firsttime;
                    exist.ModifiedDt = DateTime.Now;
                    return entities.SaveChanges() > 0;
                }
            }
            return false;
        }


        public bool Delete(int userid)
        {
            if (userid != 0)
            {
                using (var entities = new atmEntities())
                {
                    var user = (from a in entities.tblUsers where a.UserId == userid select a).SingleOrDefault();
                    if (null != user)
                    {
                        entities.tblUsers.Remove(user);
                        return entities.SaveChanges() > 0;
                    }
                }
            }
            return false;
        }
    }
}
