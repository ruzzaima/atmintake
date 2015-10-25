using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Security;
using SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Atm.Entity.Persistance
{
    public class SqlMembershipProvider : MembershipProvider, IMembershipProvider
    {
        public int Update(LoginUser user, List<string> messages)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblUsers where a.UserId == user.UserId select a).SingleOrDefault();
                if (null == exist) return 0;
                exist.AlternativeEmail = user.AlternativeEmail;
                exist.ApplicantId = user.ApplicantId;
                exist.Email = user.Email;
                exist.ModifiedBy = user.ModifiedBy;
                exist.ModifiedDt = DateTime.Now;
                exist.ServiceCd = user.ServiceCd;
                exist.IsLocked = user.IsLocked;
                exist.LastLoginDt = user.LastLoginDt;
                exist.FirstTime = user.FirstTime;
                exist.FullName = user.FullName;
                exist.Salt = user.Salt;
                entities.SaveChanges();
                return exist.UserId;
            }

        }

        public bool CustomChangePassword(string username, string oldpassword, string newpassword)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblUsers where a.LoginId == username select a).SingleOrDefault();
                if (null != exist)
                {
                    if (exist.Password != oldpassword)
                        return false;

                    exist.Password = newpassword;
                    exist.ModifiedDt = DateTime.Now;
                    if (entities.SaveChanges() > 0)
                        return true;

                }
            }
            return false;
        }

        public bool CustomResetPassword(string username, string password)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblUsers where a.LoginId == username select a).SingleOrDefault();
                if (null != exist)
                {
                    exist.Password = password;
                    exist.ModifiedDt = DateTime.Now;
                    if (entities.SaveChanges() > 0)
                        return true;

                }
            }
            return false;
        }

        public int CreateNewUser(LoginUser user, List<string> messages)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblUsers where a.LoginId == user.LoginId select a).SingleOrDefault();
                if (null != exist) return 0;
                var usr = new tblUser
                {
                    AlternativeEmail = user.AlternativeEmail,
                    ApplicantId = user.ApplicantId,
                    CreatedBy = user.CreatedBy,
                    CreatedDt = DateTime.Now,
                    FullName = user.FullName,
                    FirstTime = user.FirstTime,
                    Email = user.Email,
                    IsLocked = user.IsLocked,
                    LastLoginDt = user.LastLoginDt,
                    LoginId = user.LoginId,
                    Password = ObjectBuilder.GetObject<ICryptorService>("CryptorService").ComputeHashInString(user.Salt, user.Password),
                    Salt = user.Salt,
                    ServiceCd = user.ServiceCd,
                    UserName = user.UserName
                };

                if (entities.SaveChanges() > 0)
                {
                    messages.Add("Berjaya");
                    return usr.UserId;
                }
                messages.Add("Tidak Berjaya");
            }
            return 0;
        }

        public int CreateNew(LoginUser user, List<string> messages)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblUsers where a.LoginId == user.LoginId select a).SingleOrDefault();
                if (null != exist) return 0;
                var usr = new tblUser
                {
                    AlternativeEmail = user.AlternativeEmail,
                    ApplicantId = user.ApplicantId,
                    CreatedBy = user.CreatedBy,
                    CreatedDt = DateTime.Now,
                    FullName = user.FullName,
                    FirstTime = user.FirstTime,
                    Email = user.Email,
                    IsLocked = user.IsLocked,
                    LastLoginDt = user.LastLoginDt,
                    LoginId = user.LoginId,
                    Password = ObjectBuilder.GetObject<ICryptorService>("CryptorService").ComputeHashInString(user.Salt, user.Password),
                    Salt = user.Salt,
                    ServiceCd = user.ServiceCd,
                    UserName = user.UserName
                };

                if (entities.SaveChanges() > 0)
                {
                    messages.Add("Berjaya");
                    return usr.UserId;
                }
                messages.Add("Tidak Berjaya");
            }
            return 0;
        }

        public bool VerifyUser(string username, string guid)
        {
            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(guid))
            {
                using (var entities = new atmEntities())
                {
                    var exist = (from a in entities.tblUsers where a.LoginId == username select a).SingleOrDefault();
                    if (null != exist)
                    {
                        if (exist.Salt == guid) return true;
                    }
                }
            }
            return false;
        }

        public int CreateNewUserVerification(string username, string guid)
        {
            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(guid))
            {
                using (var entities = new atmEntities())
                {
                    var exist = (from a in entities.tblUsers where a.LoginId == username select a).SingleOrDefault();
                    if (null != exist)
                    {
                        exist.Salt = guid;
                        exist.ModifiedDt = DateTime.Now;
                        entities.SaveChanges();
                        return exist.UserId;
                    }
                }
            }
            return 0;
        }

        public bool DeleteUser(LoginUser user)
        {
            if (!string.IsNullOrWhiteSpace(user.LoginId))
            {
                using (var entities = new atmEntities())
                {
                    var exist = (from a in entities.tblUsers where a.LoginId == user.LoginId select a).SingleOrDefault();
                    if (null != exist)
                    {
                        entities.tblUsers.Remove(exist);
                        return entities.SaveChanges() > 0;
                    }
                }
            }
            return false;
        }

        public List<LoginUser> LoadAll()
        {
            var list = new List<LoginUser>();
            using (var entities = new atmEntities())
            {
                var l = from a in entities.tblUsers select a;
                if (l.Any())
                {
                    foreach (var user in l)
                    {
                        var usr = new LoginUser
                        {
                            AlternativeEmail = user.AlternativeEmail,
                            ApplicantId = user.ApplicantId,
                            CreatedBy = user.CreatedBy,
                            CreatedDt = user.CreatedDt,
                            LoginId = user.LoginId,
                            UserId = user.UserId,
                            ModifiedBy = user.ModifiedBy,
                            ModifiedDt = user.ModifiedDt,
                            Salt = user.Password,
                            ServiceCd = user.ServiceCd,
                            Status = user.IsLocked.HasValue ? user.IsLocked.Value ? "Aktif" : "Tidak Aktif" : "Aktif",
                            UserName = user.UserName,
                            Email = user.Email,
                            FirstTime = user.FirstTime ?? false,
                            FullName = user.FullName,
                            IsLocked = user.IsLocked ?? false,
                            LastLoginDt = user.LastLoginDt
                        };

                        if (!string.IsNullOrWhiteSpace(user.ServiceCd))
                        {
                            var svc = (from a in entities.tblREFServices where a.ServiceCd == user.ServiceCd select a).SingleOrDefault();
                            if (null != svc)
                                usr.ServiceName = svc.Service;
                        }

                        var role = (from a in entities.tblUserRoles where a.UserId == user.UserId select a).SingleOrDefault();
                        if (null != role)
                        {
                            usr.LoginRole = new LoginRole
                            {
                                UserId = usr.UserId,
                                Roles = role.Roles
                            };
                        }


                        list.Add(usr);
                    }
                }
            }
            return list;
        }

        public LoginUser LoadByUserName(string username)
        {
            if (!string.IsNullOrWhiteSpace(username))
            {
                using (var entities = new atmEntities())
                {
                    var user = (from a in entities.tblUsers where a.LoginId == username select a).SingleOrDefault();
                    if (null != user)
                    {
                        var usr = new LoginUser
                        {
                            AlternativeEmail = user.AlternativeEmail,
                            ApplicantId = user.ApplicantId,
                            CreatedBy = user.CreatedBy,
                            CreatedDt = user.CreatedDt,
                            LoginId = user.LoginId,
                            UserId = user.UserId,
                            ModifiedBy = user.ModifiedBy,
                            ModifiedDt = user.ModifiedDt,
                            Salt = user.Password,
                            ServiceCd = user.ServiceCd,
                            Status = user.IsLocked.HasValue ? user.IsLocked.Value ? "Aktif" : "Tidak Aktif" : "Aktif",
                            UserName = user.UserName,
                            Email = user.Email,
                            FirstTime = user.FirstTime ?? false,
                            FullName = user.FullName,
                            IsLocked = user.IsLocked ?? false,
                            LastLoginDt = user.LastLoginDt
                        };

                        if (!string.IsNullOrWhiteSpace(user.ServiceCd))
                        {
                            var svc = (from a in entities.tblREFServices where a.ServiceCd == user.ServiceCd select a).SingleOrDefault();
                            if (null != svc)
                                usr.ServiceName = svc.Service;
                        }

                        var role = (from a in entities.tblUserRoles where a.UserId == user.UserId select a).SingleOrDefault();
                        if (null != role)
                        {
                            usr.LoginRole = new LoginRole
                            {
                                UserId = usr.UserId,
                                Roles = role.Roles
                            };
                        }
                        return usr;
                    }
                }
            }
            return null;
        }

        public LoginUser LoadById(int id)
        {
            if (id != 0)
            {
                using (var entities = new atmEntities())
                {
                    var user = (from a in entities.tblUsers where a.UserId == id select a).SingleOrDefault();
                    if (null != user)
                    {
                        var usr = new LoginUser
                        {
                            AlternativeEmail = user.AlternativeEmail,
                            ApplicantId = user.ApplicantId,
                            CreatedBy = user.CreatedBy,
                            CreatedDt = user.CreatedDt,
                            LoginId = user.LoginId,
                            UserId = user.UserId,
                            ModifiedBy = user.ModifiedBy,
                            ModifiedDt = user.ModifiedDt,
                            Salt = user.Password,
                            ServiceCd = user.ServiceCd,
                            Status = user.IsLocked.HasValue ? user.IsLocked.Value ? "Aktif" : "Tidak Aktif" : "Aktif",
                            UserName = user.UserName,
                            Email = user.Email,
                            FirstTime = user.FirstTime ?? false,
                            FullName = user.FullName,
                            IsLocked = user.IsLocked ?? false,
                            LastLoginDt = user.LastLoginDt
                        };

                        if (!string.IsNullOrWhiteSpace(user.ServiceCd))
                        {
                            var svc = (from a in entities.tblREFServices where a.ServiceCd == user.ServiceCd select a).SingleOrDefault();
                            if (null != svc)
                                usr.ServiceName = svc.Service;
                        }

                        var role = (from a in entities.tblUserRoles where a.UserId == user.UserId select a).SingleOrDefault();
                        if (null != role)
                        {
                            usr.LoginRole = new LoginRole
                            {
                                UserId = usr.UserId,
                                Roles = role.Roles
                            };
                        }
                        return usr;
                    }
                }
            }
            return null;
        }

        public IEnumerable<LoginUser> LoadAllByStatus(string status)
        {
            var list = new List<LoginUser>();
            using (var entities = new atmEntities())
            {
                var islock = status == "Aktif";
                var l = from a in entities.tblUsers where a.IsLocked == islock select a;
                if (l.Any())
                {
                    foreach (var user in l)
                    {
                        var usr = new LoginUser
                        {
                            AlternativeEmail = user.AlternativeEmail,
                            ApplicantId = user.ApplicantId,
                            CreatedBy = user.CreatedBy,
                            CreatedDt = user.CreatedDt,
                            LoginId = user.LoginId,
                            UserId = user.UserId,
                            ModifiedBy = user.ModifiedBy,
                            ModifiedDt = user.ModifiedDt,
                            Salt = user.Password,
                            ServiceCd = user.ServiceCd,
                            Status = user.IsLocked.HasValue ? user.IsLocked.Value ? "Aktif" : "Tidak Aktif" : "Aktif",
                            UserName = user.UserName,
                            Email = user.Email,
                            FirstTime = user.FirstTime ?? false,
                            FullName = user.FullName,
                            IsLocked = user.IsLocked ?? false,
                            LastLoginDt = user.LastLoginDt
                        };

                        if (!string.IsNullOrWhiteSpace(user.ServiceCd))
                        {
                            var svc = (from a in entities.tblREFServices where a.ServiceCd == user.ServiceCd select a).SingleOrDefault();
                            if (null != svc)
                                usr.ServiceName = svc.Service;
                        }

                        var role = (from a in entities.tblUserRoles where a.UserId == user.UserId select a).SingleOrDefault();
                        if (null != role)
                        {
                            usr.LoginRole = new LoginRole
                            {
                                UserId = usr.UserId,
                                Roles = role.Roles
                            };
                        }


                        list.Add(usr);
                    }
                }
            }
            return list;
        }

        public IEnumerable<LoginUser> LoadAllIsOnline()
        {
            throw new NotImplementedException();
        }

        public bool IsExist(string username)
        {
            if (!string.IsNullOrWhiteSpace(username))
            {
                using (var entities = new atmEntities())
                {
                    var exist = (from a in entities.tblUsers where a.LoginId == username select a).SingleOrDefault();
                    if (null != exist)
                        return true;
                }
            }
            return false;
        }

        public bool IsOauthExist(string username)
        {
            throw new NotImplementedException();
        }

        public int AddNewOauthProfile(string username)
        {
            throw new NotImplementedException();
        }

        public bool IsOnline(string username)
        {
            throw new NotImplementedException();
        }

        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblUsers where a.LoginId == username select a).SingleOrDefault();
                if (null != exist)
                {
                    if (exist.Password != oldPassword)
                        return false;

                    exist.Password = newPassword;
                    exist.ModifiedDt = DateTime.Now;
                    if (entities.SaveChanges() > 0)
                        return true;

                }
            }
            return false;
        }

        public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer)
        {
            throw new NotImplementedException();
        }

        public override MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out MembershipCreateStatus status)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteUser(string username, bool deleteAllRelatedData)
        {
            throw new NotImplementedException();
        }

        public override bool EnablePasswordReset
        {
            get { throw new NotImplementedException(); }
        }

        public override bool EnablePasswordRetrieval
        {
            get { throw new NotImplementedException(); }
        }

        public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
        }

        public override MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
        }

        public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
        }

        public override int GetNumberOfUsersOnline()
        {
            throw new NotImplementedException();
        }

        public override string GetPassword(string username, string answer)
        {
            throw new NotImplementedException();
        }

        public override MembershipUser GetUser(string username, bool userIsOnline)
        {
            throw new NotImplementedException();
        }

        public override MembershipUser GetUser(object providerUserKey, bool userIsOnline)
        {
            throw new NotImplementedException();
        }

        public override string GetUserNameByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public override int MaxInvalidPasswordAttempts
        {
            get { throw new NotImplementedException(); }
        }

        public override int MinRequiredNonAlphanumericCharacters
        {
            get { throw new NotImplementedException(); }
        }

        public override int MinRequiredPasswordLength
        {
            get { throw new NotImplementedException(); }
        }

        public override int PasswordAttemptWindow
        {
            get { throw new NotImplementedException(); }
        }

        public override MembershipPasswordFormat PasswordFormat
        {
            get { throw new NotImplementedException(); }
        }

        public override string PasswordStrengthRegularExpression
        {
            get { throw new NotImplementedException(); }
        }

        public override bool RequiresQuestionAndAnswer
        {
            get { throw new NotImplementedException(); }
        }

        public override bool RequiresUniqueEmail
        {
            get { throw new NotImplementedException(); }
        }

        public override string ResetPassword(string username, string answer)
        {
            throw new NotImplementedException();
        }

        public override bool UnlockUser(string userName)
        {
            if (!string.IsNullOrWhiteSpace(userName))
            {
                using (var entities = new atmEntities())
                {
                    var exist = (from a in entities.tblUsers where a.LoginId == userName select a).SingleOrDefault();
                    if (null != exist)
                    {
                        exist.IsLocked = false;
                        exist.ModifiedDt = DateTime.Now;
                        return entities.SaveChanges() > 0;
                    }
                }
            }
            return false;
        }

        public override void UpdateUser(MembershipUser user)
        {
            throw new NotImplementedException();
        }

        public override bool ValidateUser(string username, string password)
        {
            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                using (var entities = new atmEntities())
                {
                    var exist = (from a in entities.tblUsers where a.LoginId == username select a).SingleOrDefault();
                    if (null != exist)
                    {
                        var hasspassword = ObjectBuilder.GetObject<ICryptorService>("CryptorService").ComputeHashInString(exist.Salt, password);
                        if (exist.Password == hasspassword) return true;
                    }
                }
            }
            return false;
        }
    }
}
