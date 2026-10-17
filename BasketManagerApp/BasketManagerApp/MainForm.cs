using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasketManagerApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = "Basket Manager 🏀";
        }

        private void btnPlayers_Click(object sender, EventArgs e)
        {
            PlayersForm form = new PlayersForm();
            _ = form.ShowDialog();
        }
    }
}