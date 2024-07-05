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
    public partial class TLogin : Form
    {

        public static string ID { set; get; }

        public TLogin()
        {
            InitializeComponent();
        }

        private void btnTLogin_Click(object sender, EventArgs e)
        {
            string username = txtTUsername.Text;
            string password = txtTPassword.Text;

            if(DatabaseQueries.TOwnerLogin(username, password) == true)
            {
                THomePage obj = new THomePage();

                obj.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Login Un-Successful!!", "Error");
            }

            ID = DatabaseQueries.GetTournamentOwnerID(username);
        }

        private void TLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
