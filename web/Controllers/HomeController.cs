using System.Web.Mvc;
using SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Atm.Web.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Account", "Public");

            return RedirectToAction("Login", "Account");;
        }

        public ActionResult Advertisment(int id)
        {
            var ad = ObjectBuilder.GetObject<IAdvertismentPersistance>("AdvertismentPersistance").GetById(id);
            if (ad != null)
            {
                return View(ad);
            }
            return View(new Advertisment());
        }
        public ActionResult CheckStatus()
        {
            return View();
        }
    }
}