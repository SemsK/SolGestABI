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
    public partial class frmListClie : Form
    {
        public frmListClie()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Filtre les clients affichés dans la DataGridView par noms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_lancRech_frmListClie_Click(object sender, EventArgs e)
        {
            if  (this.txtRech_frmListClie.Text != null & rdb_nomClient.Checked ) 
            {
                // Filtre la vue associé à la DataTable (syntaxe de clause where SQL)
                ((DataView)(this.grd_frmListClie.DataSource)).RowFilter = "Nom like '%" + this.txtRech_frmListClie + "%'";
            }
            if  (this.txtRech_frmListClie.Text != null & rdb_idClient.Checked)
            {
                // Filtre la vue associé à la DataTable (syntaxe de clause where SQL)
                ((DataView)(this.grd_frmListClie.DataSource)).RowFilter = "Numéro like '%" + this.txtRech_frmListClie + "%'";
            }
            if (this.txtRech_frmListClie.Text != null & rdb_activite.Checked)
            {
                // Filtre la vue associé à la DataTable (syntaxe de clause where SQL)
                ((DataView)(this.grd_frmListClie.DataSource)).RowFilter = "Activité like '%" + this.txtRech_frmListClie + "%'";
            }            
        }

        /// <summary>
        /// Réaffiche les clients en supprimant les filtres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_annuRech_Click(object sender, EventArgs e)
        {
            this.txtRech_frmListClie.Text = null;
            ((DataView)(this.grd_frmListClie.DataSource)).RowFilter = null;
        }

        /// <summary>
        /// Établit la source de données de la dataGridView et rafraîchit son affichage
        /// </summary>
        private void afficheUnClient()
        {
            DataTable dt = new DataTable();                                          // DataTable : Recopie les clients stockés en collection reliés au DataGridView pour n'afficher que les données choisies
            DataRow dr;                                                              // Ligne de la datatable
            Int32 i;                                                                 // Variable de boucle

            dt.Columns.Add(new DataColumn("Raison Sociale", typeof(System.String)));            // Ajoute à la datatable 6 colonnes personnalisées
            dt.Columns.Add(new DataColumn("Numéro", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("Activité", typeof(System.String)));
            dt.Columns.Add(new DataColumn("C.A.", typeof(System.Decimal)));
            dt.Columns.Add(new DataColumn("Effectif", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("Adresse Mail", typeof(System.String)));

            for (i = 0; i < Donnees.ArrayClient.Count; i++)                           // Boucle de remplissage de la DataTable à partir de la collection
            {
                dr = dt.NewRow();                                                     // Instanciation d'une DataRow (ligne de la DataTable)
                dr[0] = Donnees.ArrayClient[i].RaisonSociale;                             // Affectation des 6 colonnes
                dr[1] = Donnees.ArrayClient[i].IdClient;
                dr[2] = Donnees.ArrayClient[i].Activite;
                dr[0] = Donnees.ArrayClient[i].CA;
                dr[1] = Donnees.ArrayClient[i].Effectif;
                dr[2] = Donnees.ArrayClient[i].Mail;
                dt.Rows.Add(dr);                                                      // Ajout de la ligne à la Datatable (la propriété Rows étant est elle-même une collection)
            }                                                                         // fin de boucle 
            this.grd_frmListClie.DataSource = dt.DefaultView;                                     // déterminer l'origine des données à afficher en DataGridView
            this.grd_frmListClie.Refresh();                                           // refraîchir l'affichage
            dt = null;
            dr = null;
        }

        /// <summary>
        /// Bouton Ajouter un client ==> Ouvre et intancie le form NewClie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ajouClie_frmListClie_Click(object sender, EventArgs e)
        {                                                 
            frmNewClie frmNew = new frmNewClie();                                     // instancie un form de saisie de stagiaire et l'affiche en modal
            if (frmNew.ShowDialog() == DialogResult.OK)                               // si on sort de la saisie par OK  
            {
                afficheUnClient();                                                    // régénère l'affichage du dataGridView  
            }
        }

        /// <summary>
        /// Double-clic sur le datagridview : ouvre la feuille détail du client correspondant à la ligne double-cliquée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grd_frmListClie_DoubleClick(object sender, EventArgs e)
        {
            Int32 iStag;                                                              // rang du stagiaire dans la collection 
            iStag = this.grd_frmListClie.CurrentRow.Index;                            // récupérer indice du stagiaire cliqué en DataGridView             
            MSclient leClient = Donnees.ArrayClient[iStag];                           // instancier un objet stagiaire pointant vers le stagiaire d'origine dans la collection             
            frmDspClie frmDsp = new frmDspClie(leClient);                             // instancier un form détail pour ce stagiaire             
            DialogResult result = frmDsp.ShowDialog();                                // afficher le form détail en modal   
            if (result == DialogResult.OK)
            {
                this.afficheUnClient();
            }
        }
    }
}
