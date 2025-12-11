namespace academic_system
{
    partial class ManageSubjectsForm
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
			this.labelManageSubjects = new System.Windows.Forms.Label();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.dgvSubjects = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
			this.SuspendLayout();
			// 
			// labelManageSubjects
			// 
			this.labelManageSubjects.AutoSize = true;
			this.labelManageSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelManageSubjects.Location = new System.Drawing.Point(402, 105);
			this.labelManageSubjects.Name = "labelManageSubjects";
			this.labelManageSubjects.Size = new System.Drawing.Size(308, 42);
			this.labelManageSubjects.TabIndex = 0;
			this.labelManageSubjects.Text = "Manage Subjects";
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(796, 298);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(255, 59);
			this.btnCreate.TabIndex = 1;
			this.btnCreate.Text = "Create new";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(796, 382);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(255, 59);
			this.btnUpdate.TabIndex = 2;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(796, 467);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(255, 59);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// dgvSubjects
			// 
			this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSubjects.Location = new System.Drawing.Point(21, 236);
			this.dgvSubjects.Name = "dgvSubjects";
			this.dgvSubjects.RowHeadersWidth = 82;
			this.dgvSubjects.RowTemplate.Height = 33;
			this.dgvSubjects.Size = new System.Drawing.Size(655, 387);
			this.dgvSubjects.TabIndex = 4;
			// 
			// ManageSubjectsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1154, 773);
			this.Controls.Add(this.dgvSubjects);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.labelManageSubjects);
			this.Name = "ManageSubjectsForm";
			this.Text = "ManageSubjectsForm";
			this.Load += new System.EventHandler(this.ManageSubjectsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelManageSubjects;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvSubjects;
    }
}