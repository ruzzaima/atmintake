using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Security;
using FluentNHibernate.Conventions.Inspections;
using NHibernate.Cfg;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;
using SevenH.MMCSB.Atm.Web.Models;
using Spring.Context.Support;
using Spring.Objects.Factory;

namespace SevenH.MMCSB.Atm.Web
{
    [Authorize]
    public class AccountController : Controller
    {
        [AllowAnonymous]
        public ActionResult ForgotPassword()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var login = ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").GetByIdNumber(model.IdNumber);
                if (null != login)
                {
                    // compare the email with previous for validity checking
                    if (model.Email.ToLower().Trim() != login.Email.ToLower().Trim() && model.Email.ToLower().Trim() != login.AlternativeEmail.ToLower().Trim())
                        ModelState.AddModelError("", "Email yang dimasukkan tidak menepati rekod sedia ada.");

                    if (ModelState.IsValid)
                    {
                        // create temp password and mark as first time login back to force user to change their password back
                        var random = new Random();
                        var temppass = "TEMP" + random.Next(1000, 9999);
                        login.FirstTime = true;
                        login.ChangePasswordFirstTime(temppass);
                        login.Password = temppass;
                        var from = ConfigurationManager.AppSettings["fromEmail"];
                        // send notification email
                        var url = this.Request.Url;
                        if (url != null)
                        {
                            var loginurl = ConfigurationManager.AppSettings["server"] + "/Account/Login";
                            var templatepath = Path.Combine(System.Web.HttpContext.Current.Server.MapPath(@"~/Templates"), "ForgotPassword.html");
                            var mail = new MailService();
                            mail.SendForgotPassword(from, new List<string> { login.Email, login.AlternativeEmail }, null, null, login, loginurl, templatepath, DateTime.Now);
                        }

                        TempData["Message"] = "Kata laluan sementara telah dihantar ke emel yang didaftarkan. Sila semak emel anda.";
                        return RedirectToAction("Login", "Account");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Id pengguna tidak wujud.");
                }
            }
            // If we got this far, something failed, redisplay form
            return View(model);
        }

        [AllowAnonymous]
        public ActionResult ResetPassword()
        {
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ResetPassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var login = ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").GetByUserName(User.Identity.Name);
                if (null != login)
                {
                    if (ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").Validate(User.Identity.Name, model.Password))
                    {
                        ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").ChangePassword(login.UserId, model.NewPassword);
                        FormsAuthentication.SignOut();
                        TempData["Message"] = "Kata laluan telah ditukar. Sila log masuk semula.";
                        return RedirectToAction("Login", "Account");
                    }
                    ModelState.AddModelError("", "Kata Laluan tidak sah.");
                }
                ModelState.AddModelError("", "ID Pengguna tidak wujud.");
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var login = ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").GetByUserName(model.UserName);
                if (null != login)
                {
                    if (ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").Validate(model.UserName, model.Password))
                    {
                        FormsAuthentication.SetAuthCookie(model.UserName, true);
                        if (login.FirstTime)
                            return RedirectToAction("FirstTimeLogin", "Account");
                        login.LastLoginDt = DateTime.Now;
                        login.Save();
                        if (login.ApplicantId.HasValue) Session["IsRegistered"] = "Yes"; else Session["IsRegistered"] = "No";
                        return RedirectToAction("Application", "Public");
                    }
                    ModelState.AddModelError("", "Kata laluan tidak tepat.");
                }
                else
                {
                    ModelState.AddModelError("", "ID Pengguna tidak wujud.");
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> LoginFromMain(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var login = ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").GetByUserName(model.UserName);
                if (null != login)
                {
                    if (ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").Validate(model.UserName, model.Password))
                    {
                        FormsAuthentication.SetAuthCookie(model.UserName, true);
                        if (login.FirstTime)
                            return RedirectToAction("FirstTimeLogin", "Account");
                        return RedirectToAction("Account", "Public");
                    }
                    ModelState.AddModelError("", "Kata laluan tidak tepat.");
                }
                ModelState.AddModelError("", "ID Pengguna tidak wujud.");
            }
            // for login from main only

            var vm = new HomeViewModel();
            vm.ListOfAdvertisment.AddRange(ObjectBuilder.GetObject<IAdvertismentPersistance>("AdvertismentPersistance").GetAdvertisments(true, null));
            vm.LoginModel = model;
            return View("~/Views/Home/Index.cshtml", vm);
        }

        //
        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        //
        // POST: /Account/LogOff
        [HttpPost]
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return Json(new { OK = true, message = "Log Keluar" });
        }

        public ActionResult FirstTimeLogin()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> FirstTimeLogin(FirstTimeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var login = ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").GetByUserName(User.Identity.Name);
                if (null != login)
                {
                    login.FirstTime = false;
                    login.ChangePasswordFirstTime(model.Password);
                    FormsAuthentication.SignOut();
                    TempData["Message"] = "Kata laluan telah ditukar. Sila log masuk semula.";
                    return RedirectToAction("Login", "Account");
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }
    }
}