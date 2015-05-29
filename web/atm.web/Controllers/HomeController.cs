using System;
using System.Collections.Generic;
using System.Web.Mvc;
using SevenH.MMCSB.Atm.Domain;


namespace SevenH.MMCSB.Atm.Web.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var acq = new Acquisition().GetAcquisition(9);

            return View();
        }

    }
}