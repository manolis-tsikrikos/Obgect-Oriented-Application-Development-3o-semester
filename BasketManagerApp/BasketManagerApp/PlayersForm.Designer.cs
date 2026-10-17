namespace BasketManagerApp
{
    partial class PlayersForm
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
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.btnDeletePlayer = new System.Windows.Forms.Button();
            this.btnEditPlayer = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlayers.BackgroundColor = System.Drawing.Color.White;
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPlayers.Location = new System.Drawing.Point(0, 0);
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.Size = new System.Drawing.Size(734, 150);
            this.dgvPlayers.TabIndex = 0;
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPlayer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnAddPlayer.ForeColor = System.Drawing.Color.Navy;
            this.btnAddPlayer.Location = new System.Drawing.Point(0, 156);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(87, 38);
            this.btnAddPlayer.TabIndex = 1;
            this.btnAddPlayer.Text = "Add Player";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // btnDeletePlayer
            // 
            this.btnDeletePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePlayer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnDeletePlayer.ForeColor = System.Drawing.Color.Navy;
            this.btnDeletePlayer.Location = new System.Drawing.Point(0, 244);
            this.btnDeletePlayer.Name = "btnDeletePlayer";
            this.btnDeletePlayer.Size = new System.Drawing.Size(87, 38);
            this.btnDeletePlayer.TabIndex = 2;
            this.btnDeletePlayer.Text = "Delete Selected";
            this.btnDeletePlayer.UseVisualStyleBackColor = true;
            this.btnDeletePlayer.Click += new System.EventHandler(this.btnDeletePlayer_Click);
            // 
            // btnEditPlayer
            // 
            this.btnEditPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPlayer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnEditPlayer.ForeColor = System.Drawing.Color.Navy;
            this.btnEditPlayer.Location = new System.Drawing.Point(0, 200);
            this.btnEditPlayer.Name = "btnEditPlayer";
            this.btnEditPlayer.Size = new System.Drawing.Size(87, 38);
            this.btnEditPlayer.TabIndex = 3;
            this.btnEditPlayer.Text = "Edit Selected";
            this.btnEditPlayer.UseVisualStyleBackColor = true;
            this.btnEditPlayer.Click += new System.EventHandler(this.btnEditPlayer_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnStatistics.ForeColor = System.Drawing.Color.Navy;
            this.btnStatistics.Location = new System.Drawing.Point(0, 288);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(87, 38);
            this.btnStatistics.TabIndex = 4;
            this.btnStatistics.Text = "View Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // PlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnEditPlayer);
            this.Controls.Add(this.btnDeletePlayer);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.dgvPlayers);
            this.Name = "PlayersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Players";
            this.Load += new System.EventHandler(this.PlayersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnDeletePlayer;
        private System.Windows.Forms.Button btnEditPlayer;
        private System.Windows.Forms.Button btnStatistics;
    }
}