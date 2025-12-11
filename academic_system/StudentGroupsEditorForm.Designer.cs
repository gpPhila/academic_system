namespace academic_system
{
    partial class StudentGroupsEditorForm
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
			this.txtName = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(219, 166);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(68, 25);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Name";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(320, 163);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(258, 31);
			this.txtName.TabIndex = 1;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(449, 217);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(147, 54);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(270, 217);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(147, 54);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// StudentGroupsEditorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.labelName);
			this.Name = "StudentGroupsEditorForm";
			this.Text = "StudentGroupsEditorForm";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}