using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Security;
using SevenH.MMCSB.Atm.Domain;
using ConfigurationManager = System.Configuration.ConfigurationManager;

namespace atm.migration
{
    class Program
    {
        public const string AWAM = "Awam";
        public const string SUPER_ADMIN = "Super Admin";
        public const string PEGAWAI_PENGAMBILAN = "Pegawai Pengambilan";
        public const string KERANI_PENGAMBILAN = "Kerani Pengambilan";
        public const string STATISTIC = "STATISTIK";
        public const string HRMIS = "HRMIS";

        static void Main()
        {
            var users = new List<LoginUser>();
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sph"].ConnectionString))
            using (var cmd = new SqlCommand("SELECT * FROM tblUser", conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var us = new LoginUser()
                        {
                            Id = reader.GetInt32(0).ToString(),
                            ApplicantId = reader.GetNullableInt32(1),
                            LoginId = reader.GetString(2),
                            FullName = reader.GetString(3),
                            UserName = reader.GetString(4),
                            Email = reader.GetString(5),
                            AlternativeEmail = reader.GetString(6),
                            ServiceCd = reader.ToString(7),
                            Salt = reader.GetString(8),
                            WebId = reader.GetString(9), // PAssword
                            IsLockedOut = reader.GetBoolean(10),
                            FirstTime = reader.GetBoolean(11),
                            LastLoginDt = reader.GetNullableDateTime(12),
                            CreatedDate = reader.GetDateTime(13),
                            CreatedBy = reader.ToString(14),
                            ChangedDate = reader.GetNullableDateTime(15) ?? DateTime.Now,
                            ChangedBy = reader.ToString(16),
                            LastLoginDt2 = reader.GetNullableDateTime(17),
                            Designation = "Public"
                        };
                        users.Add(us);
                    }

                }

            }

            users.Where(x => x.Email.Length > 50).ToList().ForEach(x => Console.WriteLine(x.Id + " -->" + x.Email));
            users.Where(x => x.UserName.Length > 50).ToList().ForEach(x => Console.WriteLine(x.Id + " -->" + x.UserName));

            if (!Roles.RoleExists(AWAM))
                Roles.CreateRole(AWAM);
            if (!Roles.RoleExists(SUPER_ADMIN))
                Roles.CreateRole(SUPER_ADMIN);
            if (!Roles.RoleExists(PEGAWAI_PENGAMBILAN))
                Roles.CreateRole(PEGAWAI_PENGAMBILAN);
            if (!Roles.RoleExists(KERANI_PENGAMBILAN))
                Roles.CreateRole(KERANI_PENGAMBILAN);
            if (!Roles.RoleExists(STATISTIC))
                Roles.CreateRole(STATISTIC);
            if (!Roles.RoleExists(HRMIS))
                Roles.CreateRole(HRMIS);

            foreach (var u in users)
            {
                try
                {

                    var member = Membership.GetUserNameByEmail(u.Email);
                    var t = Membership.GetUser(u.UserName);
                    var exist = !string.IsNullOrEmpty(member) || null != t;
                    if (!exist)
                        Membership.CreateUser(u.UserName, u.WebId, u.Email);

                    if (!Roles.IsUserInRole(u.UserName, AWAM))
                        Roles.AddUserToRole(u.UserName, AWAM);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{u.UserName} -> {u.WebId} -> {u.Email}");
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine("DONE");
            Console.ReadLine();

        }
    }
}
