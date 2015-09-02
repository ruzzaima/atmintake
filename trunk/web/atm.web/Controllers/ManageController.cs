using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common.Logging;
using NHibernate.Engine;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;
using SevenH.MMCSB.Atm.Web.Models;

namespace SevenH.MMCSB.Atm.Web.Controllers
{
    [AtmAuthorize(Roles = RolesString.SUPER_ADMIN)]
    public class ManageController : Controller
    {
        public ActionResult ManageUser()
        {
            return View();
        }

        public ActionResult UserProfile(int? id)
        {
            var vm = new AddUserViewModel();
            var services = ObjectBuilder.GetObject<IReferencePersistence>("ReferencePersistence").GetServices();
            var enumerable = services as IList<Service> ?? services.ToList();
            if (enumerable.Any())
                vm.ListOfService.AddRange(enumerable);
            if (id.HasValue)
                vm.LoginUser = ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").GetById(id.Value);
            else
                vm.LoginUser.Status = "Y";

            return View(vm);
        }

        public ActionResult CheckInAtm(int id)
        {
            if (id != 0)
            {
                var atmexist = ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").ExistingAtmMemberByArmyNo(id);
                if (null != atmexist)
                {
                    if (atmexist.ExistingMemberStatus != null)
                    {
                        if (atmexist.ExistingMemberStatus.Code.Trim() != "1")
                            return Json(new { OK = false, message = "Anda tidak layak memohon kerana anda tidak berkhidmat di dalam ATM." });
                        else
                            return Json(new { OK = true, message = "Pengguna wujud dan layak.", name = atmexist.Name });
                    }
                    return Json(new { OK = false, message = "Maklumat status tidak wujud." });
                }
                else
                {
                    return Json(new { OK = false, message = "Maklumat pengguna tidak wujud di dalam HRMIS." });
                }
            }
            return Json(new { OK = false, message = "Sila bekalkan maklumat pengguna." });
        }

        public ActionResult SubmitUser(LoginUser loguser)
        {
            if (loguser.LoginRole != null && !string.IsNullOrWhiteSpace(loguser.LoginRole.Roles))
            {
                if (loguser.LoginRole != null)
                {
                    if (loguser.LoginRole.Roles != RolesString.AWAM)
                    {
                        loguser.Email = "NA";
                        loguser.AlternativeEmail = "NA";
                        if (loguser.UserId == 0)
                            loguser.Salt = Guid.NewGuid().ToString();
                    }
                }
                loguser.CreatedDt = DateTime.Now;
                loguser.CreatedBy = User.Identity.Name;
                loguser.IsLocked = loguser.Status != "Aktif";
                if (loguser.Save() > 0)
                {
                    var user = ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").GetByUserName(User.Identity.Name);
                    if (null != user)
                        ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").LoggingUser(user.UserId, LogStatusCodeString.Create_User, User.Identity.Name, DateTime.Now);
                    return Json(new { OK = true, message = "Berjaya." });
                }
            }
            return Json(new { OK = false, message = "Tidak Berjaya." });
        }

        public ActionResult SubmitAndEmailUser(LoginUser loguser)
        {
            if (loguser.LoginRole != null && !string.IsNullOrWhiteSpace(loguser.Email))
            {
                if (loguser.LoginRole != null)
                {
                    if (loguser.LoginRole.Roles != RolesString.AWAM)
                    {
                        loguser.Email = "NA";
                        loguser.AlternativeEmail = "NA";
                        if (loguser.UserId == 0)
                            loguser.Salt = Guid.NewGuid().ToString();
                    }
                }
                if (loguser.UserId == 0)
                {
                    loguser.CreatedDt = DateTime.Now;
                    loguser.CreatedBy = User.Identity.Name;
                }
                loguser.IsLocked = loguser.Status != "Aktif";
                loguser.FirstTime = true;
                if (loguser.Save() > 0)
                {
                    // change the password if the is new password
                    if (loguser.UserId != 0)
                        loguser.ChangePassword(loguser.Password);

                    var user = ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").GetByUserName(User.Identity.Name);
                    if (null != user)
                    {
                        var url = this.Request.Url;
                        if (url != null)
                        {
                            var from = ConfigurationManager.AppSettings["fromEmail"];
                            var loginurl = ConfigurationManager.AppSettings["server"] + "/Account/Login";
                            var templatepath = Path.Combine(System.Web.HttpContext.Current.Server.MapPath(@"~/Templates"), "TempPassword.html");
                            var mail = new MailService();
                            mail.SendMail("[JOM MASUK TENTERA]Notifikasi Kata Laluan Sementara", from, new List<string> { loguser.Email, loguser.AlternativeEmail }, null, null, loguser, loginurl, templatepath, DateTime.Now);
                        }
                        ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").LoggingUser(user.UserId, LogStatusCodeString.Create_User, User.Identity.Name, DateTime.Now);
                    }
                    return Json(new { OK = true, message = "Berjaya." });
                }
            }
            return Json(new { OK = false, message = "Tidak Berjaya." });
        }


        public ActionResult DeleteUser(int userid)
        {
            if (userid != 0)
            {
                var user = ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").GetById(userid);
                if (null != user)
                {
                    if (!user.ApplicantId.HasValue)
                    {
                        if (ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").Delete(userid))
                            return Json(new { OK = true, message = "Makluamt pengguna berjaya dibuang." });
                    }
                }
            }
            return Json(new { OK = false, message = "Tidak Berjaya." });
        }

        public ActionResult LoadUser(JQueryDataTableParamModel param, string category)
        {

            IEnumerable<LoginUser> users = null;

            if (!string.IsNullOrWhiteSpace(category))
            {
                if (category == "SP")
                    users = ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").LoadAllUser(true, true, string.Empty, param.sSearch, param.iDisplayLength, param.iDisplayStart);
                if (category == "AW")
                    users = ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").LoadAllUser(false, true, string.Empty, param.sSearch, param.iDisplayLength, param.iDisplayStart);
            }
            else
                users = ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").LoadAllUser(true, true, string.Empty, param.sSearch, param.iDisplayLength, param.iDisplayStart);

            var sortColumnIndex = Convert.ToInt32(Request["iSortCol_0"]);
            Func<LoginUser, string> orderingFunction = (c => sortColumnIndex == 0 ? c.FullName : sortColumnIndex == 1 ? c.FullName : c.LoginId);
            var sortDirection = Request["sSortDir_0"]; // asc or desc
            if (sortDirection == "asc")
            {
                if (users != null) users = users.OrderBy(orderingFunction);
            }
            else if (users != null) users = users.OrderByDescending(orderingFunction);

            var loginUsers = users as IList<LoginUser> ?? users.ToList();
            var aadata = loginUsers.Select(a => new string[]
            {
                a.UserId.ToString(),
                a.FullName,
                a.LoginId,
                string.Format("{0}<br/>{1}", a.Email, a.AlternativeEmail),
                a.ServiceName,
                a.LoginRole.Roles,
                a.IsLocked ? "Tidak Aktif" : "Aktif",
                string.Format("{0:dd/MM/yyyy hh:mm:tt}", a.LastLoginDt),
                a.UserId.ToString()
            }).ToList().Skip(param.iDisplayStart).Take(param.iDisplayLength);

            return Json(new
            {
                OK = true,
                message = "Succeed",
                sEcho = param.sEcho,
                iTotalRecords = loginUsers.Count(),
                iTotalDisplayRecords = loginUsers.Count(),
                aaData = aadata,
            }, JsonRequestBehavior.AllowGet);
        }

    }
}