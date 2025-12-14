namespace academic_system
{
    partial class StudentDashboard
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnManageAcc = new System.Windows.Forms.Button();
			this.btnLogOut = new System.Windows.Forms.Button();
			this.labelStudentInfo = new System.Windows.Forms.Label();
			this.labelStudentSubjects = new System.Windows.Forms.Label();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtGroup = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(334, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(393, 51);
			this.label1.TabIndex = 0;
			this.label1.Text = "Student Dashboard";
			// 
			// btnManageAcc
			// 
			this.btnManageAcc.Location = new System.Drawing.Point(820, 193);
			this.btnManageAcc.Name = "btnManageAcc";
			this.btnManageAcc.Size = new System.Drawing.Size(225, 45);
			this.btnManageAcc.TabIndex = 1;
			this.btnManageAcc.Text = "Manage account";
			this.btnManageAcc.UseVisualStyleBackColor = true;
			this.btnManageAcc.Click += new System.EventHandler(this.btnManageAcc_Click);
			// 
			// btnLogOut
			// 
			this.btnLogOut.Location = new System.Drawing.Point(820, 244);
			this.btnLogOut.Name = "btnLogOut";
			this.btnLogOut.Size = new System.Drawing.Size(225, 45);
			this.btnLogOut.TabIndex = 2;
			this.btnLogOut.Text = "Log out";
			this.btnLogOut.UseVisualStyleBackColor = true;
			this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
			// 
			// labelStudentInfo
			// 
			this.labelStudentInfo.AutoSize = true;
			this.labelStudentInfo.Location = new System.Drawing.Point(30, 158);
			this.labelStudentInfo.Name = "labelStudentInfo";
			this.labelStudentInfo.Size = new System.Drawing.Size(204, 25);
			this.labelStudentInfo.TabIndex = 3;
			this.labelStudentInfo.Text = "Student information:";
			// 
			// labelStudentSubjects
			// 
			this.labelStudentSubjects.AutoSize = true;
			this.labelStudentSubjects.Location = new System.Drawing.Point(273, 158);
			this.labelStudentSubjects.Name = "labelStudentSubjects";
			this.labelStudentSubjects.Size = new System.Drawing.Size(88, 25);
			this.labelStudentSubjects.TabIndex = 4;
			this.labelStudentSubjects.Text = "Grades:";
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(37, 195);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(196, 31);
			this.txtFirstName.TabIndex = 5;
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(38, 232);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(196, 31);
			this.txtLastName.TabIndex = 6;
			// 
			// txtGroup
			// 
			this.txtGroup.Location = new System.Drawing.Point(38, 269);
			this.txtGroup.Name = "txtGroup";
			this.txtGroup.Size = new System.Drawing.Size(196, 31);
			this.txtGroup.TabIndex = 7;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(278, 195);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 82;
			this.dataGridView1.RowTemplate.Height = 33;
			this.dataGridView1.Size = new System.Drawing.Size(504, 420);
			this.dataGridView1.TabIndex = 8;
			// 
			// StudentDashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1081, 649);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtGroup);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.labelStudentSubjects);
			this.Controls.Add(this.labelStudentInfo);
			this.Controls.Add(this.btnLogOut);
			this.Controls.Add(this.btnManageAcc);
			this.Controls.Add(this.label1);
			this.Name = "StudentDashboard";
			this.Text = "StudentDashboard";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManageAcc;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label labelStudentInfo;
        private System.Windows.Forms.Label labelStudentSubjects;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}