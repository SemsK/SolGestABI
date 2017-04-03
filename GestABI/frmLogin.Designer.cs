namespace GestABI
{
    partial class frmLogin
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btnAnn_Login = new System.Windows.Forms.Button();
            this.btnVal_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(12, 20);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(249, 17);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Entrez le code propre à votre activité :";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(95, 59);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(135, 20);
            this.txtLogin.TabIndex = 1;
            // 
            // btnAnn_Login
            // 
            this.btnAnn_Login.Location = new System.Drawing.Point(229, 108);
            this.btnAnn_Login.Name = "btnAnn_Login";
            this.btnAnn_Login.Size = new System.Drawing.Size(75, 23);
            this.btnAnn_Login.TabIndex = 2;
            this.btnAnn_Login.Text = "Annuler";
            this.btnAnn_Login.UseVisualStyleBackColor = true;
            // 
            // btnVal_Login
            // 
            this.btnVal_Login.Location = new System.Drawing.Point(137, 108);
            this.btnVal_Login.Name = "btnVal_Login";
            this.btnVal_Login.Size = new System.Drawing.Size(75, 23);
            this.btnVal_Login.TabIndex = 3;
            this.btnVal_Login.Text = "Valider";
            this.btnVal_Login.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 143);
            this.Controls.Add(this.btnVal_Login);
            this.Controls.Add(this.btnAnn_Login);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblLogin);
            this.Name = "frmLogin";
            this.Text = "Vérification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnAnn_Login;
        private System.Windows.Forms.Button btnVal_Login;
    }
}