using System;
using System.Collections.Generic;
using System.Linq;
using SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Atm.Entity.Persistance
{
    class ApplicantPersistence : IApplicantPersistence
    {
        public void Delete(int id)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblApplicants where a.ApplicantId == id select a);
                if (exist.Any())
                    entities.tblApplicants.RemoveRange(exist);
            }
        }

        public int Save(Applicant appl)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblApplicants where a.NewICNo == appl.NewICNo select a).SingleOrDefault();
                if (null != exist)
                {
                    appl.ApplicantId = exist.ApplicantId;
                    return Update(appl);
                }
                var usr = BindindToTable(appl);
                entities.tblApplicants.Add(usr);
                if (entities.SaveChanges() > 0)
                    return usr.ApplicantId;
            }
            return 0;
        }

        public int Update(Applicant appl)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblApplicants where a.ApplicantId == appl.ApplicantId select a).SingleOrDefault();
                if (null != exist)
                {
                    exist.Email = appl.Email;
                    exist.FullName = appl.FullName.ToUpper();
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
                    exist.BirthDt = appl.BirthDt ?? DateTime.MinValue;
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

        public Applicant GetApplicant(int id)
        {
            if (id != 0)
            {
                using (var entities = new atmEntities())
                {
                    var exist = (from a in entities.tblApplicants where a.ApplicantId == id select a).SingleOrDefault();
                    if (null != exist)
                        return BindingToClass(exist);
                }
            }
            return null;
        }

        public int SaveEducation(ApplicantEducation education)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblApplicantEdus where a.ApplicantId == education.ApplicantId && a.HighEduLevelCd == education.HighEduLevelCd select a).SingleOrDefault();
                if (exist != null)
                {
                    education.ApplicantEduId = exist.ApplicantEduId;
                    return UpdateEducation(education);
                }

                if (education.ApplicantEduId != 0) { return UpdateEducation(education); }

                var ed = new tblApplicantEdu
                {
                    ApplicantId = education.ApplicantId,
                    ConfermentYr = education.ConfermentYr,
                    CreatedBy = education.CreatedBy,
                    CreatedDt = education.CreatedDt,
                    EduCertTitle = education.EduCertTitle,
                    HighEduLevelCd = !string.IsNullOrWhiteSpace(education.HighEduLevelCd) ? education.HighEduLevelCd.Trim() : education.HighEduLevelCd,
                    InstCd = !string.IsNullOrWhiteSpace(education.InstCd) ? education.InstCd.Trim() : education.InstCd,
                    InstitutionName = education.InstitutionName,
                    MajorMinorCd = !string.IsNullOrWhiteSpace(education.MajorMinorCd) ? education.MajorMinorCd.Trim() : education.MajorMinorCd,
                    OverSeaInd = education.OverSeaInd,
                    OverallGrade = education.OverallGrade,
                    SKMLevel = education.SKMLevel
                };
                entities.tblApplicantEdus.Add(ed);
                if (entities.SaveChanges() > 0)
                    return ed.ApplicantEduId;
            }
            return 0;
        }

        public int UpdateEducation(ApplicantEducation education)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblApplicantEdus where a.ApplicantEduId == education.ApplicantEduId select a).SingleOrDefault();
                if (exist != null)
                {
                    exist.ApplicantId = education.ApplicantId;
                    exist.ConfermentYr = education.ConfermentYr;
                    exist.EduCertTitle = education.EduCertTitle;
                    exist.HighEduLevelCd = !string.IsNullOrWhiteSpace(education.HighEduLevelCd) ? education.HighEduLevelCd.Trim() : education.HighEduLevelCd;
                    exist.InstCd = !string.IsNullOrWhiteSpace(education.InstCd) ? education.InstCd.Trim() : education.InstCd;
                    exist.InstitutionName = education.InstitutionName;
                    exist.LastModifiedBy = education.LastModifiedBy;
                    exist.LastModifiedDt = DateTime.Now;
                    exist.MajorMinorCd = !string.IsNullOrWhiteSpace(education.MajorMinorCd) ? education.MajorMinorCd.Trim() : education.MajorMinorCd;
                    exist.OverSeaInd = education.OverSeaInd;
                    exist.OverallGrade = education.OverallGrade;
                    exist.SKMLevel = education.SKMLevel;
                    entities.SaveChanges();

                    return exist.ApplicantEduId;
                }
            }
            return 0;
        }

        public IEnumerable<ApplicantEducation> GetEducation(int applicantid)
        {
            var list = new List<ApplicantEducation>();
            using (var entities = new atmEntities())
            {
                var l = from a in entities.tblApplicantEdus where a.ApplicantId == applicantid select a;
                if (l.Any())
                {
                    foreach (var aes in l)
                    {
                        var ed = new ApplicantEducation
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

                        if (aes.tblApplicantEduSubjects.Any())
                        {
                            foreach (var s in aes.tblApplicantEduSubjects)
                            {
                                ed.ApplicantEduSubjectCollection.Add(new ApplicantEduSubject
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

        public int SaveEducationSubject(ApplicantEduSubject subject)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblApplicantEduSubjects where a.ApplicantEduId == subject.ApplicantEduId && a.SubjectCd == subject.SubjectCd select a).SingleOrDefault();
                if (null != exist)
                {
                    subject.EduSubjectId = exist.EduSubjectId;
                    return UpdateEducationSubject(subject);
                }

                if (subject.EduSubjectId != 0) { return UpdateEducationSubject(subject); }

                var s = new tblApplicantEduSubject
                {
                    ApplicantEduId = subject.ApplicantEduId,
                    CreatedBy = subject.CreatedBy,
                    CreatedDt = subject.CreatedDt,
                    Grade = subject.Grade,
                    GradeCd = !string.IsNullOrWhiteSpace(subject.GradeCd) ? subject.GradeCd.Trim() : subject.GradeCd,
                    SubjectCd = subject.SubjectCd,
                    LastModifiedBy = subject.LastModifiedBy,
                    LastModifiedDt = subject.LastModifiedDt
                };
                entities.tblApplicantEduSubjects.Add(s);
                if (entities.SaveChanges() > 0)
                    return s.EduSubjectId;
            }
            return 0;
        }

        public int UpdateEducationSubject(ApplicantEduSubject subject)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblApplicantEduSubjects where a.EduSubjectId == subject.EduSubjectId select a).SingleOrDefault();
                if (null != exist)
                {
                    exist.ApplicantEduId = subject.ApplicantEduId;
                    exist.CreatedBy = subject.CreatedBy;
                    exist.CreatedDt = subject.CreatedDt;
                    exist.Grade = subject.Grade;
                    exist.GradeCd = !string.IsNullOrWhiteSpace(subject.GradeCd) ? subject.GradeCd.Trim() : subject.GradeCd;
                    exist.SubjectCd = subject.SubjectCd;
                    exist.LastModifiedBy = subject.LastModifiedBy;
                    exist.LastModifiedDt = DateTime.Now;
                    entities.SaveChanges();

                    return exist.EduSubjectId;
                }
            }
            return 0;
        }

        public IEnumerable<ApplicantEduSubject> GetEducationSubject(int appeduid)
        {
            var list = new List<ApplicantEduSubject>();
            using (var entities = new atmEntities())
            {
                var l = from a in entities.tblApplicantEduSubjects where a.ApplicantEduId == appeduid select a;
                if (l.Any())
                {
                    foreach (var s in l)
                    {
                        list.Add(new ApplicantEduSubject
                        {
                            ApplicantEduId = s.ApplicantEduId,
                            CreatedBy = s.CreatedBy,
                            CreatedDt = s.CreatedDt,
                            EduSubjectId = s.EduSubjectId,
                            Grade = s.Grade,
                            GradeCd = !string.IsNullOrWhiteSpace(s.GradeCd) ? s.GradeCd.Trim() : s.GradeCd,
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

        public ApplicantEduSubject GetSubject(int appeduid, int subjectcode)
        {
            if (appeduid != 0 && subjectcode != 0)
            {
                using (var entities = new atmEntities())
                {
                    var exist = (from a in entities.tblApplicantEduSubjects where a.ApplicantEduId == appeduid && a.SubjectCd == subjectcode select a).SingleOrDefault();
                    if (null != exist)
                    {
                        return new ApplicantEduSubject
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

        public int SaveSkill(ApplicantSkill skill)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblApplicantSkills where a.ApplicantId == skill.ApplicantId && a.SkillCd == skill.SkillCd select a).SingleOrDefault();
                if (exist != null)
                {
                    skill.ApplicantSkillId = exist.ApplicantSkillId;
                    return UpdateSkill(skill);
                }

                if (skill.ApplicantSkillId != 0) { return UpdateSkill(skill); }

                var s = new tblApplicantSkill
                {
                    AchievementCd = skill.AchievementCd,
                    ApplicantId = skill.ApplicantId,
                    CreatedBy = skill.CreatedBy,
                    CreatedDt = skill.CreatedDt,
                    LanguageSkillSpeak = skill.LanguageSkillSpeak,
                    LanguageSkillWrite = skill.LanguageSkillWrite,
                    Others = skill.Others,
                    SkillCatCd = !string.IsNullOrWhiteSpace(skill.SkillCatCd) ? skill.SkillCatCd.Trim() : skill.SkillCatCd,
                    SkillCd = !string.IsNullOrWhiteSpace(skill.SkillCd) ? skill.SkillCd.Trim() : skill.SkillCd
                };
                entities.tblApplicantSkills.Add(s);
                if (entities.SaveChanges() > 0)
                    return s.ApplicantSkillId;

            }
            return 0;
        }

        public int UpdateSkill(ApplicantSkill skill)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblApplicantSkills where a.ApplicantSkillId == skill.ApplicantSkillId select a).SingleOrDefault();
                if (exist != null)
                {
                    exist.AchievementCd = skill.AchievementCd;
                    exist.ApplicantId = skill.ApplicantId;
                    exist.LastModifiedBy = skill.LastModifiedBy;
                    exist.LastModifiedDt = skill.LastModifiedDt;
                    exist.LanguageSkillSpeak = skill.LanguageSkillSpeak;
                    exist.LanguageSkillWrite = skill.LanguageSkillWrite;
                    exist.Others = skill.Others;
                    exist.SkillCatCd = !string.IsNullOrWhiteSpace(skill.SkillCatCd) ? skill.SkillCatCd.Trim() : skill.SkillCatCd;
                    exist.SkillCd = !string.IsNullOrWhiteSpace(skill.SkillCd) ? skill.SkillCd.Trim() : skill.SkillCd;

                    entities.SaveChanges();
                    return exist.ApplicantSkillId;
                }
            }
            return 0;
        }

        public IEnumerable<ApplicantSkill> GetSkill(int applicantid)
        {
            using (var entities = new atmEntities())
            {
                var skills = entities.tblApplicantSkills.Where(sk => sk.ApplicantId == applicantid).ToList();
                var list = from s in skills
                           select new ApplicantSkill
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
                               Skill = s.tblREFSkill?.Skill,
                               SkillCatCd = s.SkillCatCd?.Trim(),
                               SkillCd = s.SkillCd?.Trim()
                           };


                return list.ToList();

            }
        }

        public int SaveSport(ApplicantSport sport)
        {
            using (var entities = new atmEntities())
            {
                // to cater Other category
                if (sport.SportAssocId != 99)
                {
                    var exist = (from a in entities.tblApplicantSportAssocs where a.ApplicantId == sport.ApplicantId && a.SportAssocId != null && a.SportAssocId == sport.SportAssocId select a).SingleOrDefault();
                    if (exist != null)
                    {
                        sport.ApplicantSportAssocId = exist.ApplicantSportAssocId;
                        return UpdateSport(sport);
                    }
                }

                if (sport.ApplicantSportAssocId != 0) { return UpdateSport(sport); }

                var s = new tblApplicantSportAssoc
                {
                    AchievementCd = sport.AchievementCd,
                    ApplicantId = sport.ApplicantId,
                    CreatedBy = sport.CreatedBy,
                    CreatedDt = sport.CreatedDt,
                    Others = sport.Others,
                    SportAssocId = sport.SportAssocId,
                    Year = sport.Year
                };
                entities.tblApplicantSportAssocs.Add(s);
                if (entities.SaveChanges() > 0)
                    return s.ApplicantSportAssocId;

            }
            return 0;
        }

        public int UpdateSport(ApplicantSport sport)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblApplicantSportAssocs where a.ApplicantSportAssocId == sport.ApplicantSportAssocId select a).SingleOrDefault();
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

        public IEnumerable<ApplicantSport> GetSport(int applicantid)
        {
            var list = new List<ApplicantSport>();
            using (var entities = new atmEntities())
            {
                var l = from a in entities.tblApplicantSportAssocs where a.ApplicantId == applicantid select a;
                if (l.Any())
                {
                    foreach (var s in l)
                    {
                        var appsa = new ApplicantSport
                        {
                            AchievementCd = !string.IsNullOrWhiteSpace(s.AchievementCd) ? s.AchievementCd.Trim() : s.AchievementCd,
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

        public ApplicantPhoto GetPhoto(int applicantid)
        {
            if (applicantid != 0)
            {
                using (var entities = new atmEntities())
                {
                    var exist = (from a in entities.tblApplicantPhotoes where a.ApplicantId == applicantid select a).SingleOrDefault();
                    if (null != exist)
                    {
                        var p = new ApplicantPhoto
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

        public int SaveApplicantPhoto(ApplicantPhoto photo)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblApplicantPhotoes where a.ApplicantId == photo.ApplicantId select a).SingleOrDefault();
                if (null != exist)
                {
                    photo.Id = exist.Id;
                    UpdateApplicantPhoto(photo);
                }
                else
                {
                    var p = new tblApplicantPhoto
                    {
                        ApplicantId = photo.ApplicantId,
                        CreatedBy = photo.CreatedBy,
                        CreatedDt = photo.CreatedDate,
                        Photo = photo.Photo,
                        PhotoExt = photo.PhotoExt
                    };
                    entities.tblApplicantPhotoes.Add(p);
                    if (entities.SaveChanges() > 0)
                        return p.Id;
                }
            }
            return 0;
        }

        public int UpdateApplicantPhoto(ApplicantPhoto photo)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblApplicantPhotoes where a.Id == photo.Id select a).SingleOrDefault();
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

        public bool CheckingExistingAtmMember(string idnumber)
        {
            if (!string.IsNullOrWhiteSpace(idnumber))
            {
                using (var entities = new atmEntities())
                {
                    var exist = (from a in entities.tblExistingAtmMembers where a.ICNOBaru.ToLower() == idnumber.ToLower() select a).SingleOrDefault();
                    return null != exist;
                }
            }
            return false;
        }

        public ExistingMember ExistingAtmMember(string idnumber)
        {
            if (!string.IsNullOrWhiteSpace(idnumber))
            {
                using (var entities = new atmEntities())
                {
                    var exist = (from a in entities.tblExistingAtmMembers where a.ICNOBaru.ToLower() == idnumber.ToLower() select a).SingleOrDefault();
                    if (null != exist)
                    {
                        return new ExistingMember
                        {
                            CoId = exist.COID,
                            Name = exist.CONm,
                            ArmyNo = exist.NoTentera,
                            IdNumber = exist.ICNOBaru,
                            ExistingMemberStatus = new ExistingMemberStatus
                            {
                                Code = exist.tblREFExistingMemberStatu.ExistingMemberStatusCD,
                                Status = exist.tblREFExistingMemberStatu.ExistingMemberStatus
                            }
                        };
                    }
                }
            }
            return null;
        }


        private static tblApplicant BindindToTable(Applicant appl)
        {
            var usr = new tblApplicant
            {
                Email = appl.Email,
                FullName = appl.FullName.ToUpper(),
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

        private static Applicant BindingToClass(tblApplicant appl)
        {
            var usr = new Applicant
            {
                ApplicantId = appl.ApplicantId,
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
                BirthDt = appl.BirthDt,
                BirthPlace = appl.BirthPlace,
                BirthStateCd = appl.BirthStateCd,
                BirthStateName = appl.tblREFState.State,
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


        public bool CheckingExistingAtmMemberByArmyNo(string armyno)
        {
            if (!string.IsNullOrWhiteSpace(armyno))
            {
                using (var entities = new atmEntities())
                {
                    var exist = (from a in entities.tblExistingAtmMembers where a.NoTentera == armyno select a).SingleOrDefault();
                    return null != exist;
                }
            }
            return false;
        }

        public ExistingMember ExistingAtmMemberByArmyNo(string armyno)
        {
            if (!string.IsNullOrWhiteSpace(armyno))
            {
                using (var entities = new atmEntities())
                {
                    var exist = (from a in entities.tblExistingAtmMembers where a.NoTentera == armyno select a).SingleOrDefault();
                    if (null != exist)
                    {
                        var atm = new ExistingMember
                        {
                            CoId = exist.COID,
                            Name = exist.CONm,
                            ArmyNo = exist.NoTentera,
                            IdNumber = exist.ICNOBaru,
                        };

                        if (!string.IsNullOrWhiteSpace(exist.ExistingMemberStatusCd))
                        {
                            atm.ExistingMemberStatus = new ExistingMemberStatus
                            {
                                Code = exist.tblREFExistingMemberStatu.ExistingMemberStatusCD,
                                Status = exist.tblREFExistingMemberStatu.ExistingMemberStatus
                            };
                        }
                        return atm;
                    }
                }
            }
            return null;
        }


        public IEnumerable<Applicant> Search(string category, string name, string icno, string searchcriteria)
        {
            var list = new List<Applicant>();
            using (var entities = new atmEntities())
            {
                var l = from a in entities.tblApplicants select a;
                if (!string.IsNullOrWhiteSpace(name))
                    l = l.Where(a => a.FullName.Contains(name));
                if (!string.IsNullOrWhiteSpace(icno))
                    l = l.Where(a => a.NewICNo.Contains(icno));
                if (!string.IsNullOrWhiteSpace(searchcriteria))
                    l = l.Where(a => a.NewICNo.Contains(searchcriteria) || a.FullName.Contains(searchcriteria));
                if (l.Any())
                {
                    foreach (var app in l)
                    {
                        list.Add(BindingToClass(app));
                    }
                }
            }
            return list;
        }


        public ApplicantSport GetApplicantSportAndKokos(int applicantsportid)
        {
            if (applicantsportid != 0)
            {
                using (var entities = new atmEntities())
                {
                    var exist = (from a in entities.tblApplicantSportAssocs where a.ApplicantSportAssocId == applicantsportid select a).SingleOrDefault();
                    if (null != exist)
                    {
                        var apps = new ApplicantSport()
                        {
                            AchievementCd = !string.IsNullOrWhiteSpace(exist.AchievementCd) ? exist.AchievementCd.Trim() : exist.AchievementCd,
                            ApplicantId = exist.ApplicantId,
                            ApplicantSportAssocId = exist.ApplicantSportAssocId,
                            CreatedBy = exist.CreatedBy,
                            CreatedDt = exist.CreatedDt,
                            LastModifiedBy = exist.LastModifiedBy,
                            LastModifiedDt = exist.LastModifiedDt,
                            Others = exist.Others,
                            Year = exist.Year,
                            SportAssocId = exist.SportAssocId,
                        };

                        if (exist.SportAssocId.HasValue && exist.tblREFSportAndAssociation != null)
                        {
                            apps.SportAndAssociation = new SportAndAssociation()
                            {
                                ActiveInd = exist.tblREFSportAndAssociation.ActiveInd,
                                CreatedBy = exist.tblREFSportAndAssociation.CreatedBy,
                                CreatedDt = exist.tblREFSportAndAssociation.CreatedDt,
                                LastModifiedBy = exist.tblREFSportAndAssociation.LastModifiedBy,
                                LastModifiedDt = exist.tblREFSportAndAssociation.LastModifiedDt,
                                SportAssocId = exist.tblREFSportAndAssociation.SportAssocId,
                                SportAssociatName = exist.tblREFSportAndAssociation.SportAssociatName,
                                SportAssociatType = exist.tblREFSportAndAssociation.SportAssociatType
                            };
                        }

                        return apps;
                    }
                }
            }
            return null;
        }

        public bool DeleteApplicantSport(int applicantsportid)
        {
            if (applicantsportid != 0)
            {
                using (var entities = new atmEntities())
                {
                    var exist = (from a in entities.tblApplicantSportAssocs where a.ApplicantSportAssocId == applicantsportid select a).SingleOrDefault();
                    if (null != exist)
                    {
                        entities.tblApplicantSportAssocs.Remove(exist);
                        return entities.SaveChanges() > 0;
                    }
                }
            }
            return false;
        }


        public IEnumerable<Applicant> ExecuteQuery(string sql)
        {
            var list = new List<Applicant>();
            if (!string.IsNullOrWhiteSpace(sql))
            {
                using (var entities = new atmEntities())
                {
                    var l = entities.tblApplicants.SqlQuery(sql).ToList();
                    if (l.Any())
                    {
                        list.AddRange(l.Select(BindingToClass));
                    }
                }
            }
            return list;
        }
    }
}
