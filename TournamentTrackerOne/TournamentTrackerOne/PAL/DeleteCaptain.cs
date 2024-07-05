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
using TournamentTrackerOne.BAL;


namespace TournamentTrackerOne.PAL
{
    public partial class DeleteCaptain : Form
    {
        public DeleteCaptain()
        {
            InitializeComponent();
        }

        private void DeleteCaptain_Load(object sender, EventArgs e)
        {
            
        }

        private void btnloadCapids_Click(object sender, EventArgs e)
        {
            SqlDataReader myReader = DatabaseQueries.GetCaptainIDs();

            while (myReader.Read())
            {
                string capIDs = myReader["Captain_ID"].ToString();
                cmbCapIDs.Items.Add(capIDs);
            }
        }

        private void btnDeleteCaptainRd_Click(object sender, EventArgs e)
        {
            string capIDs = cmbCapIDs.Text;

            if (MessageBox.Show("Are you Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                DatabaseQueries.DeleteCaptainRecord(capIDs);
                MessageBox.Show("Record Deleted Successfully!!", "Message");
            }
            else
            {
                MessageBox.Show("Record NOT Deleted!!", "Message");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
