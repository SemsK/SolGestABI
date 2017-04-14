using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestABI
{
    public partial class frmNewCont : GestABI.frmCont
    {

        //**********************CONSTRUCTEURS*************************

        public frmNewCont()
        {
            InitializeComponent();                                                         // Initialisation. (La groupebox "Recherche" devient invisible)

            this.grbFiche_frmCont.Location = new System.Drawing.Point(18, 12);             // On réhausse donc la groupebox "Fiche Contact",
            this.grbIntervention.Location = new System.Drawing.Point(18, 205);             // On réhausse aussi la groupebox "Boutons"
            this.grbBoutons_NewCont.Location = new System.Drawing.Point(415, 285);         // ...et on réduit la taille de la fenêtre laissé par le vide.
            this.Height = 398;

            this.txt_idContact.Text = ClasseContact.compteurContact.ToString();               // Incrémente automatiquement le numéro contact
            this.txt_idContact.ReadOnly = true;                                             // Ce numéro s'affiche directement en textbox (Lecture seule)
        }

        /// <summary>
        /// Fonction qui instancie un nouvel objet ClasseContact puis tente d'affecter ses membres (Variables ou propriétés)
        /// avec interception éventuelle levée par la classeContact.
        /// </summary>
        /// <returns> Boolean : true = OK, false =erreur </returns>
        private Boolean instancie()
        {
            ClasseContact nouveauContact = new ClasseContact();                                 // Crée une référence d'objet ClasseContact 
            try
            {
                // affecte les données de l'objet ClasseContact : variables simples, ou propriétés ce qui déclenche alors le code des méthodes get/set
                nouveauContact.IdClient = ClasseClient.IdClient;
                nouveauContact.IdContact = ClasseContact.compteurContact;
                nouveauContact.NomContact = base.txt_nomContact.Text;                           // Avec conversion en MAJ    
                nouveauContact.PrenomContact = base.txt_prenomContact.Text;                     // Avec conversion en min                       
                nouveauContact.FonctionContact = base.txt_fonctionContact.Text;                 // Avec conversion en MAJ  
                nouveauContact.TelContact = base.txt_telContact.Text;
                nouveauContact.MailContact = base.txt_mailContact.Text;                         // Avec controle de saisie
                nouveauContact.NomDoc = cbb_nomProjet.Text;
                nouveauContact.DureeCumul = Int32.Parse(txt_dureeCumul.Text.Trim());            // Conversion idContact saisi en textbox 

                Donnees.ArrayContact.Add(nouveauContact);                                       // Ajouter la référence d'objet MStagiaire dans la collection                 
                return true;
            }
            catch (Exception ex)
            {
                nouveauContact = null;
                MessageBox.Show("Erreur : \n" + ex.Message, "Ajout de contact");
                return false;
            }
        }


        private Boolean Est_Saisie_OK()
        {
            bool correct = true;                                                                // La saisie est correct si... (Appelons les méthodes de classe Outils)

            if (!Outils.Est_NomContact_OK(this.txt_nomContact.Text.Trim()))                     // Vérifie que le champ "Nom" est correctement rempli
            {
                errorProvider_NewCont.SetError(this.txt_nomContact, "Nom invalide");
                correct = false;
            }
            else
            {
                errorProvider_NewCont.SetError(this.txt_nomContact, String.Empty);              // Si la saisie est correct, l'icône d'erreur disparait
            }

            if (!Outils.Est_PrenomContact_OK(this.txt_prenomContact.Text.Trim()))               // Vérifie que le champ "Prénom" est correctement rempli
            {
                errorProvider_NewCont.SetError(this.txt_prenomContact, "Prénom invalide");
                correct = false;
            }
            else
            {
                errorProvider_NewCont.SetError(this.txt_prenomContact, String.Empty);
            }

            if (!Outils.Est_Fonction_OK(this.txt_fonctionContact.Text.Trim()))                  // Vérifie que le champ "fonction" est correctement rempli
            {
                errorProvider_NewCont.SetError(this.txt_fonctionContact, "Nom invalide");
                correct = false;
            }
            else
            {
                errorProvider_NewCont.SetError(this.txt_fonctionContact, String.Empty);
            }

            if (!Outils.Est_Telephone_OK)



            return correct;
        }





    /// <summary>
    /// Méthode Bouton OK : instancie un Objet MSContact, le renseigne puis le référence dans la collection d’objets
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param> 
    private void btnOK_frmNewCont_Click(object sender, EventArgs e)
        {
            // controle vraissemblance des données saisies sur le form 
            if (this.Est_Saisie_OK())
            {
                if (this.instancie())
                {   // Cas général : si l'instanciation stagiaire et son ajout à la collection est OK :
                    ClasseContact.compteurContact += 1;                                 // - incrémentation compteurs de stagiaires
                    this.DialogResult = DialogResult.OK;                            // - fermeture de la boite de dialogue par validation
                }
            }
        }

        ///// <summary>
        ///// Fonction de contrôle de vraissemblance du champ idContact
        ///// (appelée avant d'instancier un objet MScontact et d'affecter ses membres)         
        ///// </summary>
        ///// <returns> Booléen : true = OK, false = erreur</returns> 

        //public Boolean controle()
        //{   // contrôler la vraissemblance de tous les champs 
        //    Boolean code = true;                                                    // le code de retour ; OK a priori 
        //    if (!(estEntier(this.txt_idContact.Text)))                              // appel fonction générique de contrôle  
        //    {                                                                       // la chaîne reçue n'est pas convertible          
        //        code = false;
        //        MessageBox.Show("le numéro du contact saisi n'est pas un entier valide", "ERREUR");
        //    }
        //    if (!(estEntier(this.txt_dureeCumul.Text)))                              // appel fonction générique de contrôle  
        //    {                                                                       // la chaîne reçue n'est pas convertible          
        //        code = false;
        //        MessageBox.Show("le nombre d'heures saisi n'est pas un entier valide", "ERREUR");
        //    }

        //    return code;
        //}




        /// <summary>
        /// Bouton Quitter : Ferme le form de saisie ; annule l'ajout d'un nouveau contact 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnQuit_frmNewCont_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
