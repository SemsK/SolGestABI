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
            this.grbIntervention.Location = new System.Drawing.Point(18, 221);
            this.grbBoutons_NewCont.Location = new System.Drawing.Point(349, 405);
            this.Height = 517;
        }
    }
}
