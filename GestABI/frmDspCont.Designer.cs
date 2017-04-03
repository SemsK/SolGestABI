namespace GestABI
{
    partial class frmDspCont
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnModi_frmDspCont = new System.Windows.Forms.Button();
            this.cbb_nomProjet = new System.Windows.Forms.ComboBox();
            this.btnSupp__frmDspCont = new System.Windows.Forms.Button();
            this.lblNoContact = new System.Windows.Forms.Label();
            this.grbIntervention.SuspendLayout();
            this.grbFiche_frmCont.SuspendLayout();
            this.grbRecherche_frmCont.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbIntervention
            // 
            this.grbIntervention.Controls.Add(this.cbb_nomProjet);
            this.grbIntervention.Location = new System.Drawing.Point(18, 220);
            this.grbIntervention.Controls.SetChildIndex(this.mtb_dureeProjet, 0);
            this.grbIntervention.Controls.SetChildIndex(this.mtb_dureeCumul, 0);
            this.grbIntervention.Controls.SetChildIndex(this.cbb_nomProjet, 0);
            // 
            // grbFiche_frmCont
            // 
            this.grbFiche_frmCont.Location = new System.Drawing.Point(18, 12);
            // 
            // btnModi_frmDspCont
            // 
            this.btnModi_frmDspCont.Location = new System.Drawing.Point(439, 409);
            this.btnModi_frmDspCont.Name = "btnModi_frmDspCont";
            this.btnModi_frmDspCont.Size = new System.Drawing.Size(75, 23);
            this.btnModi_frmDspCont.TabIndex = 25;
            this.btnModi_frmDspCont.Text = "Modifier";
            this.btnModi_frmDspCont.UseVisualStyleBackColor = true;
            // 
            // cbb_nomProjet
            // 
            this.cbb_nomProjet.FormattingEnabled = true;
            this.cbb_nomProjet.Location = new System.Drawing.Point(102, 26);
            this.cbb_nomProjet.Name = "cbb_nomProjet";
            this.cbb_nomProjet.Size = new System.Drawing.Size(503, 21);
            this.cbb_nomProjet.TabIndex = 26;
            // 
            // btnSupp__frmDspCont
            // 
            this.btnSupp__frmDspCont.Location = new System.Drawing.Point(548, 409);
            this.btnSupp__frmDspCont.Name = "btnSupp__frmDspCont";
            this.btnSupp__frmDspCont.Size = new System.Drawing.Size(75, 23);
            this.btnSupp__frmDspCont.TabIndex = 34;
            this.btnSupp__frmDspCont.Text = "Supprimer";
            this.btnSupp__frmDspCont.UseVisualStyleBackColor = true;
            // 
            // lblNoContact
            // 
            this.lblNoContact.AutoSize = true;
            this.lblNoContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoContact.Location = new System.Drawing.Point(7, 204);
            this.lblNoContact.Name = "lblNoContact";
            this.lblNoContact.Size = new System.Drawing.Size(639, 39);
            this.lblNoContact.TabIndex = 35;
            this.lblNoContact.Text = "Aucun contact dans la base de données!";
            // 
            // frmDspCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.lblNoContact);
            this.Controls.Add(this.btnSupp__frmDspCont);
            this.Controls.Add(this.btnModi_frmDspCont);
            this.Name = "frmDspCont";
            this.Text = "Affichage d\'un contact client";
            this.Load += new System.EventHandler(this.frmDspCont_Load);
            this.Controls.SetChildIndex(this.grbRecherche_frmCont, 0);
            this.Controls.SetChildIndex(this.grbIntervention, 0);
            this.Controls.SetChildIndex(this.grbFiche_frmCont, 0);
            this.Controls.SetChildIndex(this.btnModi_frmDspCont, 0);
            this.Controls.SetChildIndex(this.btnSupp__frmDspCont, 0);
            this.Controls.SetChildIndex(this.lblNoContact, 0);
            this.grbIntervention.ResumeLayout(false);
            this.grbIntervention.PerformLayout();
            this.grbFiche_frmCont.ResumeLayout(false);
            this.grbFiche_frmCont.PerformLayout();
            this.grbRecherche_frmCont.ResumeLayout(false);
            this.grbRecherche_frmCont.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnModi_frmDspCont;
        private System.Windows.Forms.ComboBox cbb_nomProjet;
        private System.Windows.Forms.Button btnSupp__frmDspCont;
        private System.Windows.Forms.Label lblNoContact;
    }
}
