using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTrackerOne.BAL
{
    class MatchMaking
    {
        // Data Members //
        public string Tournament_ID { set; get; }
        public string RoundNo { set; get; }
        public string MatchNo { set; get; }
        public string TeamA { set; get; }
        public string TeamB { set; get; }
        public string ScoreA { set; get; }
        public string ScoreB { set; get; }



        // Constructor //
        public MatchMaking(string tID, string rn, string mh, string ta, string tb, string sa, string sb)
        {
            Tournament_ID = tID;
            RoundNo = rn;
            MatchNo = mh;
            TeamA = ta;
            TeamB = tb;
            ScoreA = sa;
            ScoreB = sb;
        }

    }
}
