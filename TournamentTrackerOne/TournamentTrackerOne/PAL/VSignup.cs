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

namespace TournamentTrackerOne.PAL
{
    public partial class VSignup : Form
    {
        public VSignup()
        {
            InitializeComponent();
        }

        private void btnVSignUp_Click(object sender, EventArgs e)
        {
            string tO_ID = txtViewerID.Text;
            string firstName = txtVFirstName.Text;
            string lastName = txtVLastName.Text;
            string email = txtVEmail.Text;
            string address = txtVAddress.Text;
            string contactNo = txtVContactNo.Text;
            string userName = txtVUsername.Text;
            string password = txtVPassword.Text;

            Viewer obj = new Viewer(tO_ID, firstName, lastName, email, address, contactNo, userName, password);


            try
            {
                DatabaseQueries.AddViewerRecord(obj);
                MessageBox.Show("Sign-Up Successful!!Login to Continue", "Message");

                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sign-Up Failed!!", "Error");
            }
        }
    }
}
