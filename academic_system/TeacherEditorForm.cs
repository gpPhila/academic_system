using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace academic_system
{
    public partial class TeacherEditorForm : Form
    {
		public bool IsUpdate { get; }

		public string FirstName => txtFirstName.Text.Trim();
		public string LastName => txtLastName.Text.Trim();
		public TeacherEditorForm(string title, Teacher existingTeacher = null)
        {
            InitializeComponent();
			this.Text = title;

			IsUpdate = existingTeacher != null;

			if (IsUpdate)
			{
				txtFirstName.Text = existingTeacher.FirstName;
				txtLastName.Text = existingTeacher.LastName;
			}
		}

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
			if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName))
			{
				MessageBox.Show("Please fill both fields.");
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
