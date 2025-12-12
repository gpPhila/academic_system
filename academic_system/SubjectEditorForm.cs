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
				if (cmbTeacher.SelectedItem is TeacherOption option)
					return option.Id;

				return -1;
			}
		}
		private class TeacherOption
		{
			public int Id { get; set; }
			public string Name { get; set; }
			public override string ToString() => Name;
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
			cmbTeacher.Items.Clear();

			cmbTeacher.Items.Add(new TeacherOption
			{
				Id = -1,
				Name = "--- Select a teacher ---"
			});

			foreach (var teacher in manager.GetAllTeachers())
			{
				cmbTeacher.Items.Add(new TeacherOption
				{
					Id = teacher.TeacherId,
					Name = $"{teacher.FirstName} {teacher.LastName}"
				});
			}

			cmbTeacher.SelectedIndex = 0;
		}

		private void LoadExistingData()
		{
			txtName.Text = existingSubject.Name;
			txtDescription.Text = existingSubject.Description;

			foreach (var item in cmbTeacher.Items)
			{
				if (item is TeacherOption option && option.Id == existingSubject.TeacherId)
				{
					cmbTeacher.SelectedItem = item;
					return;
				}
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
        {
			if (string.IsNullOrWhiteSpace(SubjectName))
			{
				MessageBox.Show("Please enter subject name.");
				return;
			}

			if (SelectedTeacherId == -1)
			{
				MessageBox.Show("Please select a teacher.");
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

        private void cmbTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
