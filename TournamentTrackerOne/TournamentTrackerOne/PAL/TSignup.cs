using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TournamentTrackerOne.BAL;
using TournamentTrackerOne.DAL;

using System.Data.SqlClient;

namespace TournamentTrackerOne.PAL
{
    public partial class TSignup : Form
    {
        public TSignup()
        {
            InitializeComponent();
        }

        private void btnTSignUp_Click(object sender, EventArgs e)
        {
            string tO_ID = txtTOwnerID.Text;
            string firstName = txtTFirstName.Text;
            string lastName = txtTLastName.Text;
            string email = txtTEmail.Text;
            string address = txtTAddress.Text;
            string contactNo = txtTContactNo.Text;
            string userName = txtTUsername.Text;
            string password = txtTPassword.Text;

            TournamentOwner obj = new TournamentOwner(tO_ID, firstName, lastName, email, address, contactNo, userName, password);

            
            try
            {
                DatabaseQueries.TOwnerSignUp(obj);
                MessageBox.Show("Sign-Up Successful!!Login to Continue", "Message");

                this.Hide();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Sign-Up Failed!!", "Error");
            }
        }
    }
}
