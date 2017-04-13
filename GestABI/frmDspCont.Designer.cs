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
            this.btnSupp__frmDspCont = new System.Windows.Forms.Button();
            this.grbBoutons_NewCont = new System.Windows.Forms.GroupBox();
            this.btnQuit_frmDspCont = new System.Windows.Forms.Button();
            this.btnValider_frmDspCont = new System.Windows.Forms.Button();
            this.btnAnnu_frmDspCont = new System.Windows.Forms.Button();
            this.grbIntervention.SuspendLayout();
            this.grbFiche_frmCont.SuspendLayout();
            this.grbRecherche_frmCont.SuspendLayout();
            this.grbBoutons_NewCont.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSupp__frmDspCont
            // 
            this.btnSupp__frmDspCont.Location = new System.Drawing.Point(16, 21);
            this.btnSupp__frmDspCont.Name = "btnSupp__frmDspCont";
            this.btnSupp__frmDspCont.Size = new System.Drawing.Size(75, 23);
            this.btnSupp__frmDspCont.TabIndex = 34;
            this.btnSupp__frmDspCont.Text = "Supprimer";
            this.btnSupp__frmDspCont.UseVisualStyleBackColor = true;
            this.btnSupp__frmDspCont.Click += new System.EventHandler(this.btnSupp__frmDspCont_Click);
            // 
            // grbBoutons_NewCont
            // 
            this.grbBoutons_NewCont.Controls.Add(this.btnQuit_frmDspCont);
            this.grbBoutons_NewCont.Controls.Add(this.btnSupp__frmDspCont);
            this.grbBoutons_NewCont.Controls.Add(this.btnValider_frmDspCont);
            this.grbBoutons_NewCont.Controls.Add(this.btnAnnu_frmDspCont);
            this.grbBoutons_NewCont.Location = new System.Drawing.Point(18, 372);
            this.grbBoutons_NewCont.Name = "grbBoutons_NewCont";
            this.grbBoutons_NewCont.Size = new System.Drawing.Size(611, 61);
            this.grbBoutons_NewCont.TabIndex = 47;
            this.grbBoutons_NewCont.TabStop = false;
            // 
            // btnQuit_frmDspCont
            // 
            this.btnQuit_frmDspCont.Location = new System.Drawing.Point(521, 21);
            this.btnQuit_frmDspCont.Name = "btnQuit_frmDspCont";
            this.btnQuit_frmDspCont.Size = new System.Drawing.Size(75, 23);
            this.btnQuit_frmDspCont.TabIndex = 27;
            this.btnQuit_frmDspCont.Text = "Quitter";
            this.btnQuit_frmDspCont.UseVisualStyleBackColor = true;
            this.btnQuit_frmDspCont.Click += new System.EventHandler(this.btnQuit_frmDspCont_Click);
            // 
            // btnValider_frmDspCont
            // 
            this.btnValider_frmDspCont.Location = new System.Drawing.Point(337, 21);
            this.btnValider_frmDspCont.Name = "btnValider_frmDspCont";
            this.btnValider_frmDspCont.Size = new System.Drawing.Size(75, 23);
            this.btnValider_frmDspCont.TabIndex = 26;
            this.btnValider_frmDspCont.Text = "Valider";
            this.btnValider_frmDspCont.UseVisualStyleBackColor = true;
            this.btnValider_frmDspCont.Click += new System.EventHandler(this.btnValider_frmDspCont_Click);
            // 
            // btnAnnu_frmDspCont
            // 
            this.btnAnnu_frmDspCont.Location = new System.Drawing.Point(430, 21);
            this.btnAnnu_frmDspCont.Name = "btnAnnu_frmDspCont";
            this.btnAnnu_frmDspCont.Size = new System.Drawing.Size(75, 23);
            this.btnAnnu_frmDspCont.TabIndex = 25;
            this.btnAnnu_frmDspCont.Text = "Annuler";
            this.btnAnnu_frmDspCont.UseVisualStyleBackColor = true;
            this.btnAnnu_frmDspCont.Click += new System.EventHandler(this.btnAnnu_frmDspCont_Click);
            // 
            // frmDspCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(646, 451);
            this.Controls.Add(this.grbBoutons_NewCont);
            this.Name = "frmDspCont";
            this.Text = "Affichage / Modification d\'un contact";
            this.Load += new System.EventHandler(this.frmDspCont_Load);
            this.Controls.SetChildIndex(this.grbBoutons_NewCont, 0);
            this.Controls.SetChildIndex(this.grbRecherche_frmCont, 0);
            this.Controls.SetChildIndex(this.grbIntervention, 0);
            this.Controls.SetChildIndex(this.grbFiche_frmCont, 0);
            this.grbIntervention.ResumeLayout(false);
            this.grbIntervention.PerformLayout();
            this.grbFiche_frmCont.ResumeLayout(false);
            this.grbFiche_frmCont.PerformLayout();
            this.grbRecherche_frmCont.ResumeLayout(false);
            this.grbRecherche_frmCont.PerformLayout();
            this.grbBoutons_NewCont.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSupp__frmDspCont;
        private System.Windows.Forms.GroupBox grbBoutons_NewCont;
        private System.Windows.Forms.Button btnAnnu_frmDspCont;
        private System.Windows.Forms.Button btnQuit_frmDspCont;
        private System.Windows.Forms.Button btnValider_frmDspCont;
    }
}
