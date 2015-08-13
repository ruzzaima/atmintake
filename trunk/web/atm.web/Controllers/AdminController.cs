using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;
using SevenH.MMCSB.Atm.Web.Models;

namespace SevenH.MMCSB.Atm.Web.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            var did = 0;
            if (Session["SelectedAcquisition"] == null)
                return RedirectToAction("Intakes");
            if (Session["SelectedAcquisition"] != null)
            {
                var acqid = Session["SelectedAcquisition"].ToString();
                if (!string.IsNullOrWhiteSpace(acqid))
                {
                    int.TryParse(acqid, out did);
                    if (did == 0)
                        return RedirectToAction("Intakes");
                }
            }

            var vm = new DashboardViewModel();
            vm.Acquisition = ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetAcquisition(did);
            return View(vm);
        }

        public ActionResult Intakes()
        {
            return View();
        }

        public ActionResult SetSelectedAcquisition(int acqid)
        {
            if (acqid != 0)
            {
                var pd = ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetAcquisition(acqid);
                if (null != pd)
                {
                    Session["SelectedAcquisition"] = pd.AcquisitionId;
                    return Json(new { OK = true, message = "Berjaya", name = "Siri " + pd.Siri + "/" + pd.Year + " " + pd.AcquisitionType.AcquisitionTypeNm });
                }
            }
            return Json(new { OK = false, message = "Tidak Berjaya", name = "" });
        }


        public ActionResult LoadIntakes(JQueryDataTableParamModel param)
        {
            var intakes = new List<Acquisition>();

            if (User.Identity.IsAuthenticated)
            {
                var usr = ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").GetByUserName(User.Identity.Name);
                if (null != usr)
                {
                    if (!string.IsNullOrWhiteSpace(usr.ServiceCd))
                        intakes.AddRange(ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetAllAcquisition(null, usr.ServiceCd).ToList());
                    else
                        intakes.AddRange(ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetAllAcquisition(null, string.Empty).ToList());
                }
            }

            var aadata = intakes.Select(a => new string[]
            {
                a.AcquisitionId.ToString(),
                a.AcquisitionType.AcquisitionTypeNm,
                a.Siri.HasValue && a.Year.HasValue ? a.Siri.Value.ToString() + "/" + a.Year.Value.ToString() : "NA", 
                a.CloseStatus.HasValue ?  a.CloseStatus.Value ? "Buka" : "Tutup" : "NA",
                a.AcquisitionId.ToString()
            });

            return Json(new
            {
                OK = true,
                message = "Succeed",
                sEcho = param.sEcho,
                iTotalRecords = intakes.Count(),
                iTotalDisplayRecords = intakes.Count(),
                aaData = aadata,
            }, JsonRequestBehavior.AllowGet);
        }

    }
}