namespace BasketManagerApp
{
    partial class StatisticsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTotalPlayers = new System.Windows.Forms.Label();
            this.lblAveragePPG = new System.Windows.Forms.Label();
            this.lblTopScorer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTotalPlayers
            // 
            this.lblTotalPlayers.AutoSize = true;
            this.lblTotalPlayers.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTotalPlayers.ForeColor = System.Drawing.Color.White;
            this.lblTotalPlayers.Location = new System.Drawing.Point(40, 50);
            this.lblTotalPlayers.Name = "lblTotalPlayers";
            this.lblTotalPlayers.Size = new System.Drawing.Size(104, 21);
            this.lblTotalPlayers.TabIndex = 0;
            this.lblTotalPlayers.Text = "Total Players:";
            // 
            // lblAveragePPG
            // 
            this.lblAveragePPG.AutoSize = true;
            this.lblAveragePPG.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblAveragePPG.ForeColor = System.Drawing.Color.White;
            this.lblAveragePPG.Location = new System.Drawing.Point(40, 110);
            this.lblAveragePPG.Name = "lblAveragePPG";
            this.lblAveragePPG.Size = new System.Drawing.Size(108, 21);
            this.lblAveragePPG.TabIndex = 1;
            this.lblAveragePPG.Text = "Average PPG:";
            // 
            // lblTopScorer
            // 
            this.lblTopScorer.AutoSize = true;
            this.lblTopScorer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTopScorer.ForeColor = System.Drawing.Color.White;
            this.lblTopScorer.Location = new System.Drawing.Point(40, 170);
            this.lblTopScorer.Name = "lblTopScorer";
            this.lblTopScorer.Size = new System.Drawing.Size(94, 21);
            this.lblTopScorer.TabIndex = 2;
            this.lblTopScorer.Text = "Top Scorer:";
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.lblTopScorer);
            this.Controls.Add(this.lblAveragePPG);
            this.Controls.Add(this.lblTotalPlayers);
            this.Name = "StatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalPlayers;
        private System.Windows.Forms.Label lblAveragePPG;
        private System.Windows.Forms.Label lblTopScorer;
    }
}