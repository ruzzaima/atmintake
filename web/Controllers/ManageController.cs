﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Security;
using Bespoke.Sph.Domain;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;
using SevenH.MMCSB.Atm.Web.Models;
using ObjectBuilder = SevenH.MMCSB.Atm.Domain.ObjectBuilder;

namespace SevenH.MMCSB.Atm.Web.Controllers
{
    [Authorize(Roles = RolesString.SUPER_ADMIN + "," + RolesString.PEGAWAI_PENGAMBILAN + "," + RolesString.KERANI_PENGAMBILAN)]
    public class ManageController : Controller
    {
        public ActionResult ManageUser()
        {
            return View();
        }

        public async Task<ActionResult> UserProfile(string id)
        {
            var context = new SphDataContext();
            var user = await context.LoadOneAsync<UserProfile>(x => x.Id == id);

            var vm = new AddUserViewModel();
            var services = ObjectBuilder.GetObject<IReferencePersistence>("ReferencePersistence").GetServices();
            var enumerable = services as IList<Service> ?? services.ToList();
            if (enumerable.Any())
                vm.ListOfService.AddRange(enumerable);
            if (null != user)
                vm.LoginUser = user as LoginUser;
            else
                vm.LoginUser.Status = "Y";

            return View(vm);
        }

        public ActionResult CheckInAtm(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return Json(new {OK = false, message = "Sila bekalkan maklumat pengguna."});
            var atmexist = ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").ExistingAtmMemberByArmyNo(id);
            if (null != atmexist)
            {
                if (atmexist.ExistingMemberStatus != null)
                {
                    if (atmexist.ExistingMemberStatus.Code.Trim() != "1")
                        return Json(new { OK = false, message = "Anda tidak layak memohon kerana anda tidak berkhidmat di dalam ATM." });
                    return Json(new { OK = true, message = "Pengguna wujud dan layak.", name = atmexist.Name });
                }
                return Json(new { OK = false, message = "Maklumat status tidak wujud." });
            }
            return Json(new { OK = false, message = "Maklumat pengguna tidak wujud di dalam HRMIS." });
        }

        public ActionResult SubmitUser(LoginUser loguser)
        {
            if (!string.IsNullOrWhiteSpace(loguser.LoginRole?.Roles))
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


        public async Task<ActionResult> DeleteUser(string username)
        {
            var context = new SphDataContext();
            var user = await context.LoadOneAsync<UserProfile>(x => x.UserName == username);
            if (null == user) return HttpNotFound("Cannot find user " + username);
            using (var session = context.OpenSession())
            {
                session.Delete(user);
                await session.SubmitChanges();
            }

            Membership.DeleteUser(username, true);
            return Json(new { OK = true, message = "Makluamt pengguna berjaya dihapuskan." });

        }

        public ActionResult LoadUser(JQueryDataTableParamModel param, string category)
        {

            IEnumerable<LoginUser> users = null;
            var total = 0;
            if (!string.IsNullOrWhiteSpace(category))
            {
                if (category == "SP")
                    users = ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").LoadAllUser(true, true, string.Empty, param.sSearch, param.iDisplayLength, param.iDisplayStart, out total);
                if (category == "AW")
                    users = ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").LoadAllUser(false, true, string.Empty, param.sSearch, param.iDisplayLength, param.iDisplayStart, out total);
            }
            else
                users = ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").LoadAllUser(true, true, string.Empty, param.sSearch, param.iDisplayLength, param.iDisplayStart, out total);

            var sortColumnIndex = Convert.ToInt32(Request["iSortCol_0"]);
            Func<LoginUser, string> orderingFunction = (c => sortColumnIndex == 0 ? c.FullName : sortColumnIndex == 1 ? c.FullName : c.LoginId);
            var sortDirection = Request["sSortDir_0"]; // asc or desc
            users = sortDirection == "asc" ? users?.OrderBy(orderingFunction) : users?.OrderByDescending(orderingFunction);

            var loginUsers = users as IList<LoginUser> ?? users.ToList();
            var aadata = loginUsers.Select(a => new[]
            {
                a.UserId.ToString(),
                a.FullName,
                a.LoginId,
                $"{a.Email}<br/>{a.AlternativeEmail}",
                a.ServiceName,
                a.LoginRole.Roles,
                a.IsLocked ? "Tidak Aktif" : "Aktif",
                $"{a.LastLoginDt:dd/MM/yyyy hh:mm:tt}",
                a.UserId.ToString()
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

    }
}