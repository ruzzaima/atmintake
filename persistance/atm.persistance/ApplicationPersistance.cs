using System;
using System.Collections.Generic;
using System.Linq;
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
                if (application.AppId != 0)
                {
                    var exist = (from a in entities.tblApplications where a.AppId == application.AppId select a).SingleOrDefault();
                    if (null != exist)
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
                    WrittenTest = application.WrittenTest
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
                WrittenTest = exist.WrittenTest
            };

            if (exist.AcquisitionId.HasValue)
                app.Acquisition =
                    ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence")
                        .GetAcquisition(exist.AcquisitionId.Value);

            if (exist.ApplicantId.HasValue && exist.AcquisitionId.HasValue)
                app.ApplicantSubmitted =
                    ObjectBuilder.GetObject<IApplicantSubmittedPersistence>("ApplicantSubmittedPersistence")
                        .GetApplicant(exist.ApplicantId.Value, exist.AcquisitionId.Value);

            return app;
        }

        public Application GetByApplicantIdAndAcquisitionId(int applicantid, int acquisitionid)
        {
            if (applicantid != 0 && acquisitionid != 0)
            {
                using (var entities = new atmEntities())
                {
                    var exist = (from a in entities.tblApplications where a.ApplicantId == applicantid && a.AcquisitionId == acquisitionid select a).SingleOrDefault();
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
    }
}
