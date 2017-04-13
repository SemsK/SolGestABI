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

        }
    }
}
