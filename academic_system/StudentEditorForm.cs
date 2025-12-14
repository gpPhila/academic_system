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
    public partial class StudentEditorForm : Form
    {
		private readonly AdminManager manager;
		public bool IsUpdate { get; }
		public string FirstName => txtFirstName.Text.Trim();
		public string LastName => txtLastName.Text.Trim();
		public int SelectedGroupId
		{
			get
			{
				if (cmbGroups.SelectedItem is GroupOption option)
					return option.Id;

				return -1;
			}
		}

		private class GroupOption
		{
			public int Id { get; set; }
			public string Name { get; set; }
			public override string ToString() => Name;
		}

		public StudentEditorForm(string title, AdminManager manager, Student existingStudent = null)
        {
            InitializeComponent();
			this.Text = title;
			this.manager = manager;

			IsUpdate = existingStudent != null;

			LoadGroups();

			if (IsUpdate)
			{
				txtFirstName.Text = existingStudent.FirstName;
				txtLastName.Text = existingStudent.LastName;
				
				foreach (var item in cmbGroups.Items)
				{
					if (item is GroupOption option && option.Id == existingStudent.GroupId)
					{
						cmbGroups.SelectedItem = item;
						break;
					}
				}
				
			}

		}

		private void LoadGroups()
		{
			cmbGroups.Items.Clear();

			cmbGroups.Items.Add(new GroupOption
			{
				Id = -1,
				Name = "-- select a group --"
			});

			foreach (var group in manager.GetAllGroups())
			{
				cmbGroups.Items.Add(new GroupOption
				{
					Id = group.GroupId,
					Name = group.Name
				});
			}

			cmbGroups.SelectedIndex = 0;
		}


		private void btnSave_Click(object sender, EventArgs e)
        {
			if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName))
			{
				MessageBox.Show("Please fill all fields.");
				return;
			}

			if (SelectedGroupId == -1)
			{
				MessageBox.Show("Please select a group.");
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
