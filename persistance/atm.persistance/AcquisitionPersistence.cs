using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Atm.Entity.Persistance
{
    class AcquisitionPersistence : IAcquisitionPersistence
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Save(Acquisition appl)
        {
            throw new NotImplementedException();
        }

        public Acquisition GetAcquisition(int id)
        {
            using (var entities = new atmEntities())
            {
                var acq = (from a in entities.tblAcquisitions where a.AcquisitionId == id select a).SingleOrDefault();
                if (null != acq)
                {
                    var a = new Acquisition()
                           {
                               AcquisitionId = acq.AcquisitionId,
                               CloseStatus = acq.CloseStatus,
                               CloseStatusBy = acq.CloseStatusBy,
                               ClosingDate = acq.ClosingDate,
                               CompleteStatus = acq.CompleteStatus,
                               CompleteStatusBy = acq.CompleteStatusBy,
                               FinalSelStatus = acq.FinalSelStatus,
                               FinalSelStatusBy = acq.FinalSelStatusBy,
                               InviteFinalSelStatusBy = acq.InviteFinalSelStatusBy,
                               FirstSelectionStatus = acq.FirstSelectionStatus,
                               FirstSelectionStatusBy = acq.FirstSelectionStatusBy,
                               InviteFirstSelStatus = acq.InviteFirstSelStatus,
                               InviteFirstSelStatusBy = acq.InviteFirstSelStatusBy,
                               InviteFinalSelStatus = acq.InviteFinalSelStatus,
                               LastModifiedBy = acq.LastModifiedBy,
                               LastModifiedDt = acq.LastModifiedDt,
                               NewStatus = acq.NewStatus,
                               NewStatusBy = acq.NewStatusBy,
                               OpenStatus = acq.OpenStatus,
                               OpenStatusBy = acq.OpenStatusBy,
                               AssignNoTenteraStatus = acq.AssignNoTenteraStatus,
                               AssignNoTenteraStatusBy = acq.AssignNoTenteraStatusBy,
                               SecurityCheckStatus = acq.SecurityCheckStatus,
                               SecurityCheckStatusBy = acq.SecurityCheckStatusBy,
                               WrittenTestStatus = acq.WrittenTestStatus,
                               WrittenTestStatusBy = acq.WrittenTestStatusBy,
                               Siri = acq.Siri,
                               Year = acq.Year,
                               Target = acq.Target,
                               CreatedBy = acq.CreatedBy,
                               CreatedDt = acq.CreatedDt
                           };
                    return a;
                }
            }
            return null;
        }

        public IEnumerable<AcquisitionLocation> GetLocations(string zonecode)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Acquisition> GetAllAcquisition(bool isactive, string servicecode)
        {
            throw new NotImplementedException();
        }
    }
}
