using System.Web.Mvc;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Web.Models;

namespace SevenH.MMCSB.Atm.Web.Controllers
{
    [AllowAnonymous]
    public class AtmHomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Account", "Public");

            var vm = new HomeViewModel();
            vm.ListOfAdvertisment.AddRange(ObjectBuilder.GetObject<IAdvertismentPersistance>(Strings.ADVERTISMENT_PERSISTANCE).GetAdvertisments(true, null));
            return View(vm);
        }

        public ActionResult Advertisment(int id)
        {
            var ad = ObjectBuilder.GetObject<IAdvertismentPersistance>(Strings.ADVERTISMENT_PERSISTANCE).GetById(id);
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