using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TournamentTrackerOne.PAL
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            if (txtAdminUsername.Text == "Admin" && txtAdminPass.Text == "admin123")
            {
                TournamentTracker tMain = new TournamentTracker();
                tMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Un-Successful!!", "Error");
            }
        }

        private void picExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
