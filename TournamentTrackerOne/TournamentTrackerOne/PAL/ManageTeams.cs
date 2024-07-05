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
    public partial class ManageTeams : Form
    {
        public ManageTeams()
        {
            InitializeComponent();
        }

        private void btnManageCaptain_Click(object sender, EventArgs e)
        {
            ManageCaptain obj = new ManageCaptain();

            obj.Show();
            this.Hide();
        }

        private void btnManageCoach_Click(object sender, EventArgs e)
        {
            ManageCoach obj = new ManageCoach();

            obj.Show();
            this.Hide();
        }

        private void btnAddTeams_Click(object sender, EventArgs e)
        {
            AddTeams obj = new AddTeams();
            obj.Show();
            this.Hide();
        }

        private void btnDeleteTeams_Click(object sender, EventArgs e)
        {
            DeleteTeam obj = new DeleteTeam();

            obj.Show();
            this.Hide();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            AddPlayer player = new AddPlayer();

            player.Show();
            this.Hide();
        }

        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            DeletePlayer obj = new DeletePlayer();
            obj.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            NewTournament newTournament = new NewTournament();
            newTournament.Show();
            this.Hide();
        }
    }
}
