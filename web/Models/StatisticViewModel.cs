using System.Collections.Generic;
using SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Atm.Web.Models
{
    public class StatisticViewModel
    {
        public List<Religion> ListOfReligion { get; set; } = new List<Religion>();


        public List<HighEduLevel> ListOfHighEduLevel { get; set; } = new List<HighEduLevel>();


        public Race Race { get; set; } = new Race();


        public List<Ethnic> ListOfEthnic { get; set; } = new List<Ethnic>();


        public List<Race> ListOfRace { get; set; } = new List<Race>();

        public Acquisition Acquisition { get; set; } = new Acquisition();


        public List<State> ListOfState { get; set; } = new List<State>();

        public List<ApplicantSubmitted> ListOfApplicant { get; set; } = new List<ApplicantSubmitted>();
    }
}