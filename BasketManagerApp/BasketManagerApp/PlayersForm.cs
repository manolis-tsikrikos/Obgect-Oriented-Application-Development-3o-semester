using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BasketManagerApp.Models;

namespace BasketManagerApp
{
    public partial class PlayersForm : Form
    {
        private List<Player> players = new List<Player>();
        private int nextId = 1;

        public PlayersForm()
        {
            InitializeComponent();
        }

        private void PlayersForm_Load(object sender, EventArgs e)
        {
            dgvPlayers.AutoGenerateColumns = true;
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dgvPlayers.DataSource = null;
            dgvPlayers.DataSource = players;
        }

        // ✅ ADD
        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            using (AddPlayerForm form = new AddPlayerForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Player p = form.CreatedPlayer;
                    p.Id = nextId++;

                    players.Add(p);
                    RefreshGrid();
                }
            }
        }

        // ✅ EDIT
        private void btnEditPlayer_Click(object sender, EventArgs e)
        {
            if (dgvPlayers.CurrentRow == null)
            {
                MessageBox.Show("Please select a player first.");
                return;
            }

            Player selectedPlayer =
                (Player)dgvPlayers.CurrentRow.DataBoundItem;

            using (AddPlayerForm form = new AddPlayerForm(selectedPlayer))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
        }

        // ✅ DELETE
        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            if (dgvPlayers.CurrentRow == null)
            {
                MessageBox.Show("Please select a player first.");
                return;
            }

            Player selectedPlayer =
                (Player)dgvPlayers.CurrentRow.DataBoundItem;

            var confirm = MessageBox.Show(
                $"Delete {selectedPlayer.Name}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                players.Remove(selectedPlayer);
                RefreshGrid();
            }
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            StatisticsForm form = new StatisticsForm(players);
            form.ShowDialog();
        }
    }
}