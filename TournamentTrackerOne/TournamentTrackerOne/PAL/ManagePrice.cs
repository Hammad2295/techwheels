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
    public partial class ManagePrice : Form
    {
        public ManagePrice()
        {
            InitializeComponent();
        }

        public void loadform(Object form)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }

            Form obj = form as Form;
            obj.TopLevel = false;
            obj.Dock = DockStyle.Fill;

            this.mainPanel.Controls.Add(obj);
            this.mainPanel.Tag = obj;

            obj.Show();
        }
        private void btnAddPrice_Click(object sender, EventArgs e)
        {
            loadform(new AddPrice());
        }

        private void btnDeleteCoach_Click(object sender, EventArgs e)
        {
            loadform(new ShowPrice());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            NewTournament newTournament = new NewTournament();
            newTournament.Show();
            this.Hide();
        }
    }
}
