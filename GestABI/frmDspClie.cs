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
    public partial class frmDspClie : frmClie
    {    
        /// <summary>
        /// Constructeur adapté : mémorise le client à traiter
        /// </summary>
        /// <param name="unClient"> la référence de l'objet MSclient à gérer dans ce form</param>
        public frmDspClie(ClasseClient unClient)
        {
            //unClient.RaisonSociale = Donnees.ArrayClient[frmListClie.iClie].RaisonSociale;

            this.leClient = unClient;                                                 // Crée une référence d'objet client reçu en paramètre  
            InitializeComponent();
        }

        /// <summary>
        /// La référence du client à afficher / modifier
        /// </summary>
        private ClasseClient leClient;
        
        /// <summary>
        /// Au démarrage, affiche le client reçu sur le form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDspClie_Load(object sender, EventArgs e)
        {
            this.afficheClient(this.leClient);                                        // Affiche le client
        }

        /// <summary>
        /// Procédure affichant en textbox les données d'un client reçu
        /// </summary>
        /// <param name="unClient"></param>
        public void afficheClient(ClasseClient unClient)  
        {
            this.txt_raisonSociale.Text = unClient.RaisonSociale;                     //Affecte les textbox
            this.txt_idClient.Text = unClient.IdClient.ToString();
            this.cbb_type.Text = unClient.TypeClient;
            this.txt_activite.Text = unClient.Activite;
            this.txt_cA.Text = unClient.CA.ToString();
            this.cbb_nature.Text = unClient.Nature;
            this.cbb_nomContact_frmClie.Text = unClient.NomContact;
            this.txt_effectif.Text = unClient.Effectif.ToString();
            this.txt_telephone.Text = unClient.Telephone;
            this.txt_mail.Text = unClient.Mail;
            this.txt_adresse.Text = unClient.Adresse;
            this.txt_codeClient.Text = unClient.CodeClient;
            this.txt_ville.Text = unClient.Ville;
            this.txt_commClient.Text = unClient.CommClient;
        }

        /// <summary>
        /// Bouton "Supprimer le client" : Supprime le client de la liste MSclient et NClient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupp_frmDspClie_Click(object sender, EventArgs e)
        {
            Donnees.ArrayClient.Remove(leClient);
        }

        /// <summary>
        /// Bouton "Valider les modifications" : Enregistre les données saisies / Affiche dans la Liste l'objet MSclient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValiModi_Click(object sender, EventArgs e)
        {
            leClient.RaisonSociale = base.txt_raisonSociale.Text;
            leClient.IdClient = Int32.Parse(base.txt_idClient.Text.Trim());
            leClient.TypeClient = cbb_type.Text;
            leClient.Activite = base.txt_activite.Text;
            leClient.CA = Decimal.Parse(base.txt_cA.Text.Trim());
            leClient.Nature = cbb_nature.Text;
            leClient.NomContact = base.cbb_nomContact_frmClie.Text;
            leClient.Effectif = Int32.Parse(base.txt_effectif.Text.Trim());
            leClient.Telephone = base.txt_telephone.Text;
            leClient.Mail = base.txt_mail.Text;
            leClient.Adresse = base.txt_adresse.Text;
            leClient.CodeClient = base.txt_codeClient.Text;
            leClient.Ville = base.txt_ville.Text;
            leClient.CommClient = base.txt_commClient.Text;
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Bouton "Ajouter un client" : Ouvre le form NewClie ""Ajouter un nouveau client"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void btnAjou_frmDspClie_Click(object sender, EventArgs e)
        {
            frmNewClie frmNClie = new frmNewClie();                           // Déclare une instance du form frmNewClie (Ajouter un client)
            if (frmNClie.ShowDialog() == DialogResult.OK)
            {                                  
                this.afficheClient(leClient);                                 // Afficher ce client sur le form  
            }
        }

        /// <summary>
        /// Bouton "Annuler les modifications" : Affiche les données de référence du stagiaire 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuModi_Click(object sender, EventArgs e)
        {
            this.afficheClient(this.leClient);                                // Réaffiche le stagiaire
        }
    }
}

