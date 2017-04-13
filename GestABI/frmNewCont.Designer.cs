namespace GestABI
{
    partial class frmNewCont
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
            this.grbBoutons_NewCont = new System.Windows.Forms.GroupBox();
            this.btnOK_frmNewCont = new System.Windows.Forms.Button();
            this.btnQuit_frmNewCont = new System.Windows.Forms.Button();
            this.grbIntervention.SuspendLayout();
            this.grbFiche_frmCont.SuspendLayout();
            this.grbRecherche_frmCont.SuspendLayout();
            this.grbBoutons_NewCont.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbRecherche_frmCont
            // 
            this.grbRecherche_frmCont.Visible = false;
            // 
            // grbBoutons_NewCont
            // 
            this.grbBoutons_NewCont.Controls.Add(this.btnOK_frmNewCont);
            this.grbBoutons_NewCont.Controls.Add(this.btnQuit_frmNewCont);
            this.grbBoutons_NewCont.Location = new System.Drawing.Point(415, 330);
            this.grbBoutons_NewCont.Name = "grbBoutons_NewCont";
            this.grbBoutons_NewCont.Size = new System.Drawing.Size(214, 61);
            this.grbBoutons_NewCont.TabIndex = 46;
            this.grbBoutons_NewCont.TabStop = false;
            // 
            // btnOK_frmNewCont
            // 
            this.btnOK_frmNewCont.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK_frmNewCont.Location = new System.Drawing.Point(15, 21);
            this.btnOK_frmNewCont.Name = "btnOK_frmNewCont";
            this.btnOK_frmNewCont.Size = new System.Drawing.Size(75, 23);
            this.btnOK_frmNewCont.TabIndex = 34;
            this.btnOK_frmNewCont.Text = "OK";
            this.btnOK_frmNewCont.UseVisualStyleBackColor = true;
            this.btnOK_frmNewCont.Click += new System.EventHandler(this.btnOK_frmNewCont_Click);
            // 
            // btnQuit_frmNewCont
            // 
            this.btnQuit_frmNewCont.Location = new System.Drawing.Point(124, 21);
            this.btnQuit_frmNewCont.Name = "btnQuit_frmNewCont";
            this.btnQuit_frmNewCont.Size = new System.Drawing.Size(75, 23);
            this.btnQuit_frmNewCont.TabIndex = 38;
            this.btnQuit_frmNewCont.Text = "Quitter";
            this.btnQuit_frmNewCont.UseVisualStyleBackColor = true;
            this.btnQuit_frmNewCont.Click += new System.EventHandler(this.btnQuit_frmNewCont_Click);
            // 
            // frmNewCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(646, 403);
            this.Controls.Add(this.grbBoutons_NewCont);
            this.Name = "frmNewCont";
            this.ShowInTaskbar = false;
            this.Text = "Ajouter un nouveau contact";
            this.Controls.SetChildIndex(this.grbIntervention, 0);
            this.Controls.SetChildIndex(this.grbFiche_frmCont, 0);
            this.Controls.SetChildIndex(this.grbRecherche_frmCont, 0);
            this.Controls.SetChildIndex(this.grbBoutons_NewCont, 0);
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

        private System.Windows.Forms.GroupBox grbBoutons_NewCont;
        private System.Windows.Forms.Button btnOK_frmNewCont;
        private System.Windows.Forms.Button btnQuit_frmNewCont;
    }
}
