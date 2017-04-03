namespace GestABI
{
    partial class frmNewClie
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
            this.btnList_frmNewClie = new System.Windows.Forms.Button();
            this.btnOK_frmNewClie = new System.Windows.Forms.Button();
            this.text_nomContact_frmClie = new System.Windows.Forms.TextBox();
            this.btnQuit_frmNewClie = new System.Windows.Forms.Button();
            this.grbBoutons_frmNewClie = new System.Windows.Forms.GroupBox();
            this.grbFiche_frmClie.SuspendLayout();
            this.grbRecherche_frmClie.SuspendLayout();
            this.grbBoutons_frmNewClie.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbFiche_frmClie
            // 
            this.grbFiche_frmClie.Controls.Add(this.text_nomContact_frmClie);
            this.grbFiche_frmClie.Controls.SetChildIndex(this.text_nomContact_frmClie, 0);
            this.grbFiche_frmClie.Controls.SetChildIndex(this.txt_mail, 0);
            this.grbFiche_frmClie.Controls.SetChildIndex(this.txt_adresse, 0);
            this.grbFiche_frmClie.Controls.SetChildIndex(this.txt_ville, 0);
            this.grbFiche_frmClie.Controls.SetChildIndex(this.txt_effectif, 0);
            this.grbFiche_frmClie.Controls.SetChildIndex(this.txt_commClient, 0);
            this.grbFiche_frmClie.Controls.SetChildIndex(this.txt_raisonSociale, 0);
            this.grbFiche_frmClie.Controls.SetChildIndex(this.txt_nomClient, 0);
            this.grbFiche_frmClie.Controls.SetChildIndex(this.txt_idClient, 0);
            this.grbFiche_frmClie.Controls.SetChildIndex(this.txt_activite, 0);
            this.grbFiche_frmClie.Controls.SetChildIndex(this.txt_cA, 0);
            this.grbFiche_frmClie.Controls.SetChildIndex(this.txt_telephone, 0);
            this.grbFiche_frmClie.Controls.SetChildIndex(this.txt_codeClient, 0);
            // 
            // grbRecherche_frmClie
            // 
            this.grbRecherche_frmClie.Visible = false;
            // 
            // btnList_frmNewClie
            // 
            this.btnList_frmNewClie.Location = new System.Drawing.Point(190, 20);
            this.btnList_frmNewClie.Name = "btnList_frmNewClie";
            this.btnList_frmNewClie.Size = new System.Drawing.Size(75, 23);
            this.btnList_frmNewClie.TabIndex = 33;
            this.btnList_frmNewClie.Text = "Liste";
            this.btnList_frmNewClie.UseVisualStyleBackColor = true;
            // 
            // btnOK_frmNewClie
            // 
            this.btnOK_frmNewClie.Location = new System.Drawing.Point(14, 20);
            this.btnOK_frmNewClie.Name = "btnOK_frmNewClie";
            this.btnOK_frmNewClie.Size = new System.Drawing.Size(75, 23);
            this.btnOK_frmNewClie.TabIndex = 34;
            this.btnOK_frmNewClie.Text = "OK";
            this.btnOK_frmNewClie.UseVisualStyleBackColor = true;
            this.btnOK_frmNewClie.Click += new System.EventHandler(this.btnOK_frmNewClie_Click);
            // 
            // text_nomContact_frmClie
            // 
            this.text_nomContact_frmClie.Location = new System.Drawing.Point(119, 306);
            this.text_nomContact_frmClie.Name = "text_nomContact_frmClie";
            this.text_nomContact_frmClie.Size = new System.Drawing.Size(510, 20);
            this.text_nomContact_frmClie.TabIndex = 37;
            // 
            // btnQuit_frmNewClie
            // 
            this.btnQuit_frmNewClie.Location = new System.Drawing.Point(102, 20);
            this.btnQuit_frmNewClie.Name = "btnQuit_frmNewClie";
            this.btnQuit_frmNewClie.Size = new System.Drawing.Size(75, 23);
            this.btnQuit_frmNewClie.TabIndex = 38;
            this.btnQuit_frmNewClie.Text = "Quitter";
            this.btnQuit_frmNewClie.UseVisualStyleBackColor = true;
            this.btnQuit_frmNewClie.Click += new System.EventHandler(this.btnQuit_frmNewClie_Click_1);
            // 
            // grbBoutons_frmNewClie
            // 
            this.grbBoutons_frmNewClie.Controls.Add(this.btnOK_frmNewClie);
            this.grbBoutons_frmNewClie.Controls.Add(this.btnList_frmNewClie);
            this.grbBoutons_frmNewClie.Controls.Add(this.btnQuit_frmNewClie);
            this.grbBoutons_frmNewClie.Location = new System.Drawing.Point(386, 649);
            this.grbBoutons_frmNewClie.Name = "grbBoutons_frmNewClie";
            this.grbBoutons_frmNewClie.Size = new System.Drawing.Size(280, 58);
            this.grbBoutons_frmNewClie.TabIndex = 44;
            this.grbBoutons_frmNewClie.TabStop = false;
            // 
            // frmNewClie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(686, 719);
            this.Controls.Add(this.grbBoutons_frmNewClie);
            this.Name = "frmNewClie";
            this.ShowInTaskbar = false;
            this.Text = "Ajouter un nouveau client";
            this.Controls.SetChildIndex(this.grbFiche_frmClie, 0);
            this.Controls.SetChildIndex(this.grbRecherche_frmClie, 0);
            this.Controls.SetChildIndex(this.grbBoutons_frmNewClie, 0);
            this.grbFiche_frmClie.ResumeLayout(false);
            this.grbFiche_frmClie.PerformLayout();
            this.grbRecherche_frmClie.ResumeLayout(false);
            this.grbRecherche_frmClie.PerformLayout();
            this.grbBoutons_frmNewClie.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnList_frmNewClie;
        private System.Windows.Forms.Button btnOK_frmNewClie;
        private System.Windows.Forms.Button btnQuit_frmNewClie;
        private System.Windows.Forms.GroupBox grbBoutons_frmNewClie;
        protected System.Windows.Forms.TextBox text_nomContact_frmClie;
    }
}
