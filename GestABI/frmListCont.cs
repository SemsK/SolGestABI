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
    public partial class frmListCont : Form
    {
        public frmListCont()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Filtre les contacts affichés dans la DataGridView par nom, numéro ou activité
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_lancRech_frmListCont_Click(object sender, EventArgs e)
        {
            if (this.txtRech_frmListCont.Text != null & rdb_nomContact.Checked)
            {
                // Filtre la vue associé à la DataTable (syntaxe de clause where SQL)
                ((DataView)(this.grd_frmListCont.DataSource)).RowFilter = "Nom like '%" + this.txtRech_frmListCont + "%'";
            }
            if (this.txtRech_frmListCont.Text != null & rdb_prenomContact.Checked)
            {
                // Filtre la vue associé à la DataTable (syntaxe de clause where SQL)
                ((DataView)(this.grd_frmListCont.DataSource)).RowFilter = "Prénom like '%" + this.txtRech_frmListCont + "%'";
            }
            if (this.txtRech_frmListCont.Text != null & rdb_raisonSociale.Checked)
            {
                // Filtre la vue associé à la DataTable (syntaxe de clause where SQL)
                ((DataView)(this.grd_frmListCont.DataSource)).RowFilter = "Client like '%" + this.txtRech_frmListCont + "%'";
            }
        }

        /// <summary>
        /// Réaffiche les contacts en supprimant les filtres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_annuRech_frmListCont_Click(object sender, EventArgs e)
        {
            this.txtRech_frmListCont.Text = null;
            ((DataView)(this.grd_frmListCont.DataSource)).RowFilter = null;
        }

        /// <summary>
        /// Établit la source de données de la dataGridView et rafraîchit son affichage
        /// </summary>
        private void afficheContactS()
        {
            DataTable dt2 = new DataTable();                                          // DataTable : Recopie les contacts stockés en collection reliés au DataGridView pour n'afficher que les données choisies
            DataRow dr2;                                                              // Ligne de la datatable
            Int32 i;                                                                  // Variable de boucle

            dt2.Columns.Add(new DataColumn("Nom", typeof(System.String)));            // Ajoute à la datatable 6 colonnes personnalisées
            dt2.Columns.Add(new DataColumn("Prénom", typeof(System.String)));
            dt2.Columns.Add(new DataColumn("Numéro", typeof(System.Int32)));
            dt2.Columns.Add(new DataColumn("Fonction", typeof(System.String)));
            dt2.Columns.Add(new DataColumn("Téléphone", typeof(System.String)));
            dt2.Columns.Add(new DataColumn("Adresse Mail", typeof(System.String)));

            for (i = 0; i < Donnees.ArrayContact.Count; i++)                          // Boucle de remplissage de la DataTable à partir de la collection
            {
                dr2 = dt2.NewRow();                                                   // Instanciation d'une DataRow (ligne de la DataTable)
                dr2[0] = Donnees.ArrayContact[i].NomContact;                          // Affectation des 6 colonnes
                dr2[1] = Donnees.ArrayContact[i].PrenomContact;
                dr2[2] = Donnees.ArrayContact[i].IdContact;
                dr2[0] = Donnees.ArrayContact[i].FonctionContact;
                dr2[1] = Donnees.ArrayContact[i].TelContact;
                dr2[2] = Donnees.ArrayContact[i].MailContact;
                dt2.Rows.Add(dr2);                                                    // Ajout de la ligne à la Datatable (la propriété Rows étant est elle-même une collection)
            }                                                                         // Fin de boucle 
            this.grd_frmListCont.DataSource = dt2.DefaultView;                        // Détermine l'origine des données à afficher en DataGridView
            this.grd_frmListCont.Refresh();
            dt2 = null;
            dr2 = null;
        }

        /// <summary>
        /// Bouton Ajouter un contact : Ouvre et intancie le form NewCont
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AjouCont_frmListCont_Click(object sender, EventArgs e)
        {
            frmNewCont frmNew = new frmNewCont();                                     // instancie un form de saisie de stagiaire et l'affiche en modal
            if (frmNew.ShowDialog() == DialogResult.OK)                               // si on sort de la saisie par OK  
            {
                afficheContactS();                                                    // régénère l'affichage du dataGridView  
            }
        }

        /// <summary>
        /// Double-clic sur le datagridview : ouvre la feuille détail du contact correspondant à la ligne double-cliquée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grd_frmListCont_DoubleClick(object sender, EventArgs e)
        {
            Int32 iCont;                                                              // rang du stagiaire dans la collection 
            iCont = this.grd_frmListCont.CurrentRow.Index;                            // récupérer indice du stagiaire cliqué en DataGridView             
            ClasseClient leContact = Donnees.ArrayClient[iCont];                          // instancier un objet stagiaire pointant vers le stagiaire d'origine dans la collection             
            frmDspClie frmDspP = new frmDspClie(leContact);                           // instancier un form détail pour ce stagiaire             
            DialogResult result = frmDspP.ShowDialog();                               // afficher le form détail en modal   
            if (result == DialogResult.OK)
            {
                this.afficheContactS();
            }
        }
    }
}
