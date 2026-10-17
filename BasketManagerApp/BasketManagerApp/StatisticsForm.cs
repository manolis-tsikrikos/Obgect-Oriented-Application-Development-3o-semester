using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BasketManagerApp.Models;

namespace BasketManagerApp
{
    public partial class StatisticsForm : Form
    {
        private List<Player> players;

        public StatisticsForm(List<Player> playersList)
        {
            InitializeComponent();
            players = playersList;
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            UpdateStatistics();
        }

        private void UpdateStatistics()
        {
            lblTotalPlayers.Text = "Total Players: " + players.Count;

            if (players.Count == 0)
            {
                lblAveragePPG.Text = "Average PPG: 0";
                lblTopScorer.Text = "Top Scorer: None";
                return;
            }

            double avg = players.Average(p => p.PointsPerGame);
            lblAveragePPG.Text = "Average PPG: " + avg.ToString("0.0");

            Player top = players.OrderByDescending(p => p.PointsPerGame).First();
            lblTopScorer.Text = "Top Scorer: " + top.Name;
        }
    }
}