using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentTrackerOne.DAL;

namespace TournamentTrackerOne.PAL
{
    public partial class ShowPrice : Form
    {
        public ShowPrice()
        {
            InitializeComponent();
        }

        private void btnShowPriceRd_Click(object sender, EventArgs e)
        {
            DataSet dataSet = DatabaseQueries.ShowPriceRecord();

            dgvShowPrice.DataSource = dataSet.Tables["priceTable"];
        }
    }
}
