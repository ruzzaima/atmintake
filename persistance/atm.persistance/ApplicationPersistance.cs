using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Atm.Entity.Persistance
{
    class ApplicationPersistance : IApplicationPersistance
    {
        public int AddNew(Application application)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblApplications where a.ApplicantId == application.ApplicantId && a.AcquisitionId == application.AcquisitionId select a).SingleOrDefault();
                if (null != exist)
                {
                    application.AppId = exist.AppId;
                    return Update(application);
                }

                var app = new tblApplication
                {
                    AcquisitionId = application.AcquisitionId,
                    ApplicantId = application.ApplicantId,
                    ApplicationStatus = application.ApplicationStatus,
                    ArmyNo = application.ArmyNo,
                    CreatedBy = application.CreatedBy,
                    CreatedDt = DateTime.Now,
                    DentalExamine = application.DentalExamine,
                    FinalSelectionInd = application.FinalSelectionInd,
                    FinalSelectionRemark = application.FinalSelectionRemark,
                    FinalShortlistedInd = application.FinalShortlistedInd,
                    FirstSelActualAcqLocationId = application.FirstSelActualAcqLocationId,
                    FirstSelectionAttdnInd = application.FirstSelectionAttdnInd,
                    FirstSelectionDate = application.FirstSelectionDate,
                    FirstSelectionInd = application.FirstSelectionInd,
                    FirstShortlistedInd = application.FirstShortlistedInd,
                    InvitationFirstSel = application.InvitationFirstSel,
                    MedicalExamine = application.MedicalExamine,
                    Panel1Score = application.Panel1Score,
                    Panel2Score = application.Panel2Score,
                    Panel3Score = application.Panel3Score,
                    PhysicalExamination = application.PhysicalExamination,
                    PhysicalTest = application.PhysicalTest,
                    ReportDuty = application.ReportDuty,
                    SecurityAADK = application.SecurityAADK,
                    SecurityAADKRemark = application.SecurityAADKRemark,
                    SecurityBSPP = application.SecurityBSPP,
                    SecurityBSPPRemark = application.SecurityBSPPRemark,
                    SecurityJPN = application.SecurityJPN,
                    SecurityJPNRemark = application.SecurityJPNRemark,
                    SecurityKPM = application.SecurityKPM,
                    SecurityKPMRemark = application.SecurityKPMRemark,
                    SecurityPDRM = application.SecurityPDRM,
                    SecurityPDRMRemark = application.SecurityPDRMRemark,
                    SecurityStatus = application.SecurityStatus,
                    SelectedAcqLocationId = application.SelectedAcqLocationId,
                    SelectionCenterId = application.SelectionCenterId,
                    SuppDocumentReview = application.SuppDocumentReview,
                    Urine = application.Urine,
                    WrittenTest = application.WrittenTest,
                    FinalSelActualAcqLocationId = application.FinalSelActualAcqLocationId,
                    FinalSelectionEndDate = application.FinalSelectionEndDate,
                    FinalSelectionStartDate = application.FinalSelectionStartDate,
                    FinalServiceCd = application.FinalServiceCd,
                    FirstSelectionEndDate = application.FirstSelectionEndDate,
                    NoKawalan = application.NoKawalan,
                    ReportDutyDate = application.ReportDutyDate,
                    ReportDutyLocId = application.ReportDutyLocId,

                };
                entities.tblApplications.Add(app);
                if (entities.SaveChanges() > 0) return app.AppId;
            }
            return 0;
        }

        public int Update(Application application)
        {
            if (application.AppId != 0)
            {
                using (var entities = new atmEntities())
                {
                    var exist = (from a in entities.tblApplications where a.AppId == application.AppId select a).SingleOrDefault();
                    if (null != exist)
                    {
                        exist.ApplicationStatus = application.ApplicationStatus;
                        exist.ArmyNo = application.ArmyNo;
                        exist.LastModifiedBy = application.CreatedBy;
                        exist.LastModifiedDt = DateTime.Now;
                        exist.DentalExamine = application.DentalExamine;
                        exist.FinalSelectionInd = application.FinalSelectionInd;
                        exist.FinalSelectionRemark = application.FinalSelectionRemark;
                        exist.FinalShortlistedInd = application.FinalShortlistedInd;
                        exist.FirstSelActualAcqLocationId = application.FirstSelActualAcqLocationId;
                        exist.FirstSelectionAttdnInd = application.FirstSelectionAttdnInd;
                        exist.FirstSelectionDate = application.FirstSelectionDate;
                        exist.FirstSelectionInd = application.FirstSelectionInd;
                        exist.FirstShortlistedInd = application.FirstShortlistedInd;
                        exist.InvitationFirstSel = application.InvitationFirstSel;
                        exist.MedicalExamine = application.MedicalExamine;
                        exist.Panel1Score = application.Panel1Score;
                        exist.Panel2Score = application.Panel2Score;
                        exist.Panel3Score = application.Panel3Score;
                        exist.PhysicalExamination = application.PhysicalExamination;
                        exist.PhysicalTest = application.PhysicalTest;
                        exist.ReportDuty = application.ReportDuty;
                        exist.SecurityAADK = application.SecurityAADK;
                        exist.SecurityAADKRemark = application.SecurityAADKRemark;
                        exist.SecurityBSPP = application.SecurityBSPP;
                        exist.SecurityBSPPRemark = application.SecurityBSPPRemark;
                        exist.SecurityJPN = application.SecurityJPN;
                        exist.SecurityJPNRemark = application.SecurityJPNRemark;
                        exist.SecurityKPM = application.SecurityKPM;
                        exist.SecurityKPMRemark = application.SecurityKPMRemark;
                        exist.SecurityPDRM = application.SecurityPDRM;
                        exist.SecurityPDRMRemark = application.SecurityPDRMRemark;
                        exist.SecurityStatus = application.SecurityStatus;
                        exist.SelectedAcqLocationId = application.SelectedAcqLocationId;
                        exist.SelectionCenterId = application.SelectionCenterId;
                        exist.SuppDocumentReview = application.SuppDocumentReview;
                        exist.Urine = application.Urine;
                        exist.WrittenTest = application.WrittenTest;
                        exist.NoKawalan = application.NoKawalan;
                        exist.FinalSelActualAcqLocationId = application.FinalSelActualAcqLocationId;
                        exist.FinalSelectionEndDate = application.FinalSelectionEndDate;
                        exist.FinalSelectionStartDate = application.FinalSelectionStartDate;
                        exist.FinalServiceCd = application.FinalServiceCd;
                        exist.FirstSelectionEndDate = application.FirstSelectionEndDate;
                        exist.ReportDutyDate = application.ReportDutyDate;
                        exist.ReportDutyLocId = application.ReportDutyLocId;

                        entities.SaveChanges();
                        return exist.AppId;
                    }
                }
            }
            return 0;
        }

        public Application GetById(int id)
        {
            if (id != 0)
            {
                using (var entities = new atmEntities())
                {
                    var exist = (from a in entities.tblApplications where a.AppId == id select a).SingleOrDefault();
                    if (null != exist)
                    {
                        return BindingToClass(exist);
                    }
                }
            }
            return null;
        }

        private static Application BindingToClass(tblApplication exist)
        {
            var app = new Application
            {
                AppId = exist.AppId,
                AcquisitionId = exist.AcquisitionId ?? 0,
                ApplicantId = exist.ApplicantId ?? 0,
                ApplicationStatus = exist.ApplicationStatus,
                ArmyNo = exist.ArmyNo,
                CreatedBy = exist.CreatedBy,
                CreatedDt = exist.CreatedDt,
                LastModifiedBy = exist.LastModifiedBy,
                LastModifiedDt = exist.LastModifiedDt,
                DentalExamine = exist.DentalExamine,
                FinalSelectionInd = exist.FinalSelectionInd,
                FinalSelectionRemark = exist.FinalSelectionRemark,
                FinalShortlistedInd = exist.FinalShortlistedInd,
                FirstSelActualAcqLocationId = exist.FirstSelActualAcqLocationId,
                FirstSelectionAttdnInd = exist.FirstSelectionAttdnInd,
                FirstSelectionDate = exist.FirstSelectionDate,
                FirstSelectionInd = exist.FirstSelectionInd,
                FirstShortlistedInd = exist.FirstShortlistedInd,
                InvitationFirstSel = exist.InvitationFirstSel,
                MedicalExamine = exist.MedicalExamine,
                Panel1Score = exist.Panel1Score,
                Panel2Score = exist.Panel2Score,
                Panel3Score = exist.Panel3Score,
                PhysicalExamination = exist.PhysicalExamination,
                PhysicalTest = exist.PhysicalTest,
                ReportDuty = exist.ReportDuty,
                SecurityAADK = exist.SecurityAADK,
                SecurityAADKRemark = exist.SecurityAADKRemark,
                SecurityBSPP = exist.SecurityBSPP,
                SecurityBSPPRemark = exist.SecurityBSPPRemark,
                SecurityJPN = exist.SecurityJPN,
                SecurityJPNRemark = exist.SecurityJPNRemark,
                SecurityKPM = exist.SecurityKPM,
                SecurityKPMRemark = exist.SecurityKPMRemark,
                SecurityPDRM = exist.SecurityPDRM,
                SecurityPDRMRemark = exist.SecurityPDRMRemark,
                SecurityStatus = exist.SecurityStatus,
                SelectedAcqLocationId = exist.SelectedAcqLocationId,
                SelectionCenterId = exist.SelectionCenterId,
                SuppDocumentReview = exist.SuppDocumentReview,
                Urine = exist.Urine,
                WrittenTest = exist.WrittenTest,
                ReportDutyLocId = exist.ReportDutyLocId,
                ReportDutyDate = exist.ReportDutyDate,
                FinalSelectionEndDate = exist.FinalSelectionEndDate,
                FinalSelectionStartDate = exist.FinalSelectionStartDate,
                FinalSelActualAcqLocationId = exist.FinalSelActualAcqLocationId,
                NoKawalan = exist.NoKawalan,
                FinalServiceCd = exist.FinalServiceCd,
                FirstSelectionEndDate = exist.FirstSelectionEndDate,
            };

            if (exist.AcquisitionId.HasValue)
                app.Acquisition =
                    ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence")
                        .GetAcquisition(exist.AcquisitionId.Value);

            if (exist.ApplicantId.HasValue && exist.AcquisitionId.HasValue)
                app.ApplicantSubmitted =
                    ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence")
                        .GetApplicant(exist.ApplicantId.Value, exist.AcquisitionId.Value);

            if (exist.ReportDutyLocId.HasValue)
                if (exist.tblREFReportDutyLoc != null)
                    app.ReportDutyLocation = new Location()
                    {
                        LocationId = exist.tblREFReportDutyLoc.ReportDutyLocId,
                        LocationNm = exist.tblREFReportDutyLoc.ReportDutyLoc
                    };

            if (exist.FinalSelActualAcqLocationId.HasValue)
                app.FinalSelectionLocation = ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetLocation(exist.FinalSelActualAcqLocationId.Value);

            if (exist.FirstSelActualAcqLocationId.HasValue)
                app.FirstSelectionLocation = ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetLocation(exist.FirstSelActualAcqLocationId.Value);

            return app;
        }

        public Application GetByApplicantIdAndAcquisitionId(int applicantid, int acquisitionid)
        {
            if (applicantid != 0 && acquisitionid != 0)
            {
                using (var entities = new atmEntities())
                {
                    var exist = (from a in entities.tblApplications where a.ApplicantId == applicantid && a.AcquisitionId == acquisitionid select a).OrderByDescending(a => a.CreatedDt).FirstOrDefault();
                    if (null != exist)
                    {
                        return BindingToClass(exist);
                    }
                }
            }
            return null;
        }

        public IEnumerable<Application> GetAllByApplicantId(int applicantid)
        {
            var list = new List<Application>();
            if (applicantid != 0)
            {
                using (var entities = new atmEntities())
                {
                    var l = from a in entities.tblApplications where a.ApplicantId == applicantid select a;
                    if (l.Any())
                    {
                        foreach (var app in l)
                            list.Add(BindingToClass(app));
                    }
                }
            }
            return list;
        }

        public IEnumerable<Application> GetAllByApplicantIdNumber(string idnumber)
        {
            var list = new List<Application>();
            if (!string.IsNullOrWhiteSpace(idnumber))
            {
                using (var entities = new atmEntities())
                {
                    var l = from a in entities.tblApplications join b in entities.tblApplicantSubmiteds on a.ApplicantId equals b.ApplicantId where b.NewICNo == idnumber select a;
                    if (l.Any())
                    {
                        foreach (var app in l)
                            list.Add(BindingToClass(app));
                    }
                }
            }
            return list;
        }

        public bool IsSubmitted(int applicantid, int acquisitionid, out int applicationid)
        {
            if (applicantid != 0 && acquisitionid != 0)
            {
                using (var entities = new atmEntities())
                {
                    var exist = (from a in entities.tblApplications where a.ApplicantId == applicantid && a.AcquisitionId == acquisitionid select a).SingleOrDefault();
                    if (null != exist)
                    {
                        applicationid = exist.AppId;
                        return true;
                    }
                }
            }
            applicationid = 0;
            return false;
        }

        public bool IsSubmitted(string icno, int acquisitionid, out int applicationid)
        {
            if (!string.IsNullOrWhiteSpace(icno) && acquisitionid != 0)
            {
                using (var entities = new atmEntities())
                {
                    var exist = (from a in entities.tblApplications join b in entities.tblApplicantSubmiteds on a.ApplicantId equals b.ApplicantId where b.NewICNo == icno && a.AcquisitionId == acquisitionid select a).SingleOrDefault();
                    if (null != exist)
                    {
                        applicationid = exist.AppId;
                        return true;
                    }
                }
            }
            applicationid = 0;
            return false;
        }

        public int UpdateStatus(int acquisitionid, int applicantid, bool? firstinvitation, bool? firstselection, bool? finalselection, bool? lastselection, string modifiedby)
        {
            if (acquisitionid != 0 && applicantid != 0)
            {
                using (var entities = new atmEntities())
                {
                    var application = (from a in entities.tblApplications where a.AcquisitionId == acquisitionid && a.ApplicantId == applicantid select a).OrderByDescending(a => a.CreatedDt).FirstOrDefault();
                    if (null != application)
                    {
                        application.InvitationFirstSel = firstinvitation;
                        application.FirstSelectionInd = firstselection;
                        application.FinalSelectionInd = finalselection;
                        application.ApplicationStatus = lastselection;

                        application.LastModifiedDt = DateTime.Now;
                        application.LastModifiedBy = modifiedby;
                        var upd = entities.SaveChanges();

                        return application.AppId;
                    }
                }
            }
            return 0;
        }


        public int UpdateFirstInvitationStatus(int acquisitionid, int applicantid, bool? firstinvitation, string modifiedby)
        {
            if (acquisitionid != 0 && applicantid != 0)
            {
                using (var entities = new atmEntities())
                {
                    var application = (from a in entities.tblApplications where a.AcquisitionId == acquisitionid && a.ApplicantId == applicantid select a).OrderByDescending(a => a.CreatedDt).FirstOrDefault();
                    if (null != application)
                    {
                        application.InvitationFirstSel = firstinvitation;
                        application.LastModifiedDt = DateTime.Now;
                        application.LastModifiedBy = modifiedby;
                        var upd = entities.SaveChanges();

                        return application.AppId;
                    }
                }
            }
            return 0;
        }

        public int UpdateFirstSelectionStatus(int acquisitionid, int applicantid, bool? firstselection, string modifiedby)
        {
            if (acquisitionid != 0 && applicantid != 0)
            {
                using (var entities = new atmEntities())
                {
                    var application = (from a in entities.tblApplications where a.AcquisitionId == acquisitionid && a.ApplicantId == applicantid select a).OrderByDescending(a => a.CreatedDt).FirstOrDefault();
                    if (null != application)
                    {
                        application.FirstSelectionInd = firstselection;
                        application.LastModifiedDt = DateTime.Now;
                        application.LastModifiedBy = modifiedby;
                        var upd = entities.SaveChanges();

                        return application.AppId;
                    }
                }
            }
            return 0;
        }

        public int UpdateLastSelectionStatus(int acquisitionid, int applicantid, bool? finalselection, bool? interview, string modifiedby)
        {
            if (acquisitionid != 0 && applicantid != 0)
            {
                using (var entities = new atmEntities())
                {
                    var application = (from a in entities.tblApplications where a.AcquisitionId == acquisitionid && a.ApplicantId == applicantid select a).OrderByDescending(a => a.CreatedDt).FirstOrDefault();
                    if (null != application)
                    {
                        application.FinalSelectionInd = finalselection;
                        application.ApplicationStatus = interview;
                        application.LastModifiedDt = DateTime.Now;
                        application.LastModifiedBy = modifiedby;
                        var upd = entities.SaveChanges();

                        return application.AppId;
                    }
                }
            }
            return 0;
        }


        public IEnumerable<State> GetSubmittedApplicationStates(int acquisitionid, bool? firstselection, bool? finalselection)
        {
            var list = new List<State>();
            if (acquisitionid != 0)
            {
                using (var entities = new atmEntities())
                {
                    if (firstselection.HasValue)
                    {
                        var apps = (from a in entities.tblApplications join b in entities.tblApplicantSubmiteds on new { AcquisitionId = (int)a.AcquisitionId, ApplicantId = (int)a.ApplicantId } equals new { b.AcquisitionId, b.ApplicantId } where a.FirstSelectionInd == firstselection && a.AcquisitionId == acquisitionid && b.AcquisitionId == acquisitionid select b.CorresponAddrStateCd).Distinct().OrderBy(a => a);
                        list.AddRange(from cd in apps
                                      select (from a in entities.tblREFStates where a.StateCd == cd select a).FirstOrDefault()
                                          into st
                                          where null != st
                                          select new State()
                                          {
                                              StateCd = st.StateCd,
                                              StateDesc = st.State
                                          });
                    }
                    else if (finalselection.HasValue)
                    {
                        var apps = (from a in entities.tblApplications join b in entities.tblApplicantSubmiteds on new { AcquisitionId = (int)a.AcquisitionId, ApplicantId = (int)a.ApplicantId } equals new { b.AcquisitionId, b.ApplicantId } where a.FinalSelectionInd == finalselection && a.AcquisitionId == acquisitionid && b.AcquisitionId == acquisitionid select b.CorresponAddrStateCd).Distinct().OrderBy(a => a);
                        list.AddRange(from cd in apps
                                      select (from a in entities.tblREFStates where a.StateCd == cd select a).FirstOrDefault()
                                          into st
                                          where null != st
                                          select new State()
                                          {
                                              StateCd = st.StateCd,
                                              StateDesc = st.State
                                          });
                    }
                    else
                    {
                        var apps = (from a in entities.tblApplications join b in entities.tblApplicantSubmiteds on new { AcquisitionId = (int)a.AcquisitionId, ApplicantId = (int)a.ApplicantId } equals new { b.AcquisitionId, b.ApplicantId } where a.AcquisitionId == acquisitionid && b.AcquisitionId == acquisitionid select b.CorresponAddrStateCd).Distinct().OrderBy(a => a);
                        list.AddRange(from cd in apps
                                      select (from a in entities.tblREFStates where a.StateCd == cd select a).FirstOrDefault()
                                          into st
                                          where null != st
                                          select new State()
                                          {
                                              StateCd = st.StateCd,
                                              StateDesc = st.State
                                          });
                    }

                }
            }
            return list;

        }

        public IEnumerable<City> GetSubmittedApplicationCities(int acquisitionid, string statecode, bool? firstselection, bool? finalselection)
        {
            var list = new List<City>();
            if (acquisitionid != 0)
            {
                using (var entities = new atmEntities())
                {
                    if (firstselection.HasValue)
                    {
                        var apps = (from a in entities.tblApplications join b in entities.tblApplicantSubmiteds on new { AcquisitionId = (int)a.AcquisitionId, ApplicantId = (int)a.ApplicantId } equals new { b.AcquisitionId, b.ApplicantId } where a.AcquisitionId == acquisitionid && b.AcquisitionId == acquisitionid && b.CorresponAddrStateCd == statecode && a.FirstSelectionInd == firstselection select b.CorresponAddrCityCd).Distinct().OrderBy(a => a);
                        list.AddRange(from cd in apps
                                      select (from a in entities.tblREFCities where a.CityCd == cd select a).FirstOrDefault()
                                          into st
                                          where null != st
                                          select new City()
                                          {
                                              StateCd = st.StateCd,
                                              CityCd = st.CityCd,
                                              CityName = st.City
                                          });

                    }
                    else if (finalselection.HasValue)
                    {

                        var apps = (from a in entities.tblApplications join b in entities.tblApplicantSubmiteds on new { AcquisitionId = (int)a.AcquisitionId, ApplicantId = (int)a.ApplicantId } equals new { b.AcquisitionId, b.ApplicantId } where a.AcquisitionId == acquisitionid && b.AcquisitionId == acquisitionid && b.CorresponAddrStateCd == statecode && a.FinalSelectionInd == finalselection select b.CorresponAddrCityCd).Distinct().OrderBy(a => a);
                        list.AddRange(from cd in apps
                                      select (from a in entities.tblREFCities where a.CityCd == cd select a).FirstOrDefault()
                                          into st
                                          where null != st
                                          select new City()
                                          {
                                              StateCd = st.StateCd,
                                              CityCd = st.CityCd,
                                              CityName = st.City
                                          });
                    }
                    else
                    {

                        var apps = (from a in entities.tblApplications join b in entities.tblApplicantSubmiteds on new { AcquisitionId = (int)a.AcquisitionId, ApplicantId = (int)a.ApplicantId } equals new { b.AcquisitionId, b.ApplicantId } where a.AcquisitionId == acquisitionid && b.AcquisitionId == acquisitionid && b.CorresponAddrStateCd == statecode select b.CorresponAddrCityCd).Distinct().OrderBy(a => a);
                        list.AddRange(from cd in apps
                                      select (from a in entities.tblREFCities where a.CityCd == cd select a).FirstOrDefault()
                                          into st
                                          where null != st
                                          select new City()
                                          {
                                              StateCd = st.StateCd,
                                              CityCd = st.CityCd,
                                              CityName = st.City
                                          });
                    }

                }
            }
            return list;
        }


        public int UpdateFirstSelectionLocationAndDateTime(int acquisitionid, int applicantid, int? locationid, DateTime? startdate, DateTime? enddate, string modifiedby)
        {
            if (acquisitionid != 0 && applicantid != 0)
            {
                using (var entities = new atmEntities())
                {
                    var application = (from a in entities.tblApplications where a.AcquisitionId == acquisitionid && a.ApplicantId == applicantid select a).OrderByDescending(a => a.CreatedDt).FirstOrDefault();
                    if (null != application)
                    {
                        application.FinalSelActualAcqLocationId = locationid;
                        application.FinalSelectionStartDate = startdate;
                        application.FinalSelectionEndDate = enddate;
                        application.LastModifiedDt = DateTime.Now;
                        application.LastModifiedBy = modifiedby;
                        var upd = entities.SaveChanges();

                        return application.AppId;
                    }
                }
            }
            return 0;
        }


        public IEnumerable<ReportDutyLocation> GetReportDutyLocations()
        {
            var list = new List<ReportDutyLocation>();
            using (var entities = new atmEntities())
            {
                var l = from a in entities.tblREFReportDutyLocs select a;
                foreach (var rl in l)
                {
                    list.Add(new ReportDutyLocation()
                    {
                        BUID = rl.BUID,
                        ReportDutyLoc = rl.ReportDutyLoc,
                        ReportDutyLocId = rl.ReportDutyLocId
                    });
                }
            }
            return list;
        }


        public int UpdateReportDutyLocationAndDateTime(int acquisitionid, int applicantid, int? locationid, DateTime? reportdutydate, string modifiedby, string selectedservice)
        {
            if (acquisitionid != 0 && applicantid != 0)
            {
                using (var entities = new atmEntities())
                {
                    var application = (from a in entities.tblApplications where a.AcquisitionId == acquisitionid && a.ApplicantId == applicantid select a).OrderByDescending(a => a.CreatedDt).FirstOrDefault();
                    if (null != application)
                    {
                        application.ReportDutyLocId = locationid;
                        application.ReportDutyDate = reportdutydate;
                        application.LastModifiedDt = DateTime.Now;
                        application.LastModifiedBy = modifiedby;
                        if (!string.IsNullOrWhiteSpace(selectedservice) && selectedservice != "undefined" && selectedservice != "null")
                            application.FinalServiceCd = selectedservice;
                        var upd = entities.SaveChanges();

                        return application.AppId;
                    }
                }
            }
            return 0;
        }
    }
}
