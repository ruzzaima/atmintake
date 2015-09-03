using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using NHibernate.Dialect.Function;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;
using SevenH.MMCSB.Atm.Web.Models;
using Spring.Context.Support;
using Spring.Objects.Factory;

namespace SevenH.MMCSB.Atm.Web
{
    public class PublicController : Controller
    {

        private ILoginUserPersistance _mPersistence;

        public virtual ILoginUserPersistance LoginPersistance
        {
            get
            {
                if (((_mPersistence != null))) return _mPersistence;
                var ctx = ContextRegistry.GetContext();
                _mPersistence = ((IObjectFactory)ctx).GetObject("LoginUserPersistance") as ILoginUserPersistance;
                return _mPersistence;
            }
            set { _mPersistence = value; }
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            var exist = LoginPersistance.GetByUserName(model.IdNumber);
            if (null != exist) ModelState.AddModelError("", "Pengguna dengan Kad Pengenalan : " + model.IdNumber + " sudah wujud.");

            // check validity of id number
            if (!ATMHelper.MyKadValidation(model.IdNumber)) ModelState.AddModelError("", "Kad Pengenalan : " + model.IdNumber + " tidak sah.");
            string message;
            if (!ATMHelper.MyKadAgeValidation(model.IdNumber, out message)) ModelState.AddModelError("", message);
            // checking existing member of atm
            var atmexist = ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").ExistingAtmMember(model.IdNumber);
            if (null != atmexist)
            {
                if (atmexist.ExistingMemberStatus.Code.Trim() == "1")
                    ModelState.AddModelError("", "Anda tidak layak memohon kerana anda sedang berkhidmat di dalam ATM");
                if (atmexist.ExistingMemberStatus.Code.Trim() == "4")
                    ModelState.AddModelError("", "Anda tidak layak memohon kerana pernah menyertai ATM dan telah diberhentikan atas sebab tatatertib");
            }

            if (ModelState.IsValid)
            {
                // check no kad pengenalan valid or not
                var rand = new Random();
                model.IdNumber = model.IdNumber.Replace("-", "");
                model.IdNumber = model.IdNumber.Trim();
                var login = new LoginUser()
                {
                    FullName = model.FullName,
                    UserName = model.IdNumber,
                    LoginId = model.IdNumber,
                    Email = model.Email,
                    AlternativeEmail = model.AlternateEmail,
                    Salt = Guid.NewGuid().ToString(),
                    Password = "TEMP" + rand.Next(1, 9999).ToString().PadLeft(4, '0'),
                    FirstTime = true,
                    IsLocked = false,
                    CreatedDt = DateTime.Now,
                    CreatedBy = "Registration"
                };
                var id = login.Save();
                // send notification email
                var from = ConfigurationManager.AppSettings["fromEmail"];
                var url = this.Request.Url;
                if (url != null)
                {
                    var loginurl = ConfigurationManager.AppSettings["server"] + "/Account/Login";
                    var templatepath = Path.Combine(System.Web.HttpContext.Current.Server.MapPath(@"~/Templates"), "Registration.html");
                    var mail = new MailService();
                    mail.Send(from, new List<string> { login.Email, login.AlternativeEmail }, null, null, login, loginurl, templatepath, null);
                }
                TempData["Message"] = "Id pengguna dan Kata laluan telah dihantar ke emel yang didaftarkan. Sila semak emel anda.";
                return RedirectToAction("Login", "Account");
            }
            return View(model);
        }

