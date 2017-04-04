namespace GestABI
{
    partial class frmListClie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grb_rech_frmListClie = new System.Windows.Forms.GroupBox();
            this.txtRech_frmListClie = new System.Windows.Forms.TextBox();
            this.btn_lancRech_frmListClie = new System.Windows.Forms.Button();
            this.rdb_activite = new System.Windows.Forms.RadioButton();
            this.rdb_idClient = new System.Windows.Forms.RadioButton();
            this.rdb_nomClient = new System.Windows.Forms.RadioButton();
            this.grd_frmListClie = new System.Windows.Forms.DataGridView();
            this.btn_annuRech = new System.Windows.Forms.Button();
            this.btn_affiModi_frmListClie = new System.Windows.Forms.Button();
            this.btn_ajouClie_frmListClie = new System.Windows.Forms.Button();
            this.grb_rech_frmListClie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_frmListClie)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_rech_frmListClie
            // 
            this.grb_rech_frmListClie.Controls.Add(this.txtRech_frmListClie);
            this.grb_rech_frmListClie.Controls.Add(this.btn_lancRech_frmListClie);
            this.grb_rech_frmListClie.Controls.Add(this.rdb_activite);
            this.grb_rech_frmListClie.Controls.Add(this.rdb_idClient);
            this.grb_rech_frmListClie.Controls.Add(this.rdb_nomClient);
            this.grb_rech_frmListClie.Location = new System.Drawing.Point(22, 12);
            this.grb_rech_frmListClie.Name = "grb_rech_frmListClie";
            this.grb_rech_frmListClie.Size = new System.Drawing.Size(738, 81);
            this.grb_rech_frmListClie.TabIndex = 0;
            this.grb_rech_frmListClie.TabStop = false;
            this.grb_rech_frmListClie.Text = "Rechercher par ...";
            // 
            // txtRech_frmListClie
            // 
            this.txtRech_frmListClie.Location = new System.Drawing.Point(374, 35);
            this.txtRech_frmListClie.Name = "txtRech_frmListClie";
            this.txtRech_frmListClie.Size = new System.Drawing.Size(218, 20);
            this.txtRech_frmListClie.TabIndex = 4;
            // 
            // btn_lancRech_frmListClie
            // 
            this.btn_lancRech_frmListClie.Location = new System.Drawing.Point(598, 33);
            this.btn_lancRech_frmListClie.Name = "btn_lancRech_frmListClie";
            this.btn_lancRech_frmListClie.Size = new System.Drawing.Size(125, 23);
            this.btn_lancRech_frmListClie.TabIndex = 3;
            this.btn_lancRech_frmListClie.Text = "Lancer la recherche";
            this.btn_lancRech_frmListClie.UseVisualStyleBackColor = true;
            this.btn_lancRech_frmListClie.Click += new System.EventHandler(this.btn_lancRech_frmListClie_Click);
            // 
            // rdb_activite
            // 
            this.rdb_activite.AutoSize = true;
            this.rdb_activite.Location = new System.Drawing.Point(246, 39);
            this.rdb_activite.Name = "rdb_activite";
            this.rdb_activite.Size = new System.Drawing.Size(60, 17);
            this.rdb_activite.TabIndex = 2;
            this.rdb_activite.TabStop = true;
            this.rdb_activite.Text = "Activité";
            this.rdb_activite.UseVisualStyleBackColor = true;
            // 
            // rdb_idClient
            // 
            this.rdb_idClient.AutoSize = true;
            this.rdb_idClient.Location = new System.Drawing.Point(134, 39);
            this.rdb_idClient.Name = "rdb_idClient";
            this.rdb_idClient.Size = new System.Drawing.Size(62, 17);
            this.rdb_idClient.TabIndex = 1;
            this.rdb_idClient.TabStop = true;
            this.rdb_idClient.Text = "Numéro";
            this.rdb_idClient.UseVisualStyleBackColor = true;
            // 
            // rdb_nomClient
            // 
            this.rdb_nomClient.AutoSize = true;
            this.rdb_nomClient.Location = new System.Drawing.Point(31, 39);
            this.rdb_nomClient.Name = "rdb_nomClient";
            this.rdb_nomClient.Size = new System.Drawing.Size(47, 17);
            this.rdb_nomClient.TabIndex = 0;
            this.rdb_nomClient.TabStop = true;
            this.rdb_nomClient.Text = "Nom";
            this.rdb_nomClient.UseVisualStyleBackColor = true;
            // 
            // grd_frmListClie
            // 
            this.grd_frmListClie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_frmListClie.Location = new System.Drawing.Point(22, 112);
            this.grd_frmListClie.Name = "grd_frmListClie";
            this.grd_frmListClie.Size = new System.Drawing.Size(738, 545);
            this.grd_frmListClie.TabIndex = 1;
            this.grd_frmListClie.DoubleClick += new System.EventHandler(this.grd_frmListClie_DoubleClick);
            // 
            // btn_annuRech
            // 
            this.btn_annuRech.Location = new System.Drawing.Point(351, 676);
            this.btn_annuRech.Name = "btn_annuRech";
            this.btn_annuRech.Size = new System.Drawing.Size(120, 23);
            this.btn_annuRech.TabIndex = 2;
            this.btn_annuRech.Text = "Annuler la rech.";
            this.btn_annuRech.UseVisualStyleBackColor = true;
            this.btn_annuRech.Click += new System.EventHandler(this.btn_annuRech_Click);
            // 
            // btn_affiModi_frmListClie
            // 
            this.btn_affiModi_frmListClie.Location = new System.Drawing.Point(640, 676);
            this.btn_affiModi_frmListClie.Name = "btn_affiModi_frmListClie";
            this.btn_affiModi_frmListClie.Size = new System.Drawing.Size(120, 23);
            this.btn_affiModi_frmListClie.TabIndex = 3;
            this.btn_affiModi_frmListClie.Text = "Afficher / Modifier";
            this.btn_affiModi_frmListClie.UseVisualStyleBackColor = true;
            // 
            // btn_ajouClie_frmListClie
            // 
            this.btn_ajouClie_frmListClie.Location = new System.Drawing.Point(496, 676);
            this.btn_ajouClie_frmListClie.Name = "btn_ajouClie_frmListClie";
            this.btn_ajouClie_frmListClie.Size = new System.Drawing.Size(120, 23);
            this.btn_ajouClie_frmListClie.TabIndex = 4;
            this.btn_ajouClie_frmListClie.Text = "Ajouter un client";
            this.btn_ajouClie_frmListClie.UseVisualStyleBackColor = true;
            this.btn_ajouClie_frmListClie.Click += new System.EventHandler(this.btn_ajouClie_frmListClie_Click);
            // 
            // frmListClie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 718);
            this.Controls.Add(this.btn_ajouClie_frmListClie);
            this.Controls.Add(this.btn_affiModi_frmListClie);
            this.Controls.Add(this.btn_annuRech);
            this.Controls.Add(this.grd_frmListClie);
            this.Controls.Add(this.grb_rech_frmListClie);
            this.Name = "frmListClie";
            this.Text = "Liste des clients";
            this.grb_rech_frmListClie.ResumeLayout(false);
            this.grb_rech_frmListClie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_frmListClie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rdb_nomClient;
        private System.Windows.Forms.DataGridView grd_frmListClie;
        private System.Windows.Forms.Button btn_lancRech_frmListClie;
        private System.Windows.Forms.RadioButton rdb_activite;
        private System.Windows.Forms.RadioButton rdb_idClient;
        private System.Windows.Forms.TextBox txtRech_frmListClie;
        private System.Windows.Forms.Button btn_annuRech;
        private System.Windows.Forms.Button btn_affiModi_frmListClie;
        private System.Windows.Forms.Button btn_ajouClie_frmListClie;
        private System.Windows.Forms.GroupBox grb_rech_frmListClie;
    }
}