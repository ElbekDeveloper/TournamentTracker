namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.tbxTeamName = new System.Windows.Forms.TextBox();
            this.lblCreateTeam = new System.Windows.Forms.Label();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.cboSelectTeamMember = new System.Windows.Forms.ComboBox();
            this.lblSelectTeamMember = new System.Windows.Forms.Label();
            this.groupBoxAddNewMember = new System.Windows.Forms.GroupBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCreateMember = new System.Windows.Forms.Button();
            this.listboxTeamMembers = new System.Windows.Forms.ListBox();
            this.btnDeleteSelectedMember = new System.Windows.Forms.Button();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.groupBoxAddNewMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxTeamName
            // 
            this.tbxTeamName.Location = new System.Drawing.Point(35, 79);
            this.tbxTeamName.Name = "tbxTeamName";
            this.tbxTeamName.Size = new System.Drawing.Size(307, 35);
            this.tbxTeamName.TabIndex = 6;
            // 
            // lblCreateTeam
            // 
            this.lblCreateTeam.AutoSize = true;
            this.lblCreateTeam.ForeColor = System.Drawing.Color.Gray;
            this.lblCreateTeam.Location = new System.Drawing.Point(30, 9);
            this.lblCreateTeam.Name = "lblCreateTeam";
            this.lblCreateTeam.Size = new System.Drawing.Size(190, 30);
            this.lblCreateTeam.TabIndex = 4;
            this.lblCreateTeam.Text = "Create Tournament";
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTeamName.ForeColor = System.Drawing.Color.Gray;
            this.lblTeamName.Location = new System.Drawing.Point(30, 46);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(111, 25);
            this.lblTeamName.TabIndex = 5;
            this.lblTeamName.Text = "Team Name";
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddTeam.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddTeam.Location = new System.Drawing.Point(79, 185);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(141, 32);
            this.btnAddTeam.TabIndex = 11;
            this.btnAddTeam.Text = "Add Member";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            // 
            // cboSelectTeamMember
            // 
            this.cboSelectTeamMember.FormattingEnabled = true;
            this.cboSelectTeamMember.Location = new System.Drawing.Point(35, 141);
            this.cboSelectTeamMember.Name = "cboSelectTeamMember";
            this.cboSelectTeamMember.Size = new System.Drawing.Size(307, 38);
            this.cboSelectTeamMember.TabIndex = 10;
            // 
            // lblSelectTeamMember
            // 
            this.lblSelectTeamMember.AutoSize = true;
            this.lblSelectTeamMember.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectTeamMember.ForeColor = System.Drawing.Color.Gray;
            this.lblSelectTeamMember.Location = new System.Drawing.Point(31, 117);
            this.lblSelectTeamMember.Name = "lblSelectTeamMember";
            this.lblSelectTeamMember.Size = new System.Drawing.Size(154, 21);
            this.lblSelectTeamMember.TabIndex = 9;
            this.lblSelectTeamMember.Text = "Select Team Member";
            // 
            // groupBoxAddNewMember
            // 
            this.groupBoxAddNewMember.Controls.Add(this.textBox1);
            this.groupBoxAddNewMember.Controls.Add(this.btnCreateMember);
            this.groupBoxAddNewMember.Controls.Add(this.tbxEmail);
            this.groupBoxAddNewMember.Controls.Add(this.tbxLastName);
            this.groupBoxAddNewMember.Controls.Add(this.lblPhoneNumber);
            this.groupBoxAddNewMember.Controls.Add(this.lblEmail);
            this.groupBoxAddNewMember.Controls.Add(this.lblLastName);
            this.groupBoxAddNewMember.Controls.Add(this.tbxFirstName);
            this.groupBoxAddNewMember.Controls.Add(this.lblFirstName);
            this.groupBoxAddNewMember.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxAddNewMember.Location = new System.Drawing.Point(35, 229);
            this.groupBoxAddNewMember.Name = "groupBoxAddNewMember";
            this.groupBoxAddNewMember.Size = new System.Drawing.Size(307, 236);
            this.groupBoxAddNewMember.TabIndex = 12;
            this.groupBoxAddNewMember.TabStop = false;
            this.groupBoxAddNewMember.Text = "Add New Member";
            this.groupBoxAddNewMember.Enter += new System.EventHandler(this.groupBoxAddNewMember_Enter);
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxFirstName.Location = new System.Drawing.Point(106, 42);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(181, 29);
            this.tbxFirstName.TabIndex = 9;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Gray;
            this.lblFirstName.Location = new System.Drawing.Point(21, 45);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(86, 21);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastName.ForeColor = System.Drawing.Color.Gray;
            this.lblLastName.Location = new System.Drawing.Point(21, 80);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(84, 21);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxLastName.Location = new System.Drawing.Point(106, 77);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(181, 29);
            this.tbxLastName.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmail.ForeColor = System.Drawing.Color.Gray;
            this.lblEmail.Location = new System.Drawing.Point(22, 119);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 21);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxEmail.Location = new System.Drawing.Point(107, 116);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(181, 29);
            this.tbxEmail.TabIndex = 9;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.Gray;
            this.lblPhoneNumber.Location = new System.Drawing.Point(22, 158);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(67, 21);
            this.lblPhoneNumber.TabIndex = 8;
            this.lblPhoneNumber.Text = "Phone #";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(107, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 29);
            this.textBox1.TabIndex = 9;
            // 
            // btnCreateMember
            // 
            this.btnCreateMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCreateMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCreateMember.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateMember.Location = new System.Drawing.Point(57, 192);
            this.btnCreateMember.Name = "btnCreateMember";
            this.btnCreateMember.Size = new System.Drawing.Size(159, 32);
            this.btnCreateMember.TabIndex = 11;
            this.btnCreateMember.Text = "Create Member";
            this.btnCreateMember.UseVisualStyleBackColor = true;
            // 
            // listboxTeamMembers
            // 
            this.listboxTeamMembers.FormattingEnabled = true;
            this.listboxTeamMembers.ItemHeight = 30;
            this.listboxTeamMembers.Location = new System.Drawing.Point(444, 59);
            this.listboxTeamMembers.Name = "listboxTeamMembers";
            this.listboxTeamMembers.Size = new System.Drawing.Size(283, 394);
            this.listboxTeamMembers.TabIndex = 13;
            // 
            // btnDeleteSelectedMember
            // 
            this.btnDeleteSelectedMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteSelectedMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteSelectedMember.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteSelectedMember.Location = new System.Drawing.Point(733, 229);
            this.btnDeleteSelectedMember.Name = "btnDeleteSelectedMember";
            this.btnDeleteSelectedMember.Size = new System.Drawing.Size(122, 65);
            this.btnDeleteSelectedMember.TabIndex = 14;
            this.btnDeleteSelectedMember.Text = "Delete Seleted";
            this.btnDeleteSelectedMember.UseVisualStyleBackColor = true;
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCreateTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCreateTeam.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateTeam.Location = new System.Drawing.Point(309, 467);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(170, 44);
            this.btnCreateTeam.TabIndex = 11;
            this.btnCreateTeam.Text = "Create Team";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 523);
            this.Controls.Add(this.btnDeleteSelectedMember);
            this.Controls.Add(this.btnCreateTeam);
            this.Controls.Add(this.listboxTeamMembers);
            this.Controls.Add(this.groupBoxAddNewMember);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.cboSelectTeamMember);
            this.Controls.Add(this.lblSelectTeamMember);
            this.Controls.Add(this.tbxTeamName);
            this.Controls.Add(this.lblCreateTeam);
            this.Controls.Add(this.lblTeamName);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.groupBoxAddNewMember.ResumeLayout(false);
            this.groupBoxAddNewMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxTeamName;
        private System.Windows.Forms.Label lblCreateTeam;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.ComboBox cboSelectTeamMember;
        private System.Windows.Forms.Label lblSelectTeamMember;
        private System.Windows.Forms.GroupBox groupBoxAddNewMember;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCreateMember;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.ListBox listboxTeamMembers;
        private System.Windows.Forms.Button btnDeleteSelectedMember;
        private System.Windows.Forms.Button btnCreateTeam;
    }
}