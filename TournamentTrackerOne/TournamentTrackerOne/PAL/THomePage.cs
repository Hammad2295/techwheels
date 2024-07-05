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
    public partial class THomePage : Form
    {
        public THomePage()
        {
            InitializeComponent();
        }

        private void btnTSignUp_Click(object sender, EventArgs e)
        {
            NewTournament obj = new NewTournament();
            obj.Show();
            this.Hide();
        }

        private void btnTLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrackTournament trackTournament = new TrackTournament();
            trackTournament.Show();
            this.Hide();
        }
    }
}
