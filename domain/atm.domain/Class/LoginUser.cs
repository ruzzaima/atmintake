using System;
using Bespoke.Sph.Domain;

namespace SevenH.MMCSB.Atm.Domain
{
    [EntityType(typeof(UserProfile))]
    public class LoginUser : UserProfile
    {
        public int? ApplicantId { set; get; }
        public int UserId { set; get; }
        public string LoginId { set; get; }
        public string Salt { set; get; }
        public string Status { set; get; }
        public bool IsLocked { set; get; }
        public bool FirstTime { set; get; }
        public string AlternativeEmail { set; get; }
        public string ServiceCd { set; get; }
        public string ServiceName { set; get; }
        public DateTime? LastLoginDt { set; get; }
        public DateTime? LastLoginDt2 { set; get; }

    }
}
