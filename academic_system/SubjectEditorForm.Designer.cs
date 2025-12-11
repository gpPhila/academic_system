namespace academic_system
{
    partial class SubjectEditorForm
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
			this.labelName = new System.Windows.Forms.Label();
			this.labelDescription = new System.Windows.Forms.Label();
			this.labelTeacher = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtDescription = new System.Windows.Forms.RichTextBox();
			this.cmbTeacher = new System.Windows.Forms.ComboBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(227, 103);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(68, 25);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Name";
			// 
			// labelDescription
			// 
			this.labelDescription.AutoSize = true;
			this.labelDescription.Location = new System.Drawing.Point(175, 140);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(120, 25);
			this.labelDescription.TabIndex = 1;
			this.labelDescription.Text = "Description";
			// 
			// labelTeacher
			// 
			this.labelTeacher.AutoSize = true;
			this.labelTeacher.Location = new System.Drawing.Point(204, 309);
			this.labelTeacher.Name = "labelTeacher";
			this.labelTeacher.Size = new System.Drawing.Size(91, 25);
			this.labelTeacher.TabIndex = 2;
			this.labelTeacher.Text = "Teacher";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(315, 100);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(310, 31);
			this.txtName.TabIndex = 3;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(316, 140);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(309, 155);
			this.txtDescription.TabIndex = 4;
			this.txtDescription.Text = "";
			// 
			// cmbTeacher
			// 
			this.cmbTeacher.FormattingEnabled = true;
			this.cmbTeacher.Location = new System.Drawing.Point(315, 306);
			this.cmbTeacher.Name = "cmbTeacher";
			this.cmbTeacher.Size = new System.Drawing.Size(308, 33);
			this.cmbTeacher.TabIndex = 5;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(466, 359);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(159, 45);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(282, 359);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(159, 45);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// SubjectEditorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(850, 501);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.cmbTeacher);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.labelTeacher);
			this.Controls.Add(this.labelDescription);
			this.Controls.Add(this.labelName);
			this.Name = "SubjectEditorForm";
			this.Text = "SubjectEditorForm";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbTeacher;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}