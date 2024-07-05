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
    public partial class VLogin : Form
    {
        public VLogin()
        {
            InitializeComponent();
        }

        private void btnVLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = DatabaseQueries.GetConnection();
            string str = "Select * from Viewer  where Username = '" + txtVUsername.Text.Trim() + "' and Password_  = '" + txtVPassword.Text.Trim() + "'";
            
            SqlDataAdapter adapter = new SqlDataAdapter(str, connection);
           
            DataTable db = new DataTable();
            adapter.Fill(db);

            if (db.Rows.Count == 1)
            {
                ViewerScoreBoard obj2 = new ViewerScoreBoard();
                obj2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Login Un-Successful!!", "Error");
            }
        }

        private SqlConnection GetConnection()
        {
            throw new NotImplementedException();
        }
    }
}
