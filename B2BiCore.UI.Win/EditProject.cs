using B2BiCore.Domain;
using B2BiCore.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B2BiCore.UI.Win
{
    public partial class EditProject : Form
    {
        private ProjectModel proj = new ProjectModel();
        bool isConnectionValid = false;
        public EditProject()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Referesh lbxProjects
            lbxProjects.DataSource = GetAllProjectNames();
            InitializecbxDatabaseProvider();
        }

        private void InitializecbxDatabaseProvider()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (int enumValue in Enum.GetValues(typeof(DatabaseTypes)))
            {
                dict.Add(Enum.GetName(typeof(DatabaseTypes),enumValue),enumValue);
            }

            cbxDataProvider.DisplayMember = "Key";
            cbxDataProvider.ValueMember = "Value";
            cbxDataProvider.DataSource = new BindingSource(dict, null);

        }

        private List<string> GetAllProjectNames()
        {
            List<string> projectList = new List<string>();
            DomainController domain = new DomainController();
            List<ProjectModel> models = domain.GetProjectModels();

            List<string> names = new List<string>();
            foreach (ProjectModel p in models)
            {
                names.Add(p.Name);
            }
            return names;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnRefresh_Click(this , e);

            txtDatabaseServer.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtInitialCatalog.Clear();

            isConnectionValid = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            proj.Server= txtDatabaseServer.Text;
            proj.Username =  txtUsername.Text;
            proj.Password= txtPassword.Text;
            proj.Database =  txtInitialCatalog.Text;
            proj.DatabaseType = (string) cbxDataProvider.SelectedValue;

        }

        private void btnOK_Validating(object sender, CancelEventArgs e)
        {
            if (ValidateForm())
            {

            }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                //Connect to DB and retrieve SIVersion Table.

            }


        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtDatabaseServer.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtInitialCatalog.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace ((string) cbxDataProvider.SelectedValue))
            {
                return false;
            }

            return true;
        }
    }
}
