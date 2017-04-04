using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestABI
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Menu "Fenêtre/Clients/Liste" => Instancie un form "Liste des clients"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmListe_clients_Click(object sender, EventArgs e)
        {
            frmListClie frmLClie = new frmListClie()    // Déclare une instance du form frmListClie (Liste des clients)
            { MdiParent = this };                       // Instancie le form frmLClie
            frmLClie.Show();                            // Affiche le form frmLClie dans son conteneur frmMDI
        }

        /// <summary>
        /// Menu "Fenêtre/Contacts/Ajouter" => Instancie un form "Ajouter un nouveau contact"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmAjouter_contacts_Click(object sender, EventArgs e)
        {
            frmNewCont frmNCont = new frmNewCont()     // Déclare une instance du form frmNewCont (Ajouter un contact)
            { MdiParent = this };                      // Instancie le form frmNCont 
            frmNCont.Show();                           // Affiche le form frmNCont dans son conteneur frmMDI
        }

        /// <summary>
        /// Menu "Fenêtre/Contacts/Liste" => Instancie un form "Liste des contacts"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmListe_contacts_Click(object sender, EventArgs e)
        {
            frmListCont frmLCont = new frmListCont()  // Déclare une instance du form frmListCont (Liste des contacts)
            { MdiParent = this };                     // Instancie le form frmLCont
            frmLCont.Show();                          // Affiche le form frmLCont dans son conteneur frmMDI
        }

        /// <summary>
        /// Menu "Fichier/Quitter" => Quitte l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit(); // quitter l'application
        }

        /// <summary>
        /// Méthode appelée pendant la fermeture du form frmMDI
        /// aussi bien par Application.Exit(), Alt-F4 ou case de fermeture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmClos_frmMDI(object sender, FormClosingEventArgs e)
        {
            DialogResult rep;
            /* Cette variable contient la réponse. Son type correspond aux données fourni par un objet de classe MessageBox.
            *  L’affichage d'un message s'obtient par la méthode Show de la classe MessageBox.
            *  Ses paramètres permettent de personnaliser la boite de dialogue standard (Ici, Oui et Non). */
            rep = MessageBox.Show("Voulez vous vraiment quitter?", "Terminer?", MessageBoxButtons.YesNo);
            /* Après le choix du bouton par l’opérateur, la classe MessageBox retourne des valeurs
             * particulières qui sont nommées (ce qu’on appelle des constantes). */
            if (rep == DialogResult.No)  // Si l’arrêt est annulé par l'opérateur,
            { e.Cancel = true; };        // on annule l'événement en cours.
        }

        private void tsmAProposDe_Click(object sender, EventArgs e)
        {
                /* Ouvre un objet de classe MessageBox, qui informe sur la conception et le dévellopement de l'application
                *  L’affichage du message s'obtient par la méthode Show de la classe MessageBox.
                *  Sa fermeture se fait par un click sur le bouton OK ou le case de fermeture */
                MessageBox.Show("L'application GestABI a été conçu et développé par KÉLÉTAONA Sems", "À Propos de ...");
        }

        /// <summary>
        /// "Fenêtre/Clients/Ajouter" => Instancie un form "Ajouter un nouveau client"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmAjouter_clients_Click(object sender, EventArgs e)
        {
            frmNewClie frmNCont = new frmNewClie()  // Déclare une instance du form frmNewClie (Ajouter un client)
            { MdiParent = this };                   // Instancie le form frmNClie 
            frmNCont.Show();                        // Affiche le form frmNClie dans son conteneur frmMDI
        }
    }
}
