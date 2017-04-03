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
        /// Rang du contact traité
        /// </summary>
        /*private Int32 iContact;*/
        public frmDspCont()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Au chargement du form : initiation de l'affichage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDspCont_Load(object sender, EventArgs e)      
        {
            base.grbRecherche_frmCont.Visible = false;
            base.grbFiche_frmCont.Visible = false;
            this.lblNoContact.Visible = true;
            this.grbIntervention.Visible = false;
            this.btnModi_frmDspCont.Visible = false;
            this.btnSupp__frmDspCont.Visible = false;
        }
    
    }
}
