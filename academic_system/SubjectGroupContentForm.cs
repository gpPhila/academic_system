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
    public partial class SubjectGroupContentForm : Form
    {
		private readonly AdminManager manager;
		private readonly GroupOfSubjects gos;
		private class SubjectOption
		{
			public int Id { get; set; }
			public string Name { get; set; }
			public override string ToString() => Name;
		}
		public SubjectGroupContentForm(AdminManager manager, GroupOfSubjects gos)
        {
            InitializeComponent();

			this.manager = manager;
			this.gos = gos;

			txtSelectedGroup.Text = gos.Name;
			txtSelectedGroup.ReadOnly = true;

			LoadSubjectsInGroup();
			LoadSubjectsComboBox();
		}
		private void LoadSubjectsInGroup()
		{
			/*
			dvgGOSS.AllowUserToAddRows = false;
			dvgGOSS.AutoGenerateColumns = true;
			dvgGOSS.DataSource = null;
			dvgGOSS.DataSource = manager.GetGOSSByGosIdWithSubjectName(gos.GOSId);
			*/
			dvgGOSS.AllowUserToAddRows = false;
			dvgGOSS.DataSource = manager.GetGOSSByGosIdWithSubjectName(gos.GOSId);
		}
		private void LoadSubjectsComboBox()
		{
			cmbSubjects.Items.Clear();

			cmbSubjects.Items.Add(new SubjectOption
			{
				Id = -1,
				Name = "-- select a subject --"
			});

			foreach (var subject in manager.GetAllSubjects())
			{
				cmbSubjects.Items.Add(new SubjectOption
				{
					Id = subject.SubjectId,
					Name = subject.Name
				});
			}

			cmbSubjects.SelectedIndex = 0;
		}

		private void btnDelete_Click(object sender, EventArgs e)
        {
			if (dvgGOSS.SelectedRows.Count == 0)
			{
				MessageBox.Show("Select a subject to remove.");
				return;
			}

			//int gossId = (int)dvgGOSS.SelectedRows[0].Cells["GossId"].Value;
			int gossId = Convert.ToInt32(
			dvgGOSS.SelectedRows[0].Cells["goss_id"].Value
			);

			manager.DeleteGOSS(gossId);
			LoadSubjectsInGroup();
		}

        private void cmbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
			if (cmbSubjects.SelectedIndex <= 0)
			{
				MessageBox.Show("Select a subject first.");
				return;
			}

			var option = (SubjectOption)cmbSubjects.SelectedItem;
			manager.AddGOSS(gos.GOSId, option.Id);

			LoadSubjectsInGroup();
			cmbSubjects.SelectedIndex = 0;
		}

        private void btnOK_Click(object sender, EventArgs e)
        {
			DialogResult = DialogResult.OK;
			Close();
		}
    }
}
