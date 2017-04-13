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
        public frmNewCont()
        {
            InitializeComponent();
            // Replace en haut de la fenêtre "Ajouter un nouveau contact" les groupesbox "Fiche","Intervention" et "Boutons"
            // afin d'éviter un vide laissé par le groupebox "Recherche" devenu invisible. 
            this.grbFiche_frmCont.Location = new System.Drawing.Point(18, 12);
            this.grbIntervention.Location = new System.Drawing.Point(18, 205);
            this.grbBoutons_NewCont.Location = new System.Drawing.Point(415, 285);
            this.Height = 398;
        }

        /// <summary>
        /// Méthode Bouton OK : instancie un Objet MSContact, le renseigne puis le référence dans la collection d’objets
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void btnOK_frmNewCont_Click(object sender, EventArgs e)
        {
            // controle vraissemblance des données saisies sur le form 
            if (this.controle())
            {
                if (this.instancie())
                {   // Cas général : si l'instanciation stagiaire et son ajout à la collection est OK :
                    ClasseContact.compteurContact += 1;                                 // - incrémentation compteurs de stagiaires
                    this.DialogResult = DialogResult.OK;                            // - fermeture de la boite de dialogue par validation
                }
            }
        }

        /// <summary>
        /// Fonction de contrôle de vraissemblance du champ idContact
        /// (appelée avant d'instancier un objet MScontact et d'affecter ses membres)         
        /// </summary>
        /// <returns> Booléen : true = OK, false = erreur</returns> 
        public Boolean controle()
        {   // contrôler la vraissemblance de tous les champs 
            Boolean code = true;                                                    // le code de retour ; OK a priori 
            if (!(estEntier(this.txt_idContact.Text)))                              // appel fonction générique de contrôle  
            {                                                                       // la chaîne reçue n'est pas convertible          
                code = false;
                MessageBox.Show("le numéro du contact saisi n'est pas un entier valide", "ERREUR");
            }
            if (!(estEntier(this.txt_dureeCumul.Text)))                              // appel fonction générique de contrôle  
            {                                                                       // la chaîne reçue n'est pas convertible          
                code = false;
                MessageBox.Show("le nombre d'heures saisi n'est pas un entier valide", "ERREUR");
            }

            return code;
        }

        /// <summary>
        /// Méthode appelée pour contrôler qu'une chaîne reçue puisse se convetir en Int32
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public Boolean estEntier(String s)
        {
            /* Vérifie que la chaine reçue représente bien un entier valide : consitué uniquement
             * de chiffres, sans espaces, et inférieur à 10 chiffres (capacité Max du tye Int32) */
            Int32 i;                                                                 // Indice de chaîne
            Char c;                                                                  // Caractère courant
            Boolean code = true;                                                     // Code retour, a priori OK 
            if (s.Length < 10 && s.Length > 0)                                       // Test la longueur de la chaïne de reçue
            {
                for (i = 0; i < s.Length; i++)                                       // Vérifie 1 à 1 que tous les caractères sont des chiffres
                {
                    c = s[i];                                                        // Extrait le [i]ème caractère
                    if (!(Char.IsDigit(c)))                                          // Detcection de l'erreur
                    {
                       code = false;
                    }                                                // Erreur détecté
                }
            }                                                                        // Fin de la boucle for
            else                                                                     // Détection de longueur de chaîne
            {
                code = false;
            }                                                        // Erreur détecté
            return code;

        }

        /// <summary>
        /// Fonction qui instancie un nouvel objet  MScontact puis tente d'affecter ses membres (Variables ou propriétés)
        /// avec interception éventuelle levée par la classe MScontact.
        /// </summary>
        /// <returns> Boolean : true = OK, false =erreur </returns>
        private Boolean instancie()
        {
            ClasseContact nouveauContact = new ClasseContact();  // créer une référence d'objet MStagiaire 
            try
            {
                // affecter les données de l'objet MStagiaire : variables simples, ou propriétés ce qui déclenche alors le code des méthodes set
                nouveauContact.NomContact = txt_nomContact.Text;                           // Avec conversion en MAJ    
                nouveauContact.PrenomContact = txt_prenomContact.Text;                     // Avec conversion en min 
                nouveauContact.IdContact = Int32.Parse(txt_idContact.Text.Trim());                // Conversion idContact saisi en textbox       
                nouveauContact.FonctionContact = txt_fonctionContact.Text;                 // Avec conversion en MAJ  
                nouveauContact.TelContact = txt_telContact.Text;                           
                nouveauContact.MailContact = txt_mailContact.Text;                         // Avec controle de saisie 
                nouveauContact.DureeCumul = Int32.Parse(txt_dureeCumul.Text.Trim());             // Conversion idContact saisi en textbox 
                Donnees.ArrayContact.Add(nouveauContact);                                  // Ajouter la référence d'objet MStagiaire dans la collection                 
                return true;
            }
            catch (Exception ex)
            {
                nouveauContact = null;
                MessageBox.Show("Erreur : \n" + ex.Message, "Ajout de contact");
                return false;
            }
        }

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
