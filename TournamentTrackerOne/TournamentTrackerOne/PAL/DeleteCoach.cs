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
    public partial class DeleteCoach : Form
    {
        public DeleteCoach()
        {
            InitializeComponent();
        }

        private void btnLoadCchIDs_Click(object sender, EventArgs e)
        {
            SqlDataReader myReader = DatabaseQueries.GetCoachIDs();

            while (myReader.Read())
            {
                string cchIDs = myReader["Coach_ID"].ToString();
                cmbCchIDs.Items.Add(cchIDs);
            }
        }

        private void btnDeleteCoachRd_Click(object sender, EventArgs e)
        {
            string cchIDs = cmbCchIDs.Text;

            if (MessageBox.Show("Are you Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DatabaseQueries.DeleteCoachRecord(cchIDs);
                MessageBox.Show("Record Deleted Successfully!!", "Message");
            }
            else
            {
                MessageBox.Show("Record NOT Deleted!!", "Message");
            }
        }
    }
}
