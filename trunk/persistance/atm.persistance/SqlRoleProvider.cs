using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Atm.Entity.Persistance
{
    public class SqlRoleProvider : RoleProvider, IRoleProvider
    {
        public void DeleteRoles(LoginUser user, List<string> roles)
        {
            using (var entities = new atmEntities())
            {
                foreach (var exist in roles.Select(role => (from a in entities.tblUserRoles where a.UserId == user.UserId select a).SingleOrDefault()).Where(exist => null != exist))
                {
                    entities.tblUserRoles.Remove(exist);
                    entities.SaveChanges();
                }
            }
        }

        public bool CheckUserIsInRole(string username, string role)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblUsers where a.LoginId == username select a).SingleOrDefault();
                if (null != exist)
                {
                    var r = (from a in entities.tblUserRoles where a.UserId == exist.UserId select a).SingleOrDefault();
                    if (null != r)
                    {
                        if (!string.IsNullOrWhiteSpace(r.Roles))
                            return r.Roles.Contains(role);
                    }
                }
            }
            return false;
        }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
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

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblUsers where a.LoginId == username select a).SingleOrDefault();
                if (null != exist)
                {
                    var r = (from a in entities.tblUserRoles where a.UserId == exist.UserId select a).SingleOrDefault();
                    if (null != r)
                    {
                        if (!string.IsNullOrWhiteSpace(r.Roles))
                            return r.Roles.Split(',').ToArray();
                    }
                }
            }
            return new[] { RolesString.AWAM };
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblUsers where a.LoginId == username select a).SingleOrDefault();
                if (null != exist)
                {
                    var r = (from a in entities.tblUserRoles where a.UserId == exist.UserId select a).SingleOrDefault();
                    if (null != r)
                    {
                        if (!string.IsNullOrWhiteSpace(r.Roles))
                            return r.Roles.Contains(roleName);
                    }
                }
            }
            return false;
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }

        public int AddRoles(int userid, string roles)
        {
            if (userid == 0 && string.IsNullOrWhiteSpace(roles)) return 0;
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblUserRoles where a.UserId == userid select a).SingleOrDefault();
                if (null != exist)
                {
                    exist.Roles = roles;
                    entities.SaveChanges();
                    return 1;
                }
                // new record
                var r = new tblUserRole()
                {
                    UserId = userid,
                    Roles = roles
                };
                entities.tblUserRoles.Add(r);
                if (entities.SaveChanges() > 0)
                    return r.UserId;
            }
            return 0;
        }
    }
}
