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
    public partial class VLoginSignup : Form
    {
        public VLoginSignup()
        {
            InitializeComponent();
        }

        private void btnVLogin_Click(object sender, EventArgs e)
        {
            VLogin vLogin = new VLogin();
            vLogin.Show();
            this.Hide();
        }

        private void btnVSignup_Click(object sender, EventArgs e)
        {

        }
    }
}
