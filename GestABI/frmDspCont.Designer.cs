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
            this.btnSupp__frmDspCont = new System.Windows.Forms.Button();
            this.grbIntervention.SuspendLayout();
            this.grbFiche_frmCont.SuspendLayout();
            this.grbRecherche_frmCont.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbIntervention
            // 
            this.grbIntervention.Location = new System.Drawing.Point(18, 220);
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
            // btnSupp__frmDspCont
            // 
            this.btnSupp__frmDspCont.Location = new System.Drawing.Point(548, 409);
            this.btnSupp__frmDspCont.Name = "btnSupp__frmDspCont";
            this.btnSupp__frmDspCont.Size = new System.Drawing.Size(75, 23);
            this.btnSupp__frmDspCont.TabIndex = 34;
            this.btnSupp__frmDspCont.Text = "Supprimer";
            this.btnSupp__frmDspCont.UseVisualStyleBackColor = true;
            // 
            // frmDspCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.btnSupp__frmDspCont);
            this.Controls.Add(this.btnModi_frmDspCont);
            this.Name = "frmDspCont";
            this.Text = "Affichage d\'un contact client";
            this.Controls.SetChildIndex(this.grbRecherche_frmCont, 0);
            this.Controls.SetChildIndex(this.grbIntervention, 0);
            this.Controls.SetChildIndex(this.grbFiche_frmCont, 0);
            this.Controls.SetChildIndex(this.btnModi_frmDspCont, 0);
            this.Controls.SetChildIndex(this.btnSupp__frmDspCont, 0);
            this.grbIntervention.ResumeLayout(false);
            this.grbIntervention.PerformLayout();
            this.grbFiche_frmCont.ResumeLayout(false);
            this.grbFiche_frmCont.PerformLayout();
            this.grbRecherche_frmCont.ResumeLayout(false);
            this.grbRecherche_frmCont.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnModi_frmDspCont;
        private System.Windows.Forms.Button btnSupp__frmDspCont;
    }
}
