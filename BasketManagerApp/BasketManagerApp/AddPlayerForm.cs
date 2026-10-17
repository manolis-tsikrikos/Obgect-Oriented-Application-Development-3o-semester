using System;
using System.Windows.Forms;
using BasketManagerApp.Models;

namespace BasketManagerApp
{
    public partial class AddPlayerForm : Form
    {
        public Player CreatedPlayer { get; private set; }

        // ADD MODE
        public AddPlayerForm()
        {
            InitializeComponent();

            cmbPosition.Items.AddRange(new string[]
            {
                "PG",
                "SG",
                "SF",
                "PF",
                "C"
            });

            cmbPosition.SelectedIndex = 0;
        }

        // EDIT MODE
        public AddPlayerForm(Player existingPlayer) : this()
        {
            if (existingPlayer != null)
            {
                txtName.Text = existingPlayer.Name;
                cmbPosition.SelectedItem = existingPlayer.Position;
                numNumber.Value = existingPlayer.Number;
                numPPG.Value = (decimal)existingPlayer.PointsPerGame;

                CreatedPlayer = existingPlayer;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show(
                    "Please enter player name.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // If editing existing player → update it
            if (CreatedPlayer != null)
            {
                CreatedPlayer.Name = txtName.Text.Trim();
                CreatedPlayer.Position = cmbPosition.SelectedItem.ToString();
                CreatedPlayer.Number = (int)numNumber.Value;
                CreatedPlayer.PointsPerGame = (double)numPPG.Value;
            }
            else
            {
                // Create new player
                CreatedPlayer = new Player(
                    0,
                    txtName.Text.Trim(),
                    cmbPosition.SelectedItem.ToString(),
                    (int)numNumber.Value,
                    (double)numPPG.Value
                );
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}