using System;
using System.Collections.Generic;
using System.Linq;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Atm.Entity.Persistance
{
    class ApplicantSubmittedPersistance : IApplicantSubmittedPersistence
    {
        public void Delete(int id)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblApplicantSubmiteds where a.ApplicantId == id select a);
                if (exist.Any())
                    entities.tblApplicantSubmiteds.RemoveRange(exist);
            }
        }

        public int Save(ApplicantSubmitted appl)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblApplicantSubmiteds where a.NewICNo == appl.NewICNo && a.AcquisitionId == appl.AcquisitionId select a).OrderByDescending(a => a.CreatedDt).FirstOrDefault();
                if (null != exist)
                {
                    appl.ApplicantId = exist.ApplicantId;
                    return Update(appl);
                }
                var usr = BindindToTable(appl);
                entities.tblApplicantSubmiteds.Add(usr);
                if (entities.SaveChanges() > 0)
                    return usr.ApplicantId;
            }
            return 0;
        }

        public int Update(ApplicantSubmitted appl)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblApplicantSubmiteds where a.ApplicantId == appl.ApplicantId select a).SingleOrDefault();
                if (null != exist)
                {
                    exist.AcquisitionId = appl.AcquisitionId;
                    exist.Email = appl.Email;
                    exist.FullName = appl.FullName;
                    exist.ArmySelectionDt = appl.ArmySelectionDt;
                    exist.ArmySelectionInd = appl.ArmySelectionInd;
                    exist.ArmySelectionVenue = appl.ArmySelectionVenue;
                    exist.ArmyServiceInd = appl.ArmyServiceInd;
                    exist.ArmyServiceResignRemark = appl.ArmyServiceResignRemark;
                    exist.ArmyServiceYrOfServ = appl.ArmyServiceYrOfServ;
                    exist.BMI = appl.BMI;
                    exist.BirthCertNo = appl.BirthCertNo;
                    exist.BirthCityCd = appl.BirthCityCd;
                    exist.BirthCountryCd = appl.BirthCountryCd;
                    exist.BirthDt = appl.BirthDt?? DateTime.Now;
                    exist.BirthPlace = appl.BirthPlace;
                    exist.BirthStateCd = appl.BirthStateCd;
                    exist.BloodTypeCd = appl.BloodTypeCd;
                    exist.ChildNo = appl.ChildNo;
                    exist.ColorBlindInd = appl.ColorBlindInd;
                    exist.ComputerICT = appl.ComputerICT;
                    exist.ComputerMSExcel = appl.ComputerMSExcel;
                    exist.ComputerMSPwrPoint = appl.ComputerMSPwrPoint;
                    exist.ComputerMSWord = appl.ComputerMSWord;
                    exist.ComputerOthers = appl.ComputerOthers;
                    exist.CorresponAddr1 = appl.CorresponAddr1;
                    exist.CorresponAddr2 = appl.CorresponAddr2;
                    exist.CorresponAddr3 = appl.CorresponAddr3;
                    exist.CorresponAddrCityCd = appl.CorresponAddrCityCd;
                    exist.CorresponAddrCountryCd = appl.CorresponAddrCountryCd;
                    exist.CorresponAddrPostCd = appl.CorresponAddrPostCd;
                    exist.CorresponAddrStateCd = appl.CorresponAddrStateCd;
                    exist.CrimeInvolvement = appl.CrimeInvolvement;
                    exist.CronicIlnessInd = appl.CronicIlnessInd;
                    exist.CurrentOccupation = appl.CurrentOccupation;
                    exist.CurrentOrganisation = appl.CurrentOrganisation;
                    exist.CurrentSalary = appl.CurrentSalary;
                    exist.DadICNo = appl.DadICNo;
                    exist.DadName = appl.DadName;
                    exist.DadNationalityCd = appl.DadNationalityCd;
                    exist.DadNotApplicable = appl.DadNotApplicable;
                    exist.DadNotApplicableInd = appl.DadNotApplicable;
                    exist.DadOccupation = appl.DadOccupation;
                    exist.DadPhoneNo = appl.DadPhoneNo;
                    exist.DadSalary = appl.DadSalary;
                    exist.DrugCaseInvolvement = appl.DrugCaseInvolvement;
                    exist.EmployeeAggreeInd = appl.EmployeeAggreeInd;
                    exist.EthnicCd = appl.EthnicCd;
                    exist.FamilyHighestEduLevel = appl.FamilyHighestEduLevel;
                    exist.GenderCd = appl.GenderCd;
                    exist.GuardianICNo = appl.GuardianICNo;
                    exist.GuardianName = appl.GuardianName;
                    exist.GuardianNationalityCd = appl.GuardianNationalityCd;
                    exist.GuardianNotApplicable = appl.GuardianNotApplicable;
                    exist.GuardianNotApplicableInd = appl.GuardianNotApplicable;
                    exist.GuardianOccupation = appl.GuardianOccupation;
                    exist.GuardianPhoneNo = appl.GuardianPhoneNo;
                    exist.GuardianSalary = appl.GuardianSalary;
                    exist.Height = appl.Height;
                    exist.HomePhoneNo = appl.HomePhoneNo;
                    exist.LastModifiedBy = appl.LastModifiedBy;
                    exist.LastModifiedDt = appl.LastModifiedDt;
                    exist.MobilePhoneNo = appl.MobilePhoneNo;
                    exist.MomICNo = appl.MomICNo;
                    exist.MomName = appl.MomName;
                    exist.MomNationalityCd = appl.MomNationalityCd;
                    exist.MomNotApplicable = appl.MomNotApplicable;
                    exist.MomNotApplicableInd = appl.MomNotApplicable;
                    exist.MomOccupation = appl.MomOccupation;
                    exist.MomPhoneNo = appl.MomPhoneNo;
                    exist.MomSalary = appl.MomSalary;
                    exist.MrtlStatusCd = appl.MrtlStatusCd;
                    exist.NationalityCd = appl.NationalityCd;
                    exist.NationalityCertNo = appl.NationalityCertNo;
                    exist.NewICNo = appl.NewICNo;
                    exist.NoOfSibling = appl.NoOfSibling;
                    exist.NoTentera = appl.NoTentera;
                    exist.OriginalPelepasanDocument = appl.OriginalPelepasanDocument;
                    exist.PalapesArmyNo = appl.PalapesArmyNo;
                    exist.PalapesInd = appl.PalapesInd;
                    exist.PalapesInstitution = appl.PalapesInstitution;
                    exist.PalapesRemark = appl.PalapesRemark;
                    exist.PalapesServices = appl.PalapesServices;
                    exist.PalapesTauliahEndDt = appl.PalapesTauliahEndDt;
                    exist.PalapesYear = appl.PalapesYear;
                    exist.PelepasanDocument = appl.PelepasanDocument;
                    exist.RaceCd = appl.RaceCd;
                    exist.ReligionCd = appl.ReligionCd;
                    exist.ResidenceTypeInd = appl.ResidenceTypeInd;
                    exist.ScholarshipBody = appl.ScholarshipBody;
                    exist.ScholarshipBodyAddr = appl.ScholarshipBodyAddr;
                    exist.ScholarshipContractStDate = appl.ScholarshipContractStDate;
                    exist.ScholarshipInd = appl.ScholarshipInd;
                    exist.ScholarshipNoOfYrContract = appl.ScholarshipNoOfYrContract;
                    exist.SelectionTD = appl.SelectionTD;
                    exist.SelectionTL = appl.SelectionTL;
                    exist.SelectionTU = appl.SelectionTU;
                    exist.SpectaclesUserInd = appl.SpectaclesUserInd;
                    exist.Weight = appl.Weight;

                    entities.SaveChanges();

                    return exist.ApplicantId;
                }
            }
            return 0;
        }

        public ApplicantSubmitted GetApplicant(string icno, int acquisitionid)
        {
            if (!string.IsNullOrWhiteSpace(icno) && acquisitionid != 0)
            {
                using (var entities = new atmEntities())
                {
                    var exist = (from a in entities.tblApplicantSubmiteds where a.NewICNo == icno && a.AcquisitionId == acquisitionid select a).SingleOrDefault();
                    if (null != exist)
                    {
                        var app = BindingToClass(exist);
                        var edus = GetEducation(app.ApplicantId, acquisitionid);
                        foreach (var ed in edus)
                            app.ApplicantEducationSubmittedCollection.Add(ed);

                        return app;
                    }
                }
            }
            return null;
        }
        public ApplicantSubmitted GetApplicant(int applicantid, int acquisitionid)
        {
            if (applicantid != 0 && acquisitionid != 0)
            {
                using (var entities = new atmEntities())
                {
                    var exist = (from a in entities.tblApplicantSubmiteds where a.ApplicantId == applicantid && a.AcquisitionId == acquisitionid select a).SingleOrDefault();
                    if (null != exist)
                    {
                        var app = BindingToClass(exist);
                        var edus = GetEducation(app.ApplicantId, acquisitionid);
                        foreach (var ed in edus)
                            app.ApplicantEducationSubmittedCollection.Add(ed);

                        return app;
                    }
                }
            }
            return null;
        }

        public IEnumerable<ApplicantSubmitted> GetApplicants(string icno)
        {
            var list = new List<ApplicantSubmitted>();

            if (!string.IsNullOrWhiteSpace(icno))
            {
                using (var entities = new atmEntities())
                {
                    var exist = from a in entities.tblApplicantSubmiteds where a.NewICNo == icno select a;
                    if (exist.Any())
                        foreach (var u in exist)
                        {
                            var app = BindingToClass(u);
                            var edus = GetEducation(app.ApplicantId, app.AcquisitionId);
                            foreach (var ed in edus)
                                app.ApplicantEducationSubmittedCollection.Add(ed);

                            list.Add(app);
                        }


                }
            }
            return list;
        }

        public IEnumerable<ApplicantSubmitted> GetApplicants(int acquisitionid)
        {
            var list = new List<ApplicantSubmitted>();

            if (acquisitionid == 0) return list;
            using (var entities = new atmEntities())
            {
                var exist = from a in entities.tblApplicantSubmiteds where a.AcquisitionId == acquisitionid select a;
                if (!exist.Any()) return list;
                foreach (var u in exist)
                {
                    var app = BindingToClass(u);
                    var edus = GetEducation(app.ApplicantId, app.AcquisitionId);
                    foreach (var ed in edus)
                        app.ApplicantEducationSubmittedCollection.Add(ed);

                    list.Add(app);
                }
            }
            return list;
        }

        public int SaveEducation(ApplicantEducationSubmitted education)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblApplicantEduSubmitteds where a.ApplicantId == education.ApplicantId && a.HighEduLevelCd == education.HighEduLevelCd select a).SingleOrDefault();
                if (exist != null)
                {
                    education.ApplicantEduId = exist.ApplicantEduId;
                    return UpdateEducation(education);
                }
                var ed = new tblApplicantEduSubmitted
                {
                    ApplicantId = education.ApplicantId,
                    ConfermentYr = education.ConfermentYr,
                    CreatedBy = education.CreatedBy,
                    CreatedDt = education.CreatedDt,
                    EduCertTitle = education.EduCertTitle,
                    HighEduLevelCd = education.HighEduLevelCd,
                    InstCd = education.InstCd,
                    InstitutionName = education.InstitutionName,
                    MajorMinorCd = education.MajorMinorCd,
                    OverSeaInd = education.OverSeaInd,
                    OverallGrade = education.OverallGrade,
                    SKMLevel = education.SKMLevel
                };
                entities.tblApplicantEduSubmitteds.Add(ed);

                if (entities.SaveChanges() > 0)
                {
                    // save submitted subject
                    return ed.ApplicantEduId;
                }
            }
            return 0;
        }

        public int UpdateEducation(ApplicantEducationSubmitted education)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblApplicantEduSubmitteds where a.ApplicantEduId == education.ApplicantEduId select a).SingleOrDefault();
                if (exist != null)
                {
                    exist.ApplicantId = education.ApplicantId;
                    exist.ConfermentYr = education.ConfermentYr;
                    exist.EduCertTitle = education.EduCertTitle;
                    exist.HighEduLevelCd = education.HighEduLevelCd;
                    exist.InstCd = education.InstCd;
                    exist.InstitutionName = education.InstitutionName;
                    exist.LastModifiedBy = education.LastModifiedBy;
                    exist.LastModifiedDt = DateTime.Now;
                    exist.MajorMinorCd = education.MajorMinorCd;
                    exist.OverSeaInd = education.OverSeaInd;
                    exist.OverallGrade = education.OverallGrade;
                    exist.SKMLevel = education.SKMLevel;

                    entities.SaveChanges();

                    return exist.ApplicantEduId;
                }
            }
            return 0;
        }

        public IEnumerable<ApplicantEducationSubmitted> GetEducation(int applicantid, int acquisitionid)
        {
            var list = new List<ApplicantEducationSubmitted>();
            using (var entities = new atmEntities())
            {
                var l = from a in entities.tblApplicantEduSubmitteds join b in entities.tblApplicantSubmiteds on a.ApplicantId equals b.ApplicantId where a.ApplicantId == applicantid && b.AcquisitionId == acquisitionid select a;
                if (l.Any())
                {
                    foreach (var aes in l)
                    {
                        var ed = new ApplicantEducationSubmitted
                        {
                            ApplicantEduId = aes.ApplicantEduId,
                            ApplicantId = aes.ApplicantId,
                            ConfermentYr = aes.ConfermentYr,
                            CreatedBy = aes.CreatedBy,
                            CreatedDt = aes.CreatedDt,
                            EduCertTitle = aes.EduCertTitle,
                            HighEduLevel = aes.tblREFHighEduLevel != null ? aes.tblREFHighEduLevel.HighestEduLevel : string.Empty,
                            HighEduLevelCd = !string.IsNullOrWhiteSpace(aes.HighEduLevelCd) ? aes.HighEduLevelCd.Trim() : aes.HighEduLevelCd,
                            InstCd = !string.IsNullOrWhiteSpace(aes.InstCd) ? aes.InstCd.Trim() : aes.InstCd,
                            InstitutionName = aes.InstitutionName,
                            LastModifiedBy = aes.LastModifiedBy,
                            LastModifiedDt = aes.LastModifiedDt,
                            MajorMinorCd = !string.IsNullOrWhiteSpace(aes.MajorMinorCd) ? aes.MajorMinorCd.Trim() : aes.MajorMinorCd,
                            OverSeaInd = aes.OverSeaInd,
                            OverallGrade = aes.OverallGrade,
                            SKMLevel = aes.SKMLevel
                        };
                        var subjects = from a in entities.tblApplicantEduSubjectSubmitteds where a.ApplicantEduId == ed.ApplicantEduId select a;
                        if (subjects.Any())
                        {
                            foreach (var s in subjects)
                            {
                                ed.ApplicantEduSubjectSubmittedCollection.Add(new ApplicantEduSubjectSubmitted
                                {
                                    ApplicantEduId = s.ApplicantEduId,
                                    CreatedBy = s.CreatedBy,
                                    CreatedDt = s.CreatedDt,
                                    EduSubjectId = s.EduSubjectId,
                                    Grade = s.tblREFSubjectGrade.Grade,
                                    GradeCd = !string.IsNullOrWhiteSpace(s.GradeCd) ? s.GradeCd.Trim() : s.GradeCd,
                                    LastModifiedBy = s.LastModifiedBy,
                                    LastModifiedDt = s.LastModifiedDt,
                                    Subject = s.tblREFSubject.Subject,
                                    SubjectCd = s.SubjectCd
                                });
                            }
                        }
                        list.Add(ed);
                    }
                }
            }
            return list;
        }

        public int SaveEducationSubject(ApplicantEduSubjectSubmitted subject)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblApplicantEduSubjectSubmitteds where a.ApplicantEduId == subject.ApplicantEduId && a.SubjectCd == subject.SubjectCd select a).SingleOrDefault();
                if (null != exist)
                {
                    subject.EduSubjectId = exist.EduSubjectId;
                    return UpdateEducationSubject(subject);
                }
                var s = new tblApplicantEduSubjectSubmitted
                {
                    ApplicantEduId = subject.ApplicantEduId,
                    CreatedBy = subject.CreatedBy,
                    CreatedDt = subject.CreatedDt,
                    Grade = subject.Grade,
                    GradeCd = subject.GradeCd,
                    SubjectCd = subject.SubjectCd,
                    LastModifiedBy = subject.LastModifiedBy,
                    LastModifiedDt = subject.LastModifiedDt
                };
                entities.tblApplicantEduSubjectSubmitteds.Add(s);
                if (entities.SaveChanges() > 0)
                    return s.ApplicantEduId;
            }
            return 0;
        }

        public int UpdateEducationSubject(ApplicantEduSubjectSubmitted subject)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblApplicantEduSubjectSubmitteds where a.EduSubjectId == subject.EduSubjectId select a).SingleOrDefault();
                if (null != exist)
                {
                    exist.ApplicantEduId = subject.ApplicantEduId;
                    exist.CreatedBy = subject.CreatedBy;
                    exist.CreatedDt = subject.CreatedDt;
                    exist.Grade = subject.Grade;
                    exist.GradeCd = subject.GradeCd;
                    exist.SubjectCd = subject.SubjectCd;
                    exist.LastModifiedBy = subject.LastModifiedBy;
                    exist.LastModifiedDt = DateTime.Now;

                    entities.SaveChanges();

                    return exist.EduSubjectId;
                }
            }
            return 0;
        }

        public IEnumerable<ApplicantEduSubjectSubmitted> GetEducationSubject(int appeduid)
        {
            var list = new List<ApplicantEduSubjectSubmitted>();
            using (var entities = new atmEntities())
            {
                var l = from a in entities.tblApplicantEduSubjectSubmitteds where a.ApplicantEduId == appeduid select a;
                if (l.Any())
                {
                    foreach (var s in l)
                    {
                        list.Add(new ApplicantEduSubjectSubmitted
                        {
                            ApplicantEduId = s.ApplicantEduId,
                            CreatedBy = s.CreatedBy,
                            CreatedDt = s.CreatedDt,
                            EduSubjectId = s.EduSubjectId,
                            Grade = s.Grade,
                            GradeCd = s.GradeCd,
                            LastModifiedBy = s.LastModifiedBy,
                            LastModifiedDt = s.LastModifiedDt,
                            SubjectCd = s.SubjectCd,
                            Subject = s.tblREFSubject.Subject
                        });
                    }
                }
            }
            return list;
        }

        public int SaveSkill(ApplicantSkillSubmitted skill)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblApplicantSkillSubmitteds where a.ApplicantId == skill.ApplicantId && a.SkillCd == skill.SkillCd select a).SingleOrDefault();
                if (exist != null)
                {
                    skill.ApplicantSkillId = exist.ApplicantSkillId;
                    return UpdateSkill(skill);
                }

                var s = new tblApplicantSkillSubmitted
                {
                    AchievementCd = skill.AchievementCd,
                    ApplicantId = skill.ApplicantId,
                    CreatedBy = skill.CreatedBy,
                    CreatedDt = skill.CreatedDt,
                    LanguageSkillSpeak = skill.LanguageSkillSpeak,
                    LanguageSkillWrite = skill.LanguageSkillWrite,
                    Others = skill.Others,
                    SkillCatCd = skill.SkillCatCd,
                    SkillCd = skill.SkillCd
                };
                entities.tblApplicantSkillSubmitteds.Add(s);

                if (entities.SaveChanges() > 0)
                    return s.ApplicantSkillId;

            }
            return 0;
        }

        public int UpdateSkill(ApplicantSkillSubmitted skill)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblApplicantSkillSubmitteds where a.ApplicantSkillId == skill.ApplicantSkillId select a).SingleOrDefault();
                if (exist != null)
                {
                    exist.AchievementCd = skill.AchievementCd;
                    exist.ApplicantId = skill.ApplicantId;
                    exist.LastModifiedBy = skill.LastModifiedBy;
                    exist.LastModifiedDt = skill.LastModifiedDt;
                    exist.LanguageSkillSpeak = skill.LanguageSkillSpeak;
                    exist.LanguageSkillWrite = skill.LanguageSkillWrite;
                    exist.Others = skill.Others;
                    exist.SkillCatCd = skill.SkillCatCd;
                    exist.SkillCd = skill.SkillCd;

                    entities.SaveChanges();
                    return exist.ApplicantSkillId;
                }
            }
            return 0;
        }

        public IEnumerable<ApplicantSkillSubmitted> GetSkill(int applicantid, int acquisitionid)
        {
            var list = new List<ApplicantSkillSubmitted>();
            using (var entities = new atmEntities())
            {
                var l = from a in entities.tblApplicantSkillSubmitteds join b in entities.tblApplicantSubmiteds on a.ApplicantId equals b.ApplicantId where a.ApplicantId == applicantid && b.AcquisitionId == acquisitionid select a;
                if (l.Any())
                {
                    foreach (var s in l)
                    {
                        var sks = new ApplicantSkillSubmitted
                        {
                            AchievementCd = s.AchievementCd,
                            CreatedBy = s.CreatedBy,
                            CreatedDt = s.CreatedDt,
                            LastModifiedBy = s.LastModifiedBy,
                            LastModifiedDt = s.LastModifiedDt,
                            ApplicantId = s.ApplicantId,
                            ApplicantSkillId = s.ApplicantSkillId,
                            LanguageSkillSpeak = s.LanguageSkillSpeak,
                            LanguageSkillWrite = s.LanguageSkillWrite,
                            Others = s.Others,
                            Skill = s.tblREFSkill.Skill,
                            SkillCatCd = !string.IsNullOrWhiteSpace(s.SkillCatCd) ? s.SkillCatCd.Trim() : s.SkillCatCd,
                            SkillCd = !string.IsNullOrWhiteSpace(s.SkillCd) ? s.SkillCd.Trim() : s.SkillCd
                        };

                        if (!string.IsNullOrWhiteSpace(sks.SkillCd) && s.tblREFSkill != null)
                            sks.Skill = s.tblREFSkill.Skill;

                        list.Add(sks);
                    }
                }
            }
            return list;
        }

        public int SaveSport(ApplicantSportSubmitted sport)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblApplicantSportAssocSubmitteds where a.ApplicantId == sport.ApplicantId && a.ApplicantSportAssocId == sport.SportAssocId select a).SingleOrDefault();
                if (exist != null)
                {
                    sport.ApplicantSportAssocId = exist.ApplicantSportAssocId;
                    return UpdateSport(sport);
                }

                var s = new tblApplicantSportAssocSubmitted
                {
                    AchievementCd = sport.AchievementCd,
                    ApplicantId = sport.ApplicantId,
                    CreatedBy = sport.CreatedBy,
                    CreatedDt = sport.CreatedDt,
                    Others = sport.Others,
                    SportAssocId = sport.SportAssocId,
                    Year = sport.Year
                };
                entities.tblApplicantSportAssocSubmitteds.Add(s);

                if (entities.SaveChanges() > 0)
                    return s.ApplicantSportAssocId;
            }
            return 0;
        }

        public int UpdateSport(ApplicantSportSubmitted sport)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblApplicantSportAssocSubmitteds where a.ApplicantSportAssocId == sport.ApplicantSportAssocId select a).SingleOrDefault();
                if (exist != null)
                {
                    exist.AchievementCd = sport.AchievementCd;
                    exist.ApplicantId = sport.ApplicantId;
                    exist.Others = sport.Others;
                    exist.Year = sport.Year;
                    exist.LastModifiedBy = sport.LastModifiedBy;
                    exist.LastModifiedDt = sport.LastModifiedDt;

                    entities.SaveChanges();
                    return exist.ApplicantSportAssocId;
                }
            }
            return 0;
        }

        public IEnumerable<ApplicantSportSubmitted> GetSport(int applicantid, int acquisitionid)
        {
            var list = new List<ApplicantSportSubmitted>();
            using (var entities = new atmEntities())
            {
                var l = from a in entities.tblApplicantSportAssocSubmitteds join b in entities.tblApplicantSubmiteds on a.ApplicantId equals b.ApplicantId where a.ApplicantId == applicantid && b.AcquisitionId == acquisitionid select a;
                if (l.Any())
                {
                    foreach (var s in l)
                    {
                        var appsa = new ApplicantSportSubmitted
                        {
                            AchievementCd = s.AchievementCd,
                            ApplicantId = s.ApplicantId,
                            ApplicantSportAssocId = s.ApplicantSportAssocId,
                            CreatedBy = s.CreatedBy,
                            CreatedDt = s.CreatedDt,
                            LastModifiedBy = s.LastModifiedBy,
                            LastModifiedDt = s.LastModifiedDt,
                            Others = s.Others,
                            SportAssocId = s.SportAssocId,
                            Year = s.Year
                        };

                        if (s.SportAssocId.HasValue && s.tblREFSportAndAssociation != null)
                        {
                            appsa.SportAndAssociation = new SportAndAssociation()
                            {
                                SportAssocId = s.tblREFSportAndAssociation.SportAssocId,
                                SportAssociatName = s.tblREFSportAndAssociation.SportAssociatName,
                                SportAssociatType = s.tblREFSportAndAssociation.SportAssociatType,
                                ActiveInd = s.tblREFSportAndAssociation.ActiveInd,
                            };
                        }

                        list.Add(appsa);
                    }
                }
            }
            return list;
        }

        public ApplicantSubmittedPhoto GetPhoto(int applicantid)
        {
            if (applicantid != 0)
            {
                using (var entities = new atmEntities())
                {
                    var exist = (from a in entities.tblApplicantSubmittedPhotoes where a.ApplicantId == applicantid select a).SingleOrDefault();
                    if (null != exist)
                    {
                        var p = new ApplicantSubmittedPhoto
                        {
                            ApplicantId = exist.ApplicantId,
                            CreatedBy = exist.CreatedBy,
                            CreatedDate = exist.CreatedDt,
                            Id = exist.Id,
                            LastModifiedBy = exist.LastModifiedBy,
                            LastModifiedDate = exist.LastModifiedDt,
                            Photo = exist.Photo,
                            PhotoExt = exist.PhotoExt
                        };
                        return p;
                    }
                }
            }
            return null;
        }

        public int SaveApplicantPhoto(ApplicantSubmittedPhoto photo)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblApplicantSubmittedPhotoes where a.ApplicantId == photo.ApplicantId select a).SingleOrDefault();
                if (null != exist)
                {
                    photo.Id = exist.Id;
                    UpdateApplicantPhoto(photo);
                }
                else
                {
                    var p = new tblApplicantSubmittedPhoto
                    {
                        ApplicantId = photo.ApplicantId,
                        CreatedBy = photo.CreatedBy,
                        CreatedDt = photo.CreatedDate,
                        Photo = photo.Photo,
                        PhotoExt = photo.PhotoExt
                    };
                    entities.tblApplicantSubmittedPhotoes.Add(p);
                    if (entities.SaveChanges() > 0)
                        return p.Id;
                }
            }
            return 0;
        }

        public int UpdateApplicantPhoto(ApplicantSubmittedPhoto photo)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblApplicantSubmittedPhotoes where a.Id == photo.Id select a).SingleOrDefault();
                if (null != exist)
                {
                    exist.ApplicantId = photo.ApplicantId;
                    exist.LastModifiedBy = photo.LastModifiedBy;
                    exist.LastModifiedDt = photo.LastModifiedDate;
                    exist.Photo = photo.Photo;
                    exist.PhotoExt = photo.PhotoExt;
                    entities.SaveChanges();
                    return exist.Id;
                }
            }
            return 0;
        }

        private static tblApplicantSubmited BindindToTable(ApplicantSubmitted appl)
        {
            var usr = new tblApplicantSubmited
            {
                AcquisitionId = appl.AcquisitionId,
                Email = appl.Email,
                FullName = appl.FullName,
                CreatedDt = appl.CreatedDt,
                ArmySelectionDt = appl.ArmySelectionDt,
                ArmySelectionInd = appl.ArmySelectionInd,
                ArmySelectionVenue = appl.ArmySelectionVenue,
                ArmyServiceInd = appl.ArmyServiceInd,
                ArmyServiceResignRemark = appl.ArmyServiceResignRemark,
                ArmyServiceYrOfServ = appl.ArmyServiceYrOfServ,
                BMI = appl.BMI,
                BirthCertNo = appl.BirthCertNo,
                BirthCityCd = appl.BirthCityCd,
                BirthCountryCd = appl.BirthCountryCd,
                BirthDt = appl.BirthDt ?? DateTime.MinValue,
                BirthPlace = appl.BirthPlace,
                BirthStateCd = appl.BirthStateCd,
                BloodTypeCd = appl.BloodTypeCd,
                ChildNo = appl.ChildNo,
                ColorBlindInd = appl.ColorBlindInd,
                ComputerICT = appl.ComputerICT,
                ComputerMSExcel = appl.ComputerMSExcel,
                ComputerMSPwrPoint = appl.ComputerMSPwrPoint,
                ComputerMSWord = appl.ComputerMSWord,
                ComputerOthers = appl.ComputerOthers,
                CorresponAddr1 = appl.CorresponAddr1,
                CorresponAddr2 = appl.CorresponAddr2,
                CorresponAddr3 = appl.CorresponAddr3,
                CorresponAddrCityCd = appl.CorresponAddrCityCd,
                CorresponAddrCountryCd = appl.CorresponAddrCountryCd,
                CorresponAddrPostCd = appl.CorresponAddrPostCd,
                CorresponAddrStateCd = appl.CorresponAddrStateCd,
                CreatedBy = appl.CreatedBy,
                CrimeInvolvement = appl.CrimeInvolvement,
                CronicIlnessInd = appl.CronicIlnessInd,
                CurrentOccupation = appl.CurrentOccupation,
                CurrentOrganisation = appl.CurrentOrganisation,
                CurrentSalary = appl.CurrentSalary,
                DadICNo = appl.DadICNo,
                DadName = appl.DadName,
                DadNationalityCd = appl.DadNationalityCd,
                DadNotApplicable = appl.DadNotApplicable,
                DadNotApplicableInd = appl.DadNotApplicable,
                DadOccupation = appl.DadOccupation,
                DadPhoneNo = appl.DadPhoneNo,
                DadSalary = appl.DadSalary,
                DrugCaseInvolvement = appl.DrugCaseInvolvement,
                EmployeeAggreeInd = appl.EmployeeAggreeInd,
                EthnicCd = appl.EthnicCd,
                FamilyHighestEduLevel = appl.FamilyHighestEduLevel,
                GenderCd = appl.GenderCd,
                GuardianICNo = appl.GuardianICNo,
                GuardianName = appl.GuardianName,
                GuardianNationalityCd = appl.GuardianNationalityCd,
                GuardianNotApplicable = appl.GuardianNotApplicable,
                GuardianNotApplicableInd = appl.GuardianNotApplicable,
                GuardianOccupation = appl.GuardianOccupation,
                GuardianPhoneNo = appl.GuardianPhoneNo,
                GuardianSalary = appl.GuardianSalary,
                Height = appl.Height,
                HomePhoneNo = appl.HomePhoneNo,
                LastModifiedBy = appl.LastModifiedBy,
                LastModifiedDt = appl.LastModifiedDt,
                MobilePhoneNo = appl.MobilePhoneNo,
                MomICNo = appl.MomICNo,
                MomName = appl.MomName,
                MomNationalityCd = appl.MomNationalityCd,
                MomNotApplicable = appl.MomNotApplicable,
                MomNotApplicableInd = appl.MomNotApplicable,
                MomOccupation = appl.MomOccupation,
                MomPhoneNo = appl.MomPhoneNo,
                MomSalary = appl.MomSalary,
                MrtlStatusCd = appl.MrtlStatusCd,
                NationalityCd = appl.NationalityCd,
                NationalityCertNo = appl.NationalityCertNo,
                NewICNo = appl.NewICNo,
                NoOfSibling = appl.NoOfSibling,
                NoTentera = appl.NoTentera,
                OriginalPelepasanDocument = appl.OriginalPelepasanDocument,
                PalapesArmyNo = appl.PalapesArmyNo,
                PalapesInd = appl.PalapesInd,
                PalapesInstitution = appl.PalapesInstitution,
                PalapesRemark = appl.PalapesRemark,
                PalapesServices = appl.PalapesServices,
                PalapesTauliahEndDt = appl.PalapesTauliahEndDt,
                PalapesYear = appl.PalapesYear,
                PelepasanDocument = appl.PelepasanDocument,
                RaceCd = appl.RaceCd,
                ReligionCd = appl.ReligionCd,
                ResidenceTypeInd = appl.ResidenceTypeInd,
                ScholarshipBody = appl.ScholarshipBody,
                ScholarshipBodyAddr = appl.ScholarshipBodyAddr,
                ScholarshipContractStDate = appl.ScholarshipContractStDate,
                ScholarshipInd = appl.ScholarshipInd,
                ScholarshipNoOfYrContract = appl.ScholarshipNoOfYrContract,
                SelectionTD = appl.SelectionTD,
                SelectionTL = appl.SelectionTL,
                SelectionTU = appl.SelectionTU,
                SpectaclesUserInd = appl.SpectaclesUserInd,
                Weight = appl.Weight
            };
            return usr;
        }

        private static ApplicantSubmitted BindingToClass(tblApplicantSubmited appl)
        {
            var usr = new ApplicantSubmitted();
            usr.ApplicantId = appl.ApplicantId;
            usr.AcquisitionId = appl.AcquisitionId;
            usr.Email = appl.Email;
            usr.FullName = appl.FullName;
            usr.CreatedDt = appl.CreatedDt;
            usr.ArmySelectionDt = appl.ArmySelectionDt;
            usr.ArmySelectionInd = appl.ArmySelectionInd;
            usr.ArmySelectionVenue = appl.ArmySelectionVenue;
            usr.ArmyServiceInd = appl.ArmyServiceInd;
            usr.ArmyServiceResignRemark = appl.ArmyServiceResignRemark;
            usr.ArmyServiceYrOfServ = appl.ArmyServiceYrOfServ;
            usr.BMI = appl.BMI;
            usr.BirthCertNo = appl.BirthCertNo;
            usr.BirthCityCd = appl.BirthCityCd;
            usr.BirthCountryCd = appl.BirthCountryCd;
            usr.BirthDt = appl.BirthDt;
            usr.BirthPlace = appl.BirthPlace;
            usr.BirthStateCd = appl.BirthStateCd;
            usr.BirthStateName = appl.tblREFState != null ? appl.tblREFState.State : string.Empty;
            usr.BloodTypeCd = appl.BloodTypeCd;
            usr.ChildNo = appl.ChildNo;
            usr.ColorBlindInd = appl.ColorBlindInd;
            usr.ComputerICT = appl.ComputerICT;
            usr.ComputerMSExcel = appl.ComputerMSExcel;
            usr.ComputerMSPwrPoint = appl.ComputerMSPwrPoint;
            usr.ComputerMSWord = appl.ComputerMSWord;
            usr.ComputerOthers = appl.ComputerOthers;
            usr.CorresponAddr1 = appl.CorresponAddr1;
            usr.CorresponAddr2 = appl.CorresponAddr2;
            usr.CorresponAddr3 = appl.CorresponAddr3;
            usr.CorresponAddrCityCd = appl.CorresponAddrCityCd;
            usr.CorresponAddrCountryCd = appl.CorresponAddrCountryCd;
            usr.CorresponAddrPostCd = appl.CorresponAddrPostCd;
            usr.CorresponAddrStateCd = appl.CorresponAddrStateCd;
            usr.CreatedBy = appl.CreatedBy;
            usr.CrimeInvolvement = appl.CrimeInvolvement;
            usr.CronicIlnessInd = appl.CronicIlnessInd;
            usr.CurrentOccupation = appl.CurrentOccupation;
            usr.CurrentOrganisation = appl.CurrentOrganisation;
            usr.CurrentSalary = appl.CurrentSalary;
            usr.DadICNo = appl.DadICNo;
            usr.DadName = appl.DadName;
            usr.DadNationalityCd = appl.DadNationalityCd;
            usr.DadNotApplicable = appl.DadNotApplicable;
            usr.DadOccupation = appl.DadOccupation;
            usr.DadPhoneNo = appl.DadPhoneNo;
            usr.DadSalary = appl.DadSalary;
            usr.DrugCaseInvolvement = appl.DrugCaseInvolvement;
            usr.EmployeeAggreeInd = appl.EmployeeAggreeInd;
            usr.EthnicCd = appl.EthnicCd;
            usr.FamilyHighestEduLevel = appl.FamilyHighestEduLevel;
            usr.GenderCd = appl.GenderCd;
            usr.GuardianICNo = appl.GuardianICNo;
            usr.GuardianName = appl.GuardianName;
            usr.GuardianNationalityCd = appl.GuardianNationalityCd;
            usr.GuardianNotApplicable = appl.GuardianNotApplicable;
            usr.GuardianOccupation = appl.GuardianOccupation;
            usr.GuardianPhoneNo = appl.GuardianPhoneNo;
            usr.GuardianSalary = appl.GuardianSalary;
            usr.Height = appl.Height;
            usr.HomePhoneNo = appl.HomePhoneNo;
            usr.LastModifiedBy = appl.LastModifiedBy;
            usr.LastModifiedDt = appl.LastModifiedDt;
            usr.MobilePhoneNo = appl.MobilePhoneNo;
            usr.MomICNo = appl.MomICNo;
            usr.MomName = appl.MomName;
            usr.MomNationalityCd = appl.MomNationalityCd;
            usr.MomNotApplicable = appl.MomNotApplicable;
            usr.MomOccupation = appl.MomOccupation;
            usr.MomPhoneNo = appl.MomPhoneNo;
            usr.MomSalary = appl.MomSalary;
            usr.MrtlStatusCd = appl.MrtlStatusCd;
            usr.NationalityCd = appl.NationalityCd;
            usr.NationalityCertNo = appl.NationalityCertNo;
            usr.NewICNo = appl.NewICNo;
            usr.NoOfSibling = appl.NoOfSibling;
            usr.NoTentera = appl.NoTentera;
            usr.OriginalPelepasanDocument = appl.OriginalPelepasanDocument;
            usr.PalapesArmyNo = appl.PalapesArmyNo;
            usr.PalapesInd = appl.PalapesInd;
            usr.PalapesInstitution = appl.PalapesInstitution;
            usr.PalapesRemark = appl.PalapesRemark;
            usr.PalapesServices = appl.PalapesServices;
            usr.PalapesTauliahEndDt = appl.PalapesTauliahEndDt;
            usr.PalapesYear = appl.PalapesYear;
            usr.PelepasanDocument = appl.PelepasanDocument;
            usr.RaceCd = appl.RaceCd;
            usr.ReligionCd = appl.ReligionCd;
            usr.ResidenceTypeInd = appl.ResidenceTypeInd;
            usr.ScholarshipBody = appl.ScholarshipBody;
            usr.ScholarshipBodyAddr = appl.ScholarshipBodyAddr;
            usr.ScholarshipContractStDate = appl.ScholarshipContractStDate;
            usr.ScholarshipInd = appl.ScholarshipInd;
            usr.ScholarshipNoOfYrContract = appl.ScholarshipNoOfYrContract;
            usr.SelectionTD = appl.SelectionTD;
            usr.SelectionTL = appl.SelectionTL;
            usr.SelectionTU = appl.SelectionTU;
            usr.SpectaclesUserInd = appl.SpectaclesUserInd;
            usr.Weight = appl.Weight;

            if (!string.IsNullOrWhiteSpace(appl.CorresponAddrStateCd))
            {
                if (appl.tblREFState1 != null)
                    usr.CorresponAddrStateNm = appl.tblREFState1.State;
            }

            if (!string.IsNullOrWhiteSpace(appl.CorresponAddrCityCd))
            {
                if (appl.tblREFCity1 != null)
                    usr.CorresponAddrCityNm = appl.tblREFCity1.City;
            }
            return usr;
        }


        public IEnumerable<ApplicantSubmitted> GetApplicants(int acquisitionid, string racecode)
        {
            var list = new List<ApplicantSubmitted>();

            if (acquisitionid == 0) return list;
            using (var entities = new atmEntities())
            {
                var exist = from a in entities.tblApplicantSubmiteds where a.AcquisitionId == acquisitionid && a.RaceCd == racecode select a;
                if (!exist.Any()) return list;
                foreach (var u in exist)
                {
                    var app = BindingToClass(u);
                    var edus = GetEducation(app.ApplicantId, acquisitionid);
                    foreach (var ed in edus)
                        app.ApplicantEducationSubmittedCollection.Add(ed);

                    list.Add(app);
                }
            }
            return list;
        }


        public IEnumerable<ApplicantSubmitted> Search(int acquisitionid, string category, string name, string icno, string searchcriteria, bool? invitationfirtselection, bool? firstselection, bool? finalselection, int? take, int? skip, bool? all, out int total)
        {
            var list = new List<ApplicantSubmitted>();
            total = 0;
            if (acquisitionid == 0) return list;
            using (var entities = new atmEntities())
            {
                var l = from a in entities.tblApplicantSubmiteds where a.AcquisitionId == acquisitionid select a;
                if (!all.HasValue)
                {
                    if (invitationfirtselection.HasValue)
                        l = from a in entities.tblApplicantSubmiteds join b in entities.tblApplications on a.ApplicantId equals b.ApplicantId where b.InvitationFirstSel == invitationfirtselection && a.AcquisitionId == acquisitionid && b.AcquisitionId == acquisitionid select a;
                    if (firstselection.HasValue)
                        l = from a in entities.tblApplicantSubmiteds join b in entities.tblApplications on a.ApplicantId equals b.ApplicantId where b.FirstSelectionInd == firstselection && a.AcquisitionId == acquisitionid && b.AcquisitionId == acquisitionid select a;
                    if (finalselection.HasValue)
                        l = from a in entities.tblApplicantSubmiteds join b in entities.tblApplications on a.ApplicantId equals b.ApplicantId where b.FinalSelectionInd == finalselection && a.AcquisitionId == acquisitionid && b.AcquisitionId == acquisitionid select a;
                    if (!invitationfirtselection.HasValue && !firstselection.HasValue && !finalselection.HasValue)
                        l = from a in entities.tblApplicantSubmiteds join b in entities.tblApplications on a.ApplicantId equals b.ApplicantId where b.InvitationFirstSel == invitationfirtselection && b.FinalSelectionInd == finalselection && b.FirstSelectionInd == firstselection && a.AcquisitionId == acquisitionid && b.AcquisitionId == acquisitionid select a;
                }
                if (!string.IsNullOrWhiteSpace(name))
                    l = l.Where(a => a.FullName.Contains(name));
                if (!string.IsNullOrWhiteSpace(icno))
                    l = l.Where(a => a.NewICNo.Contains(icno));
                if (!string.IsNullOrWhiteSpace(searchcriteria))
                    l = l.Where(a => a.NewICNo.Contains(searchcriteria) || a.FullName.Contains(searchcriteria));

                total = l.Count();

                if (take.HasValue && skip.HasValue)
                    l = l.OrderBy(a => a.FullName).Skip(skip.Value).Take(take.Value);

                if (!l.Any()) return list;
                foreach (var app in l)
                {
                    var aps = BindingToClass(app);
                    if (aps.AcquisitionId != 0)
                        aps.Acquisition = ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetAcquisition(aps.AcquisitionId);
                    aps.Application = ObjectBuilder.GetObject<IApplicationPersistance>("ApplicationPersistance").GetByApplicantIdAndAcquisitionId(aps.ApplicantId, aps.AcquisitionId);

                    list.Add(aps);
                }
            }
            return list;
        }


        public IEnumerable<ApplicantSubmitted> GetByAcademis(string highleveleducd)
        {
            var list = new List<ApplicantSubmitted>();
            using (var entities = new atmEntities())
            {
                var submittededue = (from a in entities.tblApplicantEduSubmitteds select a);
                if (!string.IsNullOrWhiteSpace(highleveleducd))
                    submittededue = submittededue.Where(a => a.HighEduLevelCd == highleveleducd);

                if (submittededue.Any())
                {
                    foreach (var app in submittededue)
                    {
                        list.Add(ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence").GetApplicant(app.ApplicantId));
                    }
                }
            }
            return list;
        }


        public ApplicantSubmitted GetApplicant(int applicantid)
        {
            if (applicantid != 0)
            {
                using (var entities = new atmEntities())
                {
                    var exist = (from a in entities.tblApplicantSubmiteds where a.ApplicantId == applicantid select a).SingleOrDefault();
                    if (null != exist)
                        return BindingToClass(exist);
                }
            }
            return null;
        }


        public ApplicantEduSubjectSubmitted GetSubject(int appeduid, int subjectcode)
        {
            if (appeduid != 0 && subjectcode != 0)
            {
                using (var entities = new atmEntities())
                {
                    var exist = (from a in entities.tblApplicantEduSubjectSubmitteds where a.ApplicantEduId == appeduid && a.SubjectCd == subjectcode select a).SingleOrDefault();
                    if (null != exist)
                    {
                        return new ApplicantEduSubjectSubmitted
                        {
                            ApplicantEduId = exist.ApplicantEduId,
                            CreatedBy = exist.CreatedBy,
                            CreatedDt = exist.CreatedDt,
                            EduSubjectId = exist.EduSubjectId,
                            Grade = exist.Grade,
                            GradeCd = !string.IsNullOrWhiteSpace(exist.GradeCd) ? exist.GradeCd.Trim() : exist.GradeCd,
                            LastModifiedBy = exist.LastModifiedBy,
                            LastModifiedDt = exist.LastModifiedDt,
                            SubjectCd = exist.SubjectCd,
                            Subject = exist.tblREFSubject.Subject
                        };
                    }
                }
            }
            return null;
        }


        public IEnumerable<ApplicantSubmitted> Search(int acquisitionid, string searchcriteria, bool? invitationfirtselection, bool? firstselection, bool? finalselection, int? take, int? skip, int? finalselectionlocid, int? reportdutylocid, string statecode, string citycode, bool? all, out int total)
        {
            var list = new List<ApplicantSubmitted>();
            total = 0;
            if (acquisitionid != 0)
            {
                using (var entities = new atmEntities())
                {
                    var l = from a in entities.tblApplicantSubmiteds where a.AcquisitionId == acquisitionid select a;
                    if (!all.HasValue)
                    {
                        if (invitationfirtselection.HasValue)
                            l = from a in entities.tblApplicantSubmiteds join b in entities.tblApplications on a.ApplicantId equals b.ApplicantId where b.InvitationFirstSel == invitationfirtselection && a.AcquisitionId == acquisitionid && b.AcquisitionId == acquisitionid select a;
                        if (firstselection.HasValue)
                            l = from a in entities.tblApplicantSubmiteds join b in entities.tblApplications on a.ApplicantId equals b.ApplicantId where b.FirstSelectionInd == firstselection && a.AcquisitionId == acquisitionid && b.AcquisitionId == acquisitionid select a;
                        if (finalselection.HasValue)
                            l = from a in entities.tblApplicantSubmiteds join b in entities.tblApplications on a.ApplicantId equals b.ApplicantId where b.FinalSelectionInd == finalselection && a.AcquisitionId == acquisitionid && b.AcquisitionId == acquisitionid select a;
                        if (!invitationfirtselection.HasValue && !firstselection.HasValue && !finalselection.HasValue)
                            l = from a in entities.tblApplicantSubmiteds join b in entities.tblApplications on a.ApplicantId equals b.ApplicantId where b.InvitationFirstSel == invitationfirtselection && b.FinalSelectionInd == finalselection && b.FirstSelectionInd == firstselection && a.AcquisitionId == acquisitionid && b.AcquisitionId == acquisitionid select a;
                    }

                    if (finalselectionlocid.HasValue)
                        if (finalselectionlocid.Value == 0)
                            l = from a in entities.tblApplicantSubmiteds join b in entities.tblApplications on a.ApplicantId equals b.ApplicantId where b.InvitationFirstSel == invitationfirtselection && b.FinalSelectionInd == finalselection && b.FirstSelectionInd == firstselection && a.AcquisitionId == acquisitionid && b.AcquisitionId == acquisitionid && b.FinalSelActualAcqLocationId == null select a;
                        else
                            l = from a in entities.tblApplicantSubmiteds join b in entities.tblApplications on a.ApplicantId equals b.ApplicantId where b.InvitationFirstSel == invitationfirtselection && b.FinalSelectionInd == finalselection && b.FirstSelectionInd == firstselection && a.AcquisitionId == acquisitionid && b.AcquisitionId == acquisitionid && b.FinalSelActualAcqLocationId == finalselectionlocid select a;

                    if (reportdutylocid.HasValue)
                        if (reportdutylocid.Value == 0)
                            l = from a in entities.tblApplicantSubmiteds join b in entities.tblApplications on a.ApplicantId equals b.ApplicantId where b.InvitationFirstSel == invitationfirtselection && b.FinalSelectionInd == finalselection && b.FirstSelectionInd == firstselection && a.AcquisitionId == acquisitionid && b.AcquisitionId == acquisitionid && b.ReportDutyLocId == null select a;
                        else
                            l = from a in entities.tblApplicantSubmiteds join b in entities.tblApplications on a.ApplicantId equals b.ApplicantId where b.InvitationFirstSel == invitationfirtselection && b.FinalSelectionInd == finalselection && b.FirstSelectionInd == firstselection && a.AcquisitionId == acquisitionid && b.AcquisitionId == acquisitionid && b.ReportDutyLocId == reportdutylocid select a;

                    if (!string.IsNullOrWhiteSpace(statecode) && statecode != "undefined" && statecode != "null")
                        l = l.Where(a => a.CorresponAddrStateCd == statecode);
                    if (!string.IsNullOrWhiteSpace(citycode) && citycode != "undefined" && citycode != "null")
                        l = l.Where(a => a.CorresponAddrCityCd == citycode);

                    if (!string.IsNullOrWhiteSpace(searchcriteria))
                        l = l.Where(a => a.NewICNo.Contains(searchcriteria) || a.FullName.Contains(searchcriteria));

                    total = l.Count();

                    if (take.HasValue && skip.HasValue)
                        l = l.OrderBy(a => a.FullName).Skip(skip.Value).Take(take.Value);

                    if (l.Any())
                    {
                        foreach (var app in l)
                        {
                            var aps = BindingToClass(app);
                            if (aps.AcquisitionId != 0)
                                aps.Acquisition = ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetAcquisition(aps.AcquisitionId);
                            aps.Application = ObjectBuilder.GetObject<IApplicationPersistance>("ApplicationPersistance").GetByApplicantIdAndAcquisitionId(aps.ApplicantId, aps.AcquisitionId);

                            list.Add(aps);
                        }
                    }
                }
            }
            return list;
        }
    }
}
