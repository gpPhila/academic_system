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
			this.labelLogin = new System.Windows.Forms.Label();
			this.labelPassword = new System.Windows.Forms.Label();
			this.txtLogin = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.labelRoles = new System.Windows.Forms.Label();
			this.cmbRoles = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// labelLogin
			// 
			this.labelLogin.AutoSize = true;
			this.labelLogin.Location = new System.Drawing.Point(246, 170);
			this.labelLogin.Name = "labelLogin";
			this.labelLogin.Size = new System.Drawing.Size(65, 25);
			this.labelLogin.TabIndex = 3;
			this.labelLogin.Text = "Login";
			// 
			// labelPassword
			// 
			this.labelPassword.AutoSize = true;
			this.labelPassword.Location = new System.Drawing.Point(205, 209);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(106, 25);
			this.labelPassword.TabIndex = 4;
			this.labelPassword.Text = "Password";
			// 
			// txtLogin
			// 
			this.txtLogin.Location = new System.Drawing.Point(326, 172);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(243, 31);
			this.txtLogin.TabIndex = 7;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(326, 209);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(243, 31);
			this.txtPassword.TabIndex = 8;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(451, 269);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(164, 42);
			this.btnSave.TabIndex = 9;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(221, 269);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(164, 42);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// labelRoles
			// 
			this.labelRoles.AutoSize = true;
			this.labelRoles.Location = new System.Drawing.Point(255, 127);
			this.labelRoles.Name = "labelRoles";
			this.labelRoles.Size = new System.Drawing.Size(56, 25);
			this.labelRoles.TabIndex = 11;
			this.labelRoles.Text = "Role";
			// 
			// cmbRoles
			// 
			this.cmbRoles.FormattingEnabled = true;
			this.cmbRoles.Location = new System.Drawing.Point(326, 124);
			this.cmbRoles.Name = "cmbRoles";
			this.cmbRoles.Size = new System.Drawing.Size(245, 33);
			this.cmbRoles.TabIndex = 12;
			// 
			// UserEditorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cmbRoles);
			this.Controls.Add(this.labelRoles);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtLogin);
			this.Controls.Add(this.labelPassword);
			this.Controls.Add(this.labelLogin);
			this.Name = "UserEditorForm";
			this.Text = "UserEditorForm";
			this.Load += new System.EventHandler(this.UserEditorForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelRoles;
        private System.Windows.Forms.ComboBox cmbRoles;
    }
}