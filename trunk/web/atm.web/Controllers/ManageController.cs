using System;
using System.Collections.Generic;
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
    [Authorize(Roles = RolesString.SUPER_ADMIN)]
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
                    if (atmexist.ExistingMemberStatus.Code.Trim() != "1")
                        return Json(new { OK = false, message = "Anda tidak layak memohon kerana anda tidak berkhidmat di dalam ATM." });
                    else
                        return Json(new { OK = true, message = "Pengguna wujud dan layak.", name = atmexist.Name });
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
                loguser.Salt = Guid.NewGuid().ToString();
                loguser.Email = "NA";
                loguser.AlternativeEmail = "NA";
                loguser.CreatedDt = DateTime.Now;
                loguser.CreatedBy = User.Identity.Name;
                loguser.IsLocked = loguser.Status != "Y";
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

        public ActionResult LoadUser(JQueryDataTableParamModel param)
        {
            var users = ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").LoadAllUser(true, true, string.Empty, string.Empty);

            var aadata = users.Select(a => new string[]
            {
                a.UserId.ToString(),
                a.FullName,
                a.LoginId,
                a.ServiceName,
                a.LoginRole.Roles,
                a.IsLocked ? "Aktif" : "Tidak Aktif",
                a.UserId.ToString()
            });

            return Json(new
            {
                OK = true,
                message = "Succeed",
                sEcho = param.sEcho,
                iTotalRecords = users.Count(),
                iTotalDisplayRecords = users.Count(),
                aaData = aadata,
            }, JsonRequestBehavior.AllowGet);
        }

    }
}