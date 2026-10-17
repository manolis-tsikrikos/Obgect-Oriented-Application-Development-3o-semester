namespace BasketManagerApp
{
    partial class MainForm
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnPlayers = new System.Windows.Forms.Button();
            this.btnTeams = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Black;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(984, 100);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(258, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🏀 Basket Manager";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Silver;
            this.panelMenu.Controls.Add(this.btnStats);
            this.panelMenu.Controls.Add(this.btnTeams);
            this.panelMenu.Controls.Add(this.btnPlayers);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 100);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 511);
            this.panelMenu.TabIndex = 1;
            // 
            // btnPlayers
            // 
            this.btnPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayers.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnPlayers.ForeColor = System.Drawing.Color.White;
            this.btnPlayers.Location = new System.Drawing.Point(12, 6);
            this.btnPlayers.Name = "btnPlayers";
            this.btnPlayers.Size = new System.Drawing.Size(74, 31);
            this.btnPlayers.TabIndex = 0;
            this.btnPlayers.Text = "Players";
            this.btnPlayers.UseVisualStyleBackColor = true;
            this.btnPlayers.Click += new System.EventHandler(this.btnPlayers_Click);
            // 
            // btnTeams
            // 
            this.btnTeams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeams.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnTeams.ForeColor = System.Drawing.Color.White;
            this.btnTeams.Location = new System.Drawing.Point(12, 57);
            this.btnTeams.Name = "btnTeams";
            this.btnTeams.Size = new System.Drawing.Size(74, 31);
            this.btnTeams.TabIndex = 1;
            this.btnTeams.Text = "Teams";
            this.btnTeams.UseVisualStyleBackColor = true;
            // 
            // btnStats
            // 
            this.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStats.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnStats.ForeColor = System.Drawing.Color.White;
            this.btnStats.Location = new System.Drawing.Point(12, 111);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(74, 31);
            this.btnStats.TabIndex = 2;
            this.btnStats.Text = "Statistics";
            this.btnStats.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basket Manager 🏀";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnPlayers;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnTeams;
    }
}

