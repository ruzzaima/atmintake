using System.Linq;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace SevenH.MMCSB.Atm.Web.Controllers
{
    public class CommonController : Controller
    {

        public ActionResult GetCountries()
        {
            var repos = new ReferenceRepo();
            var countries = repos.GetCountries();
            if (countries != null && countries.Any())
            {
                var list = countries.OrderBy(a => a.CountryName).Select(a => new { Code = a.CountryCd.Trim(), Name = a.CountryName });
                return Json(new { OK = true, message = "Rekod wujud", list = JsonConvert.SerializeObject(list) });
            }
            return Json(new { OK = false, message = "Tiada rekod" });
        }

        public ActionResult GetStates(string countrycode)
        {
            var repos = new ReferenceRepo();
            var states = repos.GetStates(countrycode);
            if (states != null && states.Any())
            {
                var list = states.OrderBy(a => a.StateDesc).Select(a => new { Code = a.StateCd.Trim(), Name = a.StateDesc });
                return Json(new { OK = true, message = "Rekod wujud", list = JsonConvert.SerializeObject(list) });
            }
            return Json(new { OK = false, message = "Tiada rekod" });
        }

        public ActionResult GetCities(string statecode)
        {
            var repos = new ReferenceRepo();
            var cities = repos.GetCities(statecode);
            if (cities != null && cities.Any())
            {
                var list = cities.OrderBy(a => a.CityName).Select(a => new { Code = a.CityCd.Trim(), Name = a.CityName });
                return Json(new { OK = true, message = "Rekod wujud", list = JsonConvert.SerializeObject(list) });
            }
            return Json(new { OK = false, message = "Tiada rekod" });
        }

        public ActionResult GetReligions()
        {
            var repos = new ReferenceRepo();
            var religions = repos.GetReligions();
            if (religions != null && religions.Any())
            {
                var list = religions.OrderBy(a => a.ReligionDescription).Select(a => new { Code = a.ReligionCd.Trim(), Name = a.ReligionDescription });
                return Json(new { OK = true, message = "Rekod wujud", list = JsonConvert.SerializeObject(list) });
            }
            return Json(new { OK = false, message = "Tiada Rekod" });
        }

        public ActionResult GetRaces()
        {
            var repos = new ReferenceRepo();
            var races = repos.GetRaces();
            if (null != races && races.Any())
            {
                var list = races.OrderBy(a => a.RaceDescription).Select(a => new { Code = a.RaceCd.Trim(), Name = a.RaceDescription });
                return Json(new { OK = true, message = "Rekod wujud", list = JsonConvert.SerializeObject(list) });
            }
            return Json(new { OK = false, message = "Tiada Rekod" });
        }

        public ActionResult GetOccupations()
        {
            var repos = new ReferenceRepo();
            var occupations = repos.GetOccupations();
            if (occupations != null && occupations.Any())
            {
                var list = occupations.Select(a => new { Code = a.OccupationCd.Trim(), Name = a.OccupationName });
                return Json(new { OK = true, message = "Rekod wujud", list = JsonConvert.SerializeObject(list) });
            }
            return Json(new { OK = false, message = "Tiada Rekod" });
        }

        public ActionResult GetHighEducationLevel()
        {
            var repos = new ReferenceRepo();
            var highedus = repos.GetHighEduLevels();
            if (highedus != null && highedus.Any())
            {
                var list = highedus.OrderBy(a => a.HighestEduLevel).Select(a => new { Code = a.HighEduLevelCd.Trim(), Name = a.HighestEduLevel });
                return Json(new { OK = true, message = "Rekod wujud", list = JsonConvert.SerializeObject(list) });
            }
            return Json(new { OK = false, message = "Tiada Rekod" });
        }

        public ActionResult GetInstitutions()
        {
            var repos = new ReferenceRepo();
            var inst = repos.GetInstitutions();
            if (inst != null && inst.Any())
            {
                var list = inst.OrderBy(a => a.InstNm).Select(a => new { Code = a.InstCd.Trim(), Name = a.InstNm });
                return Json(new { OK = true, message = "Rekod wujud", list = JsonConvert.SerializeObject(list) });
            }
            return Json(new { OK = false, message = "Tiada Rekod" });
        }

        public ActionResult GetEthnics(string racecode)
        {
            var repos = new ReferenceRepo();
            var ethnics = repos.GetEthnics(racecode);
            if (ethnics != null && ethnics.Any())
            {
                var list = ethnics.OrderBy(a => a.EthnicDescription).Select(a => new { Code = a.EthnicCd.Trim(), Name = a.EthnicDescription });
                return Json(new { OK = true, message = "Rekod wujud", list = JsonConvert.SerializeObject(list) });
            }
            return Json(new { OK = false, message = "Tiada Rekod" });
        }

        public ActionResult GetSports()
        {
            var repos = new ReferenceRepo();
            var sports = repos.GetSportAndAssociations("S");
            if (sports != null && sports.Any())
            {
                var list = sports.OrderBy(a => a.SportAssociatName).Select(a => new { Id = a.SportAssocId, Name = a.SportAssociatName});
                return Json(new { OK = true, message = "Rekod wujud", list = JsonConvert.SerializeObject(list) });
            }
            return Json(new { OK = false, message = "Tiada Rekod" });
        }

        public ActionResult GetAssociations()
        {
            var repos = new ReferenceRepo();
            var sports = repos.GetSportAndAssociations("A");
            if (sports != null && sports.Any())
            {
                var list = sports.OrderBy(a => a.SportAssociatName).Select(a => new { Id = a.SportAssocId, Name = a.SportAssociatName });
                return Json(new { OK = true, message = "Rekod wujud", list = JsonConvert.SerializeObject(list) });
            }
            return Json(new { OK = false, message = "Tiada Rekod" });
        }

        public ActionResult GetAchivements()
        {
            var repos = new ReferenceRepo();
            var achievements = repos.GetAchievements();
            if (achievements != null && achievements.Any())
            {
                var list = achievements.OrderBy(a => a.AchievementDescription).Select(a => new { Code = a.AchievementCd, Name = a.AchievementDescription });
                return Json(new { OK = true, message = "Rekod wujud", list = JsonConvert.SerializeObject(list) });
            }
            return Json(new { OK = false, message = "Tiada Rekod" });
        }
    }
}