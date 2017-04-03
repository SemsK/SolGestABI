namespace GestABI
{
    partial class frmListCont
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
            this.txtRech_frmListCont = new System.Windows.Forms.TextBox();
            this.btn_lancRech_frmListCont = new System.Windows.Forms.Button();
            this.rdb_nomClient = new System.Windows.Forms.RadioButton();
            this.rdb_prenomContact = new System.Windows.Forms.RadioButton();
            this.rdb_nomContact = new System.Windows.Forms.RadioButton();
            this.dgv_frmListClie = new System.Windows.Forms.DataGridView();
            this.cln_nomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_nomContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_prenomContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_fonctionContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_telContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_mailContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_annuRech_frmListCont = new System.Windows.Forms.Button();
            this.btn_creeClie_frmListCont = new System.Windows.Forms.Button();
            this.btn_affiModi_frmListCont = new System.Windows.Forms.Button();
            this.grb_rech_frmListClie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_frmListClie)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_rech_frmListClie
            // 
            this.grb_rech_frmListClie.Controls.Add(this.txtRech_frmListCont);
            this.grb_rech_frmListClie.Controls.Add(this.btn_lancRech_frmListCont);
            this.grb_rech_frmListClie.Controls.Add(this.rdb_nomClient);
            this.grb_rech_frmListClie.Controls.Add(this.rdb_prenomContact);
            this.grb_rech_frmListClie.Controls.Add(this.rdb_nomContact);
            this.grb_rech_frmListClie.Location = new System.Drawing.Point(22, 12);
            this.grb_rech_frmListClie.Name = "grb_rech_frmListClie";
            this.grb_rech_frmListClie.Size = new System.Drawing.Size(738, 81);
            this.grb_rech_frmListClie.TabIndex = 1;
            this.grb_rech_frmListClie.TabStop = false;
            this.grb_rech_frmListClie.Text = "Rechercher par ...";
            // 
            // txtRech_frmListCont
            // 
            this.txtRech_frmListCont.Location = new System.Drawing.Point(374, 35);
            this.txtRech_frmListCont.Name = "txtRech_frmListCont";
            this.txtRech_frmListCont.Size = new System.Drawing.Size(218, 20);
            this.txtRech_frmListCont.TabIndex = 4;
            // 
            // btn_lancRech_frmListCont
            // 
            this.btn_lancRech_frmListCont.Location = new System.Drawing.Point(598, 33);
            this.btn_lancRech_frmListCont.Name = "btn_lancRech_frmListCont";
            this.btn_lancRech_frmListCont.Size = new System.Drawing.Size(125, 23);
            this.btn_lancRech_frmListCont.TabIndex = 3;
            this.btn_lancRech_frmListCont.Text = "Lancer la recherche";
            this.btn_lancRech_frmListCont.UseVisualStyleBackColor = true;
            // 
            // rdb_nomClient
            // 
            this.rdb_nomClient.AutoSize = true;
            this.rdb_nomClient.Location = new System.Drawing.Point(246, 39);
            this.rdb_nomClient.Name = "rdb_nomClient";
            this.rdb_nomClient.Size = new System.Drawing.Size(51, 17);
            this.rdb_nomClient.TabIndex = 2;
            this.rdb_nomClient.TabStop = true;
            this.rdb_nomClient.Text = "Client";
            this.rdb_nomClient.UseVisualStyleBackColor = true;
            // 
            // rdb_prenomContact
            // 
            this.rdb_prenomContact.AutoSize = true;
            this.rdb_prenomContact.Location = new System.Drawing.Point(134, 39);
            this.rdb_prenomContact.Name = "rdb_prenomContact";
            this.rdb_prenomContact.Size = new System.Drawing.Size(61, 17);
            this.rdb_prenomContact.TabIndex = 1;
            this.rdb_prenomContact.TabStop = true;
            this.rdb_prenomContact.Text = "Prénom";
            this.rdb_prenomContact.UseVisualStyleBackColor = true;
            // 
            // rdb_nomContact
            // 
            this.rdb_nomContact.AutoSize = true;
            this.rdb_nomContact.Location = new System.Drawing.Point(31, 39);
            this.rdb_nomContact.Name = "rdb_nomContact";
            this.rdb_nomContact.Size = new System.Drawing.Size(47, 17);
            this.rdb_nomContact.TabIndex = 0;
            this.rdb_nomContact.TabStop = true;
            this.rdb_nomContact.Text = "Nom";
            this.rdb_nomContact.UseVisualStyleBackColor = true;
            // 
            // dgv_frmListClie
            // 
            this.dgv_frmListClie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_frmListClie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln_nomClient,
            this.cln_nomContact,
            this.cln_prenomContact,
            this.cln_fonctionContact,
            this.cln_telContact,
            this.cln_mailContact});
            this.dgv_frmListClie.Location = new System.Drawing.Point(22, 112);
            this.dgv_frmListClie.Name = "dgv_frmListClie";
            this.dgv_frmListClie.Size = new System.Drawing.Size(738, 545);
            this.dgv_frmListClie.TabIndex = 2;
            // 
            // cln_nomClient
            // 
            this.cln_nomClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cln_nomClient.HeaderText = "Client";
            this.cln_nomClient.Name = "cln_nomClient";
            this.cln_nomClient.Width = 120;
            // 
            // cln_nomContact
            // 
            this.cln_nomContact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cln_nomContact.HeaderText = "Nom";
            this.cln_nomContact.Name = "cln_nomContact";
            // 
            // cln_prenomContact
            // 
            this.cln_prenomContact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cln_prenomContact.HeaderText = "Prénom";
            this.cln_prenomContact.Name = "cln_prenomContact";
            // 
            // cln_fonctionContact
            // 
            this.cln_fonctionContact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cln_fonctionContact.HeaderText = "Fonction";
            this.cln_fonctionContact.Name = "cln_fonctionContact";
            this.cln_fonctionContact.Width = 80;
            // 
            // cln_telContact
            // 
            this.cln_telContact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cln_telContact.HeaderText = "Téléphone";
            this.cln_telContact.Name = "cln_telContact";
            // 
            // cln_mailContact
            // 
            this.cln_mailContact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cln_mailContact.HeaderText = "Adresse mail";
            this.cln_mailContact.Name = "cln_mailContact";
            this.cln_mailContact.Width = 200;
            // 
            // btn_annuRech_frmListCont
            // 
            this.btn_annuRech_frmListCont.Location = new System.Drawing.Point(351, 676);
            this.btn_annuRech_frmListCont.Name = "btn_annuRech_frmListCont";
            this.btn_annuRech_frmListCont.Size = new System.Drawing.Size(120, 23);
            this.btn_annuRech_frmListCont.TabIndex = 3;
            this.btn_annuRech_frmListCont.Text = "Annuler la rech.";
            this.btn_annuRech_frmListCont.UseVisualStyleBackColor = true;
            // 
            // btn_creeClie_frmListCont
            // 
            this.btn_creeClie_frmListCont.Location = new System.Drawing.Point(496, 676);
            this.btn_creeClie_frmListCont.Name = "btn_creeClie_frmListCont";
            this.btn_creeClie_frmListCont.Size = new System.Drawing.Size(120, 23);
            this.btn_creeClie_frmListCont.TabIndex = 5;
            this.btn_creeClie_frmListCont.Text = "Créer un client";
            this.btn_creeClie_frmListCont.UseVisualStyleBackColor = true;
            // 
            // btn_affiModi_frmListCont
            // 
            this.btn_affiModi_frmListCont.Location = new System.Drawing.Point(640, 676);
            this.btn_affiModi_frmListCont.Name = "btn_affiModi_frmListCont";
            this.btn_affiModi_frmListCont.Size = new System.Drawing.Size(120, 23);
            this.btn_affiModi_frmListCont.TabIndex = 6;
            this.btn_affiModi_frmListCont.Text = "Afficher / Modifier";
            this.btn_affiModi_frmListCont.UseVisualStyleBackColor = true;
            // 
            // frmListCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 718);
            this.Controls.Add(this.btn_affiModi_frmListCont);
            this.Controls.Add(this.btn_creeClie_frmListCont);
            this.Controls.Add(this.btn_annuRech_frmListCont);
            this.Controls.Add(this.dgv_frmListClie);
            this.Controls.Add(this.grb_rech_frmListClie);
            this.Name = "frmListCont";
            this.Text = "Liste des contacts";
            this.grb_rech_frmListClie.ResumeLayout(false);
            this.grb_rech_frmListClie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_frmListClie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_rech_frmListClie;
        private System.Windows.Forms.TextBox txtRech_frmListCont;
        private System.Windows.Forms.Button btn_lancRech_frmListCont;
        private System.Windows.Forms.RadioButton rdb_nomClient;
        private System.Windows.Forms.RadioButton rdb_prenomContact;
        private System.Windows.Forms.RadioButton rdb_nomContact;
        private System.Windows.Forms.DataGridView dgv_frmListClie;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_nomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_nomContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_prenomContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_fonctionContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_telContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_mailContact;
        private System.Windows.Forms.Button btn_annuRech_frmListCont;
        private System.Windows.Forms.Button btn_creeClie_frmListCont;
        private System.Windows.Forms.Button btn_affiModi_frmListCont;
    }
}