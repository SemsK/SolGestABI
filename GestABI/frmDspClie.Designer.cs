﻿namespace GestABI
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
            this.btnAnnuModi = new System.Windows.Forms.Button();
            this.btnValiModi = new System.Windows.Forms.Button();
            this.btnAjou_frmDspClie = new System.Windows.Forms.Button();
            this.grbButton_frmDspClie = new System.Windows.Forms.GroupBox();
            this.grbFiche_frmClie.SuspendLayout();
            this.grbRecherche_frmClie.SuspendLayout();
            this.grbButton_frmDspClie.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSupp_frmDspClie
            // 
            this.btnSupp_frmDspClie.Location = new System.Drawing.Point(6, 23);
            this.btnSupp_frmDspClie.Name = "btnSupp_frmDspClie";
            this.btnSupp_frmDspClie.Size = new System.Drawing.Size(144, 23);
            this.btnSupp_frmDspClie.TabIndex = 33;
            this.btnSupp_frmDspClie.Text = "Supprimer le client";
            this.btnSupp_frmDspClie.UseVisualStyleBackColor = true;
            this.btnSupp_frmDspClie.Click += new System.EventHandler(this.btnSupp_frmDspClie_Click);
            // 
            // btnAnnuModi
            // 
            this.btnAnnuModi.Location = new System.Drawing.Point(346, 23);
            this.btnAnnuModi.Name = "btnAnnuModi";
            this.btnAnnuModi.Size = new System.Drawing.Size(144, 23);
            this.btnAnnuModi.TabIndex = 34;
            this.btnAnnuModi.Text = "Annuler les modifications";
            this.btnAnnuModi.UseVisualStyleBackColor = true;
            this.btnAnnuModi.Click += new System.EventHandler(this.btnAnnuModi_Click);
            // 
            // btnValiModi
            // 
            this.btnValiModi.Location = new System.Drawing.Point(196, 23);
            this.btnValiModi.Name = "btnValiModi";
            this.btnValiModi.Size = new System.Drawing.Size(144, 23);
            this.btnValiModi.TabIndex = 44;
            this.btnValiModi.Text = "Valider vos modifications";
            this.btnValiModi.UseVisualStyleBackColor = true;
            this.btnValiModi.Click += new System.EventHandler(this.btnValiModi_Click);
            // 
            // btnAjou_frmDspClie
            // 
            this.btnAjou_frmDspClie.Location = new System.Drawing.Point(496, 23);
            this.btnAjou_frmDspClie.Name = "btnAjou_frmDspClie";
            this.btnAjou_frmDspClie.Size = new System.Drawing.Size(144, 23);
            this.btnAjou_frmDspClie.TabIndex = 47;
            this.btnAjou_frmDspClie.Text = "Ajouter un client";
            this.btnAjou_frmDspClie.UseVisualStyleBackColor = true;
            this.btnAjou_frmDspClie.Click += new System.EventHandler(this.btnAjou_frmDspClie_Click);
            // 
            // grbButton_frmDspClie
            // 
            this.grbButton_frmDspClie.Controls.Add(this.btnSupp_frmDspClie);
            this.grbButton_frmDspClie.Controls.Add(this.btnAjou_frmDspClie);
            this.grbButton_frmDspClie.Controls.Add(this.btnValiModi);
            this.grbButton_frmDspClie.Controls.Add(this.btnAnnuModi);
            this.grbButton_frmDspClie.Location = new System.Drawing.Point(20, 642);
            this.grbButton_frmDspClie.Name = "grbButton_frmDspClie";
            this.grbButton_frmDspClie.Size = new System.Drawing.Size(646, 64);
            this.grbButton_frmDspClie.TabIndex = 48;
            this.grbButton_frmDspClie.TabStop = false;
            // 
            // frmDspClie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(687, 726);
            this.Controls.Add(this.grbButton_frmDspClie);
            this.Name = "frmDspClie";
            this.Text = "Affichage / Modification d\'un client";
            this.Load += new System.EventHandler(this.frmDspClie_Load);
            this.Controls.SetChildIndex(this.grbFiche_frmClie, 0);
            this.Controls.SetChildIndex(this.grbRecherche_frmClie, 0);
            this.Controls.SetChildIndex(this.grbButton_frmDspClie, 0);
            this.grbFiche_frmClie.ResumeLayout(false);
            this.grbFiche_frmClie.PerformLayout();
            this.grbRecherche_frmClie.ResumeLayout(false);
            this.grbRecherche_frmClie.PerformLayout();
            this.grbButton_frmDspClie.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSupp_frmDspClie;
        private System.Windows.Forms.Button btnAnnuModi;
        private System.Windows.Forms.Button btnValiModi;
        private System.Windows.Forms.Button btnAjou_frmDspClie;
        private System.Windows.Forms.GroupBox grbButton_frmDspClie;
    }
}
