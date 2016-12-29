using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entites;

namespace AppGestionStagiaires.GestionStagiaires
{
    public partial class FormStagiaireUC : UserControl
    {
        public FormStagiaireUC()
        {
            InitializeComponent();
        }

        public event EventHandler EnregistrerClick;
        public event EventHandler AnnulerClick;

        
        /// <summary>
        /// Lire ou obtient le stagiaire 
        /// </summary>
        public Stagiaire Stagiaire { set; get; }
          

        private void FormStagiaireUC_Load(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// Afficher l'objet stagiaire dans l'interface
        /// </summary>
        public void AfficherStagiaire()
        {
            txt_nom.Text = Stagiaire.Nom;
            dtp_datetime.Value = Stagiaire.DateNaissance;
        }

        // Enregistrer ou Modifier un Stagiaire
        private void br_enregistrer_Click(object sender, EventArgs e)
        {
            if (this.Stagiaire == null) Stagiaire = new Stagiaire();
            Stagiaire.Nom = txt_nom.Text;
            Stagiaire.DateNaissance = dtp_datetime.Value;
            if (cb_groupe.SelectedItem != null)
                Stagiaire.Groupe = (Groupe)cb_groupe.SelectedItem;
            EnregistrerClick(this, e);
        }

        private void bt_annuler_Click(object sender, EventArgs e)
        {
            AnnulerClick(this, e);
        }
    }
}
