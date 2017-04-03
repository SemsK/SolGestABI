namespace GestABI
{
    partial class frmDspClie
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
            this.btnSupp_frmDspClie = new System.Windows.Forms.Button();
            this.btnModiCont = new System.Windows.Forms.Button();
            this.txt_typeSociete = new System.Windows.Forms.TextBox();
            this.txt_nature = new System.Windows.Forms.TextBox();
            this.cbb_nomContact_frmDspClie = new System.Windows.Forms.ComboBox();
            this.btnValiModi = new System.Windows.Forms.Button();
            this.lblNoClient = new System.Windows.Forms.Label();
            this.btnAjou_frmDspClie = new System.Windows.Forms.Button();
            this.grbFiche_frmClie.SuspendLayout();
            this.grbRecherche_frmClie.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbFiche_frmClie
            // 
            this.grbFiche_frmClie.Controls.Add(this.cbb_nomContact_frmDspClie);
            this.grbFiche_frmClie.Controls.Add(this.txt_typeSociete);
            this.grbFiche_frmClie.Controls.Add(this.txt_nature);
            this.grbFiche_frmClie.Controls.SetChildIndex(this.cbb_typeSociete, 0);
            this.grbFiche_frmClie.Controls.SetChildIndex(this.cbb_nature, 0);
            this.grbFiche_frmClie.Controls.SetChildIndex(this.txt_nomClient, 0);
            this.grbFiche_frmClie.Controls.SetChildIndex(this.txt_mail, 0);
            this.grbFiche_frmClie.Controls.SetChildIndex(this.txt_idClient, 0);
            this.grbFiche_frmClie.Controls.SetChildIndex(this.txt_adresse, 0);
            this.grbFiche_frmClie.Controls.SetChildIndex(this.txt_activite, 0);
            this.grbFiche_frmClie.Controls.SetChildIndex(this.txt_ville, 0);
            this.grbFiche_frmClie.Controls.SetChildIndex(this.txt_effectif, 0);
            this.grbFiche_frmClie.Controls.SetChildIndex(this.txt_commClient, 0);
            this.grbFiche_frmClie.Controls.SetChildIndex(this.txt_raisonSociale, 0);
            this.grbFiche_frmClie.Controls.SetChildIndex(this.txt_cA, 0);
            this.grbFiche_frmClie.Controls.SetChildIndex(this.txt_telephone, 0);
            this.grbFiche_frmClie.Controls.SetChildIndex(this.txt_codeClient, 0);
            this.grbFiche_frmClie.Controls.SetChildIndex(this.txt_nature, 0);
            this.grbFiche_frmClie.Controls.SetChildIndex(this.txt_typeSociete, 0);
            this.grbFiche_frmClie.Controls.SetChildIndex(this.cbb_nomContact_frmDspClie, 0);
            // 
            // btnSupp_frmDspClie
            // 
            this.btnSupp_frmDspClie.Location = new System.Drawing.Point(354, 661);
            this.btnSupp_frmDspClie.Name = "btnSupp_frmDspClie";
            this.btnSupp_frmDspClie.Size = new System.Drawing.Size(144, 23);
            this.btnSupp_frmDspClie.TabIndex = 33;
            this.btnSupp_frmDspClie.Text = "Supprimer le client";
            this.btnSupp_frmDspClie.UseVisualStyleBackColor = true;
            // 
            // btnModiCont
            // 
            this.btnModiCont.Location = new System.Drawing.Point(20, 661);
            this.btnModiCont.Name = "btnModiCont";
            this.btnModiCont.Size = new System.Drawing.Size(144, 23);
            this.btnModiCont.TabIndex = 34;
            this.btnModiCont.Text = "Modifier cette fiche client";
            this.btnModiCont.UseVisualStyleBackColor = true;
            // 
            // txt_typeSociete
            // 
            this.txt_typeSociete.Location = new System.Drawing.Point(119, 106);
            this.txt_typeSociete.Name = "txt_typeSociete";
            this.txt_typeSociete.Size = new System.Drawing.Size(188, 20);
            this.txt_typeSociete.TabIndex = 35;
            // 
            // txt_nature
            // 
            this.txt_nature.Location = new System.Drawing.Point(441, 106);
            this.txt_nature.Name = "txt_nature";
            this.txt_nature.Size = new System.Drawing.Size(188, 20);
            this.txt_nature.TabIndex = 36;
            // 
            // cbb_nomContact_frmDspClie
            // 
            this.cbb_nomContact_frmDspClie.FormattingEnabled = true;
            this.cbb_nomContact_frmDspClie.Location = new System.Drawing.Point(122, 306);
            this.cbb_nomContact_frmDspClie.Name = "cbb_nomContact_frmDspClie";
            this.cbb_nomContact_frmDspClie.Size = new System.Drawing.Size(507, 21);
            this.cbb_nomContact_frmDspClie.TabIndex = 37;
            // 
            // btnValiModi
            // 
            this.btnValiModi.Location = new System.Drawing.Point(187, 661);
            this.btnValiModi.Name = "btnValiModi";
            this.btnValiModi.Size = new System.Drawing.Size(144, 23);
            this.btnValiModi.TabIndex = 44;
            this.btnValiModi.Text = "Valider vos modifications";
            this.btnValiModi.UseVisualStyleBackColor = true;
            // 
            // lblNoClient
            // 
            this.lblNoClient.AutoSize = true;
            this.lblNoClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoClient.Location = new System.Drawing.Point(15, 218);
            this.lblNoClient.Name = "lblNoClient";
            this.lblNoClient.Size = new System.Drawing.Size(659, 39);
            this.lblNoClient.TabIndex = 46;
            this.lblNoClient.Text = "Aucun client dans votre base de données!";
            // 
            // btnAjou_frmDspClie
            // 
            this.btnAjou_frmDspClie.Location = new System.Drawing.Point(522, 661);
            this.btnAjou_frmDspClie.Name = "btnAjou_frmDspClie";
            this.btnAjou_frmDspClie.Size = new System.Drawing.Size(144, 23);
            this.btnAjou_frmDspClie.TabIndex = 47;
            this.btnAjou_frmDspClie.Text = "Ajouter un client";
            this.btnAjou_frmDspClie.UseVisualStyleBackColor = true;
            this.btnAjou_frmDspClie.Click += new System.EventHandler(this.btnAjou_frmDspClie_Click);
            // 
            // frmDspClie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(687, 718);
            this.Controls.Add(this.btnAjou_frmDspClie);
            this.Controls.Add(this.lblNoClient);
            this.Controls.Add(this.btnValiModi);
            this.Controls.Add(this.btnModiCont);
            this.Controls.Add(this.btnSupp_frmDspClie);
            this.Name = "frmDspClie";
            this.Text = "Affichage d\'un client";
            this.Load += new System.EventHandler(this.frmDspClie_Load);
            this.Controls.SetChildIndex(this.grbFiche_frmClie, 0);
            this.Controls.SetChildIndex(this.grbRecherche_frmClie, 0);
            this.Controls.SetChildIndex(this.btnSupp_frmDspClie, 0);
            this.Controls.SetChildIndex(this.btnModiCont, 0);
            this.Controls.SetChildIndex(this.btnValiModi, 0);
            this.Controls.SetChildIndex(this.lblNoClient, 0);
            this.Controls.SetChildIndex(this.btnAjou_frmDspClie, 0);
            this.grbFiche_frmClie.ResumeLayout(false);
            this.grbFiche_frmClie.PerformLayout();
            this.grbRecherche_frmClie.ResumeLayout(false);
            this.grbRecherche_frmClie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSupp_frmDspClie;
        private System.Windows.Forms.Button btnModiCont;
        private System.Windows.Forms.TextBox txt_typeSociete;
        private System.Windows.Forms.TextBox txt_nature;
        private System.Windows.Forms.ComboBox cbb_nomContact_frmDspClie;
        private System.Windows.Forms.Button btnValiModi;
        private System.Windows.Forms.Label lblNoClient;
        private System.Windows.Forms.Button btnAjou_frmDspClie;
    }
}
