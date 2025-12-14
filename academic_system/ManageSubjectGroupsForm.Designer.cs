namespace academic_system
{
    partial class ManageSubjectGroupsForm
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
			this.dgvSubjectGroups = new System.Windows.Forms.DataGridView();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAddSubjects = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvSubjectGroups)).BeginInit();
			this.SuspendLayout();
			// 
			// labelMain
			// 
			this.labelMain.AutoSize = true;
			this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMain.Location = new System.Drawing.Point(398, 116);
			this.labelMain.Name = "labelMain";
			this.labelMain.Size = new System.Drawing.Size(422, 42);
			this.labelMain.TabIndex = 0;
			this.labelMain.Text = "Manage Subject Groups";
			// 
			// dgvSubjectGroups
			// 
			this.dgvSubjectGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSubjectGroups.Location = new System.Drawing.Point(51, 283);
			this.dgvSubjectGroups.Name = "dgvSubjectGroups";
			this.dgvSubjectGroups.RowHeadersWidth = 82;
			this.dgvSubjectGroups.RowTemplate.Height = 33;
			this.dgvSubjectGroups.Size = new System.Drawing.Size(733, 447);
			this.dgvSubjectGroups.TabIndex = 1;
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(855, 335);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(290, 69);
			this.btnCreate.TabIndex = 2;
			this.btnCreate.Text = "Create new";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(855, 428);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(290, 69);
			this.btnUpdate.TabIndex = 3;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(855, 610);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(290, 69);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnAddSubjects
			// 
			this.btnAddSubjects.Location = new System.Drawing.Point(855, 518);
			this.btnAddSubjects.Name = "btnAddSubjects";
			this.btnAddSubjects.Size = new System.Drawing.Size(290, 69);
			this.btnAddSubjects.TabIndex = 5;
			this.btnAddSubjects.Text = "Add subjects";
			this.btnAddSubjects.UseVisualStyleBackColor = true;
			this.btnAddSubjects.Click += new System.EventHandler(this.btnAddSubjects_Click);
			// 
			// ManageSubjectGroupsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1208, 794);
			this.Controls.Add(this.btnAddSubjects);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.dgvSubjectGroups);
			this.Controls.Add(this.labelMain);
			this.Name = "ManageSubjectGroupsForm";
			this.Text = "ManageSubjectGroupsForm";
			((System.ComponentModel.ISupportInitialize)(this.dgvSubjectGroups)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.DataGridView dgvSubjectGroups;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddSubjects;
    }
}