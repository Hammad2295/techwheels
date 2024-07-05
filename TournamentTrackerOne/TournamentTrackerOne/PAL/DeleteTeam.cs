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
    public partial class DeleteTeam : Form
    {
        public DeleteTeam()
        {
            InitializeComponent();
        }

        private void DeleteTeam_Load(object sender, EventArgs e)
        {
            SqlDataReader myReader = DatabaseQueries.GetTeamIDs();

            while (myReader.Read())
            {
                string tIDs = myReader["Team_ID"].ToString();
                cmbTeamIDs.Items.Add(tIDs);
            }
        }

        private void btnDeleteTeamRd_Click(object sender, EventArgs e)
        {
            string tID = cmbTeamIDs.Text;

            if (MessageBox.Show("Are you Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {  
                DatabaseQueries.DeleteTeamRecord(tID);
                MessageBox.Show("Record Deleted Successfully!!", "Message");
            }
            else
            {
                MessageBox.Show("Record NOT Deleted!!", "Message");
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
