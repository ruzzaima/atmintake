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
            vm.Acquisition =
                ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetAcquisition(did);
            return View(vm);
        }

        public ActionResult Intakes()
        {
            return View();
        }

        public ActionResult AddApplicant()
        {
            return View();
        }

        public ActionResult SearchApplicant()
        {
            var vm = new AdminViewModel();
            var did = 0;
            if (Session["SelectedAcquisition"] == null)
                return RedirectToAction("Intakes", "Admin");
            if (Session["SelectedAcquisition"] != null)
            {
                var acqid = Session["SelectedAcquisition"].ToString();
                if (!string.IsNullOrWhiteSpace(acqid))
                {
                    int.TryParse(acqid, out did);
                    if (did == 0)
                        return RedirectToAction("Intakes", "Admin");

                    var acq =
                        ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetAcquisition(did);
                    if (null != acq)
                        vm.Acquisition = acq;
                }
            }
            return View(vm);
        }

        public ActionResult ExistingAtmMember()
        {
            return View();
        }

        public ActionResult AddExistingAtm()
        {
            return View();
        }

        public ActionResult SearchingAtmMember(JQueryDataTableParamModel param, string statuscode, string name, string icno, int armyno)
        {
            var applicants = ObjectBuilder.GetObject<IExistingAtmPersistance>("ExistingAtmPersistance").Search(statuscode, param.sSearch, armyno).ToList();
            if (!string.IsNullOrWhiteSpace(name))
            {
                applicants.Clear();
                applicants.AddRange(ObjectBuilder.GetObject<IExistingAtmPersistance>("ExistingAtmPersistance").Search(statuscode, name, armyno).ToList());
            }
            if (!string.IsNullOrWhiteSpace(icno))
            {
                applicants.Clear();
                applicants.AddRange(ObjectBuilder.GetObject<IExistingAtmPersistance>("ExistingAtmPersistance").Search(statuscode, icno, armyno).ToList());
            }

            var sortColumnIndex = Convert.ToInt32(Request["iSortCol_0"]);
            var sortDirection = Request["sSortDir_0"]; // asc or desc
            if (sortDirection == "asc")
                applicants = sortColumnIndex == 0 ? new List<ExistingMember>(applicants.OrderBy(a => a.Name)) : new List<ExistingMember>(applicants.OrderBy(a => a.IdNumber));
            else
                if (sortColumnIndex == 1)
                    applicants = new List<ExistingMember>(applicants.OrderByDescending(a => a.Name));
                else
                    applicants = new List<ExistingMember>(applicants.OrderByDescending(a => a.IdNumber));

            var applicantSubmitteds = applicants as IList<ExistingMember> ?? applicants.ToList();
            var aadata = applicantSubmitteds.Select(a => new string[]
            {
                a.CoId.ToString(),
                a.Name,
                a.IdNumber,
                a.ArmyNo.ToString(),
                a.CoId.ToString(),
                a.Status,
                a.CoId.ToString()
            }).ToList().Skip(param.iDisplayStart).Take(param.iDisplayLength);

            return Json(new
            {
                OK = true,
                message = "Succeed",
                sEcho = param.sEcho,
                iTotalRecords = applicantSubmitteds.Count(),
                iTotalDisplayRecords = applicantSubmitteds.Count(),
                aaData = aadata,
            }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult SearchingApplicant(JQueryDataTableParamModel param, int acquisitionid, string category, string name, string icno)
        {
            var applicants = ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence").Search(acquisitionid, category, name, icno, param.sSearch);

            var sortColumnIndex = Convert.ToInt32(Request["iSortCol_0"]);
            Func<ApplicantSubmitted, string> orderingFunction =
                (c => sortColumnIndex == 0 ? c.FullName : sortColumnIndex == 1 ? c.FullName : c.NewICNo);
            var sortDirection = Request["sSortDir_0"]; // asc or desc
            if (sortDirection == "asc")
                applicants = applicants.OrderBy(orderingFunction);
            else
                applicants = applicants.OrderByDescending(orderingFunction);

            var applicantSubmitteds = applicants as IList<ApplicantSubmitted> ?? applicants.ToList();
            var aadata = applicantSubmitteds.Select(a => new string[]
            {
                a.ApplicantId.ToString(),
                a.FullName,
                a.NewICNo,
                a.Application == null ? "Belum Hantar" : "Hantar",
                a.ApplicantId.ToString()
            }).ToList().Skip(param.iDisplayStart).Take(param.iDisplayLength);

            return Json(new
            {
                OK = true,
                message = "Succeed",
                sEcho = param.sEcho,
                iTotalRecords = applicantSubmitteds.Count(),
                iTotalDisplayRecords = applicantSubmitteds.Count(),
                aaData = aadata,
            }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult SetSelectedAcquisition(int acqid)
        {
            if (acqid != 0)
            {
                var pd = ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence")
                    .GetAcquisition(acqid);
                if (null != pd)
                {
                    Session["SelectedAcquisition"] = pd.AcquisitionId;
                    return
                        Json(
                            new
                            {
                                OK = true,
                                message = "Berjaya",
                                name = "Siri " + pd.Siri + "/" + pd.Year + " " + pd.AcquisitionType.AcquisitionTypeNm
                            });
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
                a.CloseStatus.HasValue ? a.CloseStatus.Value ? "Tutup" : "Buka" : "NA",
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

        public ActionResult FirstIntakeSelection()
        {
            var vm = new AdminViewModel();
            var did = 0;
            if (Session["SelectedAcquisition"] == null)
                return RedirectToAction("Intakes", "Admin");
            if (Session["SelectedAcquisition"] != null)
            {
                var acqid = Session["SelectedAcquisition"].ToString();
                if (!string.IsNullOrWhiteSpace(acqid))
                {
                    int.TryParse(acqid, out did);
                    if (did == 0)
                        return RedirectToAction("Intakes", "Admin");

                    var acq = ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetAcquisition(did);
                    if (null != acq)
                        vm.Acquisition = acq;
                }
            }
            return View(vm);
        }

        public ActionResult FirstIntakeUpdateAndFinalSelection()
        {
            var vm = new AdminViewModel();
            var did = 0;
            if (Session["SelectedAcquisition"] == null)
                return RedirectToAction("Intakes", "Admin");
            if (Session["SelectedAcquisition"] != null)
            {
                var acqid = Session["SelectedAcquisition"].ToString();
                if (!string.IsNullOrWhiteSpace(acqid))
                {
                    int.TryParse(acqid, out did);
                    if (did == 0)
                        return RedirectToAction("Intakes", "Admin");

                    var acq = ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetAcquisition(did);
                    if (null != acq)
                        vm.Acquisition = acq;
                }
            }
            return View(vm);
        }

        public ActionResult RunSQL(string sql, string op)
        {
            try
            {
                if (!string.IsNullOrEmpty(sql) && !string.IsNullOrEmpty(op))
                {
                    if (op == "SELECT")
                    {
                        var nquery = ObjectBuilder.GetObject<IHibernateSqlExecution>("HibernateSqlExecution").SelectQuery(sql).List();
                        ViewBag.Results = nquery;
                        ViewBag.ExeType = "SELECT";
                    }
                    else if (op == "COUNT")
                    {
                        var nquery = ObjectBuilder.GetObject<IHibernateSqlExecution>("HibernateSqlExecution").SelectQuery(sql).List();
                        ViewBag.Results = nquery;
                        ViewBag.ExeType = "COUNT";
                    }
                    else if (op == "OTHER")
                    {
                        var nquery = ObjectBuilder.GetObject<IHibernateSqlExecution>("HibernateSqlExecution").ExecuteQuery(sql);
                        ViewBag.Results = nquery;
                        ViewBag.ExeType = "OTHER";
                    }

                    return View();
                }
                else
                {
                    return View();
                }

            }
            catch (Exception err)
            {
                return Content(err.Message);
            }
        }
    }
}