        [Authorize]
        public ActionResult Account()
        {
            var vm = new UserAccountViewModel();
            var login = LoginPersistance.GetByUserName(User.Identity.Name);
            if (null != login)
            {
                vm.Id = login.UserId;
                vm.FullName = login.FullName;
                vm.IdNumber = login.LoginId;
                vm.Email = login.Email;
                vm.AlternateEmail = login.AlternativeEmail;
            }
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Account(UserAccountViewModel model)
        {
            if (ModelState.IsValid)
            {
                var login = LoginPersistance.GetByIdNumber(model.IdNumber);
                login.FullName = model.FullName;
                login.AlternativeEmail = model.AlternateEmail;
                login.Email = model.Email;
                var id = login.Save();
                return View(model);
            }
            return View(model);
        }

        [Authorize]
        public ActionResult Resume()
        {
            var vm = new ResumeViewModel() { ApplicantModel = new ApplicantModel() { ApplicantId = 0, NationalityCd = "MYS" } };
            var login = ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").GetByUserName(User.Identity.Name);
            if (null != login)
            {
                vm.ApplicantModel.FullName = login.FullName;
                vm.ApplicantModel.Email = login.Email;
                vm.ApplicantModel.NewIcNo = login.LoginId;
                if (login.ApplicantId.HasValue && login.ApplicantId.Value != 0)
                {
                    var applicant = ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").GetApplicant(login.ApplicantId.Value);
                    if (null != applicant)
                    {
                        vm.ApplicantModel = new ApplicantModel(applicant, 0);
                    }
                }

                // get all high education level
                var refrepos = new ReferenceRepo();
                var he = refrepos.GetHighEduLevels();
                if (he.Any())
                {
                    he = he.OrderBy(a => a.IndexNo);
                    foreach (var h in he)
                    {
                        var edu = new ApplicantEducation() { HighEduLevelCd = h.HighEduLevelCd, HighEduLevel = h.HighestEduLevel };
                        if (h.HighEduLevelCd == "14")
                        {
                            var subjects = refrepos.GetSubjects(h.HighEduLevelCd);
                            if (subjects.Any())
                                foreach (var s in subjects)
                                    edu.ApplicantEduSubjectCollection.Add(new ApplicantEduSubject() { SubjectCd = s.SubjectCd, Subject = s.SubjectDescription });
                        }
                        vm.ApplicantModel.ApplicantEducations.Add(edu);
                    }
                }
            }
            var repos = new ReferenceRepo();
            vm.MaritalStatuses.AddRange(repos.GetMaritalStatus());
            return View(vm);
        }


        [Authorize]
        public ActionResult PegawaiKadetForm(int id)
        {
            var vm = new ResumeViewModel() { ApplicantModel = new ApplicantModel() { ApplicantId = 0, NationalityCd = "MYS", GenderCd = "L" }, AcquisitionId = id };
            var login = ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").GetByUserName(User.Identity.Name);
            if (null != login && id != 0)
            {
                if (login.ApplicantId.HasValue && login.ApplicantId.Value != 0)
                {
                    var applicant = ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").GetApplicant(login.ApplicantId.Value);
                    if (null != applicant)
                    {
                        vm.ApplicantModel = new ApplicantModel(applicant, id);
                    }
                }
                else
                {
                    vm.ApplicantModel = new ApplicantModel(new Applicant() { NewICNo = login.LoginId, Email = login.Email, FullName = login.FullName, ColorBlindInd = true }, id);
                }

                vm.ApplicantModel.FullName = login.FullName;
                vm.ApplicantModel.Email = login.Email;
                vm.ApplicantModel.NewIcNo = login.LoginId;

                var acq = ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetAcquisition(id);
                if (null != acq)
                {
                    vm.Acquisition = acq;
                    vm.ServiceCode = acq.AcquisitionType.ServiceCd;
                }
            }
            return View(vm);
        }


        [Authorize]
        public ActionResult TLDMForm(int id)
        {
            var vm = new ResumeViewModel() { ApplicantModel = new ApplicantModel() { ApplicantId = 0, NationalityCd = "MYS", GenderCd = "L" }, AcquisitionId = id };
            var zones = ObjectBuilder.GetObject<IReferencePersistence>("ReferencePersistence").GetZones();
            if (null != zones && zones.Any())
                vm.Zones.AddRange(zones);
            var login = ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").GetByUserName(User.Identity.Name);
            if (null != login && id != 0)
            {
                if (login.ApplicantId.HasValue && login.ApplicantId.Value != 0)
                {
                    var applicant = ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").GetApplicant(login.ApplicantId.Value);
                    if (null != applicant)
                    {
                        vm.ApplicantModel = new ApplicantModel(applicant, id);
                    }
                }
                else
                {
                    vm.ApplicantModel = new ApplicantModel(new Applicant() { NewICNo = login.LoginId, Email = login.Email, FullName = login.FullName, ColorBlindInd = true }, id);
                }
                vm.ApplicantModel.FullName = login.FullName;
                vm.ApplicantModel.Email = login.Email;
                vm.ApplicantModel.NewIcNo = login.LoginId;

                var acq = ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetAcquisition(id);
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
            }
            var repos = new ReferenceRepo();
            vm.MaritalStatuses.AddRange(repos.GetMaritalStatus());
            return View(vm);
        }

        [Authorize]
        public ActionResult TUDMForm(int id)
        {
            var vm = new ResumeViewModel() { ApplicantModel = new ApplicantModel() { ApplicantId = 0, NationalityCd = "MYS", GenderCd = "L" }, AcquisitionId = id };
            var zones = ObjectBuilder.GetObject<IReferencePersistence>("ReferencePersistence").GetZones();
            if (null != zones && zones.Any())
                vm.Zones.AddRange(zones);
            var login = ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").GetByUserName(User.Identity.Name);
            if (null != login && id != 0)
            {
                if (login.ApplicantId.HasValue && login.ApplicantId.Value != 0)
                {
                    var applicant = ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").GetApplicant(login.ApplicantId.Value);
                    if (null != applicant)
                    {
                        vm.ApplicantModel = new ApplicantModel(applicant, id);
                    }
                }
                else
                {
                    vm.ApplicantModel = new ApplicantModel(new Applicant() { NewICNo = login.LoginId, Email = login.Email, FullName = login.FullName, ColorBlindInd = true }, id);
                }
                vm.ApplicantModel.FullName = login.FullName;
                vm.ApplicantModel.Email = login.Email;
                vm.ApplicantModel.NewIcNo = login.LoginId;

                var acq = ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetAcquisition(id);
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
            }
            var repos = new ReferenceRepo();
            vm.MaritalStatuses.AddRange(repos.GetMaritalStatus());
            return View(vm);
        }

        [Authorize]
        public ActionResult TDForm(int id)
        {
            var vm = new ResumeViewModel() { ApplicantModel = new ApplicantModel() { ApplicantId = 0, NationalityCd = "MYS", GenderCd = "L" }, AcquisitionId = id };
            var zones = ObjectBuilder.GetObject<IReferencePersistence>("ReferencePersistence").GetZones();
            if (null != zones && zones.Any())
                vm.Zones.AddRange(zones);

            var login = ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").GetByUserName(User.Identity.Name);
            if (null != login && id != 0)
            {
                if (login.ApplicantId.HasValue && login.ApplicantId.Value != 0)
                {
                    var applicant = ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").GetApplicant(login.ApplicantId.Value);
                    if (null != applicant)
                    {
                        vm.ApplicantModel = new ApplicantModel(applicant, id);
                    }
                }
                else
                {
                    vm.ApplicantModel = new ApplicantModel(new Applicant() { NewICNo = login.LoginId, Email = login.Email, FullName = login.FullName, ColorBlindInd = true }, id);
                }
                vm.ApplicantModel.FullName = login.FullName;
                vm.ApplicantModel.Email = login.Email;
                vm.ApplicantModel.NewIcNo = login.LoginId;

                var acq = ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetAcquisition(id);
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
            }
            vm.MaritalStatuses.AddRange(ObjectBuilder.GetObject<IReferencePersistence>("ReferencePersistence").GetMaritalStatus());
            return View(vm);
        }

        [Authorize]
        public ActionResult SubmissionNotification(int id)
        {
            var vm = new SubmissionNotificationViewModel();
            if (id != 0)
            {
                var app = ObjectBuilder.GetObject<IApplicationPersistance>("ApplicationPersistance").GetById(id);
                if (null != app)
                {
                    var applicant = ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence").GetApplicant(app.ApplicantId, app.AcquisitionId);
                    var acq = ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetAcquisition(app.AcquisitionId);
                    var acqtype = ObjectBuilder.GetObject<IReferencePersistence>("ReferencePersistence").GetAcquisitionType(acq.AcquisitionTypeCd.Value);
                    vm.RegisteredDateTime = app.CreatedDt.Value;
                    vm.Name = applicant.FullName;
                    vm.IdNumber = applicant.NewICNo;
                    vm.Service = acqtype.AcquisitionTypeNm;
                    vm.Siri = acq.Siri + "/" + acq.Year;
                    vm.Year = acq.Year.HasValue ? acq.Year.Value.ToString() : "";
                    vm.Acquisition = acq;
                }
            }
            return View(vm);
        }

        [Authorize]
        public ActionResult SubmitApplication(int acquisitionid)
        {
            var login = ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").GetByUserName(User.Identity.Name);
            if (null != login)
            {
                if (login.ApplicantId.HasValue)
                {
                    var applicant = ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").GetApplicant(login.ApplicantId.Value);

                    var message = string.Empty;
                    // check the criteria
                    if (!ATMHelper.ValidateHeightWeightBmi(Convert.ToDouble(applicant.Height), Convert.ToDouble(applicant.Weight), acquisitionid, applicant.GenderCd, out message))
                        return Json(new { OK = false, message = "Permohonan anda tidak berjaya dihantar." + message });

                    if (acquisitionid != 0)
                    {
                        // check based on acquisition
                        var acq = ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetAcquisition(acquisitionid);
                        if (null != acq)
                        {
                            var acqtype = ObjectBuilder.GetObject<IReferencePersistence>("ReferencePersistence").GetAcquisitionType(acq.AcquisitionTypeCd.Value);
                            if (acqtype != null)
                            {
                                // perempuan
                                if (acq.AcquisitionTypeCd == 3)
                                    if (applicant.GenderCd == "L")
                                        return Json(new { OK = false, message = "Permohonan anda tidak berjaya dihantar kerana pengambilan ini untuk " + acqtype.AcquisitionTypeNm });
                                // lelaki
                                if (acq.AcquisitionTypeCd == 2)
                                    if (applicant.GenderCd == "P")
                                        return Json(new { OK = false, message = "Permohonan anda tidak berjaya dihantar kerana pengambilan ini untuk " + acqtype.AcquisitionTypeNm });

                                // Pegawai.. Check the selection indicator
                                if (acqtype.ServiceCd == "10")
                                {
                                    if (!applicant.SelectionTD.HasValue && !applicant.SelectionTL.HasValue && !applicant.SelectionTU.HasValue)
                                        return Json(new { OK = false, message = "Permohonan anda tidak berjaya dihantar. Sila pilih Keutamaan Perkhidmatan Pilihan" });
                                }
                            }

                        }

                        // mandatory checking on profile photo
                        var photo = ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").GetPhoto(applicant.ApplicantId);
                        if (photo == null)
                            return Json(new { OK = false, message = "Permohonan anda tidak berjaya dihantar. Sila muat naik gambar peribadi berukuran pasport (saiz tidak melebihi 500KB)." });

                        if (photo.Photo == null && string.IsNullOrWhiteSpace(photo.PhotoExt))
                            return Json(new { OK = false, message = "Permohonan anda tidak berjaya dihantar. Sila muat naik gambar peribadi berukuran pasport (saiz tidak melebihi 500KB)." });

                        // mandatory checking on basic information
                        var peribadipoint = 0.0m;
                        var edupoint = 0.0m;
                        var spopoint = 0.0m;
                        var saspoint = 0.0m;
                        var chpoint = 0.0m;
                        ATMHelper.Checklist(applicant.ApplicantId, acquisitionid, out peribadipoint, out edupoint, out spopoint, out saspoint, out chpoint);

                        if (peribadipoint != 100m)
                            return Json(new { OK = false, message = "Permohonan anda tidak berjaya dihantar. Maklumat peribadi tidak lengkap." });
                        if (edupoint != 100m)
                            return Json(new { OK = false, message = "Permohonan anda tidak berjaya dihantar. Maklumat akademik tidak lengkap." });
                        if (chpoint != 100m)
                            return Json(new { OK = false, message = "Permohonan anda tidak berjaya dihantar. Maklumat pengakuan tidak lengkap." });

                        // copy applicant to applicant submitted
                        var app = new ApplicantSubmitted()
                                  {
                                      AcquisitionId = acquisitionid,
                                      Height = applicant.Height,
                                      Weight = applicant.Weight,
                                      FullName = applicant.FullName,
                                      BMI = applicant.BMI,
                                      BirthCertNo = applicant.BirthCertNo,
                                      BirthCityCd = applicant.BirthCityCd,
                                      BirthCountryCd = applicant.BirthCountryCd,
                                      BirthPlace = applicant.BirthPlace,
                                      BirthStateCd = applicant.BirthStateCd,
                                      BirthDt = applicant.BirthDt.HasValue ? applicant.BirthDt.Value : applicant.BirthDt,
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
                                      DadICNo = applicant.DadICNo,
                                      DadOccupation = applicant.DadOccupation,
                                      DadPhoneNo = applicant.DadPhoneNo,
                                      DadSalary = applicant.DadSalary,
                                      MomName = applicant.MomName,
                                      MomNationalityCd = applicant.NationalityCd,
                                      MomICNo = applicant.MomICNo,
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
                                      GuardianICNo = applicant.GuardianICNo,
                                      GuardianSalary = applicant.GuardianSalary,
                                      GuardianPhoneNo = applicant.GuardianPhoneNo,
                                      NewICNo = applicant.NewICNo,
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

                        var idsubmitted = app.Save();
                        if (idsubmitted != 0)
                        {
                            app.ApplicantId = idsubmitted;

                            // get educations
                            var education = ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").GetEducation(applicant.ApplicantId);
                            if (null != education && education.Any())
                            {
                                foreach (var edu in education)
                                {
                                    if (!string.IsNullOrWhiteSpace(edu.OverallGrade) || edu.SKMLevel != 0 ||
                                        edu.ConfermentYr != 0)
                                    {
                                        var subedu = new ApplicantEducationSubmitted
                                                     {
                                                         ApplicantId = app.ApplicantId,
                                                         ConfermentYr = edu.ConfermentYr,
                                                         EduCertTitle = edu.EduCertTitle,
                                                         HighEduLevel = edu.HighEduLevel,
                                                         HighEduLevelCd = edu.HighEduLevelCd,
                                                         InstCd = edu.InstCd,
                                                         InstitutionName = edu.InstitutionName,
                                                         OverSeaInd = edu.OverSeaInd,
                                                         MajorMinorCd = edu.MajorMinorCd,
                                                         OverallGrade = edu.OverallGrade,
                                                         SKMLevel = edu.SKMLevel,
                                                         CreatedBy = User.Identity.Name,
                                                         CreatedDt = DateTime.Now,
                                                     };
                                        var apeduid = subedu.Save();
                                        foreach (var subject in edu.ApplicantEduSubjectCollection)
                                        {
                                            if (!string.IsNullOrWhiteSpace(subject.Grade) ||
                                                !string.IsNullOrWhiteSpace(subject.GradeCd))
                                            {
                                                var subsubject = new ApplicantEduSubjectSubmitted
                                                                 {
                                                                     GradeCd = !string.IsNullOrWhiteSpace(subject.GradeCd) ? subject.GradeCd.Trim() : subject.GradeCd,
                                                                     Grade = !string.IsNullOrWhiteSpace(subject.Grade) ? subject.Grade.Trim() : subject.Grade,
                                                                     ApplicantEduId = apeduid,
                                                                     CreatedBy = User.Identity.Name,
                                                                     CreatedDt = DateTime.Now,
                                                                     Subject = subject.Subject,
                                                                     SubjectCd = subject.SubjectCd,
                                                                 };
                                                subsubject.Save();
                                            }
                                        }
                                    }
                                }
                            }

                            // get sports
                            var sports = ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").GetSport(applicant.ApplicantId);
                            if (null != sports && sports.Any())
                            {
                                foreach (var sp in sports)
                                {
                                    if ((sp.SportAssocId.HasValue && sp.SportAssocId != 0) || !string.IsNullOrWhiteSpace(sp.Others))
                                    {
                                        var ssp = new ApplicantSportSubmitted
                                                  {
                                                      ApplicantId = app.ApplicantId,
                                                      CreatedBy = User.Identity.Name,
                                                      CreatedDt = DateTime.Now,
                                                      AchievementCd = sp.AchievementCd,
                                                      Year = sp.Year,
                                                      Others = sp.Others,
                                                      SportAssocId = sp.SportAssocId
                                                  };
                                        ssp.Save();
                                    }
                                }
                            }

                            // get skills
                            var skills = ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").GetSkill(applicant.ApplicantId);
                            if (null != skills && skills.Any())
                            {
                                foreach (var sp in skills)
                                {
                                    var ssp = new ApplicantSkillSubmitted
                                                  {
                                                      ApplicantId = app.ApplicantId,
                                                      CreatedBy = User.Identity.Name,
                                                      CreatedDt = DateTime.Now,
                                                      LanguageSkillSpeak = sp.LanguageSkillSpeak,
                                                      LanguageSkillWrite = sp.LanguageSkillWrite,
                                                      Skill = sp.Skill,
                                                      AchievementCd = sp.AchievementCd,
                                                      Others = sp.Others,
                                                      SkillCatCd = sp.SkillCatCd,
                                                      SkillCd = sp.SkillCd,
                                                  };
                                    ssp.Save();
                                }
                            }

                            // get photo
                            if (photo.Photo != null && !string.IsNullOrWhiteSpace(photo.PhotoExt))
                            {
                                var sphoto = new ApplicantSubmittedPhoto()
                                             {
                                                 Photo = photo.Photo,
                                                 PhotoExt = photo.PhotoExt,
                                                 ApplicantId = app.ApplicantId,
                                                 CreatedBy = User.Identity.Name,
                                                 CreatedDate = DateTime.Now
                                             };

                                sphoto.Save();
                            }

                            var application = new Application()
                                              {
                                                  AcquisitionId = acquisitionid,
                                                  CreatedBy = User.Identity.Name,
                                                  CreatedDt = DateTime.Now,
                                                  ApplicantId = app.ApplicantId
                                              };
                            var id = application.Save();
                            if (id != 0)
                                return Json(new { OK = true, message = "Permohonan anda berjaya dihantar.", id = id });
                        }
                    }
                }
                return Json(new { OK = false, message = "Permohonan anda tidak berjaya dihantar kerana maklumat tidak lengkap." });
            }
            return Json(new { OK = false, message = "Permohonan anda tidak berjaya dihantar." });
        }

        [Authorize]
        public ActionResult Application()
        {
            var vm = new ApplicationViewModel();
            vm.ListOfAdvertisment.AddRange(ObjectBuilder.GetObject<IAdvertismentPersistance>("AdvertismentPersistance").GetAdvertisments(true, null));
            // check if there are already applied application
            foreach (var ads in vm.ListOfAdvertisment)
            {
                if (ads.AcquisitionId != 0)
                {
                    ads.Acquisition = ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetAcquisition(ads.AcquisitionId);
                }
            }
            var apps = ObjectBuilder.GetObject<IApplicationPersistance>("ApplicationPersistance").GetAllByApplicantIdNumber(User.Identity.Name);
            if (apps != null && apps.Any())
            {
                foreach (var ad in vm.ListOfAdvertisment)
                {
                    foreach (var ap in apps)
                    {
                        ad.IsApplied = ap.AcquisitionId == ad.AcquisitionId;
                    }
                }
            }
            return View(vm);
        }

        // checking existing in ApplicantModel table and ATM database based on IC
        public ActionResult IsExist(string mykadno)
        {
            return Json(new { OK = false, message = "Tidak Wujud" });
        }

        public ActionResult SubmitProfile(ApplicantModel applicant, int acquisitionid)
        {
            if (null != applicant)
            {
                var app = new Applicant()
                {
                    ApplicantId = applicant.ApplicantId,
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
                    if (applicant.ApplicantEducations != null && applicant.ApplicantEducations.Any())
                    {
                        foreach (var edu in applicant.ApplicantEducations)
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
                                foreach (var subject in edu.ApplicantEduSubjectCollection.ToList())
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
                                        edu.ApplicantEduSubjectCollection.Remove(subject);
                                    }
                                }
                            }
                        }
                    }

                    if (applicant.Sports != null && applicant.Sports.Any())
                    {
                        foreach (var sp in applicant.Sports)
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

                    if (applicant.Kokos != null && applicant.Kokos.Any())
                    {
                        foreach (var sp in applicant.Kokos)
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

                    if (applicant.Others != null && applicant.Others.Any())
                    {
                        foreach (var sp in applicant.Others)
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


                    if (applicant.Skills != null && applicant.Skills.Any())
                    {
                        foreach (var sp in applicant.Skills)
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
                    if (null != login)
                    {
                        login.ApplicantId = id;
                        if (!string.IsNullOrWhiteSpace(app.FullName))
                            login.FullName = app.FullName;
                        if (!string.IsNullOrWhiteSpace(app.Email))
                            login.Email = app.Email;
                        login.Save();

                        if (id != 0) Session["IsRegistered"] = "Yes"; else Session["IsRegistered"] = "No";

                    }

                    if (app.ApplicantId != 0)
                    {
                        app.LastModifiedBy = User.Identity.Name;
                        app.LastModifiedDt = DateTime.Now;
                        app.Save();
                    }

                    var appupdated = ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").GetApplicant(id);
                    return Json(new
                    {
                        OK = true,
                        message = "Berjaya",
                        id,
                        item = JsonConvert.SerializeObject(new ApplicantModel(appupdated, acquisitionid), Formatting.None, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore })
                    });
                }
            }
            return Json(new { OK = false, message = "Tidak Berjaya" });
        }

        public ActionResult SubmitSportAndKoko(IEnumerable<ApplicantSport> sports, IEnumerable<ApplicantSport> kokos, IEnumerable<ApplicantSport> others)
        {
            var login = ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").GetByUserName(User.Identity.Name);
            if (null != login)
            {
                if (login.ApplicantId != null)
                {
                    var applicant = ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").GetApplicant(login.ApplicantId.Value);


                    if (sports != null && sports.Any())
                    {
                        foreach (var s in sports)
                        {
                            s.ApplicantId = login.ApplicantId.Value;
                            // applicant.SportAndAssociations.Add(s);
                        }
                    }

                    if (kokos != null && kokos.Any())
                    {
                        foreach (var s in kokos)
                        {
                            s.ApplicantId = login.ApplicantId.Value;
                            //applicant.SportAndAssociations.Add(s);
                        }
                    }

                    applicant.Save();
                    return Json(new { OK = true, message = "Berjaya" });
                }
            }

            return Json(new { OK = false, message = "Tidak Berjaya" });
        }

        public ActionResult ValidateMyKad(string idnumber)
        {
            if (!ATMHelper.MyKadValidation(idnumber))
                return Json(new { OK = false, message = "No Kad Pengenalan : " + idnumber + " tidak sah. Sila masukkan 12 digit no kad pengenalan anda. <i>(Contoh: 900101011234)</i>" });
            string message;
            if (ATMHelper.MyKadAgeValidation(idnumber, out message))
                return Json(new { OK = true, message });
            return Json(new { OK = false, message });
        }

        [AllowAnonymous]
        public ActionResult CheckStatus(string idnumber, string captcha)
        {
            if (string.IsNullOrWhiteSpace(captcha))
                return Json(new { OK = false, message = "Sila masukkan perkataan yang tertera di dalam gambar." });
            if (Session["captchaText"] != null)
            {
                var sessioncaptcha = Session["captchaText"].ToString().Trim().ToLower();
                sessioncaptcha = sessioncaptcha.Trim();
                sessioncaptcha = sessioncaptcha.Replace(" ", string.Empty);
                captcha = captcha.ToLower().Trim();
                if (sessioncaptcha != captcha)
                    return Json(new { OK = false, message = "Perkataan yang dimasukkan tidak sama seperti di dalam gambar." });
            }

            if (!string.IsNullOrWhiteSpace(idnumber) && !string.IsNullOrWhiteSpace(captcha))
            {
                // delete generated image
                string imageFilePath = Server.MapPath("~/Images/") + Session.SessionID + ".png";
                System.IO.File.Delete(imageFilePath);

                var sb = new StringBuilder();
                var applicant = ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence").GetApplicants(idnumber);
                IEnumerable<ApplicantSubmitted> applicantSubmitteds = applicant as ApplicantSubmitted[] ?? applicant.ToArray();
                if (null != applicant && applicantSubmitteds.Any())
                {
                    var appname = "saudara/i";

                    sb.Append("<div class=\"row\">");
                    ApplicantSubmitted firstOrDefault = applicantSubmitteds.FirstOrDefault();
                    if (firstOrDefault != null)
                    {
                        sb.Append("<div class=\"row\">");
                        sb.Append(string.Format("<b>{0} {1}</b>", firstOrDefault.NewICNo, firstOrDefault.FullName));
                        sb.Append("</div>");
                    }
                    foreach (var ap in applicantSubmitteds)
                    {
                        // get application
                        if (ap.ApplicantId != 0)
                        {
                            var list = ObjectBuilder.GetObject<IApplicationPersistance>("ApplicationPersistance").GetAllByApplicantId(ap.ApplicantId);
                            foreach (var app in list)
                            {
                                sb.Append("<div class=\"row p-10\">");
                                var acq = ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetAcquisition(app.AcquisitionId);
                                if (acq.AcquisitionTypeCd != null)
                                    if (acq.AcquisitionType == null)
                                        acq.AcquisitionType = ObjectBuilder.GetObject<IReferencePersistence>("ReferencePersistence").GetAcquisitionType(acq.AcquisitionTypeCd.Value);

                                if (app.FinalSelectionInd.HasValue)
                                {
                                    if (app.FinalSelectionInd.Value)
                                    {
                                        if (acq.AcquisitionType.ServiceCd == "10")
                                            sb.Append("Tahniah, " + appname + " telah terpilih sebagai " + acq.AcquisitionType.AcquisitionTypeNm + ".");
                                        else
                                            sb.Append("Tahniah, " + appname + " telah terpilih sebagai " + acq.AcquisitionType.AcquisitionTypeNm + " " + acq.Siri + "/" + acq.Year + ".");

                                        sb.Append("<br/>Bagi memulakan latihan ketenteraan, sila lapor diri di:");
                                        sb.Append("<p>");
                                        sb.Append("<br/><b>Pusat Latihan </b>: " + (app.ReportDutyLocation != null ? app.ReportDutyLocation.LocationNm : "Tiada Rekod"));
                                        sb.Append("<br/><b>Tarikh </b>: " + string.Format("{0:dd MMM yyyy}", app.ReportDutyDate));
                                        sb.Append("<br/><b>Masa </b>: " + string.Format("{0:hh:mm tt}", app.ReportDutyDate));
                                        sb.Append("<br/><a href=\"#\" onclick=\"javascript:window.open('" + ATMHelper.ResolveServerUrl(VirtualPathUtility.ToAbsolute("~/SuppDoc/" + acq.ReportDutySupportingDocument), false) + "','finalsupp',null,true);\" style=\"color: #0000ff;\"><u>Download dokumen yang perlu diisi dan dibawa semasa lapor diri</u></a>");
                                        sb.Append("</p>");
                                    }
                                    else
                                    {
                                        if (acq.AcquisitionType.ServiceCd == "10")
                                            sb.Append("Dukacita dimaklumkan, " + appname + " tidak terpilih sebagai " + acq.AcquisitionType.AcquisitionTypeNm + ".");
                                        else
                                            sb.Append("Dukacita dimaklumkan, " + appname + " tidak terpilih sebagai " + acq.AcquisitionType.AcquisitionTypeNm + " " + acq.Siri + "/" + acq.Year + ".");
                                    }
                                }
                                else
                                {
                                    if (app.FirstSelectionInd.HasValue)
                                    {
                                        if (app.FirstSelectionInd.Value)
                                        {
                                            if (acq.AcquisitionType.ServiceCd == "10")
                                                sb.Append("Tahniah, " + appname + " layak untuk menghadiri temuduga pemilihan " + acq.AcquisitionType.AcquisitionTypeNm + ".");
                                            else
                                                sb.Append("Tahniah, " + appname + " layak untuk menghadiri temuduga pemilihan " + acq.AcquisitionType.AcquisitionTypeNm + " " + acq.Siri + "/" + acq.Year + ".");

                                            sb.Append("<br/>Butiran adalah seperti berikut:");
                                            sb.Append("<p>");
                                            sb.Append("<br/><b>Pusat Pemilihan </b> : " + (app.FinalSelectionLocation != null ? app.FinalSelectionLocation.Location.LocationNm : "Tiada Rekod"));
                                            sb.Append("<br/><b>Tarikh </b>: " + string.Format("{0:dd MMM yyyy}", app.FinalSelectionStartDate) + " - " + string.Format("{0:dd MMM yyyy}", app.FinalSelectionEndDate));
                                            sb.Append("<br/><b>Masa </b>: " + string.Format("{0:hh:mm tt}", app.FinalSelectionStartDate) + " - " + string.Format("{0:hh:mm tt}", app.FinalSelectionEndDate));
                                            sb.Append("<br/><a href=\"#\" onclick=\"javascript:window.open('" + ATMHelper.ResolveServerUrl(VirtualPathUtility.ToAbsolute("~/SuppDoc/" + acq.FinalSupportingDocument), false) + "','finalsupp',null,true);\" style=\"color: #0000ff;\"><u>Download dokumen yang perlu diisi dan dibawa semasa pemilihan</u></a>");
                                            sb.Append("</p>");
                                        }
                                        else
                                        {
                                            if (acq.AcquisitionType.ServiceCd == "10")
                                                sb.Append("Dukacita dimaklumkan, " + appname + " tidak layak untuk menghadiri temuduga pemilihan " + acq.AcquisitionType.AcquisitionTypeNm + ".");
                                            else
                                                sb.Append("Dukacita dimaklumkan, " + appname + " tidak layak untuk menghadiri temuduga pemilihan " + acq.AcquisitionType.AcquisitionTypeNm + " " + acq.Siri + "/" + acq.Year + ".");
                                        }
                                    }
                                    else
                                    {
                                        if (app.InvitationFirstSel.HasValue)
                                        {
                                            if (app.InvitationFirstSel.Value)
                                            {
                                                if (acq.AcquisitionType.ServiceCd == "10")
                                                    sb.Append("Tahniah, " + appname + " layak untuk menghadiri pemilihan awal " + acq.AcquisitionType.AcquisitionTypeNm + ".");
                                                else
                                                    sb.Append("Tahniah, " + appname + " layak untuk menghadiri pemilihan awal " + acq.AcquisitionType.AcquisitionTypeNm + " " + acq.Siri + "/" + acq.Year + ".");

                                                sb.Append("<br/>Sila hadir ke pusat pemilihan berikut:");
                                                sb.Append("<p>");
                                                sb.Append("<ul>");
                                                if (acq.AcquisitionLocationCollection != null && acq.AcquisitionLocationCollection.Any())
                                                {
                                                    foreach (var loc in acq.AcquisitionLocationCollection)
                                                        sb.Append("<li>" + loc.Location.LocationNm + "</li>");
                                                }
                                                sb.Append("</ul>");
                                                sb.Append("<p>");
                                            }
                                            else
                                            {
                                                if (acq.AcquisitionType.ServiceCd == "10")
                                                    sb.Append("Dukacita dimaklumkan, " + appname + " tidak layak untuk menghadiri pemilihan awal" + acq.AcquisitionType.AcquisitionTypeNm + ".");
                                                else
                                                    sb.Append("Dukacita dimaklumkan, " + appname + " tidak layak untuk menghadiri pemilihan awal " + acq.AcquisitionType.AcquisitionTypeNm + " " + acq.Siri + "/" + acq.Year + ".");
                                            }
                                        }
                                        else
                                        {
                                            sb.Append("Permohonan anda sedang diproses.");
                                        }
                                    }
                                }
                                sb.Append("</div");
                            }
                        }
                    }
                    sb.Append("</div>");
                    return Json(new { OK = false, message = sb.ToString() });
                }
            }
            return Json(new { OK = false, message = "Tiada rekod ditemui." });
        }

        public ActionResult CheckHeightWeightBmi(double? height, double? weight, string gendercode, int acquisitionid)
        {
            string message;
            var valid = ATMHelper.ValidateHeightWeightBmi(height, weight, acquisitionid, gendercode, out message);
            return Json(new { OK = valid, message = message });
        }

        public ActionResult CheckingGender(string gender, int acquisitionid)
        {
            if (!string.IsNullOrWhiteSpace(gender))
            {
                // get all acquisition which still on and service type is Tentera Darat
                var acq = ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetAcquisition(acquisitionid);
                var acqtype = ObjectBuilder.GetObject<IReferencePersistence>("ReferencePersistence").GetAcquisitionType(acq.AcquisitionTypeCd.Value);
                // TODO : Need to refine this
                // grab all advertisment where service code for TD = 01
                var ads = ObjectBuilder.GetObject<IAdvertismentPersistance>("AdvertismentPersistance").GetAdvertisments("01", DateTime.Now);
                if (acqtype == null) return Json(new { OK = false, message = "Jantina diperlukan." });
                // perempuan
                if (acq.AcquisitionTypeCd == 3)
                {
                    if (gender == "L")
                        return Json(new { OK = false, message = "Permohonan pengambilan ini untuk " + acqtype.AcquisitionTypeNm });
                }
                // lelaki
                if (acq.AcquisitionTypeCd == 2)
                {
                    if (gender == "P")
                        return Json(new { OK = false, message = "Permohonan pengambilan ini untuk " + acqtype.AcquisitionTypeNm });
                }
            }
            return Json(new { OK = false, message = "Jantina diperlukan." });
        }

        public ActionResult RemoveSportAndKokos(int appsid)
        {
            if (appsid != 0)
            {
                var appsport = ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").GetApplicantSportAndKokos(appsid);
                if (null != appsport)
                {
                    if (appsport.Delete())
                        return Json(new { OK = true, message = "Berjaya" });
                }
            }
            return Json(new { OK = false, message = "Tidak Berjaya" });
        }

        [AllowAnonymous]
        public ActionResult generateCaptcha()
        {
            System.Drawing.FontFamily family = new System.Drawing.FontFamily("Arial");
            CaptchaImage img = new CaptchaImage(150, 50, family);
            string text = img.CreateRandomText(4) + " " + img.CreateRandomText(3);
            img.SetText(text);
            img.GenerateImage();
            img.Image.Save(Server.MapPath("~/Images/") +
            Session.SessionID + ".png",
            System.Drawing.Imaging.ImageFormat.Png);
            Session["captchaText"] = text;
            return Json(Session.SessionID + ".png?t=" + DateTime.Now.Ticks, JsonRequestBehavior.AllowGet);
        }
    }
}