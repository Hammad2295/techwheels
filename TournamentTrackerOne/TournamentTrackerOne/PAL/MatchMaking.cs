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
using TournamentTrackerOne.DAL;

namespace TournamentTrackerOne.PAL
{
    public partial class MatchMaking : Form
    {
        public MatchMaking()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MatchMaking_Load(object sender, EventArgs e)
        {
           string x = TLogin.ID;
           string abc = DatabaseQueries.GetTournamentIDsMM(x);

            if(abc == null)
            {
                MessageBox.Show("Add Teams First!!", "Error");
            }
            else
            {
                cmbTIDs.Items.Add(abc);
            }
            


            SqlDataReader myReader = DatabaseQueries.GetTeamIDsTIT();

            while (myReader.Read())
            {
                string tIDs = myReader["Team_ID"].ToString();
               cmbTeamA.Items.Add(tIDs);
               cmbTeamB.Items.Add(tIDs);
            }

        }

        private void btnPlayMatch_Click(object sender, EventArgs e)
        {
            string tID = Convert.ToString(cmbTIDs.SelectedItem);
            string rn = txtAddRound.Text;
            string mc = txtAddMatch.Text;
            string ta = cmbTeamA.Text;
            string tb = cmbTeamB.Text;
            string sa = txtTeamAScore.Text;
            string sb = txtTeamBScore.Text;

            int sA = int.Parse(sa);
            int sB = int.Parse(sb);

            string teamWID = null;
            string teamRID = null;

            if (sA >= sB)
            {
                teamWID = ta;
                teamRID = tb;
            }
            else
            {
                teamWID = tb;
                teamRID = ta;
            }

            string winnerPrice = DatabaseQueries.GetWinnerPrice(tID);
            string runnerPrice = DatabaseQueries.GetRunnerupPrice(tID);



            DatabaseQueries.AddInWinner(mc, teamWID, winnerPrice);

            DatabaseQueries.AddInRunnerup(mc, teamRID, runnerPrice);

            BAL.MatchMaking obj = new BAL.MatchMaking(tID, rn, mc, ta, tb, sa, sb);
            try
            {
                DatabaseQueries.AddMatchMakingRecord(obj);
                MessageBox.Show("Record Added Successfully!!", "Message");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Record NOT Added!!", "Error");
            }
        }

        private void cmbTIDs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            NewTournament newTournament = new NewTournament();
            newTournament.Show();
            this.Hide();
        }
    }
}
