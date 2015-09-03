using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;
using SevenH.MMCSB.Atm.Web.Models;

namespace SevenH.MMCSB.Atm.Web.Controllers
{
    [AtmAuthorize(Roles = RolesString.SUPER_ADMIN + "," + RolesString.KERANI_PENGAMBILAN + "," + RolesString.PEGAWAI_PENGAMBILAN)]
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
            var applicants = new List<ApplicantSubmitted>();
            var total = 0;
            if (!string.IsNullOrWhiteSpace(category))
            {
                if (category == "00")
                    applicants.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence").Search(acquisitionid, category, name, icno, param.sSearch, null, null, null, param.iDisplayLength, param.iDisplayStart, out total));
                if (category == "01")
                    applicants.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence").Search(acquisitionid, category, name, icno, param.sSearch, true, null, null, param.iDisplayLength, param.iDisplayStart, out total));
                if (category == "02")
                    applicants.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence").Search(acquisitionid, category, name, icno, param.sSearch, null, true, null, param.iDisplayLength, param.iDisplayStart, out total));
                if (category == "03")
                    applicants.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence").Search(acquisitionid, category, name, icno, param.sSearch, null, null, true, param.iDisplayLength, param.iDisplayStart, out total));
            }

            var applicantSubmitteds = new List<ApplicantSubmitted>();
            var sortColumnIndex = Convert.ToInt32(Request["iSortCol_0"]);
            Func<ApplicantSubmitted, string> orderingFunction =
                (c => sortColumnIndex == 0 ? c.FullName : sortColumnIndex == 1 ? c.FullName : c.NewICNo);
            var sortDirection = Request["sSortDir_0"]; // asc or desc
            if (sortDirection == "asc")
                applicantSubmitteds.AddRange(applicants.OrderBy(orderingFunction));
            else
                applicantSubmitteds.AddRange(applicants.OrderByDescending(orderingFunction));

            var aadata = applicantSubmitteds.Select(a => new string[]
            {
                a.ApplicantId.ToString(),
                a.FullName,
                a.NewICNo,
                GenerateStatusApplication(a.Application),
                a.ApplicantId.ToString(),
            }).ToList();

