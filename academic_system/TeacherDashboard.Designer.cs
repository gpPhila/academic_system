namespace academic_system
{
    partial class TeacherDashboard
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
			this.labelMain = new System.Windows.Forms.Label();
			this.btnManage = new System.Windows.Forms.Button();
			this.btnLogOut = new System.Windows.Forms.Button();
			this.labelInfo = new System.Windows.Forms.Label();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.cmbGroups = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnFilter = new System.Windows.Forms.Button();
			this.dgvSubject = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvStudent = new System.Windows.Forms.DataGridView();
			this.labelStudents = new System.Windows.Forms.Label();
			this.btnGrade = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
			this.SuspendLayout();
			// 
			// labelMain
			// 
			this.labelMain.AutoSize = true;
			this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMain.Location = new System.Drawing.Point(455, 122);
			this.labelMain.Name = "labelMain";
			this.labelMain.Size = new System.Drawing.Size(350, 42);
			this.labelMain.TabIndex = 0;
			this.labelMain.Text = "Teacher Dashboard";
			// 
			// btnManage
			// 
			this.btnManage.Location = new System.Drawing.Point(25, 492);
			this.btnManage.Name = "btnManage";
			this.btnManage.Size = new System.Drawing.Size(211, 53);
			this.btnManage.TabIndex = 1;
			this.btnManage.Text = "Manage account";
			this.btnManage.UseVisualStyleBackColor = true;
			this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
			// 
			// btnLogOut
			// 
			this.btnLogOut.Location = new System.Drawing.Point(25, 560);
			this.btnLogOut.Name = "btnLogOut";
			this.btnLogOut.Size = new System.Drawing.Size(211, 53);
			this.btnLogOut.TabIndex = 2;
			this.btnLogOut.Text = "Log out";
			this.btnLogOut.UseVisualStyleBackColor = true;
			this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
			// 
			// labelInfo
			// 
			this.labelInfo.AutoSize = true;
			this.labelInfo.Location = new System.Drawing.Point(28, 370);
			this.labelInfo.Name = "labelInfo";
			this.labelInfo.Size = new System.Drawing.Size(209, 25);
			this.labelInfo.TabIndex = 3;
			this.labelInfo.Text = "Teacher information:";
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(25, 410);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(211, 31);
			this.txtFirstName.TabIndex = 4;
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(25, 447);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(211, 31);
			this.txtLastName.TabIndex = 5;
			// 
			// cmbGroups
			// 
			this.cmbGroups.FormattingEnabled = true;
			this.cmbGroups.Location = new System.Drawing.Point(25, 279);
			this.cmbGroups.Name = "cmbGroups";
			this.cmbGroups.Size = new System.Drawing.Size(242, 33);
			this.cmbGroups.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 241);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 25);
			this.label1.TabIndex = 8;
			this.label1.Text = "Groups:";
			// 
			// btnFilter
			// 
			this.btnFilter.Location = new System.Drawing.Point(25, 318);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.Size = new System.Drawing.Size(144, 39);
			this.btnFilter.TabIndex = 9;
			this.btnFilter.Text = "Filter";
			this.btnFilter.UseVisualStyleBackColor = true;
			this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
			// 
			// dgvSubject
			// 
			this.dgvSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSubject.Location = new System.Drawing.Point(282, 279);
			this.dgvSubject.Name = "dgvSubject";
			this.dgvSubject.RowHeadersWidth = 82;
			this.dgvSubject.RowTemplate.Height = 33;
			this.dgvSubject.Size = new System.Drawing.Size(366, 456);
			this.dgvSubject.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(277, 239);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 25);
			this.label2.TabIndex = 11;
			this.label2.Text = "Subjects:";
			// 
			// dgvStudent
			// 
			this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStudent.Location = new System.Drawing.Point(676, 279);
			this.dgvStudent.Name = "dgvStudent";
			this.dgvStudent.RowHeadersWidth = 82;
			this.dgvStudent.RowTemplate.Height = 33;
			this.dgvStudent.Size = new System.Drawing.Size(496, 456);
			this.dgvStudent.TabIndex = 13;
			// 
			// labelStudents
			// 
			this.labelStudents.AutoSize = true;
			this.labelStudents.Location = new System.Drawing.Point(671, 239);
			this.labelStudents.Name = "labelStudents";
			this.labelStudents.Size = new System.Drawing.Size(103, 25);
			this.labelStudents.TabIndex = 14;
			this.labelStudents.Text = "Students:";
			// 
			// btnGrade
			// 
			this.btnGrade.Location = new System.Drawing.Point(1043, 741);
			this.btnGrade.Name = "btnGrade";
			this.btnGrade.Size = new System.Drawing.Size(129, 53);
			this.btnGrade.TabIndex = 15;
			this.btnGrade.Text = "Grade";
			this.btnGrade.UseVisualStyleBackColor = true;
			this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
			// 
			// TeacherDashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1231, 842);
			this.Controls.Add(this.btnGrade);
			this.Controls.Add(this.labelStudents);
			this.Controls.Add(this.dgvStudent);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dgvSubject);
			this.Controls.Add(this.btnFilter);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbGroups);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.labelInfo);
			this.Controls.Add(this.btnLogOut);
			this.Controls.Add(this.btnManage);
			this.Controls.Add(this.labelMain);
			this.Name = "TeacherDashboard";
			this.Text = "TeacherDashboard";
			this.Load += new System.EventHandler(this.TeacherDashboard_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridView dgvSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Label labelStudents;
        private System.Windows.Forms.Button btnGrade;
    }
}