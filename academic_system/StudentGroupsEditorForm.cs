using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mysqlx.Crud;

namespace academic_system
{
    public partial class StudentGroupsEditorForm : Form
    {
		public string GroupName => txtName.Text.Trim();
		public bool IsUpdate { get; }

		private readonly Group existingGroup;
		public StudentGroupsEditorForm(string title, Group group = null)
        {
            InitializeComponent();
			this.Text = title;

			existingGroup = group;
			IsUpdate = group != null;

			if (IsUpdate)
			{
				txtName.Text = group.Name;
			}
		}

        private void btnSave_Click(object sender, EventArgs e)
        {
			if (string.IsNullOrEmpty(GroupName))
			{
				MessageBox.Show("Please fill the field.");
				return;
			}

			DialogResult = DialogResult.OK;
			Close();
		}

        private void btnCancel_Click(object sender, EventArgs e)
        {
			DialogResult = DialogResult.Cancel;
			Close();
		}
    }
}
