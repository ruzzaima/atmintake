using System.Web.Mvc;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;
using SevenH.MMCSB.Atm.Web.Models;

namespace SevenH.MMCSB.Atm.Web.Controllers
{
    [AtmAuthorize(Roles = RolesString.SUPER_ADMIN + "," + RolesString.PEGAWAI_PENGAMBILAN + "," + RolesString.KERANI_PENGAMBILAN + "," + RolesString.STATISTIC)]
    public class StatisticController : Controller
    {

        public ActionResult Index()
        {
            var vm = new StatisticViewModel();
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
                    }
                }
            }
            return View(vm);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">AcquisitionId</param>
        /// <returns></returns>
        public ActionResult ByStateAndGender(int id)
        {
            var vm = new StatisticViewModel();
            if (id != 0)
            {
                vm.Acquisition = ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetAcquisition(id);
                vm.ListOfState.AddRange(ObjectBuilder.GetObject<IReferencePersistence>("ReferencePersistence").GetStates("MYS"));
            }
            return View(vm);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">AcquisitionId</param>
        /// <returns></returns>
        public ActionResult ByStateAndGenderRace(int id)
        {
            var vm = new StatisticViewModel();
            if (id != 0)
            {
                vm.Acquisition = ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetAcquisition(id);
                vm.ListOfState.AddRange(ObjectBuilder.GetObject<IReferencePersistence>("ReferencePersistence").GetStates("MYS"));
                vm.ListOfRace.AddRange(ObjectBuilder.GetObject<IReferencePersistence>("ReferencePersistence").GetRaces());
            }
            return View(vm);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">AcquisitionId</param>
        /// <returns></returns>
        public ActionResult ByStateAndGenderRaceEthnic(int id, string race)
        {
            var vm = new StatisticViewModel();
            if (id != 0)
            {
                vm.Acquisition = ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetAcquisition(id);
                vm.ListOfState.AddRange(ObjectBuilder.GetObject<IReferencePersistence>("ReferencePersistence").GetStates("MYS"));
                vm.Race = ObjectBuilder.GetObject<IReferencePersistence>("ReferencePersistence").GetRace(race);
                vm.ListOfEthnic.AddRange(ObjectBuilder.GetObject<IReferencePersistence>("ReferencePersistence").GetEthnics(race));
            }
            return View(vm);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">AcquisitionId</param>
        /// <returns></returns>
        public ActionResult ByStateAndGenderAcademics(int id)
        {
            var vm = new StatisticViewModel();
            if (id != 0)
            {
                vm.Acquisition = ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetAcquisition(id);
                vm.ListOfState.AddRange(ObjectBuilder.GetObject<IReferencePersistence>("ReferencePersistence").GetStates("MYS"));
                vm.ListOfHighEduLevel.AddRange(ObjectBuilder.GetObject<IReferencePersistence>("ReferencePersistence").GetHighEduLevels());
            }
            return View(vm);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">AcquisitionId</param>
        /// <returns></returns>
        public ActionResult ByStateAndGenderReligion(int id)
        {
            var vm = new StatisticViewModel();
            if (id != 0)
            {
                vm.Acquisition = ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetAcquisition(id);
                vm.ListOfState.AddRange(ObjectBuilder.GetObject<IReferencePersistence>("ReferencePersistence").GetStates("MYS"));
                vm.ListOfReligion.AddRange(ObjectBuilder.GetObject<IReferencePersistence>("ReferencePersistence").GetReligions());
            }
            return View(vm);
        }
    }
}