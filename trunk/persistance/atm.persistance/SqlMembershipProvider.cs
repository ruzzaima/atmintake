using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Atm.Entity.Persistance
{
    public class SqlMembershipProvider : MembershipProvider, IMembershipProvider
    {
        public int Update(LoginUser user, List<string> messages)
        {
            throw new NotImplementedException();
        }

        public bool CustomChangePassword(string username, string oldpassword, string newpassword)
        {
            throw new NotImplementedException();
        }

        public bool CustomResetPassword(string username, string password)
        {
            throw new NotImplementedException();
        }

        public int CreateNewUser(LoginUser user, List<string> messages)
        {
            throw new NotImplementedException();
        }

        public int CreateNew(LoginUser user, List<string> messages)
        {
            throw new NotImplementedException();
        }

        public bool VerifyUser(string username, string guid)
        {
            throw new NotImplementedException();
        }

        public int CreateNewUserVerification(string username, string guid)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(LoginUser user)
        {
            throw new NotImplementedException();
        }

        public List<LoginUser> LoadAll()
        {
            throw new NotImplementedException();
        }

        public LoginUser LoadByUserName(string username)
        {
            throw new NotImplementedException();
        }

        public LoginUser LoadById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LoginUser> LoadAllByStatus(string status)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LoginUser> LoadAllIsOnline()
        {
            throw new NotImplementedException();
        }

        public bool IsExist(string username)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public override void UpdateUser(MembershipUser user)
        {
            throw new NotImplementedException();
        }

        public override bool ValidateUser(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
