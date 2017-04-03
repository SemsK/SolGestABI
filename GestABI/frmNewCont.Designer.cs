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
            this.btnAjou_frmNewCont = new System.Windows.Forms.Button();
            this.btnList_frmNewCont = new System.Windows.Forms.Button();
            this.btnAnnu_frmNewCont = new System.Windows.Forms.Button();
            this.txt_nomProjet_frmNewCont = new System.Windows.Forms.TextBox();
            this.grbIntervention.SuspendLayout();
            this.grbFiche_frmCont.SuspendLayout();
            this.grbRecherche_frmCont.SuspendLayout();
            this.grbBoutons_NewCont.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbIntervention
            // 
            this.grbIntervention.Controls.Add(this.txt_nomProjet_frmNewCont);
            this.grbIntervention.Controls.SetChildIndex(this.mtb_dureeProjet, 0);
            this.grbIntervention.Controls.SetChildIndex(this.mtb_dureeCumul, 0);
            this.grbIntervention.Controls.SetChildIndex(this.txt_nomProjet_frmNewCont, 0);
            // 
            // grbRecherche_frmCont
            // 
            this.grbRecherche_frmCont.Visible = false;
            // 
            // grbBoutons_NewCont
            // 
            this.grbBoutons_NewCont.Controls.Add(this.btnAjou_frmNewCont);
            this.grbBoutons_NewCont.Controls.Add(this.btnList_frmNewCont);
            this.grbBoutons_NewCont.Controls.Add(this.btnAnnu_frmNewCont);
            this.grbBoutons_NewCont.Location = new System.Drawing.Point(349, 496);
            this.grbBoutons_NewCont.Name = "grbBoutons_NewCont";
            this.grbBoutons_NewCont.Size = new System.Drawing.Size(280, 58);
            this.grbBoutons_NewCont.TabIndex = 46;
            this.grbBoutons_NewCont.TabStop = false;
            // 
            // btnAjou_frmNewCont
            // 
            this.btnAjou_frmNewCont.Location = new System.Drawing.Point(14, 20);
            this.btnAjou_frmNewCont.Name = "btnAjou_frmNewCont";
            this.btnAjou_frmNewCont.Size = new System.Drawing.Size(75, 23);
            this.btnAjou_frmNewCont.TabIndex = 34;
            this.btnAjou_frmNewCont.Text = "Ajouter";
            this.btnAjou_frmNewCont.UseVisualStyleBackColor = true;
            // 
            // btnList_frmNewCont
            // 
            this.btnList_frmNewCont.Location = new System.Drawing.Point(190, 20);
            this.btnList_frmNewCont.Name = "btnList_frmNewCont";
            this.btnList_frmNewCont.Size = new System.Drawing.Size(75, 23);
            this.btnList_frmNewCont.TabIndex = 33;
            this.btnList_frmNewCont.Text = "Liste";
            this.btnList_frmNewCont.UseVisualStyleBackColor = true;
            // 
            // btnAnnu_frmNewCont
            // 
            this.btnAnnu_frmNewCont.Location = new System.Drawing.Point(102, 20);
            this.btnAnnu_frmNewCont.Name = "btnAnnu_frmNewCont";
            this.btnAnnu_frmNewCont.Size = new System.Drawing.Size(75, 23);
            this.btnAnnu_frmNewCont.TabIndex = 38;
            this.btnAnnu_frmNewCont.Text = "Annuler";
            this.btnAnnu_frmNewCont.UseVisualStyleBackColor = true;
            // 
            // txt_nomProjet_frmNewCont
            // 
            this.txt_nomProjet_frmNewCont.Location = new System.Drawing.Point(108, 26);
            this.txt_nomProjet_frmNewCont.Name = "txt_nomProjet_frmNewCont";
            this.txt_nomProjet_frmNewCont.Size = new System.Drawing.Size(488, 20);
            this.txt_nomProjet_frmNewCont.TabIndex = 28;
            // 
            // frmNewCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(646, 572);
            this.Controls.Add(this.grbBoutons_NewCont);
            this.Name = "frmNewCont";
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
        private System.Windows.Forms.Button btnAjou_frmNewCont;
        private System.Windows.Forms.Button btnList_frmNewCont;
        private System.Windows.Forms.Button btnAnnu_frmNewCont;
        protected System.Windows.Forms.TextBox txt_nomProjet_frmNewCont;
    }
}
