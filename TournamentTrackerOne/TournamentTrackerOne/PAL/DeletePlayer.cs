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
    public partial class DeletePlayer : Form
    {
        public DeletePlayer()
        {
            InitializeComponent();
        }

        private void DeletePlayer_Load(object sender, EventArgs e)
        {
            SqlDataReader myReader = DatabaseQueries.GetPlayerIDs();

            while (myReader.Read())
            {
                string pIDs = myReader["Player_ID"].ToString();
                cmbPlayerIDs.Items.Add(pIDs);
            }
        }

        private void btnDeletePlayerRd_Click(object sender, EventArgs e)
        {
            string pID = cmbPlayerIDs.Text;

            if (MessageBox.Show("Are you Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DatabaseQueries.DeletePlayerRecord(pID);
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
