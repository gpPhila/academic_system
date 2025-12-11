namespace academic_system
{
    partial class ManageStudentGroupsForm
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
			this.dgvGroups = new System.Windows.Forms.DataGridView();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
			this.SuspendLayout();
			// 
			// labelMain
			// 
			this.labelMain.AutoSize = true;
			this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMain.Location = new System.Drawing.Point(345, 144);
			this.labelMain.Name = "labelMain";
			this.labelMain.Size = new System.Drawing.Size(426, 42);
			this.labelMain.TabIndex = 0;
			this.labelMain.Text = "Manage Student Groups";
			// 
			// dgvGroups
			// 
			this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvGroups.Location = new System.Drawing.Point(23, 267);
			this.dgvGroups.Name = "dgvGroups";
			this.dgvGroups.RowHeadersWidth = 82;
			this.dgvGroups.RowTemplate.Height = 33;
			this.dgvGroups.Size = new System.Drawing.Size(657, 422);
			this.dgvGroups.TabIndex = 1;
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(830, 353);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(205, 70);
			this.btnCreate.TabIndex = 2;
			this.btnCreate.Text = "Create new";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(830, 440);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(205, 70);
			this.btnUpdate.TabIndex = 3;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(830, 527);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(205, 70);
			this.btnDelete.TabIndex = 5;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// ManageStudentGroupsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1154, 746);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.dgvGroups);
			this.Controls.Add(this.labelMain);
			this.Name = "ManageStudentGroupsForm";
			this.Text = "ManageStudentGroupsForm";
			((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}