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
    public partial class AddPrice : Form
    {
        public AddPrice()
        {
            InitializeComponent();
        }

        private void btnAddPriceRd_Click(object sender, EventArgs e)
        {


            string tID = cmbTournamentsIDs.Text;

            double totalAmount = Convert.ToDouble(txtTotalAmount.Text);
            double winnerPercent = (Convert.ToDouble(txtPercentWinner.Text) / 100) * totalAmount;
            totalAmount -= winnerPercent;
            double runnerPercent = (Convert.ToDouble(txtPercentRunner.Text) / 100) * totalAmount;

            try
            {
                DatabaseQueries.AddPriceRecord(tID, Convert.ToString(winnerPercent), Convert.ToString(runnerPercent));
                MessageBox.Show("Price Added Successfully!!", "Message");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Price NOT Added!!", "Error");
            }
            
        }

        private void btnLoadTIDs_Click(object sender, EventArgs e)
        {
            SqlDataReader myReader = DatabaseQueries.GetTournamentIDs();

            while (myReader.Read())
            {
                string tID = myReader["Tournament_ID"].ToString();
                cmbTournamentsIDs.Items.Add(tID);
            }
        }
    }
}
