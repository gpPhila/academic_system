namespace academic_system
{
    partial class ManageTeachersForm
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
			this.dgvTeachers = new System.Windows.Forms.DataGridView();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
			this.SuspendLayout();
			// 
			// labelMain
			// 
			this.labelMain.AutoSize = true;
			this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMain.Location = new System.Drawing.Point(476, 113);
			this.labelMain.Name = "labelMain";
			this.labelMain.Size = new System.Drawing.Size(321, 42);
			this.labelMain.TabIndex = 0;
			this.labelMain.Text = "Manage Teachers";
			// 
			// dgvTeachers
			// 
			this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTeachers.Location = new System.Drawing.Point(24, 289);
			this.dgvTeachers.Name = "dgvTeachers";
			this.dgvTeachers.RowHeadersWidth = 82;
			this.dgvTeachers.RowTemplate.Height = 33;
			this.dgvTeachers.Size = new System.Drawing.Size(715, 417);
			this.dgvTeachers.TabIndex = 1;
			this.dgvTeachers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeachers_CellContentClick);
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(852, 361);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnCreate.Size = new System.Drawing.Size(279, 64);
			this.btnCreate.TabIndex = 2;
			this.btnCreate.Text = "Create new";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(852, 447);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnUpdate.Size = new System.Drawing.Size(279, 64);
			this.btnUpdate.TabIndex = 3;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(852, 531);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnDelete.Size = new System.Drawing.Size(279, 64);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// ManageTeachersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1217, 757);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.dgvTeachers);
			this.Controls.Add(this.labelMain);
			this.Name = "ManageTeachersForm";
			this.Text = "ManageTeachersForm";
			((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}