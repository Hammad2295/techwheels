using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTrackerOne.BAL
{
    class Coach : Person
    {
        // Data Members //
        public string coachID { set; get; }


        // Constructor 
        public Coach(string coachID, string fn, string ln, string em, string add, string cn) : base(fn, ln, em, add, cn)
        {
            this.coachID = coachID;
        }

        public Coach()
        {
            coachID = null; 
        }
    }
}
