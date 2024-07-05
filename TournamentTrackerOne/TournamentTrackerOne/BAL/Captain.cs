using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTrackerOne.BAL
{
    class Captain : Person
    {
        // Data Members //
        public string captainID { set; get; }

        // Constructor //
        public Captain()
        {
            captainID = null;
        }

        public Captain(string capID, string fn, string ln, string em, string add, string cn) : base(fn, ln, em, add, cn)
        {
            captainID = capID;
        }

        
    }
}
