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
    public partial class ManageSubjectGroupsForm : Form
    {
		private readonly AdminManager manager;
		public ManageSubjectGroupsForm(AdminManager manager)
        {
            InitializeComponent();
            this.manager = manager;

            LoadGroups();
        }

		private void LoadGroups()
		{
			
		}

		private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
