using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTrackerOne.BAL
{
    class Tournaments
    {
        // Properties As Members //
        public string tournamentID { set; get; }
        public string tournamentOwnerID { set { TournamentOwnerID = value; } get { return TournamentOwnerID; } }
        public string tournamentTitle { set; get; }
        public string startDate { set; get; }
        public string endDate { set; get; }
        public string location { set; get; }


        // Data Members //
        private string TournamentOwnerID;


        // Other Classes //
        TournamentOwner owner = new TournamentOwner();


        // Constructor //
        public Tournaments(string tID, string tournamentOwnerID, string title, string sDate, string eDate, string location)
        {
            this.tournamentID = tID;
            this.tournamentOwnerID = tournamentOwnerID;
            this.tournamentTitle = title;
            this.startDate = sDate;
            this.endDate = eDate;
            this.location = location;
        }

        public Tournaments()
        {
                
        }

    }
}
