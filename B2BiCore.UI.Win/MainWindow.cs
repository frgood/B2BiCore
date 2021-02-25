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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            DomainController sut = new DomainController();
            List<ProjectModel> models = sut.GetProjectModels();
            if (models.Count  == 0)
            {
                Form frmEdit = new EditProject();
                frmEdit.Show();
            }


        }
    }
}
