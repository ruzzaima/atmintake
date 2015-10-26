using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Mvc;
using Newtonsoft.Json;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;
using SevenH.MMCSB.Atm.Web.Models;

namespace SevenH.MMCSB.Atm.Web.Controllers
{
    [Authorize(Roles = RolesString.SUPER_ADMIN + "," + RolesString.KERANI_PENGAMBILAN + "," + RolesString.PEGAWAI_PENGAMBILAN)]
    public class AdminController : Controller
    {
        public const string ACQUISITION_PERSISTENCE = "AcquisitionPersistence";
        public const string SELECTED_ACQUISITION = "SelectedAcquisition";
        public const string EXISTING_ATM_PERSISTANCE = "ExistingAtmPersistance";
        public const string APPLICANT_SUBMITTED_PERSISTENCE = "ApplicantSubmittedPersistence";

        public ActionResult Index()
        {
            var did = 0;
            if (Session[SELECTED_ACQUISITION] == null)
                return RedirectToAction("Intakes");
            var acqid = Session[SELECTED_ACQUISITION]?.ToString();
            if (!string.IsNullOrWhiteSpace(acqid))
            {
                int.TryParse(acqid, out did);
                if (did == 0)
                    return RedirectToAction("Intakes");
            }

            var vm = new DashboardViewModel
            {
                Acquisition =
                    ObjectBuilder.GetObject<IAcquisitionPersistence>(ACQUISITION_PERSISTENCE).GetAcquisition(did)
            };
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
            if (Session[SELECTED_ACQUISITION] == null)
                return RedirectToAction("Intakes", "Admin");
            var acqid = Session[SELECTED_ACQUISITION]?.ToString();
            if (string.IsNullOrWhiteSpace(acqid)) return View(vm);
            int did;
            int.TryParse(acqid, out did);
            if (did == 0)
                return RedirectToAction("Intakes", "Admin");

            var acq =
                ObjectBuilder.GetObject<IAcquisitionPersistence>(ACQUISITION_PERSISTENCE).GetAcquisition(did);
            if (null != acq)
                vm.Acquisition = acq;
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

        public ActionResult SearchingAtmMember(JQueryDataTableParamModel param, string statuscode, string name, string icno, string armyno)
        {
            var applicants = ObjectBuilder.GetObject<IExistingAtmPersistance>(EXISTING_ATM_PERSISTANCE).Search(statuscode, param.sSearch, armyno).ToList();
            if (!string.IsNullOrWhiteSpace(name))
            {
                applicants.Clear();
                applicants.AddRange(ObjectBuilder.GetObject<IExistingAtmPersistance>(EXISTING_ATM_PERSISTANCE).Search(statuscode, name, armyno).ToList());
            }
            if (!string.IsNullOrWhiteSpace(icno))
            {
                applicants.Clear();
                applicants.AddRange(ObjectBuilder.GetObject<IExistingAtmPersistance>(EXISTING_ATM_PERSISTANCE).Search(statuscode, icno, armyno).ToList());
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

            var applicantSubmitteds = (IList<ExistingMember>)applicants;
            var aadata = applicantSubmitteds.Select(a => new[]
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
                    applicants.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>(APPLICANT_SUBMITTED_PERSISTENCE).Search(acquisitionid, category, name, icno, param.sSearch, null, null, null, param.iDisplayLength, param.iDisplayStart, true, out total));
                if (category == "01")
                    applicants.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>(APPLICANT_SUBMITTED_PERSISTENCE).Search(acquisitionid, category, name, icno, param.sSearch, true, null, null, param.iDisplayLength, param.iDisplayStart, null, out total));
                if (category == "02")
                    applicants.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>(APPLICANT_SUBMITTED_PERSISTENCE).Search(acquisitionid, category, name, icno, param.sSearch, null, true, null, param.iDisplayLength, param.iDisplayStart, null, out total));
                if (category == "03")
                    applicants.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>(APPLICANT_SUBMITTED_PERSISTENCE).Search(acquisitionid, category, name, icno, param.sSearch, null, null, true, param.iDisplayLength, param.iDisplayStart, null, out total));
            }

            var applicantSubmitteds = new List<ApplicantSubmitted>();
            var sortColumnIndex = Convert.ToInt32(Request["iSortCol_0"]);
            Func<ApplicantSubmitted, string> orderingFunction =
                (c => sortColumnIndex == 0 ? c.FullName : sortColumnIndex == 1 ? c.FullName : c.NewICNo);
            var sortDirection = Request["sSortDir_0"]; // asc or desc
            applicantSubmitteds.AddRange(sortDirection == "asc"
                ? applicants.OrderBy(orderingFunction)
                : applicants.OrderByDescending(orderingFunction));

