using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Atm.Entity.Persistance
{
    class AcquisitionPersistence : IAcquisitionPersistence
    {
        public void Delete(int id)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblAcquisitions where a.AcquisitionId == id select a).SingleOrDefault();
                if (null != exist)
                {
                    entities.tblAcquisitions.Remove(exist);
                    entities.SaveChanges();
                }
            }
        }

        public int Save(Acquisition appl)
        {
            using (var entities = new atmEntities())
            {
                var acq = new tblAcquisition
                {
                    AcquisitionTypeCd = appl.AcquisitionTypeCd,
                    CreatedBy = appl.CreatedBy,
                    CreatedDt = appl.CreatedDt,
                    NewStatus = appl.NewStatus,
                    NewStatusBy = appl.NewStatusBy,
                    OpenStatus = appl.OpenStatus,
                    OpenStatusBy = appl.OpenStatusBy,
                    SecurityCheckStatus = appl.SecurityCheckStatus,
                    SecurityCheckStatusBy = appl.SecurityCheckStatusBy,
                    Siri = appl.Siri,
                    Target = appl.Target,
                    Year = appl.Year,
                    ArmyNumberFrom = appl.ArmyNumberFrom,
                    PhysicalHealthStatus = appl.PhysicalHealthStatus,
                    PhysicalHealthStatusBy = appl.PhysicalHealthStatusBy,
                    ShortlistMeritInd = appl.ShortlistMeritInd,
                    ToFinalSelNominated = appl.ToFinalSelNominated,
                    ToFinalSelNominatedBy = appl.ToFinalSelNominatedBy,
                    WrittenTestStatus = appl.WrittenTestStatus,
                    WrittenTestStatusBy = appl.WrittenTestStatusBy,
                    ArmyNumberTo = appl.ArmyNumberTo,
                    AssignNoTenteraStatus = appl.AssignNoTenteraStatus,
                    AssignNoTenteraStatusBy = appl.AssignNoTenteraStatusBy,
                    CloseStatus = appl.CloseStatus,
                    CloseStatusBy = appl.CloseStatusBy,
                    CompleteStatus = appl.CompleteStatus,
                    CompleteStatusBy = appl.CompleteStatusBy,
                    FirstSelShortlisProcessInd = appl.FirstSelShortlisProcessInd,
                    ClosingDate = appl.ClosingDate,
                    DocumentStatus = appl.DocumentStatus,
                    DocumentStatusBy = appl.DocumentStatusBy,
                    FinalSelShortlisProcessInd = appl.FinalSelShortlisProcessInd,
                    FinalSelStatus = appl.FinalSelStatus,
                    FinalSelStatusBy = appl.FinalSelStatusBy,
                    FirstSelectionStatus = appl.FirstSelectionStatus,
                    FirstSelectionStatusBy = appl.FirstSelectionStatusBy,
                    InviteFinalSelStatus = appl.InviteFinalSelStatus,
                    InviteFinalSelStatusBy = appl.InviteFinalSelStatusBy,
                    InviteFirstSelNominated = appl.InviteFirstSelNominated,
                    InviteFirstSelNominatedBy = appl.InviteFirstSelNominatedBy,
                    InviteFirstSelStatus = appl.InviteFirstSelStatus,
                    InviteFirstSelStatusBy = appl.InviteFirstSelStatusBy,
                    FinalSupportingDocument = appl.FinalSupportingDocument,
                    ReportDutySupportingDocument = appl.ReportDutySupportingDocument
                };
                entities.tblAcquisitions.Add(acq);
                if (entities.SaveChanges() > 0)
                    return acq.AcquisitionId;
            }
            return 0;
        }

        public Acquisition GetAcquisition(int id)
        {
            using (var entities = new atmEntities())
            {
                var acq = (from a in entities.tblAcquisitions where a.AcquisitionId == id select a).SingleOrDefault();
                if (null != acq)
                {
                    var a = new Acquisition
                    {
                        AcquisitionId = acq.AcquisitionId,
                        AcquisitionTypeCd = acq.AcquisitionTypeCd,
                        CreatedBy = acq.CreatedBy,
                        CreatedDt = acq.CreatedDt,
                        NewStatus = acq.NewStatus,
                        NewStatusBy = acq.NewStatusBy,
                        OpenStatus = acq.OpenStatus,
                        OpenStatusBy = acq.OpenStatusBy,
                        SecurityCheckStatus = acq.SecurityCheckStatus,
                        SecurityCheckStatusBy = acq.SecurityCheckStatusBy,
                        Siri = acq.Siri,
                        Target = acq.Target,
                        Year = acq.Year,
                        ArmyNumberFrom = acq.ArmyNumberFrom,
                        PhysicalHealthStatus = acq.PhysicalHealthStatus,
                        PhysicalHealthStatusBy = acq.PhysicalHealthStatusBy,
                        ShortlistMeritInd = acq.ShortlistMeritInd,
                        ToFinalSelNominated = acq.ToFinalSelNominated,
                        ToFinalSelNominatedBy = acq.ToFinalSelNominatedBy,
                        WrittenTestStatus = acq.WrittenTestStatus,
                        WrittenTestStatusBy = acq.WrittenTestStatusBy,
                        ArmyNumberTo = acq.ArmyNumberTo,
                        AssignNoTenteraStatus = acq.AssignNoTenteraStatus,
                        AssignNoTenteraStatusBy = acq.AssignNoTenteraStatusBy,
                        CloseStatus = acq.CloseStatus,
                        CloseStatusBy = acq.CloseStatusBy,
                        CompleteStatus = acq.CompleteStatus,
                        CompleteStatusBy = acq.CompleteStatusBy,
                        FirstSelShortlisProcessInd = acq.FirstSelShortlisProcessInd,
                        ClosingDate = acq.ClosingDate,
                        DocumentStatus = acq.DocumentStatus,
                        DocumentStatusBy = acq.DocumentStatusBy,
                        FinalSelShortlisProcessInd = acq.FinalSelShortlisProcessInd,
                        FinalSelStatus = acq.FinalSelStatus,
                        FinalSelStatusBy = acq.FinalSelStatusBy,
                        FirstSelectionStatus = acq.FirstSelectionStatus,
                        FirstSelectionStatusBy = acq.FirstSelectionStatusBy,
                        InviteFinalSelStatus = acq.InviteFinalSelStatus,
                        InviteFinalSelStatusBy = acq.InviteFinalSelStatusBy,
                        InviteFirstSelNominated = acq.InviteFirstSelNominated,
                        InviteFirstSelNominatedBy = acq.InviteFirstSelNominatedBy,
                        InviteFirstSelStatus = acq.InviteFirstSelStatus,
                        InviteFirstSelStatusBy = acq.InviteFirstSelStatusBy,
                        FinalSupportingDocument = acq.FinalSupportingDocument,
                        ReportDutySupportingDocument = acq.ReportDutySupportingDocument
                    };

                    if (a.AcquisitionTypeCd != 0)
                    {
                        var aty = (from b in entities.tblREFAcqTypes where b.AcquisitionTypeCd == a.AcquisitionTypeCd select b).SingleOrDefault();
                        if (null != aty)
                        {
                            a.AcquisitionType = new AcquisitionType
                            {
                                AcquisitionTypeCd = aty.AcquisitionTypeCd,
                                AcquisitionTypeNm = aty.AcquisitionTypeNm,
                                ServiceCd = aty.ServiceCd
                            };
                        }
                    }

                    if (acq.tblAcqLocations != null && acq.tblAcqLocations.Any())
                    {
                        foreach (var loc in acq.tblAcqLocations)
                        {
                            a.AcquisitionLocationCollection.Add(new AcquisitionLocation()
                            {
                                AcqLocationId = loc.AcqLocationId,
                                AcquisitionId = loc.AcquisitionId,
                                ZoneCd = loc.ZoneCd,
                                CreatedBy = loc.CreatedBy,
                                CreatedDt = loc.CreatedDt,
                                LastModifiedBy = loc.LastModifiedBy,
                                LastModifiedDt = loc.LastModifiedDt,
                                LocationId = loc.LocationId,
                                Location = loc.tblRefLocation != null ? new Location()
                                {
                                    LocationId = loc.tblRefLocation.LocationId,
                                    LocationNm = loc.tblRefLocation.LocationNm,
                                    CityCd = loc.tblRefLocation.CityCd,
                                    StateCd = loc.tblRefLocation.StateCd,
                                    ZoneCd = loc.tblRefLocation.ZoneCd,
                                } : null
                            });
                        }
                    }

                    return a;
                }
            }
            return null;
        }

        public IEnumerable<AcquisitionLocation> GetLocations(string zonecode)
        {
            var list = new List<AcquisitionLocation>();
            using (var entities = new atmEntities())
            {
                var l = from a in entities.tblAcqLocations where a.ZoneCd == zonecode select a;
                if (l.Any())
                {
                    foreach (var al in l)
                    {
                        if (al.AcquisitionId.HasValue)
                        {
                            var loc = new AcquisitionLocation
                            {
                                AcqLocationId = al.AcqLocationId,
                                AcquisitionId = al.AcquisitionId,
                                CreatedBy = al.CreatedBy,
                                CreatedDt = al.CreatedDt,
                                LastModifiedBy = al.LastModifiedBy,
                                LastModifiedDt = al.LastModifiedDt,
                                ZoneCd = al.ZoneCd
                            };
                            if (al.tblRefLocation != null)
                            {
                                loc.Location = new Location
                                {
                                    LocationId = al.tblRefLocation.LocationId,
                                    LocationNm = al.tblRefLocation.LocationNm,
                                    StateCd = al.tblRefLocation.StateCd,
                                    ZoneCd = al.tblRefLocation.ZoneCd,
                                    CreatedBy = al.tblRefLocation.CreatedBy,
                                    CreatedDt = al.tblRefLocation.CreatedDt,
                                    CityCd = al.tblRefLocation.CityCd,
                                    ActiveInd = al.tblRefLocation.ActiveInd,
                                    LastModifiedBy = al.tblRefLocation.LastModifiedBy,
                                    LastModifiedDt = al.tblRefLocation.LastModifiedDt
                                };
                            }
                            list.Add(loc);
                        }
                    }
                }
            }
            return list;
        }

        public AcquisitionLocation GetLocation(int id)
        {
            if (id != 0)
            {
                using (var entities = new atmEntities())
                {
                    var l = (from a in entities.tblAcqLocations where a.AcqLocationId == id select a).SingleOrDefault();
                    if (l != null)
                    {
                        var loc = new AcquisitionLocation
                        {
                            AcqLocationId = l.AcqLocationId,
                            AcquisitionId = l.AcquisitionId,
                            CreatedBy = l.CreatedBy,
                            CreatedDt = l.CreatedDt,
                            LastModifiedBy = l.LastModifiedBy,
                            LastModifiedDt = l.LastModifiedDt,
                            ZoneCd = l.ZoneCd
                        };
                        if (l.tblRefLocation != null)
                        {
                            loc.Location = new Location
                            {
                                LocationId = l.tblRefLocation.LocationId,
                                LocationNm = l.tblRefLocation.LocationNm,
                                StateCd = l.tblRefLocation.StateCd,
                                ZoneCd = l.tblRefLocation.ZoneCd,
                                CreatedBy = l.tblRefLocation.CreatedBy,
                                CreatedDt = l.tblRefLocation.CreatedDt,
                                CityCd = l.tblRefLocation.CityCd,
                                ActiveInd = l.tblRefLocation.ActiveInd,
                                LastModifiedBy = l.tblRefLocation.LastModifiedBy,
                                LastModifiedDt = l.tblRefLocation.LastModifiedDt
                            };
                        }
                        return loc;
                    }
                }
            }
            return null;
        }

        public IEnumerable<Acquisition> GetAllAcquisition(bool? isactive, string servicecode)
        {
            var list = new List<Acquisition>();
            using (var entities = new atmEntities())
            {
                var l = from a in entities.tblAcquisitions select a;
                if (isactive.HasValue)
                    l = l.Where(a => a.CloseStatus.HasValue && a.CloseStatus.Value == isactive);
                if (!string.IsNullOrWhiteSpace(servicecode) && servicecode != "00")
                    l = from a in entities.tblAcquisitions join b in entities.tblREFAcqTypes on a.AcquisitionTypeCd equals b.AcquisitionTypeCd where b.ServiceCd == servicecode select a;

                if (l.Any())
                {
                    foreach (var acq in l)
                    {
                        var a = new Acquisition
                        {
                            AcquisitionId = acq.AcquisitionId,
                            AcquisitionTypeCd = acq.AcquisitionTypeCd,
                            CreatedBy = acq.CreatedBy,
                            CreatedDt = acq.CreatedDt,
                            NewStatus = acq.NewStatus,
                            NewStatusBy = acq.NewStatusBy,
                            OpenStatus = acq.OpenStatus,
                            OpenStatusBy = acq.OpenStatusBy,
                            SecurityCheckStatus = acq.SecurityCheckStatus,
                            SecurityCheckStatusBy = acq.SecurityCheckStatusBy,
                            Siri = acq.Siri,
                            Target = acq.Target,
                            Year = acq.Year,
                            ArmyNumberFrom = acq.ArmyNumberFrom,
                            PhysicalHealthStatus = acq.PhysicalHealthStatus,
                            PhysicalHealthStatusBy = acq.PhysicalHealthStatusBy,
                            ShortlistMeritInd = acq.ShortlistMeritInd,
                            ToFinalSelNominated = acq.ToFinalSelNominated,
                            ToFinalSelNominatedBy = acq.ToFinalSelNominatedBy,
                            WrittenTestStatus = acq.WrittenTestStatus,
                            WrittenTestStatusBy = acq.WrittenTestStatusBy,
                            ArmyNumberTo = acq.ArmyNumberTo,
                            AssignNoTenteraStatus = acq.AssignNoTenteraStatus,
                            AssignNoTenteraStatusBy = acq.AssignNoTenteraStatusBy,
                            CloseStatus = acq.CloseStatus,
                            CloseStatusBy = acq.CloseStatusBy,
                            CompleteStatus = acq.CompleteStatus,
                            CompleteStatusBy = acq.CompleteStatusBy,
                            FirstSelShortlisProcessInd = acq.FirstSelShortlisProcessInd,
                            ClosingDate = acq.ClosingDate,
                            DocumentStatus = acq.DocumentStatus,
                            DocumentStatusBy = acq.DocumentStatusBy,
                            FinalSelShortlisProcessInd = acq.FinalSelShortlisProcessInd,
                            FinalSelStatus = acq.FinalSelStatus,
                            FinalSelStatusBy = acq.FinalSelStatusBy,
                            FirstSelectionStatus = acq.FirstSelectionStatus,
                            FirstSelectionStatusBy = acq.FirstSelectionStatusBy,
                            InviteFinalSelStatus = acq.InviteFinalSelStatus,
                            InviteFinalSelStatusBy = acq.InviteFinalSelStatusBy,
                            InviteFirstSelNominated = acq.InviteFirstSelNominated,
                            InviteFirstSelNominatedBy = acq.InviteFirstSelNominatedBy,
                            InviteFirstSelStatus = acq.InviteFirstSelStatus,
                            InviteFirstSelStatusBy = acq.InviteFirstSelStatusBy,
                            FinalSupportingDocument = acq.FinalSupportingDocument,
                            ReportDutySupportingDocument = acq.ReportDutySupportingDocument
                        };

                        if (a.AcquisitionTypeCd != 0)
                        {
                            var aty = (from b in entities.tblREFAcqTypes where b.AcquisitionTypeCd == a.AcquisitionTypeCd select b).SingleOrDefault();
                            if (null != aty)
                            {
                                a.AcquisitionType = new AcquisitionType
                                {
                                    AcquisitionTypeCd = aty.AcquisitionTypeCd,
                                    AcquisitionTypeNm = aty.AcquisitionTypeNm,
                                    ServiceCd = aty.ServiceCd
                                };
                            }
                        }

                        if (acq.tblAcqLocations != null && acq.tblAcqLocations.Any())
                        {
                            foreach (var loc in acq.tblAcqLocations)
                            {
                                a.AcquisitionLocationCollection.Add(new AcquisitionLocation()
                                {
                                    AcqLocationId = loc.AcqLocationId,
                                    AcquisitionId = loc.AcquisitionId,
                                    ZoneCd = loc.ZoneCd,
                                    CreatedBy = loc.CreatedBy,
                                    CreatedDt = loc.CreatedDt,
                                    LastModifiedBy = loc.LastModifiedBy,
                                    LastModifiedDt = loc.LastModifiedDt,
                                    LocationId = loc.LocationId,
                                    Location = loc.tblRefLocation != null ? new Location()
                                    {
                                        LocationId = loc.tblRefLocation.LocationId,
                                        LocationNm = loc.tblRefLocation.LocationNm,
                                        CityCd = loc.tblRefLocation.CityCd,
                                        StateCd = loc.tblRefLocation.StateCd,
                                        ZoneCd = loc.tblRefLocation.ZoneCd,
                                    } : null
                                });
                            }
                        }
                        list.Add(a);
                    }
                }
            }
            return list;
        }


        public int Update(Acquisition appl)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblAcquisitions where a.AcquisitionId == appl.AcquisitionId select a).SingleOrDefault();
                if (null != exist)
                {
                    exist.AcquisitionTypeCd = appl.AcquisitionTypeCd;
                    exist.CreatedBy = appl.CreatedBy;
                    exist.CreatedDt = appl.CreatedDt;
                    exist.NewStatus = appl.NewStatus;
                    exist.NewStatusBy = appl.NewStatusBy;
                    exist.OpenStatus = appl.OpenStatus;
                    exist.OpenStatusBy = appl.OpenStatusBy;
                    exist.SecurityCheckStatus = appl.SecurityCheckStatus;
                    exist.SecurityCheckStatusBy = appl.SecurityCheckStatusBy;
                    exist.Siri = appl.Siri;
                    exist.Target = appl.Target;
                    exist.Year = appl.Year;
                    exist.ArmyNumberFrom = appl.ArmyNumberFrom;
                    exist.PhysicalHealthStatus = appl.PhysicalHealthStatus;
                    exist.PhysicalHealthStatusBy = appl.PhysicalHealthStatusBy;
                    exist.ShortlistMeritInd = appl.ShortlistMeritInd;
                    exist.ToFinalSelNominated = appl.ToFinalSelNominated;
                    exist.ToFinalSelNominatedBy = appl.ToFinalSelNominatedBy;
                    exist.WrittenTestStatus = appl.WrittenTestStatus;
                    exist.WrittenTestStatusBy = appl.WrittenTestStatusBy;
                    exist.ArmyNumberTo = appl.ArmyNumberTo;
                    exist.AssignNoTenteraStatus = appl.AssignNoTenteraStatus;
                    exist.AssignNoTenteraStatusBy = appl.AssignNoTenteraStatusBy;
                    exist.CloseStatus = appl.CloseStatus;
                    exist.CloseStatusBy = appl.CloseStatusBy;
                    exist.CompleteStatus = appl.CompleteStatus;
                    exist.CompleteStatusBy = appl.CompleteStatusBy;
                    exist.FirstSelShortlisProcessInd = appl.FirstSelShortlisProcessInd;
                    exist.ClosingDate = appl.ClosingDate;
                    exist.DocumentStatus = appl.DocumentStatus;
                    exist.DocumentStatusBy = appl.DocumentStatusBy;
                    exist.FinalSelShortlisProcessInd = appl.FinalSelShortlisProcessInd;
                    exist.FinalSelStatus = appl.FinalSelStatus;
                    exist.FinalSelStatusBy = appl.FinalSelStatusBy;
                    exist.FirstSelectionStatus = appl.FirstSelectionStatus;
                    exist.FirstSelectionStatusBy = appl.FirstSelectionStatusBy;
                    exist.InviteFinalSelStatus = appl.InviteFinalSelStatus;
                    exist.InviteFinalSelStatusBy = appl.InviteFinalSelStatusBy;
                    exist.InviteFirstSelNominated = appl.InviteFirstSelNominated;
                    exist.InviteFirstSelNominatedBy = appl.InviteFirstSelNominatedBy;
                    exist.InviteFirstSelStatus = appl.InviteFirstSelStatus;
                    exist.InviteFirstSelStatusBy = appl.InviteFirstSelStatusBy;
                    exist.FinalSupportingDocument = appl.FinalSupportingDocument;
                    exist.ReportDutySupportingDocument = appl.ReportDutySupportingDocument;

                    entities.SaveChanges();
                    return exist.AcquisitionId;
                }
            }
            return 0;
        }


        public int AddAnnouncement(AcquisitionAnnouncement announcement)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblAcqAnnouncements where a.AcquisitionId == announcement.AcquisitionId && a.AnnouncementSelectionInd == announcement.AnnouncementSelectionInd select a).SingleOrDefault();
                if (null != exist)
                {
                    announcement.AcqAnnouncementId = exist.AcqAnnouncementId;
                    return UpdateAnnouncement(announcement);
                }

                var ann = new tblAcqAnnouncement()
                {
                    AnnouncementSelectionInd = announcement.AnnouncementSelectionInd,
                    AnnouncementStatusInd = announcement.AnnouncementStatusInd,
                    AcquisitionId = announcement.AcquisitionId,
                    AnnouncementTypeInd = announcement.AnnouncementTypeInd,
                    AttachmentFileName = announcement.AttachmentFileName,
                    AttachmentOriginalFileName = announcement.AttachmentOriginalFileName,
                    Body = announcement.Body,
                    Header = announcement.Header,
                    CreatedBy = announcement.CreatedBy,
                    CreatedDt = announcement.CreatedDate,
                };
                entities.tblAcqAnnouncements.Add(ann);
                if (entities.SaveChanges() > 0)
                    return ann.AcqAnnouncementId;
            }
            return 0;
        }

        public int UpdateAnnouncement(AcquisitionAnnouncement announcement)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblAcqAnnouncements where a.AcqAnnouncementId == announcement.AcqAnnouncementId select a).SingleOrDefault();
                if (null != exist)
                {
                    exist.AnnouncementSelectionInd = announcement.AnnouncementSelectionInd;
                    exist.AnnouncementStatusInd = announcement.AnnouncementStatusInd;
                    exist.AcquisitionId = announcement.AcquisitionId;
                    exist.AnnouncementTypeInd = announcement.AnnouncementTypeInd;
                    exist.AttachmentFileName = announcement.AttachmentFileName;
                    exist.AttachmentOriginalFileName = announcement.AttachmentOriginalFileName;
                    exist.Body = announcement.Body;
                    exist.Header = announcement.Header;
                    exist.LastModifiedBy = announcement.LastModifiedBy;
                    exist.LastModifiedDt = announcement.LastModifiedDate;

                    if (entities.SaveChanges() > 0)
                        return exist.AcqAnnouncementId;
                }
            }
            return 0;
        }

        public bool DeleteAnnouncement(int id)
        {
            if (id != 0)
                using (var entities = new atmEntities())
                {
                    var exist = (from a in entities.tblAcqAnnouncements where a.AcqAnnouncementId == id select a).SingleOrDefault();
                    if (null != exist)
                    {
                        entities.tblAcqAnnouncements.Remove(exist);
                        return entities.SaveChanges() > 0;
                    }
                }
            return false;
        }

        public AcquisitionAnnouncement GetAnnouncement(int acquisitionid, int? announcementselectiontype)
        {
            using (var entities = new atmEntities())
            {
                var exist = (from a in entities.tblAcqAnnouncements where a.AcquisitionId == acquisitionid && a.AnnouncementSelectionInd == announcementselectiontype select a).SingleOrDefault();

                if (null != exist)
                {
                    var ann = new AcquisitionAnnouncement()
                    {
                        AcqAnnouncementId = exist.AcqAnnouncementId,
                        AnnouncementSelectionInd = exist.AnnouncementSelectionInd,
                        AnnouncementStatusInd = exist.AnnouncementStatusInd,
                        AcquisitionId = exist.AcquisitionId,
                        AnnouncementTypeInd = exist.AnnouncementTypeInd,
                        AttachmentFileName = exist.AttachmentFileName,
                        AttachmentOriginalFileName = exist.AttachmentOriginalFileName,
                        Body = exist.Body,
                        Header = exist.Header,
                        CreatedBy = exist.CreatedBy,
                        CreatedDate = exist.CreatedDt,
                        LastModifiedBy = exist.LastModifiedBy,
                        LastModifiedDate = exist.LastModifiedDt
                    };
                    return ann;
                }
            }
            return null;
        }


        public IEnumerable<AcquisitionLocation> GetLocations(int acquisitionid)
        {
            var list = new List<AcquisitionLocation>();
            using (var entities = new atmEntities())
            {
                var l = from a in entities.tblAcqLocations where a.AcquisitionId == acquisitionid select a;
                if (l.Any())
                {
                    foreach (var al in l)
                    {
                        if (al.AcquisitionId.HasValue)
                        {
                            var loc = new AcquisitionLocation
                            {
                                AcqLocationId = al.AcqLocationId,
                                AcquisitionId = al.AcquisitionId,
                                CreatedBy = al.CreatedBy,
                                CreatedDt = al.CreatedDt,
                                LastModifiedBy = al.LastModifiedBy,
                                LastModifiedDt = al.LastModifiedDt,
                                ZoneCd = al.ZoneCd
                            };
                            if (al.tblRefLocation != null)
                            {
                                loc.Location = new Location
                                {
                                    LocationId = al.tblRefLocation.LocationId,
                                    LocationNm = al.tblRefLocation.LocationNm,
                                    StateCd = al.tblRefLocation.StateCd,
                                    ZoneCd = al.tblRefLocation.ZoneCd,
                                    CreatedBy = al.tblRefLocation.CreatedBy,
                                    CreatedDt = al.tblRefLocation.CreatedDt,
                                    CityCd = al.tblRefLocation.CityCd,
                                    ActiveInd = al.tblRefLocation.ActiveInd,
                                    LastModifiedBy = al.tblRefLocation.LastModifiedBy,
                                    LastModifiedDt = al.tblRefLocation.LastModifiedDt
                                };
                            }
                            list.Add(loc);
                        }
                    }
                }
            }
            return list;
        }
    }
}
