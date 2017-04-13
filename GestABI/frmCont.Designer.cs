namespace GestABI
{
    partial class frmCont
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
            this.lbl_nomContact = new System.Windows.Forms.Label();
            this.lbl_prenomContact = new System.Windows.Forms.Label();
            this.lbl_telContact = new System.Windows.Forms.Label();
            this.lbl_fonctionContact = new System.Windows.Forms.Label();
            this.txt_fonctionContact = new System.Windows.Forms.TextBox();
            this.lbl_mailContact = new System.Windows.Forms.Label();
            this.lbl_nomDocs = new System.Windows.Forms.Label();
            this.lbl_dureeCumul = new System.Windows.Forms.Label();
            this.grbIntervention = new System.Windows.Forms.GroupBox();
            this.txt_dureeCumul = new System.Windows.Forms.TextBox();
            this.cbb_nomProjet = new System.Windows.Forms.ComboBox();
            this.lbl_idContact = new System.Windows.Forms.Label();
            this.grbFiche_frmCont = new System.Windows.Forms.GroupBox();
            this.txt_mailContact = new System.Windows.Forms.TextBox();
            this.txt_telContact = new System.Windows.Forms.TextBox();
            this.txt_idContact = new System.Windows.Forms.TextBox();
            this.txt_prenomContact = new System.Windows.Forms.TextBox();
            this.txt_nomContact = new System.Windows.Forms.TextBox();
            this.grbRecherche_frmCont = new System.Windows.Forms.GroupBox();
            this.txtRech_frmListCont = new System.Windows.Forms.TextBox();
            this.btn_lancRech_frmListCont = new System.Windows.Forms.Button();
            this.rdb_nomClient_frmCont = new System.Windows.Forms.RadioButton();
            this.rdb_prenomContact_frmCont = new System.Windows.Forms.RadioButton();
            this.rdb_nomContact_frmCont = new System.Windows.Forms.RadioButton();
            this.grbIntervention.SuspendLayout();
            this.grbFiche_frmCont.SuspendLayout();
            this.grbRecherche_frmCont.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nomContact
            // 
            this.lbl_nomContact.AutoSize = true;
            this.lbl_nomContact.Location = new System.Drawing.Point(13, 29);
            this.lbl_nomContact.Name = "lbl_nomContact";
            this.lbl_nomContact.Size = new System.Drawing.Size(35, 13);
            this.lbl_nomContact.TabIndex = 0;
            this.lbl_nomContact.Text = "Nom :";
            // 
            // lbl_prenomContact
            // 
            this.lbl_prenomContact.AutoSize = true;
            this.lbl_prenomContact.Location = new System.Drawing.Point(320, 29);
            this.lbl_prenomContact.Name = "lbl_prenomContact";
            this.lbl_prenomContact.Size = new System.Drawing.Size(49, 13);
            this.lbl_prenomContact.TabIndex = 2;
            this.lbl_prenomContact.Text = "Prénom :";
            // 
            // lbl_telContact
            // 
            this.lbl_telContact.AutoSize = true;
            this.lbl_telContact.Location = new System.Drawing.Point(13, 108);
            this.lbl_telContact.Name = "lbl_telContact";
            this.lbl_telContact.Size = new System.Drawing.Size(94, 13);
            this.lbl_telContact.TabIndex = 4;
            this.lbl_telContact.Text = "N° de Téléphone :";
            // 
            // lbl_fonctionContact
            // 
            this.lbl_fonctionContact.AutoSize = true;
            this.lbl_fonctionContact.Location = new System.Drawing.Point(13, 68);
            this.lbl_fonctionContact.Name = "lbl_fonctionContact";
            this.lbl_fonctionContact.Size = new System.Drawing.Size(54, 13);
            this.lbl_fonctionContact.TabIndex = 8;
            this.lbl_fonctionContact.Text = "Fonction :";
            // 
            // txt_fonctionContact
            // 
            this.txt_fonctionContact.Location = new System.Drawing.Point(108, 65);
            this.txt_fonctionContact.Name = "txt_fonctionContact";
            this.txt_fonctionContact.Size = new System.Drawing.Size(184, 20);
            this.txt_fonctionContact.TabIndex = 9;
            // 
            // lbl_mailContact
            // 
            this.lbl_mailContact.AutoSize = true;
            this.lbl_mailContact.Location = new System.Drawing.Point(320, 108);
            this.lbl_mailContact.Name = "lbl_mailContact";
            this.lbl_mailContact.Size = new System.Drawing.Size(72, 13);
            this.lbl_mailContact.TabIndex = 10;
            this.lbl_mailContact.Text = "Adresse mail :";
            // 
            // lbl_nomDocs
            // 
            this.lbl_nomDocs.AutoSize = true;
            this.lbl_nomDocs.Location = new System.Drawing.Point(12, 29);
            this.lbl_nomDocs.Name = "lbl_nomDocs";
            this.lbl_nomDocs.Size = new System.Drawing.Size(62, 13);
            this.lbl_nomDocs.TabIndex = 12;
            this.lbl_nomDocs.Text = "Document :";
            // 
            // lbl_dureeCumul
            // 
            this.lbl_dureeCumul.AutoSize = true;
            this.lbl_dureeCumul.Location = new System.Drawing.Point(320, 29);
            this.lbl_dureeCumul.Name = "lbl_dureeCumul";
            this.lbl_dureeCumul.Size = new System.Drawing.Size(127, 13);
            this.lbl_dureeCumul.TabIndex = 22;
            this.lbl_dureeCumul.Text = "Nbre d\'heures cumulées :";
            // 
            // grbIntervention
            // 
            this.grbIntervention.Controls.Add(this.txt_dureeCumul);
            this.grbIntervention.Controls.Add(this.cbb_nomProjet);
            this.grbIntervention.Controls.Add(this.lbl_dureeCumul);
            this.grbIntervention.Controls.Add(this.lbl_nomDocs);
            this.grbIntervention.Location = new System.Drawing.Point(18, 252);
            this.grbIntervention.Name = "grbIntervention";
            this.grbIntervention.Size = new System.Drawing.Size(611, 72);
            this.grbIntervention.TabIndex = 26;
            this.grbIntervention.TabStop = false;
            this.grbIntervention.Text = "Intervention";
            // 
            // txt_dureeCumul
            // 
            this.txt_dureeCumul.Location = new System.Drawing.Point(471, 26);
            this.txt_dureeCumul.Name = "txt_dureeCumul";
            this.txt_dureeCumul.Size = new System.Drawing.Size(125, 20);
            this.txt_dureeCumul.TabIndex = 30;
            // 
            // cbb_nomProjet
            // 
            this.cbb_nomProjet.FormattingEnabled = true;
            this.cbb_nomProjet.Location = new System.Drawing.Point(108, 26);
            this.cbb_nomProjet.Name = "cbb_nomProjet";
            this.cbb_nomProjet.Size = new System.Drawing.Size(184, 21);
            this.cbb_nomProjet.TabIndex = 28;
            // 
            // lbl_idContact
            // 
            this.lbl_idContact.AutoSize = true;
            this.lbl_idContact.Location = new System.Drawing.Point(320, 68);
            this.lbl_idContact.Name = "lbl_idContact";
            this.lbl_idContact.Size = new System.Drawing.Size(63, 13);
            this.lbl_idContact.TabIndex = 6;
            this.lbl_idContact.Text = "Contact n° :";
            // 
            // grbFiche_frmCont
            // 
            this.grbFiche_frmCont.Controls.Add(this.txt_mailContact);
            this.grbFiche_frmCont.Controls.Add(this.txt_telContact);
            this.grbFiche_frmCont.Controls.Add(this.txt_idContact);
            this.grbFiche_frmCont.Controls.Add(this.txt_prenomContact);
            this.grbFiche_frmCont.Controls.Add(this.txt_nomContact);
            this.grbFiche_frmCont.Controls.Add(this.lbl_idContact);
            this.grbFiche_frmCont.Controls.Add(this.txt_fonctionContact);
            this.grbFiche_frmCont.Controls.Add(this.lbl_mailContact);
            this.grbFiche_frmCont.Controls.Add(this.lbl_fonctionContact);
            this.grbFiche_frmCont.Controls.Add(this.lbl_nomContact);
            this.grbFiche_frmCont.Controls.Add(this.lbl_prenomContact);
            this.grbFiche_frmCont.Controls.Add(this.lbl_telContact);
            this.grbFiche_frmCont.Location = new System.Drawing.Point(18, 99);
            this.grbFiche_frmCont.Name = "grbFiche_frmCont";
            this.grbFiche_frmCont.Size = new System.Drawing.Size(611, 147);
            this.grbFiche_frmCont.TabIndex = 29;
            this.grbFiche_frmCont.TabStop = false;
            // 
            // txt_mailContact
            // 
            this.txt_mailContact.Location = new System.Drawing.Point(412, 105);
            this.txt_mailContact.Name = "txt_mailContact";
            this.txt_mailContact.Size = new System.Drawing.Size(184, 20);
            this.txt_mailContact.TabIndex = 41;
            // 
            // txt_telContact
            // 
            this.txt_telContact.Location = new System.Drawing.Point(108, 105);
            this.txt_telContact.Name = "txt_telContact";
            this.txt_telContact.Size = new System.Drawing.Size(184, 20);
            this.txt_telContact.TabIndex = 40;
            // 
            // txt_idContact
            // 
            this.txt_idContact.Location = new System.Drawing.Point(412, 65);
            this.txt_idContact.Name = "txt_idContact";
            this.txt_idContact.Size = new System.Drawing.Size(184, 20);
            this.txt_idContact.TabIndex = 39;
            // 
            // txt_prenomContact
            // 
            this.txt_prenomContact.Location = new System.Drawing.Point(412, 26);
            this.txt_prenomContact.Name = "txt_prenomContact";
            this.txt_prenomContact.Size = new System.Drawing.Size(184, 20);
            this.txt_prenomContact.TabIndex = 38;
            // 
            // txt_nomContact
            // 
            this.txt_nomContact.Location = new System.Drawing.Point(108, 26);
            this.txt_nomContact.Name = "txt_nomContact";
            this.txt_nomContact.Size = new System.Drawing.Size(184, 20);
            this.txt_nomContact.TabIndex = 37;
            // 
            // grbRecherche_frmCont
            // 
            this.grbRecherche_frmCont.Controls.Add(this.txtRech_frmListCont);
            this.grbRecherche_frmCont.Controls.Add(this.btn_lancRech_frmListCont);
            this.grbRecherche_frmCont.Controls.Add(this.rdb_nomClient_frmCont);
            this.grbRecherche_frmCont.Controls.Add(this.rdb_prenomContact_frmCont);
            this.grbRecherche_frmCont.Controls.Add(this.rdb_nomContact_frmCont);
            this.grbRecherche_frmCont.Location = new System.Drawing.Point(18, 12);
            this.grbRecherche_frmCont.Name = "grbRecherche_frmCont";
            this.grbRecherche_frmCont.Size = new System.Drawing.Size(611, 81);
            this.grbRecherche_frmCont.TabIndex = 30;
            this.grbRecherche_frmCont.TabStop = false;
            this.grbRecherche_frmCont.Text = "Rechercher par ...";
            // 
            // txtRech_frmListCont
            // 
            this.txtRech_frmListCont.Location = new System.Drawing.Point(240, 35);
            this.txtRech_frmListCont.Name = "txtRech_frmListCont";
            this.txtRech_frmListCont.Size = new System.Drawing.Size(218, 20);
            this.txtRech_frmListCont.TabIndex = 4;
            // 
            // btn_lancRech_frmListCont
            // 
            this.btn_lancRech_frmListCont.Location = new System.Drawing.Point(471, 33);
            this.btn_lancRech_frmListCont.Name = "btn_lancRech_frmListCont";
            this.btn_lancRech_frmListCont.Size = new System.Drawing.Size(125, 23);
            this.btn_lancRech_frmListCont.TabIndex = 3;
            this.btn_lancRech_frmListCont.Text = "Lancer la recherche";
            this.btn_lancRech_frmListCont.UseVisualStyleBackColor = true;
            // 
            // rdb_nomClient_frmCont
            // 
            this.rdb_nomClient_frmCont.AutoSize = true;
            this.rdb_nomClient_frmCont.Location = new System.Drawing.Point(157, 36);
            this.rdb_nomClient_frmCont.Name = "rdb_nomClient_frmCont";
            this.rdb_nomClient_frmCont.Size = new System.Drawing.Size(51, 17);
            this.rdb_nomClient_frmCont.TabIndex = 2;
            this.rdb_nomClient_frmCont.TabStop = true;
            this.rdb_nomClient_frmCont.Text = "Client";
            this.rdb_nomClient_frmCont.UseVisualStyleBackColor = true;
            // 
            // rdb_prenomContact_frmCont
            // 
            this.rdb_prenomContact_frmCont.AutoSize = true;
            this.rdb_prenomContact_frmCont.Location = new System.Drawing.Point(84, 36);
            this.rdb_prenomContact_frmCont.Name = "rdb_prenomContact_frmCont";
            this.rdb_prenomContact_frmCont.Size = new System.Drawing.Size(61, 17);
            this.rdb_prenomContact_frmCont.TabIndex = 1;
            this.rdb_prenomContact_frmCont.TabStop = true;
            this.rdb_prenomContact_frmCont.Text = "Prénom";
            this.rdb_prenomContact_frmCont.UseVisualStyleBackColor = true;
            // 
            // rdb_nomContact_frmCont
            // 
            this.rdb_nomContact_frmCont.AutoSize = true;
            this.rdb_nomContact_frmCont.Location = new System.Drawing.Point(20, 36);
            this.rdb_nomContact_frmCont.Name = "rdb_nomContact_frmCont";
            this.rdb_nomContact_frmCont.Size = new System.Drawing.Size(47, 17);
            this.rdb_nomContact_frmCont.TabIndex = 0;
            this.rdb_nomContact_frmCont.TabStop = true;
            this.rdb_nomContact_frmCont.Text = "Nom";
            this.rdb_nomContact_frmCont.UseVisualStyleBackColor = true;
            // 
            // frmCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 342);
            this.Controls.Add(this.grbRecherche_frmCont);
            this.Controls.Add(this.grbFiche_frmCont);
            this.Controls.Add(this.grbIntervention);
            this.Name = "frmCont";
            this.Text = "Form ancêtre contact";
            this.grbIntervention.ResumeLayout(false);
            this.grbIntervention.PerformLayout();
            this.grbFiche_frmCont.ResumeLayout(false);
            this.grbFiche_frmCont.PerformLayout();
            this.grbRecherche_frmCont.ResumeLayout(false);
            this.grbRecherche_frmCont.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_nomContact;
        private System.Windows.Forms.Label lbl_prenomContact;
        private System.Windows.Forms.Label lbl_telContact;
        private System.Windows.Forms.Label lbl_fonctionContact;
        private System.Windows.Forms.Label lbl_mailContact;
        private System.Windows.Forms.Label lbl_nomDocs;
        private System.Windows.Forms.Label lbl_dureeCumul;
        private System.Windows.Forms.Label lbl_idContact;
        protected System.Windows.Forms.GroupBox grbIntervention;
        protected System.Windows.Forms.GroupBox grbFiche_frmCont;
        private System.Windows.Forms.Button btn_lancRech_frmListCont;
        private System.Windows.Forms.RadioButton rdb_nomClient_frmCont;
        private System.Windows.Forms.RadioButton rdb_prenomContact_frmCont;
        private System.Windows.Forms.RadioButton rdb_nomContact_frmCont;
        protected System.Windows.Forms.GroupBox grbRecherche_frmCont;
        protected System.Windows.Forms.TextBox txt_fonctionContact;
        protected System.Windows.Forms.TextBox txtRech_frmListCont;
        protected System.Windows.Forms.ComboBox cbb_nomProjet;
        protected System.Windows.Forms.TextBox txt_prenomContact;
        protected System.Windows.Forms.TextBox txt_nomContact;
        protected System.Windows.Forms.TextBox txt_idContact;
        protected System.Windows.Forms.TextBox txt_mailContact;
        protected System.Windows.Forms.TextBox txt_telContact;
        protected System.Windows.Forms.TextBox txt_dureeCumul;
    }
}