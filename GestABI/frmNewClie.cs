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

        //**********************CONSTRUCTEURS*************************
        public frmNewClie()
        {
            
            InitializeComponent();                                                         // Initialisation. (La groupebox "Recherche" devient invisible)

            this.grbFiche_frmClie.Location = new System.Drawing.Point(20, 14);             // On réhausse donc la groupebox "Fiche Client",
            this.grbBoutons_frmNewClie.Location = new System.Drawing.Point(473, 555);      // On réhausse aussi la groupebox "Boutons"
            this.Height = 664;                                                             // ...et on réduit la taille de la fenêtre laissé par le vide.
            
            this.txt_idClient.Text = ClasseClient.compteurClient.ToString();               // Incrémente automatiquement le numéro client
            this.txt_idClient.ReadOnly = true;                                             // Ce numéro s'affiche directement en textbox (Lecture seule)
        }


        /// <summary>
        /// Fonction qui instancie un nouvel objet ClasseClient puis tente d'affecter ses membres (Variables ou propriétés)
        /// avec interception éventuelle levée par ClasseClient.
        /// </summary>
        /// <returns> Boolean : true = OK, false = erreur </returns>
        private Boolean instancieClient()
        {
            ClasseClient nouveauClient = new ClasseClient();                               // Crée une référence d'objet ClasseClient
            try
            {
                //Affecte les données de l'objet ClasseClient : Variables ou propriétés qui déclenche les méthodes get/set
                nouveauClient.IdClient = ClasseClient.compteurClient;
                nouveauClient.RaisonSociale = base.txt_raisonSociale.Text;                // Conversion en MAJUSCULE
                nouveauClient.TypeClient = cbb_typeSociete.Text;
                nouveauClient.Activite = base.txt_activite.Text;
                nouveauClient.CA = Decimal.Parse(base.txt_cA.Text.Trim());
                nouveauClient.Nature = cbb_nature.Text;
                nouveauClient.NomContact = base.cbb_nomContact_frmClie.Text;
                nouveauClient.Effectif = Int32.Parse(base.txt_effectif.Text.Trim());
                nouveauClient.Telephone = base.txt_telephone.Text;
                nouveauClient.Mail = base.txt_mail.Text;
                nouveauClient.Adresse = base.txt_adresse.Text;
                nouveauClient.CodeClient = base.txt_codeClient.Text;
                nouveauClient.Ville = base.txt_ville.Text;                               // Conversion en MAJUSCULE
                nouveauClient.CommClient = base.txt_commClient.Text;
                Donnees.ArrayClient.Add(nouveauClient);
                return true;
            }
            catch (Exception ex)
            {
                nouveauClient = null;
                MessageBox.Show("Erreur : \n" + ex.Message, "Ajout de client");
                return false;
            }
        }


        /// <summary>
        /// Retourne true si tous les champs de ma fiche "Client" saisis sont corrects.
        /// </summary>
        /// <returns></returns>
        private Boolean Est_Saisie_OK()
        {
            bool correct = true;
            if (!Outils.Est_RaisonSociale_OK(this.txt_raisonSociale.Text.Trim))
        }

















        /// <summary>
        /// Bouton OK : Instancie un objet MSclient, enregistre les données remplies et le référence dans la collection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_frmNewClie_Click(object sender, EventArgs e)
        {
            if (this.instancieClient())
            {   // Cas général : si l'instanciation client et son ajout à la collection est OK :
                this.DialogResult = DialogResult.OK;                                // - Ferme de la boite de dialogue par validation
                this.Close();
            }     
        }

        /// <summary>
        /// Fonction de contrôle de vraissemblance des champs Numéro et Effectif du form :
        /// (appelée avant d'instancier un objet MSclient et d'affecter ses membres) 
        /// </summary>
        /// <returns></returns>
        public Boolean controle()
        {                                                                           // Contrôle la vraissemblance de tous champs
            Boolean code = true;                                                    // Code de retour , a priori OK
            if (!(estEntier(this.txt_idClient.Text)))                               // Appelle la méthode "estEntier"
            {
                code = false;
                MessageBox.Show("Le numéro du client saisi n'est pas valide", "ERREUR");
            }
            if (!(estEntier(this.txt_effectif.Text)))
            {
                code = false;
                MessageBox.Show("Le nombre d'effectif saisi n'est pas valide", "ERREUR");
            }
            return code;
        }

        /// <summary>
        /// Méthode appelée pour contrôler qu'une chaîne reçue puisse se convetir en Int32
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public Boolean estEntier (String s)
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
