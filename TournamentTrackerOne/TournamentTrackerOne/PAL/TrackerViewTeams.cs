﻿using System;
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
    public partial class TrackerViewTeams : Form
    {
        public TrackerViewTeams()
        {
            InitializeComponent();
        }

        private void btnTTClose_Click(object sender, EventArgs e)
        {
            TrackerScore tracker = new TrackerScore();

            tracker.Show();
            this.Hide();
        }

        private void cmbTeamsinScore_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = Convert.ToString(cmbTeamsinScore.Text);
            DataSet ds = DatabaseQueries.GetDataThroughDataAdaptor1(a);
            grdTeamsinScore.DataSource = ds.Tables["Team"];
        }

        private void TrackerViewTeams_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = DatabaseQueries.GetTeamIDTournamentTracker();
            while (reader.Read())
            {
                string Team_ID = reader["Tournament_ID"].ToString();
                cmbtournamentInScore.Items.Add(Team_ID);
            }
        }

        private void cmbtournamentInScore_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = Convert.ToString(cmbtournamentInScore.SelectedItem);
            SqlDataReader reader = DatabaseQueries.GetTeamIDTournamentTracker1(a);
            while (reader.Read())
            {
                string Team_ID = reader["Team_ID"].ToString();
                cmbTeamsinScore.Items.Add(Team_ID);
            }
        }

        private void grdTeamsinScore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
