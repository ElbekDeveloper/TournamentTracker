namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.lblTournament = new System.Windows.Forms.Label();
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.cboRound = new System.Windows.Forms.ComboBox();
            this.cbxUnplayedOnly = new System.Windows.Forms.CheckBox();
            this.listboxMatchup = new System.Windows.Forms.ListBox();
            this.lblScoreTeamOne = new System.Windows.Forms.Label();
            this.tbxScoreTeamOne = new System.Windows.Forms.TextBox();
            this.lblTeamONe = new System.Windows.Forms.Label();
            this.lblScoreTeamTwo = new System.Windows.Forms.Label();
            this.lblTeamTwo = new System.Windows.Forms.Label();
            this.tbxScoreTeamTwo = new System.Windows.Forms.TextBox();
            this.lblVersus = new System.Windows.Forms.Label();
            this.btnScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTournament
            // 
            this.lblTournament.AutoSize = true;
            this.lblTournament.ForeColor = System.Drawing.Color.Gray;
            this.lblTournament.Location = new System.Drawing.Point(22, 33);
            this.lblTournament.Name = "lblTournament";
            this.lblTournament.Size = new System.Drawing.Size(129, 30);
            this.lblTournament.TabIndex = 0;
            this.lblTournament.Text = "Tournament:";
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.ForeColor = System.Drawing.Color.Gray;
            this.lblTournamentName.Location = new System.Drawing.Point(146, 33);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(93, 30);
            this.lblTournamentName.TabIndex = 1;
            this.lblTournamentName.Text = "<name>";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.ForeColor = System.Drawing.Color.Gray;
            this.lblScore.Location = new System.Drawing.Point(22, 83);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(73, 30);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Round";
            // 
            // cboRound
            // 
            this.cboRound.FormattingEnabled = true;
            this.cboRound.Location = new System.Drawing.Point(101, 80);
            this.cboRound.Name = "cboRound";
            this.cboRound.Size = new System.Drawing.Size(138, 38);
            this.cboRound.TabIndex = 3;
            // 
            // cbxUnplayedOnly
            // 
            this.cbxUnplayedOnly.AutoSize = true;
            this.cbxUnplayedOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxUnplayedOnly.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxUnplayedOnly.Location = new System.Drawing.Point(101, 124);
            this.cbxUnplayedOnly.Name = "cbxUnplayedOnly";
            this.cbxUnplayedOnly.Size = new System.Drawing.Size(146, 29);
            this.cbxUnplayedOnly.TabIndex = 4;
            this.cbxUnplayedOnly.Text = "Unplayed Only";
            this.cbxUnplayedOnly.UseVisualStyleBackColor = true;
            // 
            // listboxMatchup
            // 
            this.listboxMatchup.FormattingEnabled = true;
            this.listboxMatchup.ItemHeight = 30;
            this.listboxMatchup.Location = new System.Drawing.Point(27, 177);
            this.listboxMatchup.Name = "listboxMatchup";
            this.listboxMatchup.Size = new System.Drawing.Size(220, 244);
            this.listboxMatchup.TabIndex = 5;
            // 
            // lblScoreTeamOne
            // 
            this.lblScoreTeamOne.AutoSize = true;
            this.lblScoreTeamOne.ForeColor = System.Drawing.Color.Gray;
            this.lblScoreTeamOne.Location = new System.Drawing.Point(311, 180);
            this.lblScoreTeamOne.Name = "lblScoreTeamOne";
            this.lblScoreTeamOne.Size = new System.Drawing.Size(64, 30);
            this.lblScoreTeamOne.TabIndex = 6;
            this.lblScoreTeamOne.Text = "Score";
            // 
            // tbxScoreTeamOne
            // 
            this.tbxScoreTeamOne.Location = new System.Drawing.Point(390, 177);
            this.tbxScoreTeamOne.Name = "tbxScoreTeamOne";
            this.tbxScoreTeamOne.Size = new System.Drawing.Size(138, 35);
            this.tbxScoreTeamOne.TabIndex = 7;
            // 
            // lblTeamONe
            // 
            this.lblTeamONe.AutoSize = true;
            this.lblTeamONe.ForeColor = System.Drawing.Color.Gray;
            this.lblTeamONe.Location = new System.Drawing.Point(311, 139);
            this.lblTeamONe.Name = "lblTeamONe";
            this.lblTeamONe.Size = new System.Drawing.Size(129, 30);
            this.lblTeamONe.TabIndex = 5;
            this.lblTeamONe.Text = "<team one>";
            // 
            // lblScoreTeamTwo
            // 
            this.lblScoreTeamTwo.AutoSize = true;
            this.lblScoreTeamTwo.ForeColor = System.Drawing.Color.Gray;
            this.lblScoreTeamTwo.Location = new System.Drawing.Point(311, 351);
            this.lblScoreTeamTwo.Name = "lblScoreTeamTwo";
            this.lblScoreTeamTwo.Size = new System.Drawing.Size(64, 30);
            this.lblScoreTeamTwo.TabIndex = 10;
            this.lblScoreTeamTwo.Text = "Score";
            // 
            // lblTeamTwo
            // 
            this.lblTeamTwo.AutoSize = true;
            this.lblTeamTwo.ForeColor = System.Drawing.Color.Gray;
            this.lblTeamTwo.Location = new System.Drawing.Point(311, 310);
            this.lblTeamTwo.Name = "lblTeamTwo";
            this.lblTeamTwo.Size = new System.Drawing.Size(129, 30);
            this.lblTeamTwo.TabIndex = 9;
            this.lblTeamTwo.Text = "<team one>";
            // 
            // tbxScoreTeamTwo
            // 
            this.tbxScoreTeamTwo.Location = new System.Drawing.Point(390, 348);
            this.tbxScoreTeamTwo.Name = "tbxScoreTeamTwo";
            this.tbxScoreTeamTwo.Size = new System.Drawing.Size(138, 35);
            this.tbxScoreTeamTwo.TabIndex = 11;
            // 
            // lblVersus
            // 
            this.lblVersus.AutoSize = true;
            this.lblVersus.ForeColor = System.Drawing.Color.Gray;
            this.lblVersus.Location = new System.Drawing.Point(424, 253);
            this.lblVersus.Name = "lblVersus";
            this.lblVersus.Size = new System.Drawing.Size(53, 30);
            this.lblVersus.TabIndex = 8;
            this.lblVersus.Text = "-VS-";
            // 
            // btnScore
            // 
            this.btnScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.Location = new System.Drawing.Point(580, 242);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(110, 53);
            this.btnScore.TabIndex = 12;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(732, 446);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.tbxScoreTeamTwo);
            this.Controls.Add(this.tbxScoreTeamOne);
            this.Controls.Add(this.listboxMatchup);
            this.Controls.Add(this.cbxUnplayedOnly);
            this.Controls.Add(this.lblVersus);
            this.Controls.Add(this.lblTeamTwo);
            this.Controls.Add(this.lblTeamONe);
            this.Controls.Add(this.lblScoreTeamTwo);
            this.Controls.Add(this.lblScoreTeamOne);
            this.Controls.Add(this.cboRound);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTournamentName);
            this.Controls.Add(this.lblTournament);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTournament;
        private System.Windows.Forms.Label lblTournamentName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ComboBox cboRound;
        private System.Windows.Forms.CheckBox cbxUnplayedOnly;
        private System.Windows.Forms.ListBox listboxMatchup;
        private System.Windows.Forms.Label lblScoreTeamOne;
        private System.Windows.Forms.TextBox tbxScoreTeamOne;
        private System.Windows.Forms.Label lblTeamONe;
        private System.Windows.Forms.Label lblScoreTeamTwo;
        private System.Windows.Forms.Label lblTeamTwo;
        private System.Windows.Forms.TextBox tbxScoreTeamTwo;
        private System.Windows.Forms.Label lblVersus;
        private System.Windows.Forms.Button btnScore;
    }
}

