using System.Collections.Generic;
using SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Atm.Web.Models
{
    public class StatisticViewModel
    {
        private List<ApplicantSubmitted> m_listOfApplicant = new List<ApplicantSubmitted>();
        private List<State> m_listOfState = new List<State>();
        private Acquisition m_acquisition = new Acquisition();
        private List<Race> m_listOfRace = new List<Race>();
        private List<Ethnic> m_listOfEthnic = new List<Ethnic>();
        private Race m_race = new Race();
        private List<HighEduLevel> m_highEduLevel = new List<HighEduLevel>();
        private List<Religion> m_listOfReligion = new List<Religion>();

        public List<Religion> ListOfReligion
        {
            get { return m_listOfReligion; }
            set { m_listOfReligion = value; }
        }


        public List<HighEduLevel> ListOfHighEduLevel
        {
            get { return m_highEduLevel; }
            set { m_highEduLevel = value; }
        }


        public Race Race
        {
            get { return m_race; }
            set { m_race = value; }
        }


        public List<Ethnic> ListOfEthnic
        {
            get { return m_listOfEthnic; }
            set { m_listOfEthnic = value; }
        }

        
        public List<Race> ListOfRace
        {
            get { return m_listOfRace; }
            set { m_listOfRace = value; }
        }

        public Acquisition Acquisition
        {
            get { return m_acquisition; }
            set { m_acquisition = value; }
        }


        public List<State> ListOfState
        {
            get { return m_listOfState; }
            set { m_listOfState = value; }
        }

        public List<ApplicantSubmitted> ListOfApplicant
        {
            get { return m_listOfApplicant; }
            set { m_listOfApplicant = value; }
        }

    }
}