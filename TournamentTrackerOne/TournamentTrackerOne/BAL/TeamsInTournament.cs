using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTrackerOne.BAL
{
    class TeamsInTournament
    {
        // Properties As Members //
        public string teamsInTournamentID { set; get; }
        public string teamID { set { TeamID = value; } get { return TeamID; } }

        
        // Data Members //
        private string TeamID;


        // From Team Class //
        Team team = new Team();

        
        // Constructor //
        public TeamsInTournament(string titID)
        {
            teamsInTournamentID = titID;
            teamID = team.teamID;
        }

        public TeamsInTournament()
        {

        }

    }
}