            var aadata = applicantSubmitteds.Select(a => new[]
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
                    applicants.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>(APPLICANT_SUBMITTED_PERSISTENCE).Search(acquisitionid, category, name, icno, param.sSearch, true, null, null, param.iDisplayLength, param.iDisplayStart, null, out total));
                if (category == "01")
                    applicants.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>(APPLICANT_SUBMITTED_PERSISTENCE).Search(acquisitionid, category, name, icno, param.sSearch, false, null, null, param.iDisplayLength, param.iDisplayStart, null, out total));
                if (category == "02")
                    applicants.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>(APPLICANT_SUBMITTED_PERSISTENCE).Search(acquisitionid, category, name, icno, param.sSearch, null, null, null, param.iDisplayLength, param.iDisplayStart, null, out total));
                if (category == "03")
                    applicants.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>(APPLICANT_SUBMITTED_PERSISTENCE).Search(acquisitionid, category, name, icno, param.sSearch, null, null, null, param.iDisplayLength, param.iDisplayStart, true, out total));
                if (category == "04")
                    applicants.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>(APPLICANT_SUBMITTED_PERSISTENCE).Search(acquisitionid, category, name, icno, param.sSearch, null, true, null, param.iDisplayLength, param.iDisplayStart, null, out total));
                if (category == "05")
                    applicants.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>(APPLICANT_SUBMITTED_PERSISTENCE).Search(acquisitionid, category, name, icno, param.sSearch, null, false, null, param.iDisplayLength, param.iDisplayStart, null, out total));
                if (category == "06")
                    applicants.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>(APPLICANT_SUBMITTED_PERSISTENCE).Search(acquisitionid, category, name, icno, param.sSearch, null, null, true, param.iDisplayLength, param.iDisplayStart, null, out total));
                if (category == "07")
                    applicants.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>(APPLICANT_SUBMITTED_PERSISTENCE).Search(acquisitionid, category, name, icno, param.sSearch, null, null, false, param.iDisplayLength, param.iDisplayStart, null, out total));
            }

            var applicantSubmitteds = new List<ApplicantSubmitted>();
            var sortColumnIndex = Convert.ToInt32(Request["iSortCol_0"]);
            Func<ApplicantSubmitted, string> orderingFunction =
                (c => sortColumnIndex == 0 ? c.FullName : sortColumnIndex == 1 ? c.FullName : c.NewICNo);
            var sortDirection = Request["sSortDir_0"]; // asc or desc
            applicantSubmitteds.AddRange(sortDirection == "asc" ? applicants.OrderBy(orderingFunction) : applicants.OrderByDescending(orderingFunction));

            var aadata = applicantSubmitteds.Select(a => new[]
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
                var pd = ObjectBuilder.GetObject<IAcquisitionPersistence>(ACQUISITION_PERSISTENCE)
                    .GetAcquisition(acqid);
                if (null != pd)
                {
                    Session[SELECTED_ACQUISITION] = pd.AcquisitionId;
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
                    intakes.AddRange(!string.IsNullOrWhiteSpace(usr.ServiceCd)
                        ? ObjectBuilder.GetObject<IAcquisitionPersistence>(ACQUISITION_PERSISTENCE)
                            .GetAllAcquisition(null, usr.ServiceCd)
                            .ToList()
                        : ObjectBuilder.GetObject<IAcquisitionPersistence>(ACQUISITION_PERSISTENCE)
                            .GetAllAcquisition(null, string.Empty)
                            .ToList());
                }
            }

            var aadata = intakes.Select(a => new[]
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
            var vm = new AdminViewModel { Announcement = new AcquisitionAnnouncement { AnnouncementSelectionInd = 1, AnnouncementTypeInd = "E" } };
            if (Session[SELECTED_ACQUISITION] == null)
                return RedirectToAction("Intakes", "Admin");
            var acqid = Session[SELECTED_ACQUISITION]?.ToString();
            if (string.IsNullOrWhiteSpace(acqid)) return View(vm);

            int did;
            int.TryParse(acqid, out did);
            if (did == 0)
                return RedirectToAction("Intakes", "Admin");

            var acq = ObjectBuilder.GetObject<IAcquisitionPersistence>(ACQUISITION_PERSISTENCE).GetAcquisition(did);
            if (null != acq)
            {
                vm.Acquisition = acq;
                vm.Announcement = ObjectBuilder.GetObject<IAcquisitionPersistence>(ACQUISITION_PERSISTENCE).GetAnnouncement(acq.AcquisitionId, 1) ?? new AcquisitionAnnouncement { AnnouncementSelectionInd = 1, AnnouncementTypeInd = "E" };
            }
            return View(vm);
        }

        public ActionResult FirstIntakeUpdateAndFinalSelection()
        {
            var vm = new AdminViewModel();
            if (Session[SELECTED_ACQUISITION] == null)
                return RedirectToAction("Intakes", "Admin");
            var acqid = Session[SELECTED_ACQUISITION]?.ToString();
            if (!string.IsNullOrWhiteSpace(acqid))
            {
                int did;
                int.TryParse(acqid, out did);
                if (did == 0)
                    return RedirectToAction("Intakes", "Admin");

                var acq = ObjectBuilder.GetObject<IAcquisitionPersistence>(ACQUISITION_PERSISTENCE).GetAcquisition(did);
                if (null != acq)
                {
                    vm.Acquisition = acq;
                    vm.Announcement = ObjectBuilder.GetObject<IAcquisitionPersistence>(ACQUISITION_PERSISTENCE).GetAnnouncement(acq.AcquisitionId, 2) ?? new AcquisitionAnnouncement { AnnouncementSelectionInd = 2, AnnouncementTypeInd = "E" };
                }
            }
            return View(vm);
        }

        public ActionResult InterviewUpdateAndFinalSelection()
        {
            var vm = new AdminViewModel();
            if (Session[SELECTED_ACQUISITION] == null)
                return RedirectToAction("Intakes", "Admin");
            if (Session[SELECTED_ACQUISITION] != null)
            {
                var acqid = Session[SELECTED_ACQUISITION].ToString();
                if (!string.IsNullOrWhiteSpace(acqid))
                {
                    var did = 0;
                    int.TryParse(acqid, out did);
                    if (did == 0)
                        return RedirectToAction("Intakes", "Admin");

                    var acq = ObjectBuilder.GetObject<IAcquisitionPersistence>(ACQUISITION_PERSISTENCE).GetAcquisition(did);
                    if (null != acq)
                    {
                        vm.Acquisition = acq;
                    }
                }
            }
            return View(vm);
        }

        [AllowAnonymous]
        public ActionResult RunSql(string sql, string op)
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
            if (Session[SELECTED_ACQUISITION] == null)
                return Json(new { OK = false, message = "Tidak berjaya. Sila kembali kepada menu utama." });
            if (Session[SELECTED_ACQUISITION] == null) return Json(new {OK = false, message = "Tidak Berjaya"});


            var acqid = Session[SELECTED_ACQUISITION].ToString();
            if (string.IsNullOrWhiteSpace(acqid)) return Json(new {OK = false, message = "Tidak Berjaya"});



            var did = 0;
            int.TryParse(acqid, out did);
            if (did == 0)
                return Json(new { OK = false, message = "Tidak berjaya. Sila kembali kepada menu utama." });
            var persistance = ObjectBuilder.GetObject<IApplicantSubmittedPersistence>(APPLICANT_SUBMITTED_PERSISTENCE);
            var announcement = ObjectBuilder.GetObject<IAcquisitionPersistence>(ACQUISITION_PERSISTENCE).GetAnnouncement(did, 1);
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
            return Json(new { OK = false, message = "Tidak Berjaya" });
        }
        public ActionResult SubmitFinalSelection(int[] candidates, int[] processcandidates, int[] rejectcandidates)
        {
            var did = 0;
            if (Session[SELECTED_ACQUISITION] == null)
                return Json(new { OK = false, message = "Tidak berjaya. Sila kembali kepada menu utama." });
            if (Session[SELECTED_ACQUISITION] == null) return Json(new {OK = false, message = "Tidak Berjaya"});
            var acqid = Session[SELECTED_ACQUISITION].ToString();
            if (string.IsNullOrWhiteSpace(acqid)) return Json(new {OK = false, message = "Tidak Berjaya"});
            int.TryParse(acqid, out did);
            if (did == 0)
                return Json(new { OK = false, message = "Tidak berjaya. Sila kembali kepada menu utama." });

            if ((candidates == null || !candidates.Any()) && (processcandidates == null || !processcandidates.Any()) &&
                (rejectcandidates == null || !rejectcandidates.Any()))
                return Json(new {OK = false, message = "Tidak Berjaya"});
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
        public ActionResult SubmitLastSelection(int[] candidates, int[] processcandidates, int[] rejectcandidates)
        {
            if (Session[SELECTED_ACQUISITION] == null)
                return Json(new { OK = false, message = "Tidak berjaya. Sila kembali kepada menu utama." });
            if (Session[SELECTED_ACQUISITION] == null) return Json(new {OK = false, message = "Tidak Berjaya"});
            var acqid = Session[SELECTED_ACQUISITION].ToString();
            if (string.IsNullOrWhiteSpace(acqid)) return Json(new {OK = false, message = "Tidak Berjaya"});
            int did;
            int.TryParse(acqid, out did);
            if (did == 0)
                return Json(new { OK = false, message = "Tidak berjaya. Sila kembali kepada menu utama." });

            if ((candidates == null || !candidates.Any()) && (processcandidates == null || !processcandidates.Any()) &&
                (rejectcandidates == null || !rejectcandidates.Any()))
                return Json(new {OK = false, message = "Tidak Berjaya"});
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

        public ActionResult SubmitFinalSetLocation(int[] candidates, int? selectedlocation, DateTime? startdate, DateTime? enddate, string selectime)
        {
            if (Session[SELECTED_ACQUISITION] == null)
                return Json(new { OK = false, message = "Tidak berjaya. Sila kembali kepada menu utama." });
            if (Session[SELECTED_ACQUISITION] == null) return Json(new {OK = false, message = "Tidak Berjaya"});
            var acqid = Session[SELECTED_ACQUISITION].ToString();
            if (string.IsNullOrWhiteSpace(acqid)) return Json(new {OK = false, message = "Tidak Berjaya"});
            var did = 0;
            int.TryParse(acqid, out did);
            if (did == 0)
                return Json(new { OK = false, message = "Tidak berjaya. Sila kembali kepada menu utama." });

            if (candidates == null || !candidates.Any()) return Json(new {OK = false, message = "Tidak Berjaya"});
            if (startdate.HasValue && !string.IsNullOrWhiteSpace(selectime))
            {
                var newDateTime = startdate.Value.Add(TimeSpan.Parse(selectime));
                startdate = newDateTime;
            }

            foreach (var c in candidates)
                ObjectBuilder.GetObject<IApplicationPersistance>("ApplicationPersistance")
                    .UpdateFirstSelectionLocationAndDateTime(did, c, selectedlocation, startdate, enddate,
                        User.Identity.Name);

            return Json(new { OK = true, message = "Berjaya" });
        }
        public ActionResult SubmitReportDutySetLocation(int[] candidates, int? selectedlocation, DateTime? startdate, DateTime? enddate, string selectime, string selectedservice)
        {
            if (Session[SELECTED_ACQUISITION] == null)
                return Json(new { OK = false, message = "Tidak berjaya. Sila kembali kepada menu utama." });
            if (Session[SELECTED_ACQUISITION] == null) return Json(new {OK = false, message = "Tidak Berjaya"});
            var acqid = Session[SELECTED_ACQUISITION].ToString();
            if (string.IsNullOrWhiteSpace(acqid)) return Json(new {OK = false, message = "Tidak Berjaya"});
            var did = 0;
            int.TryParse(acqid, out did);
            if (did == 0)
                return Json(new { OK = false, message = "Tidak berjaya. Sila kembali kepada menu utama." });

            if (candidates == null || !candidates.Any()) return Json(new {OK = false, message = "Tidak Berjaya"});
            if (startdate.HasValue && !string.IsNullOrWhiteSpace(selectime))
            {
                var newDateTime = startdate.Value.Add(TimeSpan.Parse(selectime));
                startdate = newDateTime;
            }

            foreach (var c in candidates)
                ObjectBuilder.GetObject<IApplicationPersistance>("ApplicationPersistance").UpdateReportDutyLocationAndDateTime(did, c, selectedlocation, startdate, User.Identity.Name, selectedservice);

            return Json(new { OK = true, message = "Berjaya" });
        }
        public ActionResult SubmitAnnouncement(AcquisitionAnnouncement announcement)
        {
            if (Session[SELECTED_ACQUISITION] == null)
                return Json(new { OK = false, message = "Tidak berjaya. Sila kembali kepada menu utama." });
            if (Session[SELECTED_ACQUISITION] == null) return Json(new {OK = false, message = "Tidak Berjaya"});
            var acqid = Session[SELECTED_ACQUISITION].ToString();
            if (string.IsNullOrWhiteSpace(acqid)) return Json(new {OK = false, message = "Tidak Berjaya"});
            var did = 0;
            int.TryParse(acqid, out did);
            if (did == 0)
                return Json(new { OK = false, message = "Tidak berjaya. Sila kembali kepada menu utama." });

            announcement.AnnouncementTypeInd = "E";
            announcement.AcquisitionId = did;
            announcement.CreatedBy = User.Identity.Name;
            announcement.CreatedDate = DateTime.Now;
            if (announcement.Save() > 0)
                return Json(new { OK = true, message = "Berjaya" });
            return Json(new { OK = false, message = "Tidak Berjaya" });
        }

        public ActionResult PrintFirstInvitation()
        {
            var vm = new AdminViewModel();
            if (Session[SELECTED_ACQUISITION] == null)
                return RedirectToAction("Intakes", "Admin");
            if (Session[SELECTED_ACQUISITION] == null) return View(vm);
            var acqid = Session[SELECTED_ACQUISITION].ToString();
            if (!string.IsNullOrWhiteSpace(acqid))
            {
                var did = 0;
                int.TryParse(acqid, out did);
                if (did == 0)
                    return RedirectToAction("Intakes", "Admin");

                var acq = ObjectBuilder.GetObject<IAcquisitionPersistence>(ACQUISITION_PERSISTENCE).GetAcquisition(did);
                if (null != acq)
                {
                    vm.Acquisition = acq;
                    int total;
                    vm.ListOfApplicant.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>(APPLICANT_SUBMITTED_PERSISTENCE).Search(did, string.Empty, string.Empty, string.Empty, string.Empty, null, true, null, null, null, null, out total));
                }

            }
            return View(vm);
        }

        public ActionResult PrintFinalnvitation()
        {
            var vm = new AdminViewModel();
            if (Session[SELECTED_ACQUISITION] == null)
                return RedirectToAction("Intakes", "Admin");
            if (Session[SELECTED_ACQUISITION] == null) return View(vm);
            var acqid = Session[SELECTED_ACQUISITION].ToString();
            if (string.IsNullOrWhiteSpace(acqid)) return View(vm);
            int did;
            int.TryParse(acqid, out did);
            if (did == 0)
                return RedirectToAction("Intakes", "Admin");

            var acq = ObjectBuilder.GetObject<IAcquisitionPersistence>(ACQUISITION_PERSISTENCE).GetAcquisition(did);
            if (null != acq)
            {
                vm.Acquisition = acq;
                var total = 0;
                vm.ListOfApplicant.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>(APPLICANT_SUBMITTED_PERSISTENCE).Search(did, string.Empty, string.Empty, string.Empty, string.Empty, null, true, null, null, null, null, out total));
            }
            return View(vm);
        }
        public ActionResult PrintReportDutyList()
        {
            var vm = new AdminViewModel();
            if (Session[SELECTED_ACQUISITION] == null)
                return RedirectToAction("Intakes", "Admin");
            if (Session[SELECTED_ACQUISITION] == null) return View(vm);
            var acqid = Session[SELECTED_ACQUISITION].ToString();
            if (string.IsNullOrWhiteSpace(acqid)) return View(vm);


            var did = 0;
            int.TryParse(acqid, out did);
            if (did == 0)
                return RedirectToAction("Intakes", "Admin");

            var acq = ObjectBuilder.GetObject<IAcquisitionPersistence>(ACQUISITION_PERSISTENCE).GetAcquisition(did);
            if (null != acq)
            {
                vm.Acquisition = acq;
                int total;
                vm.ListOfApplicant.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>(APPLICANT_SUBMITTED_PERSISTENCE).Search(did, string.Empty, string.Empty, string.Empty, string.Empty, null, null, true, null, null, null, out total));
            }
            return View(vm);
        }

        public ActionResult RedirectForm(int id, int acquisitionid)
        {
            if (id == 0 || acquisitionid == 0) return RedirectToAction("Index", "Admin");
            var acq = ObjectBuilder.GetObject<IAcquisitionPersistence>(ACQUISITION_PERSISTENCE).GetAcquisition(acquisitionid);
            if (null == acq) return RedirectToAction("Index", "Admin");
            var appl = ObjectBuilder.GetObject<IApplicantSubmittedPersistence>(APPLICANT_SUBMITTED_PERSISTENCE).GetApplicant(id, acquisitionid);
            if (null == appl) return RedirectToAction("Index", "Admin");
            if (acq.AcquisitionType.ServiceCd == "10")
                return RedirectToAction("PegawaiKadetForm", "Admin", new { id = appl.ApplicantId, acquisitionid = acq.AcquisitionId });
            if (acq.AcquisitionType.ServiceCd == "01")
                return RedirectToAction("TdForm", "Admin", new { id = appl.ApplicantId, acquisitionid = acq.AcquisitionId });
            if (acq.AcquisitionType.ServiceCd == "02")
                return RedirectToAction("TldmForm", "Admin", new { id = appl.ApplicantId, acquisitionid = acq.AcquisitionId });
            if (acq.AcquisitionType.ServiceCd == "03")
                return RedirectToAction("TudmForm", "Admin", new { id = appl.ApplicantId, acquisitionid = acq.AcquisitionId });
            return RedirectToAction("Index", "Admin");
        }

        [Authorize(Roles = RolesString.SUPER_ADMIN + "," + RolesString.PEGAWAI_PENGAMBILAN + "," + RolesString.KERANI_PENGAMBILAN)]
        public ActionResult PegawaiKadetForm(int id, int acquisitionid)
        {
            var vm = new ResumeViewModel { ApplicantModel = new ApplicantModel { ApplicantId = 0, NationalityCd = "MYS", GenderCd = "L" }, AcquisitionId = acquisitionid };

            if (id != 0 && acquisitionid != 0)
            {
                var applicant = ObjectBuilder.GetObject<IApplicantSubmittedPersistence>(APPLICANT_SUBMITTED_PERSISTENCE).GetApplicant(id, acquisitionid);
                if (null != applicant)
                {
                    vm.ApplicantModel = new ApplicantModel(applicant, acquisitionid);
                }
            }
            else
            {
                vm.ApplicantModel = new ApplicantModel(new ApplicantSubmitted { ColorBlindInd = true }, acquisitionid);
            }

            var acq = ObjectBuilder.GetObject<IAcquisitionPersistence>(ACQUISITION_PERSISTENCE).GetAcquisition(acquisitionid);
            if (null == acq) return View(vm);
            vm.Acquisition = acq;
            vm.ServiceCode = acq.AcquisitionType.ServiceCd;
            return View(vm);
        }


        [Authorize]
        public ActionResult TldmForm(int id, int acquisitionid)
        {
            var vm = new ResumeViewModel { ApplicantModel = new ApplicantModel { ApplicantId = 0, NationalityCd = "MYS", GenderCd = "L" }, AcquisitionId = acquisitionid };
            var zones = ObjectBuilder.GetObject<IReferencePersistence>("ReferencePersistence").GetZones();
            if (null != zones && zones.Any())
                vm.Zones.AddRange(zones);

            if (id != 0 && acquisitionid != 0)
            {
                var applicant = ObjectBuilder.GetObject<IApplicantSubmittedPersistence>(APPLICANT_SUBMITTED_PERSISTENCE).GetApplicant(id, acquisitionid);
                if (null != applicant)
                {
                    vm.ApplicantModel = new ApplicantModel(applicant, acquisitionid);
                }
            }
            else
            {
                vm.ApplicantModel = new ApplicantModel(new ApplicantSubmitted { ColorBlindInd = true }, acquisitionid);
            }

            var acq = ObjectBuilder.GetObject<IAcquisitionPersistence>(ACQUISITION_PERSISTENCE).GetAcquisition(acquisitionid);
            if (null == acq) return View(vm);
            if (null != acq.AcquisitionType)
            {
                vm.ServiceCode = acq.AcquisitionType.ServiceCd;
                vm.AcquisitionName = acq.AcquisitionType.AcquisitionTypeNm;
            }
            vm.AcquisitionSiri = acq.Siri.Value;
            vm.AcquisitionYear = acq.Year.Value;
            vm.Acquisition = acq;

            return View(vm);
        }

        [Authorize]
        public ActionResult TudmForm(int id, int acquisitionid)
        {
            var vm = new ResumeViewModel { ApplicantModel = new ApplicantModel { ApplicantId = 0, NationalityCd = "MYS", GenderCd = "L" }, AcquisitionId = acquisitionid };
            var zones = ObjectBuilder.GetObject<IReferencePersistence>("ReferencePersistence").GetZones().ToList();
            if (zones.Any())
                vm.Zones.AddRange(zones);

            if (id != 0 && acquisitionid != 0)
            {
                var applicant = ObjectBuilder.GetObject<IApplicantSubmittedPersistence>(APPLICANT_SUBMITTED_PERSISTENCE).GetApplicant(id, acquisitionid);
                if (null != applicant)
                {
                    vm.ApplicantModel = new ApplicantModel(applicant, acquisitionid);
                }
            }
            else
            {
                vm.ApplicantModel = new ApplicantModel(new ApplicantSubmitted { ColorBlindInd = true }, acquisitionid);
            }

            var acq = ObjectBuilder.GetObject<IAcquisitionPersistence>(ACQUISITION_PERSISTENCE).GetAcquisition(acquisitionid);
            if (null == acq) return View(vm);
            if (null != acq.AcquisitionType)
            {
                vm.ServiceCode = acq.AcquisitionType.ServiceCd;
                vm.AcquisitionName = acq.AcquisitionType.AcquisitionTypeNm;
            }
            vm.AcquisitionSiri = acq.Siri.Value;
            vm.AcquisitionYear = acq.Year.Value;
            vm.Acquisition = acq;
            return View(vm);
        }

        [Authorize]
        public ActionResult TdForm(int id, int acquisitionid)
        {
            var vm = new ResumeViewModel { ApplicantModel = new ApplicantModel { ApplicantId = 0, NationalityCd = "MYS", GenderCd = "L" }, AcquisitionId = acquisitionid };
            var zones = ObjectBuilder.GetObject<IReferencePersistence>("ReferencePersistence").GetZones().ToArray();
            if (zones.Any())
                vm.Zones.AddRange(zones);

            if (id != 0 && acquisitionid != 0)
            {
                var applicant = ObjectBuilder.GetObject<IApplicantSubmittedPersistence>(APPLICANT_SUBMITTED_PERSISTENCE).GetApplicant(id, acquisitionid);
                if (null != applicant)
                {
                    vm.ApplicantModel = new ApplicantModel(applicant, acquisitionid);
                }
            }
            else
            {
                vm.ApplicantModel = new ApplicantModel(new ApplicantSubmitted { ColorBlindInd = true }, acquisitionid);
            }


            var acq = ObjectBuilder.GetObject<IAcquisitionPersistence>(ACQUISITION_PERSISTENCE).GetAcquisition(acquisitionid);
            if (null != acq)
            {
                if (null != acq.AcquisitionType)
                {
                    vm.ServiceCode = acq.AcquisitionType.ServiceCd;
                    vm.AcquisitionName = acq.AcquisitionType.AcquisitionTypeNm;
                }
                vm.AcquisitionSiri = acq.Siri.Value;
                vm.AcquisitionYear = acq.Year.Value;
                vm.Acquisition = acq;
            }

            vm.MaritalStatuses.AddRange(ObjectBuilder.GetObject<IReferencePersistence>("ReferencePersistence").GetMaritalStatus());
            return View(vm);
        }

        [Authorize]
        public ActionResult GetSubmittedStates(int acquisitionid, bool? firstselection, bool? finalselection)
        {
            if (acquisitionid == 0) return Json(new {OK = false, message = "Tidak Berjaya"});
            var states = ObjectBuilder.GetObject<IApplicationPersistance>("ApplicationPersistance").GetSubmittedApplicationStates(acquisitionid, firstselection, finalselection);
            var enumerable = states as State[] ?? states.ToArray();
            if (states == null || !enumerable.Any())
                return Json(new
                {
                    OK = false,
                    message = "Tiada rekod"
                });
            var value = from a in enumerable
                orderby a.StateDesc
                select new
                {
                    Code = a.StateCd.Trim(),
                    Name = a.StateDesc
                };
            return Json(new
            {
                OK = true,
                message = "Rekod wujud",
                list = JsonConvert.SerializeObject(value)
            });
        }
        [Authorize]
        public ActionResult GetSubmittedCities(int acquisitionid, string statecode, bool? firstselection, bool? finalselection)
        {
            if (acquisitionid == 0) return Json(new {OK = false, message = "Tidak Berjaya"});
            var cities = ObjectBuilder.GetObject<IApplicationPersistance>("ApplicationPersistance").GetSubmittedApplicationCities(acquisitionid, statecode, firstselection, finalselection);
            var enumerable = cities as City[] ?? cities.ToArray();
            if (cities == null || !enumerable.Any())
                return Json(new
                {
                    OK = false,
                    message = "Tiada rekod"
                });
            var value = from a in enumerable
                orderby a.CityName
                select new
                {
                    Code = a.CityCd.Trim(),
                    Name = a.CityName
                };
            return Json(new
            {
                OK = true,
                message = "Rekod wujud",
                list = JsonConvert.SerializeObject(value)
            });
        }

        public ActionResult LoadSubmittedApplicant(JQueryDataTableParamModel param, string category, int acquisitionid, string statecode, string citycode, bool? invitationselection, bool? firstselection, bool? finalselection, int? invitationlocid, int? finalselectionlocid, int? reportdutylocid)
        {
            var applicants = new List<ApplicantSubmitted>();
            var total = 0;
            if (string.IsNullOrWhiteSpace(category))
                applicants.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>(APPLICANT_SUBMITTED_PERSISTENCE).Search(acquisitionid, param.sSearch, invitationselection, firstselection, finalselection, param.iDisplayLength, param.iDisplayStart, finalselectionlocid, reportdutylocid, statecode, citycode, null, out total));
            else
            {
                if (category == "11")
                    applicants.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>(APPLICANT_SUBMITTED_PERSISTENCE).Search(acquisitionid, param.sSearch, invitationselection, firstselection, finalselection, param.iDisplayLength, param.iDisplayStart, null, null, statecode, citycode, null, out total));
                if (category == "12")
                    applicants.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>(APPLICANT_SUBMITTED_PERSISTENCE).Search(acquisitionid, param.sSearch, invitationselection, firstselection, finalselection, param.iDisplayLength, param.iDisplayStart, 0, null, statecode, citycode, null, out total));
                if (category == "13")
                    applicants.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>(APPLICANT_SUBMITTED_PERSISTENCE).Search(acquisitionid, param.sSearch, invitationselection, firstselection, finalselection, param.iDisplayLength, param.iDisplayStart, finalselectionlocid, reportdutylocid, statecode, citycode, null, out total));
                if (category == "14")
                    applicants.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>(APPLICANT_SUBMITTED_PERSISTENCE).Search(acquisitionid, param.sSearch, invitationselection, firstselection, finalselection, param.iDisplayLength, param.iDisplayStart, null, 0, statecode, citycode, null, out total));
                if (category == "15")
                {
                    reportdutylocid = reportdutylocid.HasValue ? reportdutylocid : 0;
                    applicants.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>(APPLICANT_SUBMITTED_PERSISTENCE).Search(acquisitionid, param.sSearch, invitationselection, firstselection, finalselection, param.iDisplayLength, param.iDisplayStart, null, reportdutylocid, statecode, citycode, null, out total));
                }
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
                a.CorresponAddrStateNm,
                a.CorresponAddrCityNm,
                firstselection.HasValue ? a.Application.FinalSelActualAcqLocationId.HasValue ? a.Application.FinalSelectionLocation.Location.LocationNm : "Tiada" : finalselection.HasValue ? a.Application.ReportDutyLocId.HasValue ? a.Application.ReportDutyLocation.LocationNm : "Tiada" : "Tiada",
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


        public ActionResult SubmitProfile(ApplicantModel applicant, int acquisitionid)
        {
            if (null != applicant)
            {
                var app = new ApplicantSubmitted
                {
                    ApplicantId = applicant.ApplicantId,
                    AcquisitionId = acquisitionid,
                    Height = applicant.Height,
                    Weight = applicant.Weight,
                    FullName = applicant.FullName,
                    BMI = applicant.Bmi,
                    BirthCertNo = applicant.BirthCertNo,
                    BirthCityCd = applicant.BirthCityCd,
                    BirthCountryCd = applicant.BirthCountryCd,
                    BirthPlace = applicant.BirthPlace,
                    BirthStateCd = applicant.BirthStateCd,
                    BirthDt = applicant.BirthDate.HasValue ? applicant.BirthDate.Value : applicant.BirthDate,
                    CreatedBy = User.Identity.Name,
                    CreatedDt = DateTime.Now,
                    CorresponAddr1 = applicant.CorresponAddr1,
                    CorresponAddr2 = applicant.CorresponAddr2,
                    CorresponAddr3 = applicant.CorresponAddr3,
                    CorresponAddrCityCd = applicant.CorresponAddrCityCd,
                    CorresponAddrCountryCd = applicant.CorresponAddrCountryCd,
                    CorresponAddrPostCd = applicant.CorresponAddrPostCd,
                    CorresponAddrStateCd = applicant.CorresponAddrStateCd,
                    GenderCd = applicant.GenderCd,
                    NationalityCd = applicant.NationalityCd,
                    NationalityCertNo = applicant.NationalityCertNo,
                    MobilePhoneNo = applicant.MobilePhoneNo,
                    HomePhoneNo = applicant.HomePhoneNo,
                    DadNationalityCd = applicant.DadNationalityCd,
                    DadName = applicant.DadName,
                    DadICNo = applicant.DadIcNo,
                    DadOccupation = applicant.DadOccupation,
                    DadPhoneNo = applicant.DadPhoneNo,
                    DadSalary = applicant.DadSalary,
                    MomName = applicant.MomName,
                    MomNationalityCd = applicant.MomNationalityCd,
                    MomICNo = applicant.MomIcNo,
                    MomOccupation = applicant.MomOccupation,
                    MomSalary = applicant.MomSalary,
                    MomPhoneNo = applicant.MomPhoneNo,
                    MrtlStatusCd = applicant.MrtlStatusCd,
                    ChildNo = applicant.ChildNo,
                    ColorBlindInd = applicant.ColorBlindInd,
                    EthnicCd = applicant.EthnicCd,
                    RaceCd = applicant.RaceCd,
                    ReligionCd = applicant.ReligionCd,
                    Email = applicant.Email,
                    GuardianName = applicant.GuardianName,
                    GuardianNationalityCd = applicant.GuardianNationalityCd,
                    GuardianOccupation = applicant.GuardianOccupation,
                    GuardianICNo = applicant.GuardianIcNo,
                    GuardianSalary = applicant.GuardianSalary,
                    GuardianPhoneNo = applicant.GuardianPhoneNo,
                    NewICNo = applicant.NewIcNo,
                    ScholarshipContractStDate = applicant.ScholarshipContractStDate,
                    CurrentOccupation = applicant.CurrentOccupation,
                    SelectionTD = applicant.SelectionTD,
                    SelectionTL = applicant.SelectionTL,
                    SelectionTU = applicant.SelectionTU,
                    ArmyServiceInd = applicant.ArmyServiceInd,
                    ArmyServiceYrOfServ = applicant.ArmyServiceYrOfServ,
                    ArmyServiceResignRemark = applicant.ArmyServiceResignRemark,
                    ArmySelectionInd = applicant.ArmySelectionInd,
                    ArmySelectionDt = applicant.ArmySelectionDt,
                    ArmySelectionVenue = applicant.ArmySelectionVenue,
                    ComputerICT = applicant.ComputerICT,
                    ComputerMSExcel = applicant.ComputerMSExcel,
                    ComputerMSPwrPoint = applicant.ComputerMSPwrPoint,
                    ComputerMSWord = applicant.ComputerMSWord,
                    ComputerOthers = applicant.ComputerOthers,
                    PalapesArmyNo = applicant.PalapesArmyNo,
                    PalapesInd = applicant.PalapesInd,
                    PalapesInstitution = applicant.PalapesInstitution,
                    PalapesRemark = applicant.PalapesRemark,
                    PalapesServices = applicant.PalapesServices,
                    PalapesTauliahEndDt = applicant.PalapesTauliahEndDt,
                    PalapesYear = applicant.PalapesYear,
                    CurrentOrganisation = applicant.CurrentOrganisation,
                    CurrentSalary = applicant.CurrentSalary,
                    ScholarshipInd = applicant.ScholarshipInd,
                    ScholarshipBody = applicant.ScholarshipBody,
                    ScholarshipBodyAddr = applicant.ScholarshipBodyAddr,
                    ScholarshipNoOfYrContract = applicant.ScholarshipNoOfYrContract,
                    EmployeeAggreeInd = applicant.EmployeeAggreeInd,
                    CronicIlnessInd = applicant.CronicIlnessInd,
                    CrimeInvolvement = applicant.CrimeInvolvement,
                    DrugCaseInvolvement = applicant.DrugCaseInvolvement,
                    NoOfSibling = applicant.NoOfSibling,
                    NoTentera = applicant.NoTentera,
                    SpectaclesUserInd = applicant.SpectaclesUserInd,
                    OriginalPelepasanDocument = applicant.OriginalPelepasanDocument,
                    PelepasanDocument = applicant.PelepasanDocument,
                    MomNotApplicable = applicant.MomNotApplicable,
                    DadNotApplicable = applicant.DadNotApplicable,
                    GuardianNotApplicable = applicant.GuardianNotApplicable
                };

                var login = ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").GetByUserName(User.Identity.Name);

                var id = app.Save();
                if (id > 0)
                {
                    applicant.ApplicantId = id;
                    if (applicant.ApplicantEducationSubmitteds != null && applicant.ApplicantEducationSubmitteds.Any())
                    {
                        foreach (var edu in applicant.ApplicantEducationSubmitteds)
                        {
                            if (!string.IsNullOrWhiteSpace(edu.OverallGrade) || (edu.SKMLevel != null && edu.SKMLevel != 0) || (edu.ConfermentYr != null && edu.ConfermentYr != 0))
                            {
                                edu.ApplicantId = applicant.ApplicantId;
                                edu.CreatedBy = User.Identity.Name;
                                edu.CreatedDt = DateTime.Now;

                                if (edu.HighEduLevelCd == "08" || edu.HighEduLevelCd == "20")
                                {
                                    if (edu.OverSeaInd.HasValue && edu.OverSeaInd.Value)
                                        edu.InstCd = null;
                                    else
                                        edu.InstitutionName = null;
                                }

                                var apeduid = edu.Save();
                                foreach (var subject in edu.ApplicantEduSubjectSubmittedCollection.ToList())
                                {
                                    if (!string.IsNullOrWhiteSpace(subject.Grade) || !string.IsNullOrWhiteSpace(subject.GradeCd))
                                    {
                                        subject.GradeCd = !string.IsNullOrWhiteSpace(subject.GradeCd) ? subject.GradeCd.Trim() : subject.GradeCd;
                                        subject.Grade = !string.IsNullOrWhiteSpace(subject.Grade) ? subject.Grade.Trim() : subject.Grade;
                                        subject.ApplicantEduId = apeduid;
                                        subject.CreatedBy = User.Identity.Name;
                                        subject.CreatedDt = DateTime.Now;
                                        subject.Save();
                                    }
                                    else
                                    {
                                        edu.ApplicantEduSubjectSubmittedCollection.Remove(subject);
                                    }
                                }
                            }
                        }
                    }

                    if (applicant.SportSubmitteds != null && applicant.SportSubmitteds.Any())
                    {
                        foreach (var sp in applicant.SportSubmitteds)
                        {
                            if (sp.SportAssocId.HasValue && sp.SportAssocId.Value != 0 && !string.IsNullOrWhiteSpace(sp.AchievementCd))
                            {
                                sp.ApplicantId = applicant.ApplicantId;
                                sp.CreatedBy = User.Identity.Name;
                                sp.CreatedDt = DateTime.Now;
                                sp.Save();
                            }
                        }
                    }

                    if (applicant.KokoSubmitteds != null && applicant.KokoSubmitteds.Any())
                    {
                        foreach (var sp in applicant.KokoSubmitteds)
                        {
                            if (sp.SportAssocId.HasValue && sp.SportAssocId != 0)
                            {
                                sp.ApplicantId = applicant.ApplicantId;
                                sp.CreatedBy = User.Identity.Name;
                                sp.CreatedDt = DateTime.Now;
                                sp.Save();
                            }
                        }
                    }

                    if (applicant.OtherSubmitteds != null && applicant.OtherSubmitteds.Any())
                    {
                        foreach (var sp in applicant.OtherSubmitteds)
                        {
                            if (!string.IsNullOrWhiteSpace(sp.Others))
                            {
                                sp.SportAssocId = null;
                                sp.ApplicantId = applicant.ApplicantId;
                                sp.CreatedBy = User.Identity.Name;
                                sp.CreatedDt = DateTime.Now;
                                sp.Save();
                            }
                        }
                    }


                    if (applicant.SkillSubmitteds != null && applicant.SkillSubmitteds.Any())
                    {
                        foreach (var sp in applicant.SkillSubmitteds)
                        {
                            if (!string.IsNullOrWhiteSpace(sp.Skill) || !string.IsNullOrWhiteSpace(sp.SkillCd))
                            {
                                sp.ApplicantId = applicant.ApplicantId;
                                sp.CreatedBy = User.Identity.Name;
                                sp.CreatedDt = DateTime.Now;
                                sp.Save();
                            }
                        }
                    }


                    if (app.ApplicantId != 0)
                    {
                        app.LastModifiedBy = User.Identity.Name;
                        app.LastModifiedDt = DateTime.Now;
                        app.Save();
                    }

                    var appupdated = ObjectBuilder.GetObject<IApplicantSubmittedPersistence>(APPLICANT_SUBMITTED_PERSISTENCE).GetApplicant(id, acquisitionid);
                    return Json(new
                    {
                        OK = true,
                        message = "Berjaya",
                        id,
                        item = JsonConvert.SerializeObject(new ApplicantModel(appupdated, acquisitionid), Formatting.None, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore })
                    });
                }
            }
            return Json(new { OK = false, message = "Tidak Berjaya" });
        }


    }
}