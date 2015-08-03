using System.Web.Mvc;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Web.Models;

namespace SevenH.MMCSB.Atm.Web.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Account", "Public");

            return RedirectToAction("Login", "Account");

            var vm = new HomeViewModel();
            vm.ListOfAdvertisment.AddRange(ObjectBuilder.GetObject<IAdvertismentPersistance>("AdvertismentPersistance").GetAdvertisments(true, null));
            return View(vm);
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