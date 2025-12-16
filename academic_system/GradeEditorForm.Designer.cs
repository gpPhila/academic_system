namespace academic_system
{
    partial class GradeEditorForm
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
			this.labelStudentName = new System.Windows.Forms.Label();
			this.txtStudentName = new System.Windows.Forms.TextBox();
			this.txtSubjectName = new System.Windows.Forms.TextBox();
			this.labelSubject = new System.Windows.Forms.Label();
			this.dgvGrades = new System.Windows.Forms.DataGridView();
			this.txtGradeValue = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();
			this.SuspendLayout();
			// 
			// labelStudentName
			// 
			this.labelStudentName.AutoSize = true;
			this.labelStudentName.Location = new System.Drawing.Point(174, 70);
			this.labelStudentName.Name = "labelStudentName";
			this.labelStudentName.Size = new System.Drawing.Size(86, 25);
			this.labelStudentName.TabIndex = 0;
			this.labelStudentName.Text = "Student";
			// 
			// txtStudentName
			// 
			this.txtStudentName.Location = new System.Drawing.Point(179, 98);
			this.txtStudentName.Name = "txtStudentName";
			this.txtStudentName.Size = new System.Drawing.Size(320, 31);
			this.txtStudentName.TabIndex = 1;
			// 
			// txtSubjectName
			// 
			this.txtSubjectName.Location = new System.Drawing.Point(181, 160);
			this.txtSubjectName.Name = "txtSubjectName";
			this.txtSubjectName.Size = new System.Drawing.Size(320, 31);
			this.txtSubjectName.TabIndex = 3;
			// 
			// labelSubject
			// 
			this.labelSubject.AutoSize = true;
			this.labelSubject.Location = new System.Drawing.Point(176, 132);
			this.labelSubject.Name = "labelSubject";
			this.labelSubject.Size = new System.Drawing.Size(84, 25);
			this.labelSubject.TabIndex = 2;
			this.labelSubject.Text = "Subject";
			// 
			// dgvGrades
			// 
			this.dgvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvGrades.Location = new System.Drawing.Point(183, 214);
			this.dgvGrades.Name = "dgvGrades";
			this.dgvGrades.RowHeadersWidth = 82;
			this.dgvGrades.RowTemplate.Height = 33;
			this.dgvGrades.Size = new System.Drawing.Size(315, 312);
			this.dgvGrades.TabIndex = 4;
			// 
			// txtGradeValue
			// 
			this.txtGradeValue.Location = new System.Drawing.Point(518, 347);
			this.txtGradeValue.Name = "txtGradeValue";
			this.txtGradeValue.Size = new System.Drawing.Size(58, 31);
			this.txtGradeValue.TabIndex = 5;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(516, 394);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(119, 40);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(518, 440);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(119, 40);
			this.btnUpdate.TabIndex = 7;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(518, 486);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(119, 40);
			this.btnDelete.TabIndex = 8;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(361, 544);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(119, 40);
			this.btnOK.TabIndex = 9;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// GradeEditorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(819, 637);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtGradeValue);
			this.Controls.Add(this.dgvGrades);
			this.Controls.Add(this.txtSubjectName);
			this.Controls.Add(this.labelSubject);
			this.Controls.Add(this.txtStudentName);
			this.Controls.Add(this.labelStudentName);
			this.Name = "GradeEditorForm";
			this.Text = "GradeEditorForm";
			this.Load += new System.EventHandler(this.GradeEditorForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.DataGridView dgvGrades;
        private System.Windows.Forms.TextBox txtGradeValue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOK;
    }
}