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
    public partial class TrackTournament : Form
    {
        public TrackTournament()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTTClose_Click(object sender, EventArgs e)
        {
            THomePage homePage = new THomePage();
            homePage.Show();
            this.Hide();
        }

        private void btnTrackScore_Click(object sender, EventArgs e)
        {
            TrackerScore tracker = new TrackerScore();
            tracker.Show();

            this.Hide();
        }
    }
}
