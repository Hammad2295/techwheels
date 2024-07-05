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
    public partial class AddPlayer : Form
    {
        public AddPlayer()
        {
            InitializeComponent();
        }

        private void btnAddPlayerRd_Click(object sender, EventArgs e)
        {
            string pID = txtPlayerID.Text;
            string firstName = txtPlayerFirstName.Text;
            string lastName = txtPlayerLastName.Text;
            string email = txtPlayerEmail.Text;
            string address = txtPlayerAddress.Text;
            string contactNo = txtPlayerContactNo.Text;
            string exp = txtPlayerExp.Text;
            string score = txtPlayerScore.Text;
            string description = txtPlayerDescription.Text;
            string status = txtPlayerStatus.Text;
            string teamID = cmbTeamIDs.Text;


            Player player = new Player(pID, firstName,lastName, email, address, contactNo, exp, score, description, status, teamID);


            try
            {
                DatabaseQueries.AddPlayerRecord(player);
                MessageBox.Show("Player Added Successfully!!", "Message");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Player NOT Added!!", "Error");
            }

        }

        private void AddPlayer_Load(object sender, EventArgs e)
        {
            SqlDataReader myReader = DatabaseQueries.GetTeamIDs();

            while (myReader.Read())
            {
                string tIDs = myReader["Team_ID"].ToString();
                cmbTeamIDs.Items.Add(tIDs);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            NewTournament newTournament = new NewTournament();
            newTournament.Show();
            this.Hide();
        }
    }
}
