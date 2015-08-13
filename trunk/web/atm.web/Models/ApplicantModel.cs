using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Ajax.Utilities;
using NHibernate.Mapping;
using NHibernate.Util;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Atm.Web.Models
{
    public class ApplicantModel
    {
        public ApplicantModel()
        {

        }

        public ApplicantModel(Applicant app, int acquisitionid)
        {
            ApplicantId = app.ApplicantId;
            NewIcNo = app.NewICNo;
            NoTentera = app.NoTentera;
            FullName = app.FullName;
            MrtlStatusCd = app.MrtlStatusCd;
            GenderCd = app.GenderCd;
            Height = app.Height;
            Weight = app.Weight;
            Bmi = app.BMI;
            NationalityCd = app.NationalityCd;
            NationalityCertNo = app.NationalityCertNo;
            BirthCertNo = app.BirthCertNo;
            ReligionCd = app.ReligionCd;
            RaceCd = app.RaceCd;
            EthnicCd = !string.IsNullOrWhiteSpace(app.EthnicCd) ? app.EthnicCd.Trim() : app.EthnicCd;
            BirthCountryCd = app.BirthCountryCd;
            BirthStateCd = app.BirthStateCd;
            BirthCityCd = !string.IsNullOrWhiteSpace(app.BirthCityCd) ? app.BirthCityCd.Trim() : app.BirthCityCd;
            BirthPlace = app.BirthPlace;
            BloodTypeCd = app.BloodTypeCd;
            SpectaclesUserInd = app.SpectaclesUserInd;
            ColorBlindInd = app.ColorBlindInd;
            ResidenceTypeInd = app.ResidenceTypeInd;
            CorresponAddr1 = app.CorresponAddr1;
            CorresponAddr2 = app.CorresponAddr2;
            CorresponAddr3 = app.CorresponAddr3;
            CorresponAddrPostCd = app.CorresponAddrPostCd;
            CorresponAddrCityCd = !string.IsNullOrWhiteSpace(app.CorresponAddrCityCd) ? app.CorresponAddrCityCd.Trim() : app.CorresponAddrCityCd;
            CorresponAddrStateCd = app.CorresponAddrStateCd;
            CorresponAddrCountryCd = app.CorresponAddrCountryCd;
            MobilePhoneNo = app.MobilePhoneNo;
            HomePhoneNo = app.HomePhoneNo;
            Email = app.Email;
            ChildNo = app.ChildNo;
            NoOfSibling = app.NoOfSibling;
            MomName = app.MomName;
            MomIcNo = app.MomICNo;
            MomNationalityCd = app.MomNationalityCd;
            MomOccupation = app.MomOccupation;
            MomSalary = app.MomSalary;
            MomPhoneNo = app.MomPhoneNo;
            DadName = app.DadName;
            DadIcNo = app.DadICNo;
            DadNationalityCd = app.DadNationalityCd;
            DadOccupation = app.DadOccupation;
            DadSalary = app.DadSalary;
            DadPhoneNo = app.DadPhoneNo;
            GuardianName = app.GuardianName;
            GuardianIcNo = app.GuardianICNo;
            GuardianNationalityCd = app.GuardianNationalityCd;
            GuardianOccupation = app.GuardianOccupation;
            GuardianSalary = app.GuardianSalary;
            GuardianPhoneNo = app.GuardianPhoneNo;
            FamilyHighestEduLevel = app.FamilyHighestEduLevel;
            CurrentOccupation = app.CurrentOccupation;
            CurrentOrganisation = app.CurrentOrganisation;
            CurrentSalary = app.CurrentSalary;
            PalapesInd = app.PalapesInd ?? false;
            PalapesYear = app.PalapesYear;
            PalapesArmyNo = app.PalapesArmyNo;
            PalapesInstitution = app.PalapesInstitution;
            PalapesRemark = app.PalapesRemark;
            PalapesTauliahEndDt = app.PalapesTauliahEndDt;
            ScholarshipInd = app.ScholarshipInd ?? false;
            ScholarshipBody = app.ScholarshipBody;
            ScholarshipBodyAddr = app.ScholarshipBodyAddr;
            ScholarshipNoOfYrContract = app.ScholarshipNoOfYrContract;
            ArmySelectionInd = app.ArmySelectionInd ?? false;
            ArmySelectionVenue = app.ArmySelectionVenue;
            ArmyServiceInd = app.ArmyServiceInd ?? false;
            ArmyServiceYrOfServ = app.ArmyServiceYrOfServ;
            ArmyServiceResignRemark = app.ArmyServiceResignRemark;
            SelectionTD = app.SelectionTD;
            SelectionTL = app.SelectionTL;
            SelectionTU = app.SelectionTU;
            ComputerMSWord = app.ComputerMSWord;
            ComputerMSExcel = app.ComputerMSExcel;
            ComputerMSPwrPoint = app.ComputerMSPwrPoint;
            ComputerICT = app.ComputerICT;
            ComputerOthers = app.ComputerOthers;
            CrimeInvolvement = app.CrimeInvolvement ?? false;
            DrugCaseInvolvement = app.DrugCaseInvolvement ?? false;
            CreatedBy = app.CreatedBy;
            LastModifiedBy = app.LastModifiedBy;
            CreatedDateTime = app.CreatedDt;
            LastModifiedDatetTime = app.LastModifiedDt;
            BirthDate = app.BirthDt;
            EmployeeAggreeInd = app.EmployeeAggreeInd ?? false;
            CronicIlnessInd = app.CronicIlnessInd ?? false;
            ScholarshipContractStDate = app.ScholarshipContractStDate;
            OriginalPelepasanDocument = app.OriginalPelepasanDocument;
            PelepasanDocument = app.PelepasanDocument;
            ArmySelectionDt = app.ArmySelectionDt;
            MomNotApplicable = app.MomNotApplicable ?? false;
            DadNotApplicable = app.DadNotApplicable ?? false;
            GuardianNotApplicable = app.GuardianNotApplicable ?? false;

            if (!string.IsNullOrWhiteSpace(NewIcNo))
            {
                var lastid = NewIcNo.Substring(NewIcNo.Length - 1);
                var checkgend = 0;
                int.TryParse(lastid, out checkgend);
                var even = new List<int>() { 0, 2, 4, 6, 8 };
                var odd = new List<int>() { 1, 3, 5, 7, 9 };
                if (string.IsNullOrWhiteSpace(app.GenderCd))
                {
                    if (even.Contains(checkgend)) GenderCd = "P";
                    if (odd.Contains(checkgend)) GenderCd = "L";
                }
            }

            if (string.IsNullOrWhiteSpace(app.NationalityCd))
                NationalityCd = "MYS";
            if (string.IsNullOrWhiteSpace(app.DadNationalityCd))
                DadNationalityCd = "MYS";
            if (string.IsNullOrWhiteSpace(app.MomNationalityCd))
                MomNationalityCd = "MYS";
            if (string.IsNullOrWhiteSpace(app.GuardianNationalityCd))
                GuardianNationalityCd = "MYS";
            if (string.IsNullOrWhiteSpace(BirthCountryCd))
                BirthCountryCd = "MYS";
            if (string.IsNullOrWhiteSpace(app.CorresponAddrCountryCd))
                CorresponAddrCountryCd = "MYS";

            if (string.IsNullOrWhiteSpace(BirthStateCd))
            {
                if (!string.IsNullOrWhiteSpace(NewIcNo))
                {
                    NewIcNo = NewIcNo.Trim();
                    if (NewIcNo.Length == 12)
                    {
                        var icbirthstatecode = NewIcNo.Substring(6, 2);
                        var birthstatecode = ObjectBuilder.GetObject<IReferencePersistence>("ReferencePersistence").GetStatesByBirthStateCode(icbirthstatecode);
                        if (null != birthstatecode)
                            BirthStateCd = birthstatecode.StateCd;
                    }
                }
            }

            if (!string.IsNullOrWhiteSpace(NewIcNo))
            {
                var yearstr = NewIcNo.Substring(0, 2);
                var monthstr = NewIcNo.Substring(2, 2);
                var daystr = NewIcNo.Substring(4, 2);
                var yearint = Convert.ToInt32(yearstr);
                if (yearint == 0) yearint = 2000;
                if (yearint < 10) yearint = 2000 + yearint;
                if (yearint > 10) yearint = 1900 + yearint;
                var bdate = new DateTime(yearint, Convert.ToInt16(monthstr), Convert.ToInt16(daystr));
                BirthDate = bdate;
                DateTime zeroTime = DateTime.Now;
                var daterange = DateTime.Now - bdate;
                int years = (zeroTime + daterange).Year - 1;
                DateTime today = DateTime.Today;
                int months = zeroTime.Month - bdate.Month;

                Age = zeroTime.Year - bdate.Year;
                Month = months;
            }

            if (ApplicantId != 0)
            {
                // get educations
                var education = ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").GetEducation(ApplicantId);
                if (null != education && education.Any())
                {
                    ApplicantEducations.Clear();
                    ApplicantEducations.AddRange(education.ToList());
                }

                // get skills
                var skills = ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").GetSkill(ApplicantId);
                if (null != skills && skills.Any())
                {
                    Skills.AddRange(skills.ToList());

                    if (Skills.Count <= 2)
                        Skills.Add(new ApplicantSkill() { SkillCd = "", SkillCatCd = "L", Skill = "" });
                }


                // get sports
                var sports = ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").GetSport(ApplicantId);
                if (null != sports && sports.Any())
                {
                    Sports.AddRange(sports.Where(a => a.SportAndAssociation != null && a.SportAndAssociation.SportAssociatType == "S").ToList().DistinctBy(a => a.SportAssocId));
                    Kokos.AddRange(sports.Where(a => a.SportAndAssociation != null && a.SportAndAssociation.SportAssociatType == "A").ToList().DistinctBy(a => a.SportAssocId));
                    Others.AddRange(sports.Where(a => !string.IsNullOrWhiteSpace(a.Others)));
                }
            }

            if (!string.IsNullOrWhiteSpace(app.ComputerOthers))
                ComputerOthersInd = true;

            if (acquisitionid != 0)
            {
                var acq = ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetAcquisition(acquisitionid);
                if (acq != null && acq.AcquisitionTypeCd != 0)
                {
                    var selectededucation = new string[] { };
                    var refrepos = new ReferenceRepo();
                    //var acqtype = ObjectBuilder.GetObject<IReferencePersistence>("ReferencePersistence").GetAcquisitionType(acq.AcquisitionTypeCd);
                    if (null != acq.AcquisitionType)
                    {
                        // pegawai
                        if (acq.AcquisitionType.ServiceCd == "10")
                            selectededucation = new string[] { "14", "13", "25", "11", "08", "20" };
                        // td
                        if (acq.AcquisitionType.ServiceCd == "01")
                            selectededucation = new string[] { "14", "13", "25", "26", "11" };
                        // tl
                        if (acq.AcquisitionType.ServiceCd == "02")
                            selectededucation = new string[] { "14", "13", "25", "15", "26", "11" };
                        // tu
                        if (acq.AcquisitionType.ServiceCd == "03")
                            selectededucation = new string[] { "14", "13", "25", "26", "08", "11" };

                        var he = refrepos.GetHighEduLevels().Where(a => selectededucation.Contains(a.HighEduLevelCd));
                        if (he.Any())
                        {
                            he = he.OrderBy(a => a.IndexNo);
                            if (ApplicantEducations != null && ApplicantEducations.Any())
                            {
                                var ledu = new List<ApplicantEducation>();
                                ledu.AddRange(ApplicantEducations);
                                foreach (var ed in ledu.ToList())
                                {
                                    if (ed.HighEduLevelCd == "14")
                                    {
                                        var selectedsubject = ed.ApplicantEduSubjectCollection.ToList().RemoveAll(a => !string.IsNullOrEmpty(a.GradeCd));
                                        var subjects = refrepos.GetSubjects(ed.HighEduLevelCd);
                                        if (subjects.Any())
                                        {
                                            foreach (var s in subjects.Take(10))
                                            {
                                                // check already exist or not in subjects
                                                if (ed.ApplicantEduId != 0)
                                                {
                                                    var subbs = ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").GetSubject(ed.ApplicantEduId, s.SubjectCd);
                                                    if (null != subbs)
                                                    {
                                                        if (ed.ApplicantEduSubjectCollection.All(a => a.SubjectCd != subbs.SubjectCd))
                                                            ed.ApplicantEduSubjectCollection.Add(new ApplicantEduSubject() { SubjectCd = subbs.SubjectCd, Subject = subbs.Subject });
                                                    }
                                                    else
                                                    {
                                                        if (!ed.ApplicantEduSubjectCollection.Any(a => subbs != null && a.SubjectCd == subbs.SubjectCd))
                                                            ed.ApplicantEduSubjectCollection.Add(new ApplicantEduSubject() { SubjectCd = s.SubjectCd, Subject = s.SubjectDescription });
                                                    }
                                                }
                                                else
                                                {
                                                    if (ed.ApplicantEduSubjectCollection.All(a => a.SubjectCd != s.SubjectCd))
                                                        ed.ApplicantEduSubjectCollection.Add(new ApplicantEduSubject() { SubjectCd = s.SubjectCd, Subject = s.SubjectDescription });
                                                }

                                            }
                                        }

                                        var totalsubject = 16 - ed.ApplicantEduSubjectCollection.Count();
                                        for (int i = 0; i < totalsubject; i++)
                                        {
                                            ed.ApplicantEduSubjectCollection.Add(new ApplicantEduSubject());
                                        }
                                    }
                                    foreach (var h in he)
                                    {
                                        if (ledu.All(a => a.HighEduLevelCd != h.HighEduLevelCd))
                                        {
                                            var edu = new ApplicantEducation() { HighEduLevelCd = h.HighEduLevelCd, HighEduLevel = h.HighestEduLevel };

                                            if (h.HighEduLevelCd == "14")
                                            {
                                                var subjects = refrepos.GetSubjects(h.HighEduLevelCd);
                                                if (subjects.Any())
                                                    foreach (var s in subjects.Take(10))
                                                        edu.ApplicantEduSubjectCollection.Add(new ApplicantEduSubject() { SubjectCd = s.SubjectCd, Subject = s.SubjectDescription });

                                                var totalsubject = 16 - ed.ApplicantEduSubjectCollection.Count();
                                                for (int i = 0; i < totalsubject; i++)
                                                {
                                                    edu.ApplicantEduSubjectCollection.Add(new ApplicantEduSubject());
                                                }
                                            }

                                            ledu.Add(edu);
                                        }
                                    }
                                }
                                ApplicantEducations.Clear();
                                ApplicantEducations.AddRange(ledu.DistinctBy(a => a.HighEduLevelCd));
                            }
                            else
                            {
                                foreach (var h in he)
                                {
                                    var edu = new ApplicantEducation() { HighEduLevelCd = h.HighEduLevelCd, HighEduLevel = h.HighestEduLevel };
                                    if (h.HighEduLevelCd == "14")
                                    {
                                        var subjects = refrepos.GetSubjects(h.HighEduLevelCd);
                                        if (subjects.Any())
                                            foreach (var s in subjects.Take(10))
                                                edu.ApplicantEduSubjectCollection.Add(new ApplicantEduSubject() { SubjectCd = s.SubjectCd, Subject = s.SubjectDescription });

                                        for (int i = 0; i < 6; i++)
                                        {
                                            edu.ApplicantEduSubjectCollection.Add(new ApplicantEduSubject());
                                        }
                                    }
                                    ApplicantEducations.Add(edu);
                                }
                            }
                        }

                        var scount = 0;
                        var kcount = 0;
                        if (Sports != null)
                        {
                            scount = Sports.Count();
                            if (scount == 0)
                                scount = 2;
                            else if (scount == 1)
                                scount = 1;
                            else
                                scount = 0;
                            for (int i = 0; i < scount; i++)
                            {
                                Sports.Add(new ApplicantSport());
                            }

                            kcount = Kokos.Count();
                            if (kcount == 0)
                                kcount = 2;
                            else if (kcount == 1)
                                kcount = 1;
                            else
                                kcount = 0;
                            for (int i = 0; i < kcount; i++)
                            {
                                Kokos.Add(new ApplicantSport());
                            }
                        }

                        var skills = ObjectBuilder.GetObject<IReferencePersistence>("ReferencePersistence").GetSkills("L");
                        if (skills != null && skills.Any())
                        {
                            skills = skills.Take(2);
                            foreach (var s in skills)
                            {
                                if (!Skills.Any(a => a.SkillCd.Trim() == s.SkillCd.Trim()))
                                    Skills.Add(new ApplicantSkill() { SkillCd = s.SkillCd.Trim(), SkillCatCd = "L", Skill = s.SkillDescription.Trim() });
                            }
                            if (Skills.Count <= 2)
                                Skills.Add(new ApplicantSkill() { SkillCd = "", SkillCatCd = "L", Skill = "" });
                        }

                        if (Others.Count() == 0)
                        {
                            for (int i = 0; i < 2; i++)
                            {
                                Others.Add(new ApplicantSport());
                            }
                        }
                        else if (Others.Count() == 1)
                        {
                            Others.Add(new ApplicantSport());
                        }
                    }
                }
            }
        }

        public int ApplicantId { get; set; }
        public string NewIcNo { get; set; }
        public string NoTentera { get; set; }
        public string FullName { get; set; }
        public string MrtlStatusCd { get; set; }
        public string GenderCd { get; set; }
        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Bmi { get; set; }
        public string NationalityCd { get; set; }
        public string NationalityCertNo { get; set; }
        public string BirthCertNo { get; set; }
        public string ReligionCd { get; set; }
        public string RaceCd { get; set; }
        public string EthnicCd { get; set; }
        public string BirthCountryCd { get; set; }
        public string BirthStateCd { get; set; }
        public string BirthCityCd { get; set; }
        public string BirthPlace { get; set; }
        public string BloodTypeCd { get; set; }
        public bool? SpectaclesUserInd { get; set; }
        public bool? ColorBlindInd { get; set; }
        public string ResidenceTypeInd { get; set; }
        public string CorresponAddr1 { get; set; }
        public string CorresponAddr2 { get; set; }
        public string CorresponAddr3 { get; set; }
        public string CorresponAddrPostCd { get; set; }
        public string CorresponAddrCityCd { get; set; }
        public string CorresponAddrStateCd { get; set; }
        public string CorresponAddrCountryCd { get; set; }
        public string MobilePhoneNo { get; set; }
        public string HomePhoneNo { get; set; }
        public string Email { get; set; }
        public int? ChildNo { get; set; }
        public int? NoOfSibling { get; set; }
        public string MomName { get; set; }
        public string MomIcNo { get; set; }
        public string MomNationalityCd { get; set; }
        public string MomOccupation { get; set; }
        public decimal? MomSalary { get; set; }
        public string MomPhoneNo { get; set; }
        public string DadName { get; set; }
        public string DadIcNo { get; set; }
        public string DadNationalityCd { get; set; }
        public string DadOccupation { get; set; }
        public decimal? DadSalary { get; set; }
        public string DadPhoneNo { get; set; }
        public string GuardianName { get; set; }
        public string GuardianIcNo { get; set; }
        public string GuardianNationalityCd { get; set; }
        public string GuardianOccupation { get; set; }
        public decimal? GuardianSalary { get; set; }
        public string GuardianPhoneNo { get; set; }
        public string FamilyHighestEduLevel { get; set; }
        public string CurrentOccupation { get; set; }
        public string CurrentOrganisation { get; set; }
        public decimal? CurrentSalary { get; set; }
        public bool? PalapesInd { get; set; }
        public int? PalapesYear { get; set; }
        public string PalapesArmyNo { get; set; }
        public string PalapesInstitution { get; set; }
        public string PalapesRemark { get; set; }
        public string PalapesServices { get; set; }
        public DateTime? PalapesTauliahEndDt { get; set; }
        public bool ScholarshipInd { get; set; }
        public string ScholarshipBody { get; set; }
        public string ScholarshipBodyAddr { get; set; }
        public string ScholarshipNoOfYrContract { get; set; }
        public bool ArmySelectionInd { get; set; }
        public string ArmySelectionVenue { get; set; }
        public bool ArmyServiceInd { get; set; }
        public string ArmyServiceYrOfServ { get; set; }
        public string ArmyServiceResignRemark { get; set; }
        public int? SelectionTD { get; set; }
        public int? SelectionTL { get; set; }
        public int? SelectionTU { get; set; }
        public bool? ComputerMSWord { get; set; }
        public bool? ComputerMSExcel { get; set; }
        public bool? ComputerMSPwrPoint { get; set; }
        public bool? ComputerICT { get; set; }
        public bool? ComputerOthersInd { get; set; }
        public string ComputerOthers { get; set; }
        public bool CrimeInvolvement { get; set; }
        public bool DrugCaseInvolvement { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public DateTime? LastModifiedDatetTime { get; set; }
        public DateTime? BirthDate { get; set; }
        public int Age { get; set; }
        public int Month { get; set; }
        public bool EmployeeAggreeInd { get; set; }
        public bool CronicIlnessInd { get; set; }
        public DateTime? ScholarshipContractStDate { get; set; }
        public DateTime? ArmySelectionDt { get; set; }
        public string PelepasanDocument { get; set; }
        public string OriginalPelepasanDocument { get; set; }
        public bool IsAgreeInd { get; set; }
        public bool MomNotApplicable { get; set; }
        public bool DadNotApplicable { get; set; }
        public bool GuardianNotApplicable { get; set; }

        private List<ApplicantEducation> m_applicantEducationCollection = new List<ApplicantEducation>();
        private List<ApplicantSport> m_applicantSportAndAssociations = new List<ApplicantSport>();
        private List<ApplicantSport> m_sports = new List<ApplicantSport>();
        private List<ApplicantSport> m_kokos = new List<ApplicantSport>();
        private List<ApplicantSkill> m_skills = new List<ApplicantSkill>();
        private List<ApplicantSport> m_others = new List<ApplicantSport>();

        public List<ApplicantSport> Others
        {
            get { return m_others; }
            set { m_others = value; }
        }


        public List<ApplicantSkill> Skills
        {
            get { return m_skills; }
            set { m_skills = value; }
        }


        public List<ApplicantSport> Kokos
        {
            get { return m_kokos; }
            set { m_kokos = value; }
        }


        public List<ApplicantSport> Sports
        {
            get { return m_sports; }
            set { m_sports = value; }
        }


        public List<ApplicantSport> ApplicantSportAndAssociations
        {
            get { return m_applicantSportAndAssociations; }
            set { m_applicantSportAndAssociations = value; }
        }

        public List<ApplicantEducation> ApplicantEducations
        {
            get { return m_applicantEducationCollection; }
            set { m_applicantEducationCollection = value; }
        }


    }
}