            return Json(new
            {
                OK = true,
                message = "Succeed",
                sEcho = param.sEcho,
                iTotalRecords = total,
                iTotalDisplayRecords = total,
                aaData = aadata,
            }, JsonRequestBehavior.AllowGet);
        }

        private string GenerateStatusApplication(Application application)
        {
            if (null != application)
            {
                if (application.FinalSelectionInd.HasValue)
                    return application.FinalSelectionInd.Value ? "Lulus Temuduga/Pemilihan Akhir" : "Tidak Lulus Temuduga/Pemilihan Akhir";

                if (application.FirstSelectionInd.HasValue)
                    return application.FirstSelectionInd.Value ? "Dipanggil Temuduga/Pemilihan Akhir" : "Tidak Dipanggil Temuduga/Pemilihan Akhir";

                if (application.InvitationFirstSel.HasValue)
                    return application.InvitationFirstSel.Value ? "Terpilih ke Pemilihan Awal" : "Tidak Terpilih ke Pemilihan Awal";
            }
            return "Permohonan Baru/Sedang diproses";
        }

        public ActionResult LoadToUpdateApplicant(JQueryDataTableParamModel param, int acquisitionid, string category, string name, string icno, bool? firstinvitation, bool? finalinvitation)
        {
            var applicants = new List<ApplicantSubmitted>();
            var total = 0;
            if (!string.IsNullOrWhiteSpace(category))
            {
                if (category == "00")
                    applicants.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence").Search(acquisitionid, category, name, icno, param.sSearch, true, null, null, param.iDisplayLength, param.iDisplayStart, out total));
                if (category == "01")
                    applicants.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence").Search(acquisitionid, category, name, icno, param.sSearch, false, null, null, param.iDisplayLength, param.iDisplayStart, out total));
                if (category == "02")
                    applicants.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence").Search(acquisitionid, category, name, icno, param.sSearch, null, null, null, param.iDisplayLength, param.iDisplayStart, out total));
                if (category == "03")
                    applicants.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence").Search(acquisitionid, category, name, icno, param.sSearch, null, null, null, param.iDisplayLength, param.iDisplayStart, out total));
                if (category == "04")
                    applicants.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence").Search(acquisitionid, category, name, icno, param.sSearch, null, true, null, param.iDisplayLength, param.iDisplayStart, out total));
                if (category == "05")
                    applicants.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence").Search(acquisitionid, category, name, icno, param.sSearch, null, false, null, param.iDisplayLength, param.iDisplayStart, out total));
                if (category == "06")
                    applicants.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence").Search(acquisitionid, category, name, icno, param.sSearch, null, null, true, param.iDisplayLength, param.iDisplayStart, out total));
                if (category == "07")
                    applicants.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence").Search(acquisitionid, category, name, icno, param.sSearch, null, null, false, param.iDisplayLength, param.iDisplayStart, out total));
            }

            var applicantSubmitteds = new List<ApplicantSubmitted>();
            var sortColumnIndex = Convert.ToInt32(Request["iSortCol_0"]);
            Func<ApplicantSubmitted, string> orderingFunction =
                (c => sortColumnIndex == 0 ? c.FullName : sortColumnIndex == 1 ? c.FullName : c.NewICNo);
            var sortDirection = Request["sSortDir_0"]; // asc or desc
            applicantSubmitteds.AddRange(sortDirection == "asc" ? applicants.OrderBy(orderingFunction) : applicants.OrderByDescending(orderingFunction));

            var aadata = applicantSubmitteds.Select(a => new string[]
            {
                a.ApplicantId.ToString(),
                a.FullName,
                a.NewICNo,
                GenerateStatusApplication(a.Application),
                a.ApplicantId.ToString(),
                a.ApplicantId.ToString(),
                a.ApplicantId.ToString()
            }).ToList();

            return Json(new
            {
                OK = true,
                message = "Succeed",
                sEcho = param.sEcho,
                iTotalRecords = total,
                iTotalDisplayRecords = total,
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
            var vm = new AdminViewModel() { Announcement = new AcquisitionAnnouncement() { AnnouncementSelectionInd = 1, AnnouncementTypeInd = "E" } };
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
                    {
                        vm.Acquisition = acq;
                        vm.Announcement = ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetAnnouncement(acq.AcquisitionId, 1) ?? new AcquisitionAnnouncement() { AnnouncementSelectionInd = 1, AnnouncementTypeInd = "E" };
                    }
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
                    {
                        vm.Acquisition = acq;
                        vm.Announcement = ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetAnnouncement(acq.AcquisitionId, 2) ?? new AcquisitionAnnouncement() { AnnouncementSelectionInd = 2, AnnouncementTypeInd = "E" };
                    }
                }
            }
            return View(vm);
        }

        public ActionResult InterviewUpdateAndFinalSelection()
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

        [AllowAnonymous]
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

        public ActionResult SubmitFirstSelection(int[] candidates, int[] processcandidates, int[] rejectcandidates)
        {
            var did = 0;
            if (Session["SelectedAcquisition"] == null)
                return Json(new { OK = false, message = "Tidak berjaya. Sila kembali kepada menu utama." });
            if (Session["SelectedAcquisition"] != null)
            {
                var acqid = Session["SelectedAcquisition"].ToString();
                if (!string.IsNullOrWhiteSpace(acqid))
                {
                    int.TryParse(acqid, out did);
                    if (did == 0)
                        return Json(new { OK = false, message = "Tidak berjaya. Sila kembali kepada menu utama." });
                    var persistance = ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence");
                    var announcement = ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetAnnouncement(did, 1);
                    var from = ConfigurationManager.AppSettings["fromEmail"];
                    if ((candidates != null && candidates.Any()) || (processcandidates != null && processcandidates.Any()) || (rejectcandidates != null && rejectcandidates.Any()))
                    {
                        // TODO : Later to think about email template for reject
                        if (candidates != null && candidates.Any())
                            foreach (var c in candidates)
                            {
                                if (ObjectBuilder.GetObject<IApplicationPersistance>("ApplicationPersistance").UpdateFirstInvitationStatus(did, c, true, User.Identity.Name) > 0)
                                {
                                    // sending an email
                                    //if (null != announcement)
                                    //{
                                    //    var applicant = persistance.GetApplicant(c);
                                    //    if (null != applicant && !string.IsNullOrWhiteSpace(announcement.Header) && !string.IsNullOrWhiteSpace(announcement.Body))
                                    //    {
                                    //        var mail = new MailService();
                                    //        mail.SendWithMessage(from, new List<string> { applicant.Email }, null, null, null, announcement.Header, announcement.Body, null);
                                    //    }
                                    //}
                                }
                            }

                        if (rejectcandidates != null && rejectcandidates.Any())
                            foreach (var c in rejectcandidates)
                            {
                                if (ObjectBuilder.GetObject<IApplicationPersistance>("ApplicationPersistance").UpdateFirstInvitationStatus(did, c, false, User.Identity.Name) > 0)
                                {
                                    // sending an email
                                    //if (null != announcement)
                                    //{
                                    //    var applicant = persistance.GetApplicant(c);
                                    //    if (null != applicant && !string.IsNullOrWhiteSpace(announcement.Header) && !string.IsNullOrWhiteSpace(announcement.Body))
                                    //    {
                                    //        var mail = new MailService();
                                    //        mail.SendWithMessage(from, new List<string> { applicant.Email }, null, null, null, announcement.Header, announcement.Body, null);
                                    //    }
                                    //}
                                }
                            }

                        if (processcandidates != null && processcandidates.Any())
                            foreach (var c in processcandidates)
                                ObjectBuilder.GetObject<IApplicationPersistance>("ApplicationPersistance").UpdateStatus(did, c, null, null, null, null, User.Identity.Name);


                        return Json(new { OK = true, message = "Berjaya" });
                    }
                }
            }
            return Json(new { OK = false, message = "Tidak Berjaya" });
        }
        public ActionResult SubmitFinalSelection(int[] candidates, int[] processcandidates, int[] rejectcandidates)
        {
            var did = 0;
            if (Session["SelectedAcquisition"] == null)
                return Json(new { OK = false, message = "Tidak berjaya. Sila kembali kepada menu utama." });
            if (Session["SelectedAcquisition"] != null)
            {
                var acqid = Session["SelectedAcquisition"].ToString();
                if (!string.IsNullOrWhiteSpace(acqid))
                {
                    int.TryParse(acqid, out did);
                    if (did == 0)
                        return Json(new { OK = false, message = "Tidak berjaya. Sila kembali kepada menu utama." });

                    if ((candidates != null && candidates.Any()) || (processcandidates != null && processcandidates.Any()) || (rejectcandidates != null && rejectcandidates.Any()))
                    {
                        // TODO : Later to think about email template for reject
                        if (candidates != null && candidates.Any())
                            foreach (var c in candidates)
                            {
                                if (ObjectBuilder.GetObject<IApplicationPersistance>("ApplicationPersistance").UpdateFirstSelectionStatus(did, c, true, User.Identity.Name) > 0)
                                {
                                    // sending an email
                                    //if (null != announcement)
                                    //{
                                    //    var applicant = persistance.GetApplicant(c);
                                    //    if (null != applicant && !string.IsNullOrWhiteSpace(announcement.Header) && !string.IsNullOrWhiteSpace(announcement.Body))
                                    //    {
                                    //        var mail = new MailService();
                                    //        mail.SendWithMessage(from, new List<string> { applicant.Email }, null, null, null, announcement.Header, announcement.Body, null);
                                    //    }
                                    //}
                                }
                            }

                        if (rejectcandidates != null && rejectcandidates.Any())
                            foreach (var c in rejectcandidates)
                            {
                                if (ObjectBuilder.GetObject<IApplicationPersistance>("ApplicationPersistance").UpdateFirstSelectionStatus(did, c, false, User.Identity.Name) > 0)
                                {
                                    // sending an email
                                    //if (null != announcement)
                                    //{
                                    //    var applicant = persistance.GetApplicant(c);
                                    //    if (null != applicant && !string.IsNullOrWhiteSpace(announcement.Header) && !string.IsNullOrWhiteSpace(announcement.Body))
                                    //    {
                                    //        var mail = new MailService();
                                    //        mail.SendWithMessage(from, new List<string> { applicant.Email }, null, null, null, announcement.Header, announcement.Body, null);
                                    //    }
                                    //}
                                }
                            }

                        if (processcandidates != null && processcandidates.Any())
                            foreach (var c in processcandidates)
                                ObjectBuilder.GetObject<IApplicationPersistance>("ApplicationPersistance").UpdateStatus(did, c, null, null, null, null, User.Identity.Name);


                        return Json(new { OK = true, message = "Berjaya" });
                    }
                }
            }
            return Json(new { OK = false, message = "Tidak Berjaya" });
        }
        public ActionResult SubmitLastSelection(int[] candidates, int[] processcandidates, int[] rejectcandidates)
        {
            var did = 0;
            if (Session["SelectedAcquisition"] == null)
                return Json(new { OK = false, message = "Tidak berjaya. Sila kembali kepada menu utama." });
            if (Session["SelectedAcquisition"] != null)
            {
                var acqid = Session["SelectedAcquisition"].ToString();
                if (!string.IsNullOrWhiteSpace(acqid))
                {
                    int.TryParse(acqid, out did);
                    if (did == 0)
                        return Json(new { OK = false, message = "Tidak berjaya. Sila kembali kepada menu utama." });

                    if ((candidates != null && candidates.Any()) || (processcandidates != null && processcandidates.Any()) || (rejectcandidates != null && rejectcandidates.Any()))
                    {
                        // TODO : Later to think about email template for reject
                        if (candidates != null && candidates.Any())
                            foreach (var c in candidates)
                            {
                                if (ObjectBuilder.GetObject<IApplicationPersistance>("ApplicationPersistance").UpdateLastSelectionStatus(did, c, true, true, User.Identity.Name) > 0)
                                {
                                    // sending an email
                                    //if (null != announcement)
                                    //{
                                    //    var applicant = persistance.GetApplicant(c);
                                    //    if (null != applicant && !string.IsNullOrWhiteSpace(announcement.Header) && !string.IsNullOrWhiteSpace(announcement.Body))
                                    //    {
                                    //        var mail = new MailService();
                                    //        mail.SendWithMessage(from, new List<string> { applicant.Email }, null, null, null, announcement.Header, announcement.Body, null);
                                    //    }
                                    //}
                                }
                            }

                        if (rejectcandidates != null && rejectcandidates.Any())
                            foreach (var c in rejectcandidates)
                            {
                                if (ObjectBuilder.GetObject<IApplicationPersistance>("ApplicationPersistance").UpdateLastSelectionStatus(did, c, false, false, User.Identity.Name) > 0)
                                {
                                    // sending an email
                                    //if (null != announcement)
                                    //{
                                    //    var applicant = persistance.GetApplicant(c);
                                    //    if (null != applicant && !string.IsNullOrWhiteSpace(announcement.Header) && !string.IsNullOrWhiteSpace(announcement.Body))
                                    //    {
                                    //        var mail = new MailService();
                                    //        mail.SendWithMessage(from, new List<string> { applicant.Email }, null, null, null, announcement.Header, announcement.Body, null);
                                    //    }
                                    //}
                                }
                            }

                        if (processcandidates != null && processcandidates.Any())
                            foreach (var c in processcandidates)
                                ObjectBuilder.GetObject<IApplicationPersistance>("ApplicationPersistance").UpdateStatus(did, c, null, null, null, null, User.Identity.Name);


                        return Json(new { OK = true, message = "Berjaya" });
                    }
                }
            }
            return Json(new { OK = false, message = "Tidak Berjaya" });
        }

        public ActionResult SubmitAnnouncement(AcquisitionAnnouncement announcement)
        {
            var did = 0;
            if (Session["SelectedAcquisition"] == null)
                return Json(new { OK = false, message = "Tidak berjaya. Sila kembali kepada menu utama." });
            if (Session["SelectedAcquisition"] != null)
            {
                var acqid = Session["SelectedAcquisition"].ToString();
                if (!string.IsNullOrWhiteSpace(acqid))
                {
                    int.TryParse(acqid, out did);
                    if (did == 0)
                        return Json(new { OK = false, message = "Tidak berjaya. Sila kembali kepada menu utama." });

                    announcement.AnnouncementTypeInd = "E";
                    announcement.AcquisitionId = did;
                    announcement.CreatedBy = User.Identity.Name;
                    announcement.CreatedDate = DateTime.Now;
                    if (announcement.Save() > 0)
                        return Json(new { OK = true, message = "Berjaya" });

                }
            }
            return Json(new { OK = false, message = "Tidak Berjaya" });
        }

        public ActionResult PrintFirstInvitation()
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
                    {
                        vm.Acquisition = acq;
                        var total = 0;
                        vm.ListOfApplicant.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence").Search(did, string.Empty, string.Empty, string.Empty, string.Empty, null, true, null, null, null, out total));
                    }

                }
            }
            return View(vm);
        }

        public ActionResult PrintFinalnvitation()
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
                    {
                        vm.Acquisition = acq;
                        var total = 0;
                        vm.ListOfApplicant.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence").Search(did, string.Empty, string.Empty, string.Empty, string.Empty, null, true, null, null, null, out total));
                    }

                }
            }
            return View(vm);
        }
    }
}