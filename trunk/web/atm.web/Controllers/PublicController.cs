using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
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
            if (null != exist) ModelState.AddModelError("", "Pengguna dengan Kad Pengenalan : " + model.IdNumber + " sudah wujud");

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
                var url = this.Request.Url;
                if (url != null)
                {
                    var loginurl = Url.Action("Login", "Account", null, url.Scheme);

                    var templatepath = Path.Combine(System.Web.HttpContext.Current.Server.MapPath(@"~/Templates"), "Registration.html");
                    var mail = new MailService();
                    mail.Send("hakimin@sevenhit.com", new List<string> { login.Email, login.AlternativeEmail }, null, null, login, loginurl, templatepath);
                }
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        public ActionResult Account()
        {
            var vm = new UserAccountViewModel();
            var login = LoginPersistance.GetByUserName(User.Identity.Name);
            if (null != login)
            {
                vm.FullName = login.FullName;
                vm.IdNumber = login.LoginId;
                vm.Email = login.Email;
                vm.AlternateEmail = login.AlternativeEmail;
            }
            return View(vm);
        }

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
                        vm.ApplicantModel = new ApplicantModel(applicant);
                    }
                }
            }
            var repos = new ReferenceRepo();
            vm.MaritalStatuses.AddRange(repos.GetMaritalStatus());
            return View(vm);
        }

        public ActionResult Application()
        {
            return View();
        }

        // checking existing in ApplicantModel table and ATM database based on IC
        public ActionResult IsExist(string mykadno)
        {
            return Json(new { OK = false, message = "Tidak Wujud" });
        }

        public ActionResult SubmitProfile(ApplicantModel applicant)
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
                    BirthDt = applicant.BirthDate,
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
                    DadNationalityCd = applicant.DadNationalityCd,
                    GuardianNationalityCd = applicant.GuardianNationalityCd,
                    DadName = applicant.DadName,
                    GuardianName = applicant.GuardianName,
                    MomName = applicant.MomName,
                    MomNationalityCd = applicant.NationalityCd,
                    MobilePhoneNo = applicant.MobilePhoneNo,
                    HomePhoneNo = applicant.HomePhoneNo,
                    MomICNo = applicant.MomIcNo,
                    MomOccupation = applicant.MomOccupation,
                    MomSalary = applicant.MomSalary,
                    MrtlStatusCd = applicant.MrtlStatusCd,
                    ChildNo = applicant.ChildNo,
                    ColorBlindInd = applicant.ColorBlindInd,
                    EthnicCd = applicant.EthnicCd,
                    RaceCd = applicant.RaceCd,
                    ReligionCd = applicant.ReligionCd,
                    Email = applicant.Email,
                    GuardianOccupation = applicant.GuardianOccupation,
                    GuardianICNo = applicant.GuardianIcNo,
                    GuardianSalary = applicant.GuardianSalary,
                    NewICNo = applicant.NewIcNo
                };

                var id = app.Save();
                if (id > 0)
                {
                    var login = ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").GetByUserName(User.Identity.Name);
                    if (null != login)
                    {
                        login.ApplicantId = id;
                        login.Save();
                    }
                    return Json(new { OK = true, message = "Berjaya", id });
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
                            applicant.SportAndAssociations.Add(s);
                        }
                    }

                    if (kokos != null && kokos.Any())
                    {
                        foreach (var s in kokos)
                        {
                            s.ApplicantId = login.ApplicantId.Value;
                            applicant.SportAndAssociations.Add(s);
                        }
                    }

                    applicant.Save();
                    return Json(new { OK = true, message = "Berjaya" });
                }
            }

            return Json(new { OK = false, message = "Tidak Berjaya" });
        }
    }
}