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
        private Boolean instancie()
        {
            ClasseClient nouveauClient = new ClasseClient();                                // Crée une référence d'objet ClasseClient
            try
            {
                //Affecte les données de l'objet ClasseClient : Variables ou propriétés qui déclenche les méthodes get/set
                nouveauClient.IdClient = ClasseClient.compteurClient;
                nouveauClient.RaisonSociale = base.txt_raisonSociale.Text;                 // Conversion en MAJUSCULE
                nouveauClient.TypeClient = cbb_type.Text;
                nouveauClient.Activite = base.txt_activite.Text;
                nouveauClient.CA = Decimal.Parse(base.txt_cA.Text.Trim());
                nouveauClient.Nature = cbb_nature.Text;
                nouveauClient.NomContact = base.cbb_nomContact_frmClie.Text;
                nouveauClient.Effectif = Int32.Parse(base.txt_effectif.Text.Trim());
                nouveauClient.Telephone = base.txt_telephone.Text;
                nouveauClient.Mail = base.txt_mail.Text;
                nouveauClient.Adresse = base.txt_adresse.Text;
                nouveauClient.CodeClient = base.txt_codeClient.Text;
                nouveauClient.Ville = base.txt_ville.Text;                                 // Conversion en MAJUSCULE
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
            bool correct = true;                                                          // La saisie est correct si... (Appelons les méthodes de classe Outils)

            if (!Outils.Est_RaisonSociale_OK(this.txt_raisonSociale.Text.Trim()))         // Vérifie que le champ "Raison Sociale" est correctement rempli
            {
                errorProvider_NewClie.SetError(this.txt_raisonSociale, "Raison sociale invalide");
                correct = false;
            }
            else
            {
                errorProvider_NewClie.SetError(this.txt_raisonSociale, String.Empty);     // Si la saisie est correct, l'icône d'erreur disparait
            }


            if (!Outils.Est_Activite_OK(this.txt_activite.Text.Trim()))                   // Vérifie que le champ "Activité" est correctement rempli
            {
                errorProvider_NewClie.SetError(this.txt_activite, "Activité invalide");
                correct = false;
            }
            else
            {
                errorProvider_NewClie.SetError(this.txt_activite, String.Empty);
            }

            if (!Outils.Est_CA_OK(this.txt_cA.Text.Trim()))                               // Vérifie que le champ "C.A." est correctement rempli
            {
                errorProvider_NewClie.SetError(this.txt_cA, "C.A. invalide");
                correct = false;
            }
            else
            {
                errorProvider_NewClie.SetError(this.txt_cA, String.Empty);
            }

            if  (this.cbb_type.Text == "")                                                // Vérifie qu'un choix a été fait pour le "Type"
            {
                errorProvider_NewClie.SetError(this.cbb_type, "Type du client requis");
                correct = false;
            }
            else
            {
                errorProvider_NewClie.SetError(this.cbb_type, String.Empty);
            }

            if (this.cbb_nature.Text == "")                                               // Vérifie qu'un choix a été fait pour la "Nature"
            {
                errorProvider_NewClie.SetError(this.cbb_nature, "Nature du client requise");
                correct = false;
            }
            else
            {
                errorProvider_NewClie.SetError(this.cbb_nature, String.Empty);
            }

            if (!Outils.Est_Effectif_OK(this.txt_effectif.Text.Trim()))                         // Vérifie que le champ "Effectif" est correctement rempli
            {
                errorProvider_NewClie.SetError(this.txt_effectif, "Nombre d'effectif invalide");
                correct = false;
            }
            else
            {
                errorProvider_NewClie.SetError(this.txt_effectif, String.Empty);
            }

            if (!Outils.Est_Telephone_OK(this.txt_telephone.Text.Trim()))                 // Vérifie que le champ "Téléphone" est correctement rempli
            {
                errorProvider_NewClie.SetError(this.txt_telephone, "Numéro de téléphone invalide");
                correct = false;
            }
            else
            {
                errorProvider_NewClie.SetError(this.txt_telephone, String.Empty);
            }

            if (!Outils.Est_Mail_OK(this.txt_mail.Text.Trim()))                           // Vérifie que le champ "Mail" est correctement rempli
            {
                errorProvider_NewClie.SetError(this.txt_mail, "Adresse mail invalide");
                correct = false;
            }
            else
            {
                errorProvider_NewClie.SetError(this.txt_mail, String.Empty);
            }

            if (!Outils.Est_Adresse_OK(this.txt_adresse.Text.Trim()))                     // Vérifie que le champ "Adresse" est correctement rempli
            {
                errorProvider_NewClie.SetError(this.txt_adresse, "Adresse invalide");
                correct = false;
            }
            else
            {
                errorProvider_NewClie.SetError(this.txt_adresse, String.Empty);
            }

            if (!Outils.Est_Code_OK(this.txt_codeClient.Text.Trim()))                     // Vérifie que le champ "Code Postal" est correctement rempli
            {
                errorProvider_NewClie.SetError(this.txt_codeClient, "Code postal invalide");
                correct = false;
            }
            else
            {
                errorProvider_NewClie.SetError(this.txt_codeClient, String.Empty);
            }

            if (!Outils.Est_Ville_OK(this.txt_ville.Text.Trim()))                         // Vérifie que le champ "Ville" est correctement rempli
            {
                errorProvider_NewClie.SetError(this.txt_ville, "Ville invalide");
                correct = false;
            }
            else
            {
                errorProvider_NewClie.SetError(this.txt_ville, String.Empty);
            }
            return correct;
        }


        //************************ÉVÉNEMENTS**************************

        /// <summary>
        /// Bouton OK : Instancie un objet MSclient, enregistre les données remplies et le référence dans la collection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_frmNewClie_Click(object sender, EventArgs e)
        {
            if (Est_Saisie_OK())                                                          // Si la saisie de tous les champs est correct
            {
                if (this.instancie())                                               // Si l'instanciation client et son ajout à la collection est OK
                {
                    this.DialogResult = DialogResult.OK;                                  
                    this.Close();                                                         // Ferme de la boite de dialogue par validation
                }
            }                  
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
