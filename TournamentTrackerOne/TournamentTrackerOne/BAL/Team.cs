using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTrackerOne.BAL
{
    class Team 
    {
        // Properties As Members //
        public string teamID { set; get; }
        public string teamName { set; get; }

        public string captainID { set { CaptainID = value; } get { return CaptainID; } }
        public string coachID { set { CoachID = value; } get { return CoachID; } }


        // Data Members //
        public string CaptainID;
        public string CoachID;


        // From Other Classes //
        Captain captain = new Captain();
        Coach coach = new Coach();
        
        
        
        // Constructors //
        public Team(string teamID, string teamName, string capID, string cchID)
        {
            this.teamID = teamID;
            this.teamName = teamName;
            //captainID = captain.captainID;
            captainID = capID;
            //coachID = coach.coachID;
            coachID = cchID;
        }

        public Team()
        {

        }

    }
}
