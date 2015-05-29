using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SevenH.MMCSB.Atm.Web
{
    public class PublicController : Controller
    {
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Account()
        {
            return View();
        }

        public ActionResult Resume()
        {
            return View();
        }

        public ActionResult Application()
        {
            return View();
        }

        // checking existing in applicant table and ATM database based on IC
        public ActionResult IsExist(string mykadno)
        {
            return Json(new { OK = false, message = "Tidak Wujud" });
        }
    }
}