﻿using System;
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

        public ActionResult SearchingApplicant(JQueryDataTableParamModel param, int acquisitionid, string category, string name, string icno, bool? firstinvitation, bool? finalinvitation)
        {
            var applicants = ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence").Search(acquisitionid, category, name, icno, param.sSearch, firstinvitation, finalinvitation);

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
                a.ApplicantId.ToString(),
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

        public ActionResult LoadToUpdateApplicant(JQueryDataTableParamModel param, int acquisitionid, string category, string name, string icno, bool? firstinvitation, bool? finalinvitation)
        {
            var applicants = ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence").Search(acquisitionid, category, name, icno, param.sSearch, firstinvitation, finalinvitation);

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
                a.Application == null ? "Belum Hantar" : a.Application.InvitationFirstSel.HasValue ? a.Application.InvitationFirstSel.Value ? "Terpilih Panggilan Awal" : "Tidak Terpilih Panggilan Awal" : "Tidak Terpilih Pemilihan Awal",
                a.ApplicantId.ToString(),
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

        public ActionResult SubmitFirstSelection(int[] candidates)
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
                    if (candidates != null && candidates.Any())
                    {
                        foreach (var c in candidates)
                        {
                            if (ObjectBuilder.GetObject<IApplicationPersistance>("ApplicationPersistance").UpdateStatus(did, c, true, null, null, null, User.Identity.Name) > 0)
                            {
                                // sending an email
                                if (null != announcement)
                                {
                                    var applicant = persistance.GetApplicant(c);
                                    if (null != applicant)
                                    {
                                        var mail = new MailService();
                                        mail.SendWithMessage(from, new List<string> { applicant.Email }, null, null, null, announcement.Header, announcement.Body, null);
                                    }
                                }
                            }
                        }
                        return Json(new { OK = true, message = "Berjaya" });
                    }
                }
            }
            return Json(new { OK = false, message = "Tidak Berjaya" });
        }
        public ActionResult SubmitFinalSelection(int[] candidates, int[] approvecandidates)
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

                    if (approvecandidates != null && approvecandidates.Any())
                    {
                        foreach (var c in approvecandidates)
                        {
                            ObjectBuilder.GetObject<IApplicationPersistance>("ApplicationPersistance").UpdateStatus(did, c, null, true, null, null, User.Identity.Name);
                        }
                    }

                    if (candidates != null && candidates.Any())
                    {
                        foreach (var c in candidates)
                        {
                            if (ObjectBuilder.GetObject<IApplicationPersistance>("ApplicationPersistance").UpdateStatus(did, c, null, null, true, null, User.Identity.Name) > 0)
                            {
                                // sending an email
                            }
                        }
                    }
                    return Json(new { OK = true, message = "Berjaya" });
                }
            }
            return Json(new { OK = false, message = "Tidak Berjaya" });
        }
        public ActionResult SubmitLastSelection(int[] candidates, int[] approvecandidates, int[] rejectedcandidates)
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

                    if (approvecandidates != null && approvecandidates.Any())
                    {
                        foreach (var c in approvecandidates)
                        {
                            ObjectBuilder.GetObject<IApplicationPersistance>("ApplicationPersistance").UpdateStatus(did, c, true, true, true, null, User.Identity.Name);
                        }
                    }

                    if (rejectedcandidates != null && rejectedcandidates.Any())
                    {
                        foreach (var c in rejectedcandidates)
                        {
                            ObjectBuilder.GetObject<IApplicationPersistance>("ApplicationPersistance").UpdateStatus(did, c, true, true, true, false, User.Identity.Name);
                        }
                    }

                    if (candidates != null && candidates.Any())
                    {
                        foreach (var c in candidates)
                        {
                            if (ObjectBuilder.GetObject<IApplicationPersistance>("ApplicationPersistance").UpdateStatus(did, c, true, true, true, true, User.Identity.Name) > 0)
                            {
                                // sending an email
                            }
                        }
                    }
                    return Json(new { OK = true, message = "Berjaya" });
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
                        vm.ListOfApplicant.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence").Search(did, string.Empty, string.Empty, string.Empty, string.Empty, null, true));
                    }

                }
            }
            return View(vm);
        }

        public ActionResult PrintFinalInvitation()
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
                        vm.ListOfApplicant.AddRange(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence").Search(did, string.Empty, string.Empty, string.Empty, string.Empty, null, true));
                    }

                }
            }
            return View(vm);
        }
    }
}