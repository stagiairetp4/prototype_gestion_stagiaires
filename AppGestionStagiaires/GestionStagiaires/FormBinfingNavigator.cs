using AppGestionStagiaires.GestionStagiaires;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionStagiaires.GestionStagiaires
{
    public partial class FormBinfingNavigator : Form
    {
        StagiairesService gestion = new StagiairesService();
        public FormBinfingNavigator()
        {
            InitializeComponent();
        }

        private void FormBinfingNavigator_Load(object sender, EventArgs e)
        {
            stagiaireBindingSource.DataSource = gestion.ListStagiaires();
        }

        private void stagiaireBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            gestion.valider();
        }
    }
}
