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
    public partial class AddCoach : Form
    {
        public AddCoach()
        {
            InitializeComponent();
        }

        private void btnAddCoachRd_Click(object sender, EventArgs e)
        {
            string cchID = txtCoachID.Text;
            string cchFn = txtCchFirstName.Text;
            string cchLn = txtCchLastName.Text;
            string cchEmail = txtCchEmail.Text;
            string cchAddress = txtCchAddress.Text;
            string cchCn = txtCchContactNo.Text;

            Coach coach = new Coach(cchID, cchFn, cchLn, cchEmail, cchAddress, cchCn);

            try
            {
                DatabaseQueries.AddCoachRecord(coach);
                MessageBox.Show("Coach Record Added Successfully!!", "Message");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Coach Record NOT Added!!", "Error");
            }
        }
    }
}
