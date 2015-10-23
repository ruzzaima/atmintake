using System;
using System.Linq;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Atm.Web
{
    public static class AtmHelper
    {
        public static string ResolveServerUrl(string serverUrl, bool forceHttps)
        {
            if (serverUrl.IndexOf("://") > -1)
                return serverUrl;

            string newUrl = serverUrl;
            Uri originalUri = System.Web.HttpContext.Current.Request.Url;
            newUrl = (forceHttps ? "https" : originalUri.Scheme) +
                "://" + originalUri.Authority + newUrl;
            return newUrl;
        } 

        public static bool MyKadValidation(string mykadno)
        {
            mykadno = mykadno.Trim();
            if (mykadno.Contains("-")) mykadno = mykadno.Replace("-", string.Empty);
            if (mykadno.Length > 12) return false;
            if (mykadno.Length < 12) return false;

            return true;
        }

        public static bool MyKadAgeValidation(string mykadno, out string message)
        {
            mykadno = mykadno.Trim();
            if (mykadno.Contains("-")) mykadno = mykadno.Replace("-", string.Empty);
            // get first 6
            DateTime zeroTime = new DateTime(1, 1, 1);
            var yearstr = mykadno.Substring(0, 2);
            var monthstr = mykadno.Substring(2, 2);
            var daystr = mykadno.Substring(4, 2);
            var yearint = Convert.ToInt32(yearstr);
            if (yearint == 0) yearint = 2000;
            if (yearint < 10) yearint = 2000 + yearint;
            if (yearint > 10) yearint = 1900 + yearint;
            var bdate = new DateTime(yearint, Convert.ToInt16(monthstr), Convert.ToInt16(daystr));
            var daterange = DateTime.Now - bdate;
            int years = (zeroTime + daterange).Year - 1;
            if (years < 16 || years > 27)
            {
                message = "Anda tidak layak mengikut syarat umum.";
                return false;
            }

            message = "Anda layak";
            return true;
        }

        public static bool ValidateHeightWeightBmi(double? height, double? weight, int acquisitionid, string gendercode, out string message)
        {
            if (acquisitionid != 0)
            {
                var acq = ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetAcquisition(acquisitionid);
                if (null != acq)
                {
                    var acqtype = ObjectBuilder.GetObject<IReferencePersistence>("ReferencePersistence").GetAcquisitionType(acq.AcquisitionTypeCd.Value);
                    if (null != acqtype)
                    {
                        // TD
                        if (acqtype.ServiceCd == "01")
                        {
                            if (gendercode == "L")
                            {
                                if (height.HasValue && height != 0 && (height < 1.62))
                                {
                                    message = "Tinggi anda tidak melayakkan anda memohon. Tinggi yang layak adalah sekurang-kurangnya 1.62m.";
                                    return false;
                                }
                                if (weight.HasValue && weight != 0 && weight < 47.5)
                                {
                                    message = "Berat anda tidak melayakkan anda memohon. Berat yang layak adalah melebihi 47.5kg.";
                                    return false;
                                }

                                if ((weight.HasValue && weight != 0) && (height.HasValue && height != 0))
                                {
                                    var bmi = weight / (height * height);
                                    if (bmi < 18 || bmi > 26.9)
                                    {
                                        message = "BMI anda tidak melayakkan anda memohon. BMI yang layak adalah diantara 18 dan 26.9.";
                                        return false;
                                    }
                                }
                            }
                            else
                            {
                                if (height.HasValue && height != 0 && (height < 1.62))
                                {
                                    message = "Tinggi anda tidak melayakkan anda memohon. Tinggi yang layak adalah sekurang-kurangnya 1.62m.";
                                    return false;
                                }
                                if (weight.HasValue && weight != 0 && weight < 47.5)
                                {
                                    message = "Berat anda tidak melayakkan anda memohon. Berat yang layak adalah melebihi 47.5kg.";
                                    return false;
                                }

                                if ((weight.HasValue && weight != 0) && (height.HasValue && height != 0))
                                {
                                    var bmi = weight / (height * height);
                                    if (bmi < 18 || bmi > 26.9)
                                    {
                                        message = "BMI anda tidak melayakkan anda memohon. BMI yang layak adalah diantara 18 dan 26.9.";
                                        return false;
                                    }
                                }
                            }

                        }

                        // TLDM
                        if (acqtype.ServiceCd == "02")
                        {
                            if (gendercode == "L")
                            {
                                if (height.HasValue && height != 0 && (height < 1.62))
                                {
                                    message = "Tinggi anda tidak melayakkan anda memohon. Tinggi yang layak adalah sekurang-kurangnya 1.62m.";
                                    return false;
                                }
                                if (weight.HasValue && weight != 0 && weight < 47.5)
                                {
                                    message = "Berat anda tidak melayakkan anda memohon. Berat yang layak adalah melebihi 47.5kg.";
                                    return false;
                                }

                                if ((weight.HasValue && weight != 0) && (height.HasValue && height != 0))
                                {
                                    var bmi = weight / (height * height);
                                    if (bmi < 18 || bmi > 25)
                                    {
                                        message = "BMI anda tidak melayakkan anda memohon. BMI yang layak adalah diantara 18 dan 25.";
                                        return false;
                                    }
                                }
                            }
                            else
                            {
                                if (height.HasValue && height != 0 && (height < 1.60))
                                {
                                    message = "Tinggi anda tidak melayakkan anda memohon. Tinggi yang layak adalah sekurang-kurangnya 1.60m.";
                                    return false;
                                }
                                if (weight.HasValue && weight != 0 && weight < 40.5)
                                {
                                    message = "Berat anda tidak melayakkan anda memohon. Berat yang layak adalah melebihi 40.5kg.";
                                    return false;
                                }

                                if ((weight.HasValue && weight != 0) && (height.HasValue && height != 0))
                                {
                                    var bmi = weight / (height * height);
                                    if (bmi < 18 || bmi > 23)
                                    {
                                        message = "BMI anda tidak melayakkan anda memohon. BMI yang layak adalah diantara 18 dan 23.";
                                        return false;
                                    }
                                }
                            }

                        }
                        // TUDM
                        if (acqtype.ServiceCd == "03")
                        {

                            if (gendercode == "L")
                            {
                                if (height.HasValue && height != 0 && (height < 1.62))
                                {
                                    message = "Tinggi anda tidak melayakkan anda memohon. Tinggi yang layak adalah sekurang-kurangnya 1.62m.";
                                    return false;
                                }
                                if (weight.HasValue && weight != 0 && weight < 47.5)
                                {
                                    message = "Berat anda tidak melayakkan anda memohon. Berat yang layak adalah melebihi 47.5kg.";
                                    return false;
                                }

                                if ((weight.HasValue && weight != 0) && (height.HasValue && height != 0))
                                {
                                    var bmi = weight / (height * height);
                                    if (bmi < 18 || bmi > 25)
                                    {
                                        message = "BMI anda tidak melayakkan anda memohon. BMI yang layak adalah diantara 18 dan 25.";
                                        return false;
                                    }
                                }
                            }
                            else
                            {
                                if (height.HasValue && height != 0 && (height < 1.57))
                                {
                                    message = "Tinggi anda tidak melayakkan anda memohon. Tinggi yang layak adalah sekurang-kurangnya 1.62m.";
                                    return false;
                                }
                                if (weight.HasValue && weight != 0 && weight < 40.5)
                                {
                                    message = "Berat anda tidak melayakkan anda memohon. Berat yang layak adalah melebihi 47.5kg.";
                                    return false;
                                }

                                if ((weight.HasValue && weight != 0) && (height.HasValue && height != 0))
                                {
                                    var bmi = weight / (height * height);
                                    if (bmi < 18 || bmi > 25)
                                    {
                                        message = "BMI anda tidak melayakkan anda memohon. BMI yang layak adalah diantara 18 dan 25.";
                                        return false;
                                    }
                                }
                            }
                        }

                        // Pegawai
                        if (acqtype.ServiceCd == "10")
                        {
                            if (gendercode == "L")
                            {
                                if (height.HasValue && height != 0 && (height < 1.62))
                                {
                                    message = "Tinggi anda tidak melayakkan anda memohon. Tinggi yang layak adalah sekurang-kurangnya 1.62m.";
                                    return false;
                                }
                                
                                if ((weight.HasValue && weight != 0) && (height.HasValue && height != 0))
                                {
                                    var bmi = weight / (height * height);
                                    if (bmi < 10 || bmi > 26.9)
                                    {
                                        message = "BMI anda tidak melayakkan anda memohon. BMI yang layak adalah tidak melebihi 26.9.";
                                        return false;
                                    }
                                }
                            }
                            else
                            {
                                if (height.HasValue && height != 0 && (height < 1.57))
                                {
                                    message = "Tinggi anda tidak melayakkan anda memohon. Tinggi yang layak adalah sekurang-kurangnya 1.57m.";
                                    return false;
                                }

                                if ((weight.HasValue && weight != 0) && (height.HasValue && height != 0))
                                {
                                    var bmi = weight / (height * height);
                                    if (bmi < 10 || bmi > 26.9)
                                    {
                                        message = "BMI anda tidak melayakkan anda memohon. BMI yang layak adalah tidak melebihi 26.9.";
                                        return false;
                                    }
                                }
                            }

                        }
                    }
                }
            }
            message = "Layak.";
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="applicantid"></param>
        /// <param name="acquisitionid"></param>
        /// <param name="peribadipoint">Peribadi</param>
        /// <param name="edupoint">Education</param>
        /// <param name="spopoint">Sponsorship</param>
        /// <param name="saspoint">Sport, Association and Skills</param>
        /// <param name="chpoint">Crime, Health</param>
        public static void Checklist(int applicantid, int acquisitionid, out decimal peribadipoint, out decimal edupoint, out decimal spopoint, out decimal saspoint, out decimal chpoint)
        {
            peribadipoint = 0.0m;
            edupoint = 0.0m;
            spopoint = 0.0m;
            saspoint = 0.0m;
            chpoint = 0.0m;
            var applicant = ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").GetApplicant(applicantid);
            var acq = ObjectBuilder.GetObject<IAcquisitionPersistence>("AcquisitionPersistence").GetAcquisition(acquisitionid);
            if (null == applicant || null == acq) return;

            var acqtype = ObjectBuilder.GetObject<IReferencePersistence>("ReferencePersistence").GetAcquisitionType(acq.AcquisitionTypeCd.Value);
            if (null == acqtype) return;

            var total = 0.0;
            var grandtotal = 0;

            grandtotal = grandtotal + 1;
            if (!string.IsNullOrWhiteSpace(applicant.MrtlStatusCd))
                total = total + 1;

            if (applicant.DadNotApplicable.HasValue && !applicant.DadNotApplicable.Value)
            {
                grandtotal = grandtotal + 3;
                if (!string.IsNullOrWhiteSpace(applicant.DadName))
                    total = total + 1;
                if (!string.IsNullOrWhiteSpace(applicant.DadICNo))
                    total = total + 1;
                if (!string.IsNullOrWhiteSpace(applicant.DadNationalityCd))
                    total = total + 1;
            }
            if (applicant.MomNotApplicable.HasValue && !applicant.MomNotApplicable.Value)
            {
                grandtotal = grandtotal + 3;
                if (!string.IsNullOrWhiteSpace(applicant.MomName))
                    total = total + 1;
                if (!string.IsNullOrWhiteSpace(applicant.MomICNo))
                    total = total + 1;
                if (!string.IsNullOrWhiteSpace(applicant.MomNationalityCd))
                    total = total + 1;
            }
            if (applicant.GuardianNotApplicable.HasValue && !applicant.GuardianNotApplicable.Value)
            {
                grandtotal = grandtotal + 3;
                if (!string.IsNullOrWhiteSpace(applicant.GuardianName))
                    total = total + 1;
                if (!string.IsNullOrWhiteSpace(applicant.GuardianICNo))
                    total = total + 1;
                if (!string.IsNullOrWhiteSpace(applicant.GuardianNationalityCd))
                    total = total + 1;
            }
            grandtotal = grandtotal + 10;
            if (!string.IsNullOrWhiteSpace(applicant.CorresponAddr1))
                total = total + 1;
            if (!string.IsNullOrWhiteSpace(applicant.CorresponAddrCityCd))
                total = total + 1;
            if (!string.IsNullOrWhiteSpace(applicant.CorresponAddrPostCd))
                total = total + 1;
            if (!string.IsNullOrWhiteSpace(applicant.CorresponAddrStateCd))
                total = total + 1;
            if (!string.IsNullOrWhiteSpace(applicant.CorresponAddrCountryCd))
                total = total + 1;
            if (!string.IsNullOrWhiteSpace(applicant.MobilePhoneNo))
                total = total + 1;
            if (!string.IsNullOrWhiteSpace(applicant.NationalityCd))
                total = total + 1;
            if (!string.IsNullOrWhiteSpace(applicant.BirthCountryCd))
                total = total + 1;
            if (applicant.Height.HasValue && applicant.Height != 0)
                total = total + 1;
            if (applicant.Weight.HasValue && applicant.Weight != 0)
                total = total + 1;

            if (acqtype.ServiceCd != "01")
            {
                grandtotal = grandtotal + 2;
                if (!string.IsNullOrWhiteSpace(applicant.ReligionCd))
                    total = total + 1;
                if (!string.IsNullOrWhiteSpace(applicant.RaceCd))
                    total = total + 1;
            }

            peribadipoint = Convert.ToDecimal((total / grandtotal) * 100);

            // educations
            var totaledu = 0.0;
            var totaledus = 3;
            var edus = ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").GetEducation(applicantid);
            if (null != edus)
            {
                var applicantEducations = edus as ApplicantEducation[] ?? edus.ToArray();
                totaledu = applicantEducations.Where(ed => ed.HighEduLevelCd == "14").Aggregate(totaledu, (current1, ed) => ed.ApplicantEduSubjectCollection.Take(3).Where(s => !string.IsNullOrWhiteSpace(s.GradeCd)).Aggregate(current1, (current, s) => current + 1));

                if (acq.AcquisitionType != null)
                {
                    // if pegawai.. check for sarjana muda
                    if (acq.AcquisitionType.ServiceCd == "10")
                    {
                        totaledus = totaledus + 1;
                        var sarjana = applicantEducations.SingleOrDefault(a => a.HighEduLevelCd == "08");
                        if (null != sarjana)
                        {
                            if (!string.IsNullOrWhiteSpace(sarjana.OverallGrade))
                            {
                                // parse the value as decimal
                                decimal pointer = 0.0m;
                                decimal.TryParse(sarjana.OverallGrade,out pointer);
                                if (pointer >= (decimal) 2.7)
                                    totaledu = totaledu + 1;
                            }
                        }
                    }
                }
            }
            edupoint = Convert.ToDecimal((totaledu / totaledus) * 100);

            var totalsponsor = 0;
            var totalselected = 0.0;
            // penajaan dan biasiswa
            if (applicant.PalapesInd.HasValue)
            {
                if (applicant.PalapesInd.Value)
                {
                    totalsponsor = totalsponsor + 5;
                    if (!string.IsNullOrWhiteSpace(applicant.PalapesArmyNo)) totalselected = totalselected + 1;
                    if (!string.IsNullOrWhiteSpace(applicant.PalapesInstitution)) totalselected = totalselected + 1;
                    if (!string.IsNullOrWhiteSpace(applicant.PalapesServices)) totalselected = totalselected + 1;
                    if (applicant.PalapesTauliahEndDt.HasValue) totalselected = totalselected + 1;
                    if (applicant.PalapesYear != 0) totalselected = totalselected + 1;
                }
                else
                {
                    totalsponsor = totalsponsor + 1;
                    totalselected = totalselected + 1;
                }
            }
            else
            {
                totalsponsor = totalsponsor + 1;
                totalselected = totalselected + 0;
            }

            if (applicant.ScholarshipInd.HasValue)
            {
                if (applicant.ScholarshipInd.Value)
                {
                    totalsponsor = totalsponsor + 4;
                    if (!string.IsNullOrWhiteSpace(applicant.ScholarshipBody)) totalselected = totalselected + 1;
                    if (!string.IsNullOrWhiteSpace(applicant.ScholarshipBodyAddr))
                        totalselected = totalselected + 1;
                    if (!string.IsNullOrWhiteSpace(applicant.ScholarshipNoOfYrContract))
                        totalselected = totalselected + 1;
                    if (applicant.ScholarshipContractStDate.HasValue) totalselected = totalselected + 1;
                }
                else
                {
                    totalsponsor = totalsponsor + 1;
                    totalselected = totalselected + 1;
                }
            }
            else
            {
                totalsponsor = totalsponsor + 1;
                totalselected = totalselected + 0;
            }

            if (applicant.EmployeeAggreeInd.HasValue)
            {
                if (applicant.EmployeeAggreeInd.Value)
                {
                    totalsponsor = totalsponsor + 1;
                    if (!string.IsNullOrWhiteSpace(applicant.PelepasanDocument)) totalselected = totalselected + 1;
                }
                else
                {
                    totalsponsor = totalsponsor + 1;
                    totalselected = totalselected + 1;
                }
            }
            else
            {
                totalsponsor = totalsponsor + 1;
                totalselected = totalselected + 0;
            }

            if (applicant.ArmySelectionInd.HasValue)
            {
                if (applicant.ArmySelectionInd.Value)
                {
                    totalsponsor = totalsponsor + 2;
                    if (applicant.ArmySelectionDt.HasValue) totalselected = totalselected + 1;
                    if (!string.IsNullOrWhiteSpace(applicant.ArmySelectionVenue)) totalselected = totalselected + 1;
                }
                else
                {
                    totalsponsor = totalsponsor + 1;
                    totalselected = totalselected + 1;
                }
            }
            else
            {
                totalsponsor = totalsponsor + 1;
                totalselected = totalselected + 0;
            }

            if (totalsponsor == 0 && totalselected == 0)
                spopoint = 0.0m;
            else
                spopoint = Convert.ToDecimal((totalselected / totalsponsor) * 100);

            // Sukan/Badan Beruniform dan Kemahiran
            var totals = 0.0;

            var sps = ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").GetSport(applicantid);
            if (null != sps && sps.Any())
            {
                var sports =
                    sps.Where(a => a.SportAndAssociation != null && a.SportAndAssociation.SportAssociatType == "S");
                totals = totals + sports.Count();
                var kokos =
                    sps.Where(a => a.SportAndAssociation != null && a.SportAndAssociation.SportAssociatType == "A");
                totals = totals + kokos.Count();
            }

            var skills = ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence")
                .GetSkill(applicantid);
            if (null != skills && skills.Any())
                totals = totals + skills.Count();

            saspoint = Convert.ToDecimal((totals / 6) * 100);

            var totalchd = 0;
            var totalchdselected = 0;
            if (applicant.CrimeInvolvement.HasValue)
            {
                totalchd = totalchd + 1;
                totalchdselected = totalchdselected + 1;
            }
            else
            {
                totalchd = totalchd + 1;
                totalchdselected = totalchdselected + 0;
            }

            if (applicant.DrugCaseInvolvement.HasValue)
            {
                totalchd = totalchd + 1;
                totalchdselected = totalchdselected + 1;
            }
            else
            {
                totalchd = totalchd + 1;
                totalchdselected = totalchdselected + 0;
            }

            if (applicant.CronicIlnessInd.HasValue)
            {
                totalchd = totalchd + 1;
                totalchdselected = totalchdselected + 1;
            }
            else
            {
                totalchd = totalchd + 1;
                totalchdselected = totalchdselected + 0;
            }

            chpoint = Convert.ToDecimal((totalchdselected / totalchd) * 100);
        }

    }
}