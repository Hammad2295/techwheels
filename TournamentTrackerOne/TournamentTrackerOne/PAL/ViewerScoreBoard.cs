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
    public partial class ViewerScoreBoard : Form
    {
        public ViewerScoreBoard()
        {
            InitializeComponent();
        }

        private void ViewerScoreBoard_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = DatabaseQueries.GetTournamentIDMM();
            while (reader.Read())
            {
                string MatchID = reader["Tournament_ID"].ToString();
                cmbMatchID.Items.Add(MatchID);
            }
        }

        private void cmbMatchID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = Convert.ToString(cmbMatchID.SelectedItem);

            SqlDataReader reader = DatabaseQueries.GetRoundsFromTournament(a);
            while (reader.Read())
            {
                string MatchID = reader["RoundNo"].ToString();
                cmbRound.Items.Add(MatchID);
            }
        }

        private void cmbRound_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = Convert.ToString(cmbRound.SelectedItem);

            SqlDataReader reader = DatabaseQueries.GetMatchesFromRounds(a);
            while (reader.Read())
            {
                string MatchID = reader["MatchNo"].ToString();
                cmbMatches.Items.Add(MatchID);
            }
        }

        private void cmbMatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MID = Convert.ToString((cmbMatches.SelectedItem));

            SqlDataReader myreader = DatabaseQueries.GetScoreFromMatches(MID);
            while (myreader.Read())
            {
                txtWinningPrice.Text = myreader["WinnerPrice"].ToString();
                txtWinningTeamID.Text = myreader["TeamWinnerID"].ToString();
            }
        }

        private void btnViewPlayer_Click(object sender, EventArgs e)
        {
            ViewPlayers viewPlayers = new ViewPlayers();
            viewPlayers.Show();
            this.Hide();
        }

        private void lblMatchID_Click(object sender, EventArgs e)
        {

        }

        private void btnViewTeam_Click(object sender, EventArgs e)
        {
            ShoowTeamsinScore showTeam = new ShoowTeamsinScore();
            showTeam.Show();
            this.Hide();
        }

        private void btnTTClose_Click(object sender, EventArgs e)
        {
            TournamentTracker tournamentTracker = new TournamentTracker();
            tournamentTracker.Show();
            this.Hide();
        }
    }
}
