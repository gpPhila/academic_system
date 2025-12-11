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
    public partial class SubjectEditorForm : Form
    {
		private readonly AdminManager manager;
		private readonly Subject existingSubject;
		private readonly bool isUpdate;

		public string SubjectName => txtName.Text.Trim();
		public string SubjectDescription => txtDescription.Text.Trim();
		public int SelectedTeacherId 
		{
			get
			{
				return (int)cmbTeacher.SelectedValue;
			}
		}

		public SubjectEditorForm(string title, AdminManager manager, Subject subject = null)
        {
            InitializeComponent();
			this.Text = title;
			this.manager = manager;
			this.existingSubject = subject;
			this.isUpdate = subject != null;

			LoadTeachersIntoComboBox();

			if (isUpdate)
				LoadExistingData();
		}
		private void LoadTeachersIntoComboBox()
		{
			/*
			cmbTeacher.Items.Clear();
			var teachers = manager.GetAllTeachers();

			cmbTeacher.Items.Add("No teacher");

			foreach (var t in teachers)
				cmbTeacher.Items.Add(t);

			cmbTeacher.DisplayMember = "FirstName";
			*/

			cmbTeacher.Items.Clear();
			//cmbTeacher.Items.Add(new { Name = "No teacher", Id = (int?)null });

			var teachers = manager.GetAllTeachers();

			foreach (var t in teachers)
			{
				cmbTeacher.Items.Add(new
				{
					Name = $"{t.FirstName} {t.LastName}",
					Id = (int?)t.TeacherId
				});
			}

			cmbTeacher.DisplayMember = "Name";
			cmbTeacher.ValueMember = "Id";
		}

		private void LoadExistingData()
		{
			txtName.Text = existingSubject.Name;
			txtDescription.Text = existingSubject.Description;

			if (existingSubject.TeacherId != 0)
			{
				foreach (var item in cmbTeacher.Items)
				{
					if (item is Teacher teacher && teacher.TeacherId == existingSubject.TeacherId)
					{
						cmbTeacher.SelectedItem = item;
						break;
					}
				}
			}
			else
			{
				cmbTeacher.SelectedIndex = 0; 
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
        {
			if (string.IsNullOrWhiteSpace(SubjectName))
			{
				MessageBox.Show("Please enter subject name.");
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
