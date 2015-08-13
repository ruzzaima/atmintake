using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenH.MMCSB.Atm.Domain
{
    public static class LogStatusCodeString
    {
        public const string Create_User = "0";
        public const string Successful_Login = "1";
        public const string Invalid_Password = "2";
        public const string User_Locked = "3";
        public const string User_Logged_Out = "4";
        public const string Change_Password = "5";
    }
}
