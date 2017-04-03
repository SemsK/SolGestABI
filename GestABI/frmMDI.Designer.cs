namespace GestABI
{
    partial class frmMDI
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStpRPC = new System.Windows.Forms.MenuStrip();
            this.tsmFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFenetre = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCommercial_fenetre = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClients_commercial = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAfficher_clients = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAjouter_clients = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListe_clients = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmContacts_commercial = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAfficher_contacts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAjouter_contacts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListe_contacts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProjet_fenetre = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAfficher_projet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAjouter_projet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListe_projet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRessourcesH_fenetre = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAfficher_ressourcesH = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAjouter_ressourcesH = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListe_ressourcesH = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAProposDe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStpRPC.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStpRPC
            // 
            this.menuStpRPC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFichier,
            this.tsmFenetre,
            this.toolStripMenuItem1});
            this.menuStpRPC.Location = new System.Drawing.Point(0, 0);
            this.menuStpRPC.Name = "menuStpRPC";
            this.menuStpRPC.Size = new System.Drawing.Size(1177, 24);
            this.menuStpRPC.TabIndex = 1;
            this.menuStpRPC.Text = "menuStrip1";
            // 
            // tsmFichier
            // 
            this.tsmFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmQuitter});
            this.tsmFichier.Name = "tsmFichier";
            this.tsmFichier.Size = new System.Drawing.Size(54, 20);
            this.tsmFichier.Text = "Fichier";
            // 
            // tsmQuitter
            // 
            this.tsmQuitter.Name = "tsmQuitter";
            this.tsmQuitter.Size = new System.Drawing.Size(111, 22);
            this.tsmQuitter.Text = "Quitter";
            this.tsmQuitter.Click += new System.EventHandler(this.tsmQuitter_Click);
            // 
            // tsmFenetre
            // 
            this.tsmFenetre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCommercial_fenetre,
            this.tsmProjet_fenetre,
            this.tsmRessourcesH_fenetre});
            this.tsmFenetre.Name = "tsmFenetre";
            this.tsmFenetre.Size = new System.Drawing.Size(58, 20);
            this.tsmFenetre.Text = "Fenêtre";
            // 
            // tsmCommercial_fenetre
            // 
            this.tsmCommercial_fenetre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmClients_commercial,
            this.tsmContacts_commercial});
            this.tsmCommercial_fenetre.Name = "tsmCommercial_fenetre";
            this.tsmCommercial_fenetre.Size = new System.Drawing.Size(189, 22);
            this.tsmCommercial_fenetre.Text = "Commercial";
            // 
            // tsmClients_commercial
            // 
            this.tsmClients_commercial.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAfficher_clients,
            this.tsmAjouter_clients,
            this.tsmListe_clients});
            this.tsmClients_commercial.Name = "tsmClients_commercial";
            this.tsmClients_commercial.Size = new System.Drawing.Size(152, 22);
            this.tsmClients_commercial.Text = "Clients";
            // 
            // tsmAfficher_clients
            // 
            this.tsmAfficher_clients.Name = "tsmAfficher_clients";
            this.tsmAfficher_clients.Size = new System.Drawing.Size(152, 22);
            this.tsmAfficher_clients.Text = "Afficher";
            this.tsmAfficher_clients.Click += new System.EventHandler(this.tsmAfficher_clients_Click);
            // 
            // tsmAjouter_clients
            // 
            this.tsmAjouter_clients.Name = "tsmAjouter_clients";
            this.tsmAjouter_clients.Size = new System.Drawing.Size(152, 22);
            this.tsmAjouter_clients.Text = "Ajouter";
            this.tsmAjouter_clients.Click += new System.EventHandler(this.tsmAjouter_clients_Click);
            // 
            // tsmListe_clients
            // 
            this.tsmListe_clients.Name = "tsmListe_clients";
            this.tsmListe_clients.Size = new System.Drawing.Size(152, 22);
            this.tsmListe_clients.Text = "Liste";
            this.tsmListe_clients.Click += new System.EventHandler(this.tsmListe_clients_Click);
            // 
            // tsmContacts_commercial
            // 
            this.tsmContacts_commercial.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAfficher_contacts,
            this.tsmAjouter_contacts,
            this.tsmListe_contacts});
            this.tsmContacts_commercial.Name = "tsmContacts_commercial";
            this.tsmContacts_commercial.Size = new System.Drawing.Size(152, 22);
            this.tsmContacts_commercial.Text = "Contacts";
            // 
            // tsmAfficher_contacts
            // 
            this.tsmAfficher_contacts.Name = "tsmAfficher_contacts";
            this.tsmAfficher_contacts.Size = new System.Drawing.Size(116, 22);
            this.tsmAfficher_contacts.Text = "Afficher";
            this.tsmAfficher_contacts.Click += new System.EventHandler(this.tsmAfficher_contacts_Click);
            // 
            // tsmAjouter_contacts
            // 
            this.tsmAjouter_contacts.Name = "tsmAjouter_contacts";
            this.tsmAjouter_contacts.Size = new System.Drawing.Size(116, 22);
            this.tsmAjouter_contacts.Text = "Ajouter";
            this.tsmAjouter_contacts.Click += new System.EventHandler(this.tsmAjouter_contacts_Click);
            // 
            // tsmListe_contacts
            // 
            this.tsmListe_contacts.Name = "tsmListe_contacts";
            this.tsmListe_contacts.Size = new System.Drawing.Size(116, 22);
            this.tsmListe_contacts.Text = "Liste";
            this.tsmListe_contacts.Click += new System.EventHandler(this.tsmListe_contacts_Click);
            // 
            // tsmProjet_fenetre
            // 
            this.tsmProjet_fenetre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAfficher_projet,
            this.tsmAjouter_projet,
            this.tsmListe_projet});
            this.tsmProjet_fenetre.Name = "tsmProjet_fenetre";
            this.tsmProjet_fenetre.Size = new System.Drawing.Size(189, 22);
            this.tsmProjet_fenetre.Text = "Projet";
            // 
            // tsmAfficher_projet
            // 
            this.tsmAfficher_projet.Enabled = false;
            this.tsmAfficher_projet.Name = "tsmAfficher_projet";
            this.tsmAfficher_projet.Size = new System.Drawing.Size(116, 22);
            this.tsmAfficher_projet.Text = "Afficher";
            // 
            // tsmAjouter_projet
            // 
            this.tsmAjouter_projet.Enabled = false;
            this.tsmAjouter_projet.Name = "tsmAjouter_projet";
            this.tsmAjouter_projet.Size = new System.Drawing.Size(116, 22);
            this.tsmAjouter_projet.Text = "Ajouter";
            // 
            // tsmListe_projet
            // 
            this.tsmListe_projet.Enabled = false;
            this.tsmListe_projet.Name = "tsmListe_projet";
            this.tsmListe_projet.Size = new System.Drawing.Size(116, 22);
            this.tsmListe_projet.Text = "Liste";
            // 
            // tsmRessourcesH_fenetre
            // 
            this.tsmRessourcesH_fenetre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAfficher_ressourcesH,
            this.tsmAjouter_ressourcesH,
            this.tsmListe_ressourcesH});
            this.tsmRessourcesH_fenetre.Name = "tsmRessourcesH_fenetre";
            this.tsmRessourcesH_fenetre.Size = new System.Drawing.Size(189, 22);
            this.tsmRessourcesH_fenetre.Text = "Ressources Humaines";
            // 
            // tsmAfficher_ressourcesH
            // 
            this.tsmAfficher_ressourcesH.Enabled = false;
            this.tsmAfficher_ressourcesH.Name = "tsmAfficher_ressourcesH";
            this.tsmAfficher_ressourcesH.Size = new System.Drawing.Size(116, 22);
            this.tsmAfficher_ressourcesH.Text = "Afficher";
            // 
            // tsmAjouter_ressourcesH
            // 
            this.tsmAjouter_ressourcesH.Enabled = false;
            this.tsmAjouter_ressourcesH.Name = "tsmAjouter_ressourcesH";
            this.tsmAjouter_ressourcesH.Size = new System.Drawing.Size(116, 22);
            this.tsmAjouter_ressourcesH.Text = "Ajouter";
            // 
            // tsmListe_ressourcesH
            // 
            this.tsmListe_ressourcesH.Enabled = false;
            this.tsmListe_ressourcesH.Name = "tsmListe_ressourcesH";
            this.tsmListe_ressourcesH.Size = new System.Drawing.Size(116, 22);
            this.tsmListe_ressourcesH.Text = "Liste";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAProposDe});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // tsmAProposDe
            // 
            this.tsmAProposDe.Name = "tsmAProposDe";
            this.tsmAProposDe.Size = new System.Drawing.Size(150, 22);
            this.tsmAProposDe.Text = "À propos de ...";
            this.tsmAProposDe.Click += new System.EventHandler(this.tsmAProposDe_Click);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 730);
            this.Controls.Add(this.menuStpRPC);
            this.IsMdiContainer = true;
            this.Name = "frmMDI";
            this.Text = "GestABI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClos_frmMDI);
            this.menuStpRPC.ResumeLayout(false);
            this.menuStpRPC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStpRPC;
        private System.Windows.Forms.ToolStripMenuItem tsmFenetre;
        private System.Windows.Forms.ToolStripMenuItem tsmCommercial_fenetre;
        private System.Windows.Forms.ToolStripMenuItem tsmClients_commercial;
        private System.Windows.Forms.ToolStripMenuItem tsmAfficher_clients;
        private System.Windows.Forms.ToolStripMenuItem tsmAjouter_clients;
        private System.Windows.Forms.ToolStripMenuItem tsmListe_clients;
        private System.Windows.Forms.ToolStripMenuItem tsmContacts_commercial;
        private System.Windows.Forms.ToolStripMenuItem tsmAfficher_contacts;
        private System.Windows.Forms.ToolStripMenuItem tsmAjouter_contacts;
        private System.Windows.Forms.ToolStripMenuItem tsmListe_contacts;
        private System.Windows.Forms.ToolStripMenuItem tsmProjet_fenetre;
        private System.Windows.Forms.ToolStripMenuItem tsmAfficher_projet;
        private System.Windows.Forms.ToolStripMenuItem tsmAjouter_projet;
        private System.Windows.Forms.ToolStripMenuItem tsmRessourcesH_fenetre;
        private System.Windows.Forms.ToolStripMenuItem tsmAfficher_ressourcesH;
        private System.Windows.Forms.ToolStripMenuItem tsmAjouter_ressourcesH;
        private System.Windows.Forms.ToolStripMenuItem tsmFichier;
        private System.Windows.Forms.ToolStripMenuItem tsmListe_ressourcesH;
        private System.Windows.Forms.ToolStripMenuItem tsmListe_projet;
        private System.Windows.Forms.ToolStripMenuItem tsmQuitter;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmAProposDe;
    }
}

