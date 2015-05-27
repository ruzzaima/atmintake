using System.Web.Mvc;
using SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Atm.Web.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
             var cd= new CodeItem();

            cd.Code = "aa";
            cd.Description = "bbbbbb";
            cd.Grouping = "ccccc";

            cd.Save();

            return View();
        }

    }
}