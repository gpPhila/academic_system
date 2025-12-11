namespace academic_system
{
    partial class UserEditorForm
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
			this.labelRole = new System.Windows.Forms.Label();
			this.labelLogin = new System.Windows.Forms.Label();
			this.labelPassword = new System.Windows.Forms.Label();
			this.txtLogin = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.cmbRole = new System.Windows.Forms.ComboBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.labelLastName = new System.Windows.Forms.Label();
			this.labelFirstName = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelRole
			// 
			this.labelRole.AutoSize = true;
			this.labelRole.Location = new System.Drawing.Point(255, 177);
			this.labelRole.Name = "labelRole";
			this.labelRole.Size = new System.Drawing.Size(56, 25);
			this.labelRole.TabIndex = 0;
			this.labelRole.Text = "Role";
			// 
			// labelLogin
			// 
			this.labelLogin.AutoSize = true;
			this.labelLogin.Location = new System.Drawing.Point(246, 221);
			this.labelLogin.Name = "labelLogin";
			this.labelLogin.Size = new System.Drawing.Size(65, 25);
			this.labelLogin.TabIndex = 3;
			this.labelLogin.Text = "Login";
			// 
			// labelPassword
			// 
			this.labelPassword.AutoSize = true;
			this.labelPassword.Location = new System.Drawing.Point(205, 260);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(106, 25);
			this.labelPassword.TabIndex = 4;
			this.labelPassword.Text = "Password";
			// 
			// txtLogin
			// 
			this.txtLogin.Location = new System.Drawing.Point(326, 223);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(243, 31);
			this.txtLogin.TabIndex = 7;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(326, 260);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(243, 31);
			this.txtPassword.TabIndex = 8;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(451, 320);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(164, 42);
			this.btnSave.TabIndex = 9;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(221, 320);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(164, 42);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// cmbRole
			// 
			this.cmbRole.FormattingEnabled = true;
			this.cmbRole.Items.AddRange(new object[] {
            "student",
            "teacher",
            "admin"});
			this.cmbRole.Location = new System.Drawing.Point(326, 174);
			this.cmbRole.Name = "cmbRole";
			this.cmbRole.Size = new System.Drawing.Size(243, 33);
			this.cmbRole.TabIndex = 11;
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(326, 127);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(243, 31);
			this.txtLastName.TabIndex = 15;
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(326, 90);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(243, 31);
			this.txtFirstName.TabIndex = 14;
			// 
			// labelLastName
			// 
			this.labelLastName.AutoSize = true;
			this.labelLastName.Location = new System.Drawing.Point(198, 130);
			this.labelLastName.Name = "labelLastName";
			this.labelLastName.Size = new System.Drawing.Size(112, 25);
			this.labelLastName.TabIndex = 13;
			this.labelLastName.Text = "Last name";
			// 
			// labelFirstName
			// 
			this.labelFirstName.AutoSize = true;
			this.labelFirstName.Location = new System.Drawing.Point(198, 93);
			this.labelFirstName.Name = "labelFirstName";
			this.labelFirstName.Size = new System.Drawing.Size(113, 25);
			this.labelFirstName.TabIndex = 12;
			this.labelFirstName.Text = "First name";
			this.labelFirstName.Click += new System.EventHandler(this.label2_Click);
			// 
			// UserEditorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.labelLastName);
			this.Controls.Add(this.labelFirstName);
			this.Controls.Add(this.cmbRole);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtLogin);
			this.Controls.Add(this.labelPassword);
			this.Controls.Add(this.labelLogin);
			this.Controls.Add(this.labelRole);
			this.Name = "UserEditorForm";
			this.Text = "UserEditorForm";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
    }
}