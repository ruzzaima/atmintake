using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Security;
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
                        return RedirectToAction("Index", "Home");
                    }
                    ModelState.AddModelError("", "Kata Laluan tidak sah");
                }
                ModelState.AddModelError("", "ID Pengguna tidak wujud");
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
                        return RedirectToAction("Account", "Public");
                    }
                    ModelState.AddModelError("", "Kata laluan tidak tepat");
                }
                ModelState.AddModelError("", "ID Pengguna tidak wujud");
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> LoginFromMain(string username, string password, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var login = ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").GetByUserName(username);
                if (null != login)
                {
                    if (ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").Validate(username, password))
                    {
                        FormsAuthentication.SetAuthCookie(username, true);
                        if (login.FirstTime)
                            return RedirectToAction("FirstTimeLogin", "Account");
                        return RedirectToAction("Account", "Public");
                    }
                    ModelState.AddModelError("", "Kata laluan tidak tepat");
                }
                ModelState.AddModelError("", "ID Pengguna tidak wujud");
            }
            return RedirectToAction("Index", "Home");
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
                    return RedirectToAction("Index", "Home");
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }
    }
}