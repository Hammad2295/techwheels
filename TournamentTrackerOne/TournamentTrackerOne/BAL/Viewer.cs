using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTrackerOne.BAL
{
    class Viewer : Person
    {
        // Data Members //
        public string ViewerID { set; get; }
        public string username { set; get; }
        public string password { set; get; }


        // Constrcutor //
        public Viewer(string ViewerID, string firstName, string lastName, string email, string address, string contactNo, string username, string password) : base(firstName, lastName, email, address, contactNo)
        {
            this.ViewerID = ViewerID;
            this.username = username;
            this.password = password;
        }
    }
}
