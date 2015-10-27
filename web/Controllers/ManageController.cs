using System;
using System.Collections.Generic;
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
                return Json(new { OK = false, message = "Sila bekalkan maklumat pengguna." });
            var atmexist = ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").ExistingAtmMemberByArmyNo(id);
            if (null == atmexist)
                return Json(new {OK = false, message = "Maklumat pengguna tidak wujud di dalam HRMIS."});
            if (atmexist.ExistingMemberStatus != null)
            {
                if (atmexist.ExistingMemberStatus.Code.Trim() != "1")
                    return Json(new { OK = false, message = "Anda tidak layak memohon kerana anda tidak berkhidmat di dalam ATM." });
                return Json(new { OK = true, message = "Pengguna wujud dan layak.", name = atmexist.Name });
            }
            return Json(new { OK = false, message = "Maklumat status tidak wujud." });
        }

        public async Task<ActionResult> SubmitUser(LoginUser loguser)
        {
           
            var context = new SphDataContext();
            using (var session = context.OpenSession())
            {
                session.Attach(loguser);
                await session.SubmitChanges();
            }

            return Json(new {OK = true, message = "Pengguna sudah disimpan"});
        }

        public ActionResult SubmitAndEmailUser(LoginUser loguser)
        {
            throw new Exception("What do we do here????");
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

        public async Task<ActionResult> LoadUser(JQueryDataTableParamModel param, string category)
        {
            var context = new SphDataContext();
            var lo = await context.LoadAsync(context.UserProfiles, 1, 40, true);
            var users = lo.ItemCollection.Cast<LoginUser>();

            var aadata = users.Select(a => new[]
            {
                a.UserId.ToString(),
                a.FullName,
                a.LoginId,
                $"{a.Email}<br/>{a.AlternativeEmail}",
                a.ServiceName,
                a.IsLocked ? "Tidak Aktif" : "Aktif",
                $"{a.LastLoginDt:dd/MM/yyyy hh:mm:tt}",
                a.UserId.ToString()
            }).ToList();

            return Json(new
            {
                OK = true,
                message = "Succeed",
                sEcho = param.sEcho,
                iTotalRecords = lo.TotalRows,
                iTotalDisplayRecords = 40,
                aaData = aadata,
            }, JsonRequestBehavior.AllowGet);
        }

    }
}