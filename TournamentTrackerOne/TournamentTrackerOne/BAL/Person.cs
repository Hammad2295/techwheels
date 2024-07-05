using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTrackerOne.BAL
{
    class Person
    {
        // Data Members using Properties //
        public string firstName { set; get; }
        public string lastName { set; get; }
        public string email { set; get; }
        public string address { set; get; }
        public string contactNo { set; get; }


        // Constructor //
        public Person(string fn, string ln, string em, string add, string cn)
        {  
            firstName = fn;
            lastName = ln;
            email = em;
            address = add;
            contactNo = cn;
        }

        public Person()
        {

        }
    }
}
