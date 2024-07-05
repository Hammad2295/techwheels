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
using TournamentTrackerOne.DAL;

namespace TournamentTrackerOne.PAL
{
    public partial class ViewPlayers : Form
    {
        public ViewPlayers()
        {
            InitializeComponent();
        }

        private void ViewPlayers_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = DatabaseQueries.GetTeamIDTracker();
            while (reader.Read())
            {
                string Team_ID = reader["Team_ID"].ToString();

                cmbTeams.Items.Add(Team_ID);

            }
        }

        private void cmbTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = cmbTeams.Text;



            DataSet ds = DatabaseQueries.GetDataThroughDataAdaptor(a);
            grdPlayer.DataSource = ds.Tables["ProjectTestFour"];
        }

        private void btnTTClose_Click(object sender, EventArgs e)
        {
            ViewerScoreBoard viewerScoreBoard = new ViewerScoreBoard();

            viewerScoreBoard.Show();

            this.Hide();
        }
    }
}
