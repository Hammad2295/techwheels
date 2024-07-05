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
    public partial class AddCaptain : Form
    {
        public AddCaptain()
        {
            InitializeComponent();
        }

        private void AddCaptain_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCaptainRd_Click(object sender, EventArgs e)
        {
            string capID = txtCaptainID.Text;
            string capFn = txtCapFirstName.Text;
            string capLn = txtCapLastName.Text;
            string capEmail = txtCapEmail.Text;
            string capAddress = txtCapAddress.Text;
            string capCn = txtCapContactNo.Text;

            Captain captain = new Captain(capID, capFn, capLn, capEmail, capAddress, capCn);

            try
            {
                DatabaseQueries.AddCaptainRecord(captain);
                MessageBox.Show("Captain Added Successfully!!", "Message");
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Captain NOT Added!!", "Error");
            }
        }
    }
}
