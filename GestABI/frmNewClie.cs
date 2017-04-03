using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestABI
{
    public partial class frmNewClie : frmClie
    {
        public frmNewClie()
        {
            InitializeComponent();
            // Replace en haut de la fenêtre "Ajouter un nouveau client" les groupesbox "Fiche" et "Boutons"
            // afin d'éviter un vide laissé par le groupebox "Recherche" devenu invisible. 
            this.grbFiche_frmClie.Location = new System.Drawing.Point(20, 14);
            this.grbBoutons_frmNewClie.Location = new System.Drawing.Point(386, 555);
            this.Height = 664;
        }

        /// <summary>
        /// Bouton OK : Instancie un objet MSclient, enregistre les données remplies et le référence dans la collection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_frmNewClie_Click(object sender, EventArgs e)
        {
            MSclient nouveauClient = new MSclient(); // Crée une référence d'objet MSclient

            //Affecte les données de l'objet MSclient : Variables ou propriétés qui déclenche les méthodes get/set
            nouveauClient.NomClient = base.txt_nomClient.Text;                    // Conversion en MAJUSCULE
            nouveauClient.IdClient = Int32.Parse(base.txt_idClient.Text.Trim());
            nouveauClient.TypeClient = cbb_typeSociete.Text;
            nouveauClient.Activite = base.txt_activite.Text;
            nouveauClient.CA = Decimal.Parse(base.txt_cA.Text.Trim());
            nouveauClient.Nature = cbb_nature.Text;
            nouveauClient.RaisonSociale = base.txt_raisonSociale.Text;
            nouveauClient.Effectif = Int32.Parse(base.txt_effectif.Text.Trim());
            nouveauClient.Telephone = base.txt_telephone.Text;
            nouveauClient.Mail = base.txt_mail.Text;
            nouveauClient.Adresse = base.txt_adresse.Text;
            nouveauClient.CodeClient = base.txt_codeClient.Text;
            nouveauClient.Ville = base.txt_ville.Text;                           // Conversion en MAJUSCULE
            nouveauClient.CommClient  = base.txt_commClient.Text;
            MSclient.Nclient += 1;
            this.DialogResult = DialogResult.OK;                                 // La fermeture de la fenêtre confirme la saisie
        }

        /// <summary>
        /// Bouton Quitter : Ferme le form de saisie car annule l'ajout d'un nouveau client 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuit_frmNewClie_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
