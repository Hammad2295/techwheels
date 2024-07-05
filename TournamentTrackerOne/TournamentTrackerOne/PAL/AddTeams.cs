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
    public partial class AddTeams : Form
    {
        public AddTeams()
        {
            InitializeComponent();
        }

        private void btnAddTeamRd_Click(object sender, EventArgs e)
        {
            string teamID = txtTeamID.Text;
            string teamName = txtTeamName.Text;
            string capID = cmbCapIDs.Text;
            string cchID = cmbCchIDs.Text;

            Team obj = new Team(teamID, teamName, capID, cchID);

            try
            {
                DatabaseQueries.AddTeamRecord(obj);
                MessageBox.Show("Team Added Successfully!!", "Message");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Team NOT Added!!", "Error");
            }

            string x = TLogin.ID;
            string abc = DatabaseQueries.GetTournamentIDsMM(x);

            DatabaseQueries.addRdTiT(teamID, abc);

        }

        private void AddTeams_Load(object sender, EventArgs e)
        {
            SqlDataReader myReader = DatabaseQueries.GetCaptainIDs();

            while (myReader.Read())
            {
                string capIDs = myReader["Captain_ID"].ToString();
                cmbCapIDs.Items.Add(capIDs);
            }

            SqlDataReader myReader2 = DatabaseQueries.GetCoachIDs();

            while (myReader2.Read())
            {
                string cchIDs = myReader2["Coach_ID"].ToString();
                cmbCchIDs.Items.Add(cchIDs);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            NewTournament newTournament = new NewTournament();
            newTournament.Show();
            this.Hide();
        }
    }
}
