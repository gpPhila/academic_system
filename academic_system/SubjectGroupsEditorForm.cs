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
    public partial class SubjectGroupsEditorForm : Form
    {
		private readonly AdminManager manager;
		private readonly GroupOfSubjects existingGos;
		private readonly bool isUpdate;

		public string GOSName => txtGOS.Text.Trim();
		public SubjectGroupsEditorForm(string title, GroupOfSubjects gos = null)
        {
            InitializeComponent();

			Text = title;
			existingGos = gos;
			isUpdate = gos != null;

			if (isUpdate)
				LoadExistingData();
		}
		private void LoadExistingData()
		{
			txtGOS.Text = existingGos.Name;
		}

		private void txtGOS_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
			if (string.IsNullOrWhiteSpace(GOSName))
			{
				MessageBox.Show("Please enter a name.");
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
