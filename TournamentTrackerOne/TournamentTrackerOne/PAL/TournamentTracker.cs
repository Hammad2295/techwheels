using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TournamentTrackerOne.PAL
{
    public partial class TournamentTracker : Form
    {
        public TournamentTracker()
        {
            InitializeComponent();
        }

        private void loadForm(object TObj)
        {
            if (this.pnlContainer.Controls.Count > 0)
            {
                this.pnlContainer.Controls.RemoveAt(0);
            }

            Form x = TObj as Form;
            x.TopLevel = false;
            x.Dock = DockStyle.Fill;
            this.pnlContainer.Controls.Add(x);
            this.pnlContainer.Tag = x;
            x.Show();
        }


        private void TournamentTracker_Load(object sender, EventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnTournamentPanel_Click(object sender, EventArgs e)
        {
            pnlSubMenu.Visible = true;
        }

        private void btnTLogin_Click(object sender, EventArgs e)
        {
            pnlSubMenu.Visible = false;

            loadForm(new TLogin());
        }

        private void btnTSignup_Click(object sender, EventArgs e)
        {
            pnlSubMenu.Visible = false;
            loadForm(new TSignup());
        }

        private void btnViewerPanel_Click(object sender, EventArgs e)
        {
            pnlSubMenu2.Visible = true;
        }

        private void btnVLogin_Click(object sender, EventArgs e)
        {
            pnlSubMenu2.Visible = false;
            loadForm(new VLogin());
            
        }

        private void btnVSignup_Click(object sender, EventArgs e)
        {
            pnlSubMenu2.Visible = false;
            loadForm(new VSignup());
        }

        private void picExit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
