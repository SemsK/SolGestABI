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
    /// Classe dérivée de frmCont : form de lecture et de modification des contacts
    /// </summary>
    public partial class frmDspCont : frmCont
    {
        /// <summary>
        /// Constructeur adapté : Mémorise le contact à traiter
        /// </summary>
        /// <param name="unContact"> la référence de l'objet MSContact à gérer dans ce form </param>
        public frmDspCont(MScontact unContact)
        {
            // Crée une référence d'objet contact reçu en paramètre
            this.leContact = unContact;
            InitializeComponent();
        }
         /// <summary>
         /// La référence du contact à afficher / modifier
         /// </summary>
        private MScontact leContact;

        /// <summary>
        /// Au démarrage, afficher le contact reçu sur le form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDspCont_Load(object sender, EventArgs e)
        {
            this.afficheContact(this.leContact);                          // Affiche le contact
        }

        /// <summary>
        /// Procédure affichant en textbox les données d'un contact reçu
        /// </summary>
        /// <param name="unContact"></param>
        public void afficheContact(MScontact unContact)
        {
            this.txt_nomContact.Text = unContact.NomContact;              // Affecte les textbox
            this.txt_prenomContact.Text = unContact.PrenomContact;                   
            this.txt_idContact.Text = unContact.IdContact.ToString();                    
            this.txt_fonctionContact.Text = unContact.FonctionContact;                
            this.txt_telContact.Text = unContact.TelContact;
            this.txt_mailContact.Text = unContact.MailContact;                         
            this.txt_dureeCumul.Text = unContact.DureeCumul.ToString();
        }

        /// <summary>
        /// Bouton Supprimer : Supprime le contact de la liste MScontact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupp__frmDspCont_Click(object sender, EventArgs e)
        {
            Donnees.ArrayContact.Remove(leContact);
            MScontact.compteurContact -= 1;
        }

        /// <summary>
        /// Bouton Valider : Enregistre les données saisies / Réaffiche dans la liste l'objet MScontact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider_frmDspCont_Click(object sender, EventArgs e)
        {
            leContact.NomContact = this.txt_nomContact.Text;                           
            leContact.PrenomContact = this.txt_prenomContact.Text;                    
            leContact.IdContact = Int32.Parse(txt_idContact.Text.Trim());                  
            leContact.FonctionContact = this.txt_fonctionContact.Text;              
            leContact.TelContact = this.txt_telContact.Text;
            leContact.MailContact = this.txt_mailContact.Text;                       
            leContact.DureeCumul = Int32.Parse(txt_dureeCumul.Text.Trim());
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Bouton Annuler : Affiche les données de référence du client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnu_frmDspCont_Click(object sender, EventArgs e)
        {
            this.afficheContact(this.leContact);                            // Ré-affiche le contact
        }

        /// <summary>
        /// Bouton Fermer : ferme la fenêtre 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuit_frmDspCont_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
