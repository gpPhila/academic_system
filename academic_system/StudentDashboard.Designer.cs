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
			this.btnManageAcc.Location = new System.Drawing.Point(816, 158);
			this.btnManageAcc.Name = "btnManageAcc";
			this.btnManageAcc.Size = new System.Drawing.Size(225, 45);
			this.btnManageAcc.TabIndex = 1;
			this.btnManageAcc.Text = "Manage account";
			this.btnManageAcc.UseVisualStyleBackColor = true;
			// 
			// btnLogOut
			// 
			this.btnLogOut.Location = new System.Drawing.Point(816, 209);
			this.btnLogOut.Name = "btnLogOut";
			this.btnLogOut.Size = new System.Drawing.Size(225, 45);
			this.btnLogOut.TabIndex = 2;
			this.btnLogOut.Text = "Log out";
			this.btnLogOut.UseVisualStyleBackColor = true;
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
			this.labelStudentSubjects.Location = new System.Drawing.Point(338, 158);
			this.labelStudentSubjects.Name = "labelStudentSubjects";
			this.labelStudentSubjects.Size = new System.Drawing.Size(101, 25);
			this.labelStudentSubjects.TabIndex = 4;
			this.labelStudentSubjects.Text = "Subjects:";
			// 
			// StudentDashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1081, 649);
			this.Controls.Add(this.labelStudentSubjects);
			this.Controls.Add(this.labelStudentInfo);
			this.Controls.Add(this.btnLogOut);
			this.Controls.Add(this.btnManageAcc);
			this.Controls.Add(this.label1);
			this.Name = "StudentDashboard";
			this.Text = "StudentDashboard";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManageAcc;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label labelStudentInfo;
        private System.Windows.Forms.Label labelStudentSubjects;
    }
}