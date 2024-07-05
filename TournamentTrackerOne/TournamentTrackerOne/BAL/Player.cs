using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTrackerOne.BAL
{
    class Player : Person
    {

        // Data Members //
        public string playerID { set; get; }
        public string playerExp { set; get; }
        public string playerScore { set; get; }
        public string playerDescription { set; get; }
        public string playerStatus { set; get; }
        public string playerTeamID { set; get; }


        // Constructor //
        public Player(string pID, string fn, string ln, string em, string add, string cn, string exp, string score, string descrip, string status, string pTeamID) : base (fn, ln, em, add, cn)
        {
            playerID = pID;
            playerExp = exp;
            playerScore = score;
            playerDescription = descrip;
            playerStatus = status;
            playerTeamID = pTeamID;
        }

    }
}
