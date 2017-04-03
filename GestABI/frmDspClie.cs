using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestABI
{
    /// <summary>
    /// Classe dérivée de frmClie : form de lecture et de modification des clients
    /// </summary>
    public partial class frmDspClie : frmNewClie
    {
        /// <summary>
        /// Rang du client traité
        /// </summary>
        private Int32 iClient;

        public frmDspClie()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Au chargement du form : initiation de l'affichage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDspClie_Load(object sender, EventArgs e)
        {
            base.grbRecherche_frmClie.Visible = false;
            base.grbFiche_frmClie.Visible = false;
            this.lblNoClient.Visible = true;
            this.btnModiCont.Visible = false;
            this.btnValiModi.Visible = false;            
            this.btnSupp_frmDspClie.Visible = false;
            this.btnAjou_frmDspClie.Visible = true;
        }

        /// <summary>
        /// Menu "Fenêtre/Clients/Ajouter" => Instancie un form "Ajouter un nouveau client"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjou_frmDspClie_Click(object sender, EventArgs e)
        {
            frmNewClie frmNCont = new frmNewClie()  // Déclare une instance du form frmNewCont (Ajouter un contact)
            { MdiParent = this };                   // Instancie le form frmNCont 
            frmNCont.Show();                        // Affiche le form frmNCont dans son conteneur frmMDI
            if (frmNCont.ShowDialog() == DialogResult.OK)
            {
                base.grbRecherche_frmClie.Visible = false;  // Au besoin, afficher les textbox   
                base.grbFiche_frmClie.Visible = true;
              //  this.grbBoutons_frmNewClie.Visible = true;  // Gère l'affichage des boutons                                 
                this.iClient = MSclient.Nclient - 1;        // Recherche rang du stagiaire saisi       
                this.afficheUnClient(iClient);              // Afficher ce client sur le form  
            }
        }

        /// <summary>
        /// Remplissage des textbox du form
        /// </summary>
        /// <param name="i"> Rang du stagiaire dans la collection d'objets </param>
        private void afficheUnClient (Int32 i)
        {
            MSclient leClient = Donnees.ArrayClient[i];
            // Affiche les textbox qui sont héritées (==> base.) et les convetit en chaine
            
            base.txt_nomClient.Text = leClient.NomClient;
            base.txt_idClient.Text = leClient.IdClient.ToString();
            cbb_typeSociete.Text = leClient.TypeClient;
            base.txt_activite.Text = leClient.Activite;
            base.txt_cA.Text = leClient.CA.ToString();
            cbb_nature.Text = leClient.Nature;
            base.txt_raisonSociale.Text = leClient.RaisonSociale;
            base.txt_effectif.Text = leClient.Effectif.ToString();
            base.txt_telephone.Text = leClient.Telephone;
            base.txt_mail.Text = leClient.Mail;
            base.txt_adresse.Text = leClient.Adresse;
            base.txt_codeClient.Text = leClient.CodeClient;
            base.txt_ville.Text = leClient.Ville;
            base.txt_commClient.Text = leClient.CommClient;
        }
    }
}
