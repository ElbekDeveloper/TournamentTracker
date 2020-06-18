namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            this.lblDashboard = new System.Windows.Forms.Label();
            this.lblLoadTournament = new System.Windows.Forms.Label();
            this.cboLoadExistingTournament = new System.Windows.Forms.ComboBox();
            this.btnLoadTournament = new System.Windows.Forms.Button();
            this.lblOr = new System.Windows.Forms.Label();
            this.btnCreatetorunament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDashboard.ForeColor = System.Drawing.Color.Gray;
            this.lblDashboard.Location = new System.Drawing.Point(146, 23);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(240, 30);
            this.lblDashboard.TabIndex = 6;
            this.lblDashboard.Text = "Tournament Dashboard";
            // 
            // lblLoadTournament
            // 
            this.lblLoadTournament.AutoSize = true;
            this.lblLoadTournament.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLoadTournament.ForeColor = System.Drawing.Color.Gray;
            this.lblLoadTournament.Location = new System.Drawing.Point(152, 62);
            this.lblLoadTournament.Name = "lblLoadTournament";
            this.lblLoadTournament.Size = new System.Drawing.Size(229, 25);
            this.lblLoadTournament.TabIndex = 6;
            this.lblLoadTournament.Text = "Load Existing Tournament";
            // 
            // cboLoadExistingTournament
            // 
            this.cboLoadExistingTournament.FormattingEnabled = true;
            this.cboLoadExistingTournament.Location = new System.Drawing.Point(122, 99);
            this.cboLoadExistingTournament.Name = "cboLoadExistingTournament";
            this.cboLoadExistingTournament.Size = new System.Drawing.Size(289, 38);
            this.cboLoadExistingTournament.TabIndex = 11;
            // 
            // btnLoadTournament
            // 
            this.btnLoadTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLoadTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLoadTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadTournament.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoadTournament.Location = new System.Drawing.Point(181, 157);
            this.btnLoadTournament.Name = "btnLoadTournament";
            this.btnLoadTournament.Size = new System.Drawing.Size(170, 72);
            this.btnLoadTournament.TabIndex = 13;
            this.btnLoadTournament.Text = "Load Tournament";
            this.btnLoadTournament.UseVisualStyleBackColor = true;
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOr.ForeColor = System.Drawing.Color.Gray;
            this.lblOr.Location = new System.Drawing.Point(244, 242);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(44, 21);
            this.lblOr.TabIndex = 14;
            this.lblOr.Text = "-OR-";
            // 
            // btnCreatetorunament
            // 
            this.btnCreatetorunament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCreatetorunament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCreatetorunament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatetorunament.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreatetorunament.Location = new System.Drawing.Point(181, 282);
            this.btnCreatetorunament.Name = "btnCreatetorunament";
            this.btnCreatetorunament.Size = new System.Drawing.Size(170, 69);
            this.btnCreatetorunament.TabIndex = 13;
            this.btnCreatetorunament.Text = "Create Tournament";
            this.btnCreatetorunament.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 448);
            this.Controls.Add(this.btnCreatetorunament);
            this.Controls.Add(this.lblOr);
            this.Controls.Add(this.btnLoadTournament);
            this.Controls.Add(this.cboLoadExistingTournament);
            this.Controls.Add(this.lblLoadTournament);
            this.Controls.Add(this.lblDashboard);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Label lblLoadTournament;
        private System.Windows.Forms.ComboBox cboLoadExistingTournament;
        private System.Windows.Forms.Button btnLoadTournament;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.Button btnCreatetorunament;
    }
}