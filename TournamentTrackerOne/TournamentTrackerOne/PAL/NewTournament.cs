using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TournamentTrackerOne.BAL;
using TournamentTrackerOne.DAL;


namespace TournamentTrackerOne.PAL
{
    public partial class NewTournament : Form
    {

        public static string TID {set; get;}

        public NewTournament()
        {
            InitializeComponent();
        }

        private void btnManageTeams_Click(object sender, EventArgs e)
        {
            ManageTeams obj = new ManageTeams();
            obj.Show();
            this.Hide();
        }

        private void NewTournament_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddTournamentRd_Click(object sender, EventArgs e)
        {
 

            string toId = TLogin.ID;
            string tId = txtTournamentID.Text;
            string tTitle = txtTournamentTitle.Text;
            string startDate = dtpStartDate.Text;
            string endDate = dtpEndDate.Text;
            string tLocation = txtLocation.Text;

            TID = TID;

            

            Tournaments obj2 = new Tournaments(tId, toId, tTitle, startDate, endDate, tLocation);

            try
            {
                DatabaseQueries.addTournamentRecord(obj2);
                MessageBox.Show("Tournament Added Successfully!!", "Message");
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Tournament NOT Added", "Error");
            }

        }

        private void btnManagePrice_Click(object sender, EventArgs e)
        {
            ManagePrice obj = new ManagePrice();

            obj.Show();
            this.Hide();
        }

        private void btnMM_Click(object sender, EventArgs e)
        {
            MatchMaking obj = new MatchMaking();

            obj.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            THomePage homePage = new THomePage();

            homePage.Show();
            this.Hide();
        }
    }
}
