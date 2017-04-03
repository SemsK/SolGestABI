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
    public partial class frmCont : Form
    {
        public frmCont()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Méthode appelée pendant la fermeture des form frmDspCont et frmNewCont
        /// aussi bien par Alt-F4 et case de fermeture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmClos_frmCont(object sender, FormClosingEventArgs e)
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
    }
}
