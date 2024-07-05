using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TournamentTrackerOne.PAL;
using TournamentTrackerOne.BAL;
using TournamentTrackerOne.DAL;

namespace TournamentTrackerOne.PAL
{
    public partial class TLoginSignup : Form
    {
        public TLoginSignup()
        {
            InitializeComponent();
        }

        private void btnTLogin_Click(object sender, EventArgs e)
        {
            TLogin obj = new TLogin();
            obj.Show();
            this.Hide();
        }

        private void btnTSignup_Click(object sender, EventArgs e)
        {
            TSignup obj = new TSignup();
            obj.Show();
            this.Hide();
        }
    }
}
