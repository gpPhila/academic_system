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
		private readonly AdminManager manager;
		private readonly Group existingGroup;
		public string GroupName => txtName.Text.Trim();
		public bool IsUpdate { get; }
		public int? SelectedGosId
		{
			get
			{
				if (cmbGOS.SelectedItem is GOSOption option)
					return option.Id;

				return null;
			}
		}
		private class GOSOption
		{
			public int? Id { get; set; } 
			public string Name { get; set; }
			public override string ToString() => Name;
		}

		public StudentGroupsEditorForm(string title, AdminManager manager, Group group = null)
        {
            InitializeComponent();
			this.Text = title;

			this.manager = manager;
			existingGroup = group;
			IsUpdate = group != null;

			LoadGOSIntoComboBox();

			if (IsUpdate)
			{
				//txtName.Text = group.Name;
				LoadExistingData();
			}
		}

		private void LoadGOSIntoComboBox()
		{
			cmbGOS.Items.Clear();

			cmbGOS.Items.Add(new GOSOption
			{
				Id = null,
				Name = "--- Choose a group ---"
			});

			foreach (var gos in manager.GetAllGOS())
			{
				cmbGOS.Items.Add(new GOSOption
				{
					Id = gos.GOSId,
					Name = gos.Name
				});
			}

			cmbGOS.SelectedIndex = 0;
		}

		private void LoadExistingData()
		{
			txtName.Text = existingGroup.Name;

			foreach (var item in cmbGOS.Items)
			{
				if (item is GOSOption option && option.Id == existingGroup.GosId)
				{
					cmbGOS.SelectedItem = item;
					return;
				}
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

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
