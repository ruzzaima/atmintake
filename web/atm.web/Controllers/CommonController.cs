using Newtonsoft.Json;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SevenH.MMCSB.Atm.Web
{
    public class CommonController : Controller
    {
        public ActionResult GetCountries()
        {
            ReferenceRepo referenceRepo = new ReferenceRepo();
            IEnumerable<Country> countries = referenceRepo.GetCountries();
            if (countries != null && countries.Any<Country>())
            {
                var value = from a in countries
                            orderby a.CountryName
                            select new
                            {
                                Code = a.CountryCd.Trim(),
                                Name = a.CountryName
                            };
                return Json(new
                {
                    OK = true,
                    message = "Rekod wujud",
                    list = JsonConvert.SerializeObject(value)
                });
            }
            return Json(new
            {
                OK = false,
                message = "Tiada rekod"
            });
        }

        public ActionResult GetStates(string countrycode)
        {
            ReferenceRepo referenceRepo = new ReferenceRepo();
            IEnumerable<State> states = referenceRepo.GetStates(countrycode);
            if (states != null && states.Any<State>())
            {
                var value = from a in states
                            orderby a.StateDesc
                            select new
                            {
                                Code = a.StateCd.Trim(),
                                Name = a.StateDesc
                            };
                return Json(new
                {
                    OK = true,
                    message = "Rekod wujud",
                    list = JsonConvert.SerializeObject(value)
                });
            }
            return Json(new
            {
                OK = false,
                message = "Tiada rekod"
            });
        }

        public ActionResult GetCities(string statecode)
        {
            ReferenceRepo referenceRepo = new ReferenceRepo();
            IEnumerable<City> cities = referenceRepo.GetCities(statecode);
            if (cities != null && cities.Any<City>())
            {
                var value = from a in cities
                            orderby a.CityName
                            select new
                            {
                                Code = a.CityCd.Trim(),
                                Name = a.CityName
                            };
                return Json(new
                {
                    OK = true,
                    message = "Rekod wujud",
                    list = JsonConvert.SerializeObject(value)
                });
            }
            return Json(new
            {
                OK = false,
                message = "Tiada rekod"
            });
        }

        public ActionResult GetReligions()
        {
            ReferenceRepo referenceRepo = new ReferenceRepo();
            IEnumerable<Religion> religions = referenceRepo.GetReligions();
            if (religions != null && religions.Any<Religion>())
            {
                var value = from a in religions
                            orderby a.ReligionDescription
                            select new
                            {
                                Code = a.ReligionCd.Trim(),
                                Name = a.ReligionDescription
                            };
                return Json(new
                {
                    OK = true,
                    message = "Rekod wujud",
                    list = JsonConvert.SerializeObject(value)
                });
            }
            return Json(new
            {
                OK = false,
                message = "Tiada Rekod"
            });
        }

        public ActionResult GetRaces()
        {
            ReferenceRepo referenceRepo = new ReferenceRepo();
            IEnumerable<Race> races = referenceRepo.GetRaces();
            if (races != null && races.Any<Race>())
            {
                var value = from a in races
                            orderby a.RaceDescription
                            select new
                            {
                                Code = a.RaceCd.Trim(),
                                Name = a.RaceDescription
                            };
                return Json(new
                {
                    OK = true,
                    message = "Rekod wujud",
                    list = JsonConvert.SerializeObject(value)
                });
            }
            return Json(new
            {
                OK = false,
                message = "Tiada Rekod"
            });
        }

        public ActionResult GetOccupations()
        {
            ReferenceRepo referenceRepo = new ReferenceRepo();
            IEnumerable<Occupation> occupations = referenceRepo.GetOccupations();
            if (occupations != null && occupations.Any<Occupation>())
            {
                var value = from a in occupations
                            select new
                            {
                                Code = a.OccupationCd.Trim(),
                                Name = a.OccupationName
                            };
                return Json(new
                {
                    OK = true,
                    message = "Rekod wujud",
                    list = JsonConvert.SerializeObject(value)
                });
            }
            return Json(new
            {
                OK = false,
                message = "Tiada Rekod"
            });
        }

        public ActionResult GetHighEducationLevel()
        {
            ReferenceRepo referenceRepo = new ReferenceRepo();
            IEnumerable<HighEduLevel> highEduLevels = referenceRepo.GetHighEduLevels();
            if (highEduLevels != null && highEduLevels.Any<HighEduLevel>())
            {
                var value = from a in highEduLevels
                            orderby a.HighestEduLevel
                            select new
                            {
                                Code = a.HighEduLevelCd.Trim(),
                                Name = a.HighestEduLevel
                            };
                return Json(new
                {
                    OK = true,
                    message = "Rekod wujud",
                    list = JsonConvert.SerializeObject(value)
                });
            }
            return Json(new
            {
                OK = false,
                message = "Tiada Rekod"
            });
        }

        public ActionResult GetInstitutions(string category)
        {
            ReferenceRepo referenceRepo = new ReferenceRepo();
            IEnumerable<Institution> institutions = referenceRepo.GetInstitutions();
            if (institutions != null && institutions.Any<Institution>())
            {
                var value = from a in institutions
                            orderby a.InstNm
                            select new
                            {
                                Code = a.InstCd.Trim(),
                                Name = a.InstNm
                            };
                return Json(new
                {
                    OK = true,
                    message = "Rekod wujud",
                    list = JsonConvert.SerializeObject(value)
                });
            }
            return Json(new
            {
                OK = false,
                message = "Tiada Rekod"
            });
        }

        public ActionResult GetEthnics(string racecode)
        {
            ReferenceRepo referenceRepo = new ReferenceRepo();
            IEnumerable<Ethnic> ethnics = referenceRepo.GetEthnics(racecode);
            if (ethnics != null && ethnics.Any<Ethnic>())
            {
                var value = from a in ethnics
                            orderby a.EthnicDescription
                            select new
                            {
                                Code = a.EthnicCd.Trim(),
                                Name = a.EthnicDescription
                            };
                return Json(new
                {
                    OK = true,
                    message = "Rekod wujud",
                    list = JsonConvert.SerializeObject(value)
                });
            }
            return Json(new
            {
                OK = false,
                message = "Tiada Rekod"
            });
        }

        public ActionResult GetSports()
        {
            ReferenceRepo referenceRepo = new ReferenceRepo();
            IEnumerable<SportAndAssociation> sportAndAssociations = referenceRepo.GetSportAndAssociations("S");
            if (sportAndAssociations != null && sportAndAssociations.Any<SportAndAssociation>())
            {
                var value = from a in sportAndAssociations
                            orderby a.SportAssociatName
                            select new
                            {
                                Id = a.SportAssocId,
                                Name = a.SportAssociatName
                            };
                return Json(new
                {
                    OK = true,
                    message = "Rekod wujud",
                    list = JsonConvert.SerializeObject(value)
                });
            }
            return Json(new
            {
                OK = false,
                message = "Tiada Rekod"
            });
        }

        public ActionResult GetAssociations()
        {
            ReferenceRepo referenceRepo = new ReferenceRepo();
            IEnumerable<SportAndAssociation> sportAndAssociations = referenceRepo.GetSportAndAssociations("A");
            if (sportAndAssociations != null && sportAndAssociations.Any<SportAndAssociation>())
            {
                var value = from a in sportAndAssociations
                            orderby a.SportAssociatName
                            select new
                            {
                                Id = a.SportAssocId,
                                Name = a.SportAssociatName
                            };
                return Json(new
                {
                    OK = true,
                    message = "Rekod wujud",
                    list = JsonConvert.SerializeObject(value)
                });
            }
            return Json(new
            {
                OK = false,
                message = "Tiada Rekod"
            });
        }

        public ActionResult GetAchivements()
        {
            ReferenceRepo referenceRepo = new ReferenceRepo();
            IEnumerable<Achievement> achievements = referenceRepo.GetAchievements();
            if (achievements != null && achievements.Any<Achievement>())
            {
                var value = from a in achievements
                            orderby a.AchievementDescription
                            select new
                            {
                                Code = a.AchievementCd,
                                Name = a.AchievementDescription
                            };
                return Json(new
                {
                    OK = true,
                    message = "Rekod wujud",
                    list = JsonConvert.SerializeObject(value)
                });
            }
            return Json(new
            {
                OK = false,
                message = "Tiada Rekod"
            });
        }

        public ActionResult GetSkillCategories()
        {
            ReferenceRepo referenceRepo = new ReferenceRepo();
            IEnumerable<SkillCat> skillCats = referenceRepo.GetSkillCats();
            if (skillCats != null && skillCats.Any<SkillCat>())
            {
                var value = from a in skillCats
                            orderby a.SkillCatDesc
                            select new
                            {
                                Code = a.SkillCatCd,
                                Name = a.SkillCatDesc
                            };
                return Json(new
                {
                    OK = true,
                    message = "Rekod wujud",
                    list = JsonConvert.SerializeObject(value)
                });
            }
            return Json(new
            {
                OK = false,
                message = "Tiada Rekod"
            });
        }

        public ActionResult GetSkills(string category)
        {
            ReferenceRepo referenceRepo = new ReferenceRepo();
            IEnumerable<Skill> skills = referenceRepo.GetSkills(category);
            if (skills == null || !skills.Any<Skill>())
            {
                return Json(new
                {
                    OK = false,
                    message = "Tiada Rekod"
                });
            }
            if (category == "L")
            {
                var value = from a in skills
                            where !a.SkillDescription.Contains("Melayu") && !a.SkillDescription.Contains("Inggeris")
                            orderby a.SkillDescription
                            select new
                            {
                                Code = a.SkillCd,
                                Name = a.SkillDescription
                            };
                return Json(new
                {
                    OK = true,
                    message = "Rekod wujud",
                    list = JsonConvert.SerializeObject(value)
                });
            }
            var value2 = from a in skills
                         orderby a.SkillDescription
                         select new
                         {
                             Code = a.SkillCd,
                             Name = a.SkillDescription
                         };
            return Json(new
            {
                OK = true,
                message = "Rekod wujud",
                list = JsonConvert.SerializeObject(value2)
            });
        }

        public ActionResult GetMajorMinor()
        {
            ReferenceRepo referenceRepo = new ReferenceRepo();
            IEnumerable<MajorMinor> majorMinors = referenceRepo.GetMajorMinors();
            if (majorMinors != null && majorMinors.Any<MajorMinor>())
            {
                var value = from a in majorMinors
                            orderby a.MajorMinorDesc
                            select new
                            {
                                Code = (!string.IsNullOrWhiteSpace(a.MajorMinorCd)) ? a.MajorMinorCd.Trim() : a.MajorMinorCd,
                                Name = a.MajorMinorDesc
                            };
                return Json(new
                {
                    OK = true,
                    message = "Rekod wujud",
                    list = JsonConvert.SerializeObject(value)
                });
            }
            return Json(new
            {
                OK = false,
                message = "Tiada Rekod"
            });
        }

        public ActionResult GetGrades()
        {
            ReferenceRepo referenceRepo = new ReferenceRepo();
            IEnumerable<SubjectGrade> subjectGrades = referenceRepo.GetSubjectGrades();
            if (subjectGrades != null && subjectGrades.Any<SubjectGrade>())
            {
                var value = from a in subjectGrades
                            orderby a.Ranking
                            select new
                            {
                                Code = (!string.IsNullOrWhiteSpace(a.GradeCd)) ? a.GradeCd.Trim() : a.GradeCd,
                                Name = a.GradeDescription
                            };
                return Json(new
                {
                    OK = true,
                    message = "Rekod wujud",
                    list = JsonConvert.SerializeObject(value)
                });
            }
            return Json(new
            {
                OK = false,
                message = "Tiada Rekod"
            });
        }

        public ActionResult GetSubjects()
        {
            var referenceRepo = new ReferenceRepo();
            var subjects = referenceRepo.GetSubjects();
            if (subjects != null && subjects.Any())
            {
                var value = subjects.Skip(10).OrderBy(a => a.SubjectDescription).Select(a => new { Code = a.SubjectCd, Name = a.SubjectDescription });
                return Json(new
                {
                    OK = true,
                    message = "Rekod wujud",
                    list = JsonConvert.SerializeObject(value)
                });
            }
            return Json(new
            {
                OK = false,
                message = "Tiada Rekod"
            });
        }

        public ActionResult GetZones()
        {
            var referenceRepo = new ReferenceRepo();
            var zones = referenceRepo.GetZones();
            if (zones != null && zones.Any<Zone>())
            {
                var value = zones.OrderBy(a => a.ZoneNm).Select(a => new { Code = a.ZoneCd, Name = a.ZoneNm });
                return Json(new
                {
                    OK = true,
                    message = "Rekod wujud",
                    list = JsonConvert.SerializeObject(value)
                });
            }
            return Json(new
            {
                OK = false,
                message = "Tiada Rekod"
            });
        }

        public ActionResult GetLocations(string zone)
        {
            ReferenceRepo referenceRepo = new ReferenceRepo();
            IEnumerable<AcquisitionLocation> acquisitionLocations = referenceRepo.GetAcquisitionLocations(zone);
            if (acquisitionLocations != null && acquisitionLocations.Any<AcquisitionLocation>())
            {
                var value = from a in acquisitionLocations
                            orderby a.Location.LocationNm
                            select new
                            {
                                Code = a.AcqLocationId,
                                Name = a.Location.LocationNm
                            };
                return Json(new
                {
                    OK = true,
                    message = "Rekod wujud",
                    list = JsonConvert.SerializeObject(value)
                });
            }
            return Json(new
            {
                OK = false,
                message = "Tiada Rekod"
            });
        }

        public ActionResult GetProfilePhoto(int applicantid)
        {
            if (applicantid != 0)
            {
                var photo = ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").GetPhoto(applicantid);
                if (photo != null && photo.Photo != null && !string.IsNullOrWhiteSpace(photo.PhotoExt))
                {
                    string arg = Convert.ToBase64String(photo.Photo);
                    string text = photo.PhotoExt;
                    if (text.Contains("."))
                    {
                        text = text.Replace(".", string.Empty);
                    }
                    string src = string.Format("data:image/" + text + ";base64,{0}", arg);
                    return Json(new
                    {
                        OK = true,
                        message = "Photo",
                        src = src
                    });
                }
            }
            return Json(new
            {
                OK = false,
                message = "Tiada Photo"
            });
        }
        public ActionResult GetSubmittedProfilePhoto(int applicantid)
        {
            if (applicantid != 0)
            {
                var photo = ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence").GetPhoto(applicantid);
                if (photo != null && photo.Photo != null && !string.IsNullOrWhiteSpace(photo.PhotoExt))
                {
                    string arg = Convert.ToBase64String(photo.Photo);
                    string text = photo.PhotoExt;
                    if (text.Contains("."))
                    {
                        text = text.Replace(".", string.Empty);
                    }
                    string src = string.Format("data:image/" + text + ";base64,{0}", arg);
                    return Json(new
                    {
                        OK = true,
                        message = "Photo",
                        src = src
                    });
                }
            }
            return Json(new
            {
                OK = false,
                message = "Tiada Photo"
            });
        }

        public ActionResult GetMaritalStatus(string servicecodes)
        {
            ReferenceRepo referenceRepo = new ReferenceRepo();
            IEnumerable<MaritalStatus> maritalStatus = referenceRepo.GetMaritalStatus();
            if (maritalStatus != null && maritalStatus.Any<MaritalStatus>())
            {
                List<MaritalStatus> source = maritalStatus.ToList<MaritalStatus>();
                List<MaritalStatus> arg_84_0;
                if (!(servicecodes == "10"))
                {
                    arg_84_0 = (from a in source
                                where a.MrtlStatusCd != "4" && a.MrtlStatusCd != "5"
                                select a).ToList<MaritalStatus>();
                }
                else
                {
                    arg_84_0 = (from a in source
                                where a.MrtlStatusCd != "5"
                                select a).ToList<MaritalStatus>();
                }
                source = arg_84_0;
                var value = from a in source
                            orderby a.MrtlStatusCd
                            select new
                            {
                                Code = a.MrtlStatusCd,
                                Name = a.MrtlStatus
                            };
                return Json(new
                {
                    OK = true,
                    message = "Rekod wujud",
                    list = JsonConvert.SerializeObject(value)
                });
            }
            return Json(new
            {
                OK = false,
                message = "Tiada Rekod"
            });
        }

        public ActionResult GetChecklist(int applicantid, int acquisitionid)
        {
            if (applicantid != 0 && acquisitionid != 0)
            {
                decimal num = 0.0m;
                decimal num2 = 0.0m;
                decimal num3 = 0.0m;
                decimal num4 = 0.0m;
                decimal num5 = 0.0m;
                AtmHelper.Checklist(applicantid, acquisitionid, out num, out num2, out num3, out num4, out num5);
                return Json(new
                {
                    OK = true,
                    message = "Belum Lengkap",
                    point = string.Format("{0:##}", num),
                    edu = string.Format("{0:##}", num2),
                    spo = string.Format("{0:##}", num3),
                    sas = string.Format("{0:##}", num4),
                    chd = string.Format("{0:##}", num5)
                });
            }
            return Json(new
            {
                OK = true,
                message = "Lengkap",
                point = 0
            });
        }

        public ActionResult CheckApplicant()
        {
            if (User.Identity.IsAuthenticated)
            {
                LoginUser byUserName = ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").GetByUserName(User.Identity.Name);
                if (byUserName != null && byUserName.ApplicantId.HasValue)
                {
                    return Json(new
                    {
                        OK = true,
                        message = "Maklumat id pemohon wujud.",
                        id = byUserName.ApplicantId.Value
                    });
                }
            }
            return Json(new
            {
                OK = false,
                message = "Sila masukkan maklumat permohonan dahulu."
            });
        }
        
        public ActionResult GetAcqLocations(int acquisitionid)
        {
            var  acquisitionLocations = ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetLocations(acquisitionid);
            var enumerable = acquisitionLocations as IList<AcquisitionLocation> ?? acquisitionLocations.ToList();
            if (acquisitionLocations != null && enumerable.Any())
            {
                var value = from a in enumerable
                            orderby a.Location.LocationNm
                            select new
                            {
                                Code = a.AcqLocationId,
                                Name = a.Location.LocationNm
                            };
                return Json(new
                {
                    OK = true,
                    message = "Rekod wujud",
                    list = JsonConvert.SerializeObject(value)
                });
            }
            return Json(new
            {
                OK = false,
                message = "Tiada Rekod"
            });
        }
        
        public ActionResult GetReportDutyLocations()
        {
            var acquisitionLocations = ObjectBuilder.GetObject<IApplicationPersistance>("ApplicationPersistance").GetReportDutyLocations();
            var enumerable = acquisitionLocations as IList<ReportDutyLocation> ?? acquisitionLocations.ToList();
            if (acquisitionLocations != null && enumerable.Any())
            {
                var value = from a in enumerable
                            orderby a.ReportDutyLoc
                            select new
                            {
                                Code = a.ReportDutyLocId,
                                Name = a.ReportDutyLoc
                            };
                return Json(new
                {
                    OK = true,
                    message = "Rekod wujud",
                    list = JsonConvert.SerializeObject(value)
                });
            }
            return Json(new
            {
                OK = false,
                message = "Tiada Rekod"
            });
        }
    }
}
