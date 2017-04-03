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
        /// Établit la source de données de la dataGridView et rafraîchit son affichage
        /// </summary>
        private void afficheClient()
        {
            // DataTable : Recopie les clients stockés en collection reliés au DataGridView pour n'afficher que les données choisies
            DataTable dt = new DataTable();
            DataRow dr; // Ligne de la datatable
            Int32 i;    // Variable de boucle
                        // Ajoute à la datatable 6 colonnes personnalisées
            dt.Columns.Add(new DataColumn("Nom", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Numéro", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("Activité", typeof(System.String)));
            dt.Columns.Add(new DataColumn("C.A.", typeof(System.Decimal)));
            dt.Columns.Add(new DataColumn("Effectif", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("Adresse Mail", typeof(System.String)));
            // Boucle de remplissage de la DataTable à partir de la collection
            for (i = 0; i < Donnees.ArrayClient.Count; i++)
            { 
                dr = dt.NewRow();                          // Instanciation d'une DataRow (ligne de la DataTable)
                dr[0] = Donnees.ArrayClient[i].NomClient;  // Affectation des 6 colonnes
                dr[1] = Donnees.ArrayClient[i].IdClient;
                dr[2] = Donnees.ArrayClient[i].Activite;
                dr[0] = Donnees.ArrayClient[i].CA;         
                dr[1] = Donnees.ArrayClient[i].Effectif;
                dr[2] = Donnees.ArrayClient[i].Mail;               
                dt.Rows.Add(dr);                           // Ajout de la ligne à la Datatable (la propriété Rows étant est elle-même une collection)
            }                                              // fin de boucle 
            this.grd_frmListClie.DataSource = dt;  // déterminer l'origine des données à afficher en DataGridView
            this.grd_frmListClie.Refresh();        // refraîchir l'affichage
            dt = null;
            dr = null;
        }
    }
}
