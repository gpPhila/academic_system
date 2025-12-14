namespace academic_system
{
    partial class SubjectGroupContentForm
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
			this.dvgGOSS = new System.Windows.Forms.DataGridView();
			this.labelMain = new System.Windows.Forms.Label();
			this.txtSelectedGroup = new System.Windows.Forms.TextBox();
			this.cmbSubjects = new System.Windows.Forms.ComboBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dvgGOSS)).BeginInit();
			this.SuspendLayout();
			// 
			// dvgGOSS
			// 
			this.dvgGOSS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dvgGOSS.Location = new System.Drawing.Point(32, 161);
			this.dvgGOSS.Name = "dvgGOSS";
			this.dvgGOSS.RowHeadersWidth = 82;
			this.dvgGOSS.RowTemplate.Height = 33;
			this.dvgGOSS.Size = new System.Drawing.Size(549, 354);
			this.dvgGOSS.TabIndex = 0;
			// 
			// labelMain
			// 
			this.labelMain.AutoSize = true;
			this.labelMain.Location = new System.Drawing.Point(33, 89);
			this.labelMain.Name = "labelMain";
			this.labelMain.Size = new System.Drawing.Size(163, 25);
			this.labelMain.TabIndex = 1;
			this.labelMain.Text = "Selected group:";
			// 
			// txtSelectedGroup
			// 
			this.txtSelectedGroup.Location = new System.Drawing.Point(202, 89);
			this.txtSelectedGroup.Name = "txtSelectedGroup";
			this.txtSelectedGroup.Size = new System.Drawing.Size(379, 31);
			this.txtSelectedGroup.TabIndex = 2;
			// 
			// cmbSubjects
			// 
			this.cmbSubjects.FormattingEnabled = true;
			this.cmbSubjects.Location = new System.Drawing.Point(645, 171);
			this.cmbSubjects.Name = "cmbSubjects";
			this.cmbSubjects.Size = new System.Drawing.Size(299, 33);
			this.cmbSubjects.TabIndex = 3;
			this.cmbSubjects.SelectedIndexChanged += new System.EventHandler(this.cmbSubjects_SelectedIndexChanged);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(790, 232);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(153, 41);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(791, 474);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(153, 41);
			this.btnDelete.TabIndex = 5;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(457, 558);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(136, 52);
			this.btnOK.TabIndex = 6;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// SubjectGroupContentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1015, 639);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.cmbSubjects);
			this.Controls.Add(this.txtSelectedGroup);
			this.Controls.Add(this.labelMain);
			this.Controls.Add(this.dvgGOSS);
			this.Name = "SubjectGroupContentForm";
			this.Text = "SubjectGroupContentForm";
			((System.ComponentModel.ISupportInitialize)(this.dvgGOSS)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgGOSS;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.TextBox txtSelectedGroup;
        private System.Windows.Forms.ComboBox cmbSubjects;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOK;
    }
}