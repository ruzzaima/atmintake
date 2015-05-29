using System;
using System.Collections.Generic;
using System.Web.Mvc;
using SevenH.MMCSB.Atm.Domain;


namespace SevenH.MMCSB.Atm.Web.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var cit = new ReferenceRepo().GetCities();

            var acq = new Acquisition()
            {
                AcquisitionTypeCd = "1",
                AssignNoTenteraStatus = true,
                Bil=1,
                CloseStatus=false,
                Year=2011,
                Siri=1,
                ClosingDate=DateTime.Today,
                Target=1,
                NewStatus = true,
                OpenStatus = false,
                OpenStatusBy = "rodin",
                CloseStatusBy = "rodin2",
                InviteFirstSelStatus=true,
                InviteFirstSelStatusBy="rodin3",
                SecurityCheckStatus=true,
                SecurityCheckStatusBy="rodin4",
                FirstSelectionStatus=true,
                FirstSelectionStatusBy="rodin5",
                InviteFinalSelStatus=true,
                InviteFinalSelStatusBy = "rodin6",
                WrittenTestStatus=true,
                WrittenTestStatusBy = "rodin7",
                FinalSelStatus = true,
                FinalSelStatusBy = "rodin8",
                AssignNoTenteraStatusBy="rodin9",
                CompleteStatus=true,
                CompleteStatusBy="rodin10",
                CreatedBy="admin",
                CreatedDt = DateTime.Today,
                LastModifiedBy = "admin",
                LastModifiedDt = DateTime.Today,
            };

            var acqCri = new AcquisitionCriteria()
            {
                TDHeightM = (decimal) 1.0,
                TDWeightM = (decimal)1.0,
                TDHeightF = (decimal)1.0,
                TDWeightF = (decimal)1.0,
                TLHeightF = (decimal)1.0,
                TLWeightF = (decimal)1.0,
                TLHeightM = (decimal)1.0,
                TLWeightM = (decimal)1.0,
                TUHeightF = (decimal)1.0,
                TUWeightF = (decimal)1.0,
                TUHeightM = (decimal)1.0,
                TUWeightM = (decimal)1.0,
                MaleBMIFrom = (decimal)1.0,
                MaleBMITo = (decimal)1.0,
                FemaleBMIFrom = (decimal)1.0,
                FemaleBMITo = (decimal)1.0,
                AgeMinimum = 20,
                AgeAt = DateTime.Today,
                MaleChestMinimum = (decimal)1.0,
               
            };
            acq.AcquisitionCriterias= new List<AcquisitionCriteria>
            {
                acqCri
            };

            var acqEdu = new AcquisitionEducationCriteria()
            {
                HighEduLevelCd="1",
             };

            acq.AcquisitionEducationCriterias = new List<AcquisitionEducationCriteria>
            {
                acqEdu
            };

            var acqEduSub = new AcquisitionEducationCriteriaSubject()
            {
                SubjectCd="1",
                Subject="PILIHLAH",
                MinimumGradeCd="2",
                Grade="A",
                MainSubjectInd=true,
            };

            acqEdu.AcquisitionEducationCriteriaSubjects = new List<AcquisitionEducationCriteriaSubject>
            {
                acqEduSub,
            };


           // acq.AcquisitionEducationCriterias.Add(acqEdu);

            var res = acq.Save();


            return View();
        }

    }
}