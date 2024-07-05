using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTrackerOne.BAL
{
    class TournamentOwner : Person
    {
        public string tournamentID { set; get; }
        public string username { set; get; }
        public string password { set; get; }


        // Constructor //
        public TournamentOwner(string tID, string fn, string ln, string em, string add, string cn, string us, string ps) : base (fn, ln, em, add, cn)
        {
            tournamentID = tID;
            username = us;
            password = ps;
        }

        public TournamentOwner()
        {

        }
    }
}
