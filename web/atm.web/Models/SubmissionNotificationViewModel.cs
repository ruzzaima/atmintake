using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SevenH.MMCSB.Atm.Web.Models
{
    public class SubmissionNotificationViewModel
    {
        public string Service { get; set; }
        public string Name { get; set; }
        public string IdNumber { get; set; }
        public DateTime RegisteredDateTime { get; set; }
        public string Siri { get; set; }
        public string Year { get; set; }

    }
}