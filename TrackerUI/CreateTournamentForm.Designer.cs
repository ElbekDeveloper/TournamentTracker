namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.lblCreateTournament = new System.Windows.Forms.Label();
            this.tbxTounamentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxEntryFee = new System.Windows.Forms.TextBox();
            this.cboRound = new System.Windows.Forms.ComboBox();
            this.lblSelectTeam = new System.Windows.Forms.Label();
            this.linkLblCreateNewTeam = new System.Windows.Forms.LinkLabel();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.listboxTournamentPlayers = new System.Windows.Forms.ListBox();
            this.lblTournamentPlayer = new System.Windows.Forms.Label();
            this.btnDeleteSelectedPlayers = new System.Windows.Forms.Button();
            this.lblPrizes = new System.Windows.Forms.Label();
            this.btnDeleteSelectedPrizes = new System.Windows.Forms.Button();
            this.listboxPrizes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.ForeColor = System.Drawing.Color.Gray;
            this.lblTournamentName.Location = new System.Drawing.Point(33, 65);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(186, 30);
            this.lblTournamentName.TabIndex = 2;
            this.lblTournamentName.Text = "Tournement Name";
            // 
            // lblCreateTournament
            // 
            this.lblCreateTournament.AutoSize = true;
            this.lblCreateTournament.ForeColor = System.Drawing.Color.Gray;
            this.lblCreateTournament.Location = new System.Drawing.Point(33, 10);
            this.lblCreateTournament.Name = "lblCreateTournament";
            this.lblCreateTournament.Size = new System.Drawing.Size(190, 30);
            this.lblCreateTournament.TabIndex = 1;
            this.lblCreateTournament.Text = "Create Tournament";
            // 
            // tbxTounamentName
            // 
            this.tbxTounamentName.Location = new System.Drawing.Point(38, 98);
            this.tbxTounamentName.Name = "tbxTounamentName";
            this.tbxTounamentName.Size = new System.Drawing.Size(244, 35);
            this.tbxTounamentName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(33, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Entry Fee";
            // 
            // tbxEntryFee
            // 
            this.tbxEntryFee.Location = new System.Drawing.Point(131, 156);
            this.tbxEntryFee.Name = "tbxEntryFee";
            this.tbxEntryFee.Size = new System.Drawing.Size(151, 35);
            this.tbxEntryFee.TabIndex = 4;
            this.tbxEntryFee.Text = "0";
            // 
            // cboRound
            // 
            this.cboRound.FormattingEnabled = true;
            this.cboRound.Location = new System.Drawing.Point(38, 267);
            this.cboRound.Name = "cboRound";
            this.cboRound.Size = new System.Drawing.Size(244, 38);
            this.cboRound.TabIndex = 7;
            // 
            // lblSelectTeam
            // 
            this.lblSelectTeam.AutoSize = true;
            this.lblSelectTeam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectTeam.ForeColor = System.Drawing.Color.Gray;
            this.lblSelectTeam.Location = new System.Drawing.Point(34, 241);
            this.lblSelectTeam.Name = "lblSelectTeam";
            this.lblSelectTeam.Size = new System.Drawing.Size(91, 21);
            this.lblSelectTeam.TabIndex = 5;
            this.lblSelectTeam.Text = "Select Team";
            // 
            // linkLblCreateNewTeam
            // 
            this.linkLblCreateNewTeam.AutoSize = true;
            this.linkLblCreateNewTeam.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLblCreateNewTeam.Location = new System.Drawing.Point(154, 241);
            this.linkLblCreateNewTeam.Name = "linkLblCreateNewTeam";
            this.linkLblCreateNewTeam.Size = new System.Drawing.Size(128, 21);
            this.linkLblCreateNewTeam.TabIndex = 6;
            this.linkLblCreateNewTeam.TabStop = true;
            this.linkLblCreateNewTeam.Text = "Create New Team";
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddTeam.Location = new System.Drawing.Point(74, 311);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(149, 48);
            this.btnAddTeam.TabIndex = 8;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCreateTournament.Location = new System.Drawing.Point(288, 447);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(254, 48);
            this.btnCreateTournament.TabIndex = 15;
            this.btnCreateTournament.Text = "Create Tournament";
            this.btnCreateTournament.UseVisualStyleBackColor = true;
            // 
            // listboxTournamentPlayers
            // 
            this.listboxTournamentPlayers.FormattingEnabled = true;
            this.listboxTournamentPlayers.ItemHeight = 30;
            this.listboxTournamentPlayers.Location = new System.Drawing.Point(348, 98);
            this.listboxTournamentPlayers.Name = "listboxTournamentPlayers";
            this.listboxTournamentPlayers.Size = new System.Drawing.Size(334, 124);
            this.listboxTournamentPlayers.TabIndex = 10;
            // 
            // lblTournamentPlayer
            // 
            this.lblTournamentPlayer.AutoSize = true;
            this.lblTournamentPlayer.ForeColor = System.Drawing.Color.Gray;
            this.lblTournamentPlayer.Location = new System.Drawing.Point(343, 65);
            this.lblTournamentPlayer.Name = "lblTournamentPlayer";
            this.lblTournamentPlayer.Size = new System.Drawing.Size(156, 30);
            this.lblTournamentPlayer.TabIndex = 9;
            this.lblTournamentPlayer.Text = "Teams / Players";
            // 
            // btnDeleteSelectedPlayers
            // 
            this.btnDeleteSelectedPlayers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteSelectedPlayers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteSelectedPlayers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteSelectedPlayers.Location = new System.Drawing.Point(688, 131);
            this.btnDeleteSelectedPlayers.Name = "btnDeleteSelectedPlayers";
            this.btnDeleteSelectedPlayers.Size = new System.Drawing.Size(122, 65);
            this.btnDeleteSelectedPlayers.TabIndex = 11;
            this.btnDeleteSelectedPlayers.Text = "Delete Seleted";
            this.btnDeleteSelectedPlayers.UseVisualStyleBackColor = true;
            // 
            // lblPrizes
            // 
            this.lblPrizes.AutoSize = true;
            this.lblPrizes.ForeColor = System.Drawing.Color.Gray;
            this.lblPrizes.Location = new System.Drawing.Point(343, 265);
            this.lblPrizes.Name = "lblPrizes";
            this.lblPrizes.Size = new System.Drawing.Size(67, 30);
            this.lblPrizes.TabIndex = 12;
            this.lblPrizes.Text = "Prizes";
            // 
            // btnDeleteSelectedPrizes
            // 
            this.btnDeleteSelectedPrizes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteSelectedPrizes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteSelectedPrizes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteSelectedPrizes.Location = new System.Drawing.Point(688, 331);
            this.btnDeleteSelectedPrizes.Name = "btnDeleteSelectedPrizes";
            this.btnDeleteSelectedPrizes.Size = new System.Drawing.Size(122, 65);
            this.btnDeleteSelectedPrizes.TabIndex = 14;
            this.btnDeleteSelectedPrizes.Text = "Delete Selected";
            this.btnDeleteSelectedPrizes.UseVisualStyleBackColor = true;
            // 
            // listboxPrizes
            // 
            this.listboxPrizes.FormattingEnabled = true;
            this.listboxPrizes.ItemHeight = 30;
            this.listboxPrizes.Location = new System.Drawing.Point(348, 298);
            this.listboxPrizes.Name = "listboxPrizes";
            this.listboxPrizes.Size = new System.Drawing.Size(334, 124);
            this.listboxPrizes.TabIndex = 13;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 507);
            this.Controls.Add(this.listboxPrizes);
            this.Controls.Add(this.btnDeleteSelectedPrizes);
            this.Controls.Add(this.listboxTournamentPlayers);
            this.Controls.Add(this.btnDeleteSelectedPlayers);
            this.Controls.Add(this.btnCreateTournament);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.linkLblCreateNewTeam);
            this.Controls.Add(this.cboRound);
            this.Controls.Add(this.lblSelectTeam);
            this.Controls.Add(this.tbxEntryFee);
            this.Controls.Add(this.tbxTounamentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrizes);
            this.Controls.Add(this.lblCreateTournament);
            this.Controls.Add(this.lblTournamentPlayer);
            this.Controls.Add(this.lblTournamentName);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTournamentName;
        private System.Windows.Forms.Label lblCreateTournament;
        private System.Windows.Forms.TextBox tbxTounamentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxEntryFee;
        private System.Windows.Forms.ComboBox cboRound;
        private System.Windows.Forms.Label lblSelectTeam;
        private System.Windows.Forms.LinkLabel linkLblCreateNewTeam;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnCreateTournament;
        private System.Windows.Forms.ListBox listboxTournamentPlayers;
        private System.Windows.Forms.Label lblTournamentPlayer;
        private System.Windows.Forms.Button btnDeleteSelectedPlayers;
        private System.Windows.Forms.Label lblPrizes;
        private System.Windows.Forms.Button btnDeleteSelectedPrizes;
        private System.Windows.Forms.ListBox listboxPrizes;
    }
}