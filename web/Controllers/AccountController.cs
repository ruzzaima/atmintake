using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Security;
using Bespoke.Sph.Domain;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Web.Models;

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

        [AllowAnonymous]
        public ActionResult ResetPassword()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            //                if (role.CheckUserIsInRole(login.LoginId, RolesString.AWAM))
            //                    return RedirectToAction("Application", "Public");
            //                if (role.CheckUserIsInRole(login.LoginId, RolesString.SUPER_ADMIN))
            //                    return RedirectToAction("ManageUser", "Manage");
            //                if (role.CheckUserIsInRole(login.LoginId, RolesString.PEGAWAI_PENGAMBILAN) || role.CheckUserIsInRole(User.Identity.Name, RolesString.KERANI_PENGAMBILAN) || role.CheckUserIsInRole(User.Identity.Name, RolesString.STATISTIC))
            //                    return RedirectToAction("Intakes", "Admin");

            var logger = Bespoke.Sph.Domain.ObjectBuilder.GetObject<ILogger>();
            if (ModelState.IsValid)
            {
                var directory = Bespoke.Sph.Domain.ObjectBuilder.GetObject<IDirectoryService>();
                if (await directory.AuthenticateAsync(model.UserName, model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
                    var context = new SphDataContext();
                    var profile = await context.LoadOneAsync<UserProfile>(u => u.UserName == model.UserName);
                    await logger.LogAsync(new LogEntry { Log = EventLog.Security });
                    if (null != profile)
                    {
                        if (!profile.HasChangedDefaultPassword)
                            return RedirectToAction("ChangePassword");
                        if (returnUrl == "/" ||
                            returnUrl.Equals("/epsikologi", StringComparison.InvariantCultureIgnoreCase) ||
                            returnUrl.Equals("/epsikologi#", StringComparison.InvariantCultureIgnoreCase) ||
                            returnUrl.Equals("/epsikologi/", StringComparison.InvariantCultureIgnoreCase) ||
                            returnUrl.Equals("/epsikologi/#", StringComparison.InvariantCultureIgnoreCase) ||
                            string.IsNullOrWhiteSpace(returnUrl))
                            return Redirect("/epsikologi#" + profile.StartModule);
                    }
                    if (!string.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl))
                        return Redirect(returnUrl);
                    return Redirect("epsikologi#");
                }
                var user = await directory.GetUserAsync(model.UserName);
                await logger.LogAsync(new LogEntry { Log = EventLog.Security, Message = "Login Failed" });
                if (null != user && user.IsLockedOut)
                    ModelState.AddModelError("", "Your acount has beeen locked, Please contact your administrator.");
                else
                    ModelState.AddModelError("", "The user name or password provided is incorrect.");
            }

            return View(model);
        }

        
        public ActionResult FirstTimeLogin()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> FirstTimeLogin(FirstTimeViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            var context = new SphDataContext();
            var login = (await context.LoadOneAsync<UserProfile>(x => x.UserName == User.Identity.Name)) as LoginUser;
            if (null != login)
            {
                login.FirstTime = false;
                // TODO : login.ChangePasswordFirstTime(model.Password);
                FormsAuthentication.SignOut();
                TempData["Message"] = "Kata laluan telah ditukar. Sila log masuk semula.";
                return RedirectToAction("Login", "Account");
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }
        
    }
}