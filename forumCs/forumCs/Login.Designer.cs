namespace forumCs
{
    partial class Login
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
            this.menuInscription = new System.Windows.Forms.MenuStrip();
            this.sinscrireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBxSurnom = new System.Windows.Forms.TextBox();
            this.txtBxMotDePasse = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.lblSurnom = new System.Windows.Forms.Label();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.menuInscription.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuInscription
            // 
            this.menuInscription.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinscrireToolStripMenuItem});
            this.menuInscription.Location = new System.Drawing.Point(0, 0);
            this.menuInscription.Name = "menuInscription";
            this.menuInscription.Size = new System.Drawing.Size(284, 24);
            this.menuInscription.TabIndex = 0;
            this.menuInscription.Text = "menuStrip1";
            // 
            // sinscrireToolStripMenuItem
            // 
            this.sinscrireToolStripMenuItem.Name = "sinscrireToolStripMenuItem";
            this.sinscrireToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.sinscrireToolStripMenuItem.Text = "s\'inscrire";
            this.sinscrireToolStripMenuItem.Click += new System.EventHandler(this.sinscrireToolStripMenuItem_Click);
            // 
            // txtBxSurnom
            // 
            this.txtBxSurnom.Location = new System.Drawing.Point(69, 59);
            this.txtBxSurnom.Name = "txtBxSurnom";
            this.txtBxSurnom.Size = new System.Drawing.Size(146, 20);
            this.txtBxSurnom.TabIndex = 1;
            // 
            // txtBxMotDePasse
            // 
            this.txtBxMotDePasse.Location = new System.Drawing.Point(69, 113);
            this.txtBxMotDePasse.Name = "txtBxMotDePasse";
            this.txtBxMotDePasse.PasswordChar = '*';
            this.txtBxMotDePasse.Size = new System.Drawing.Size(146, 20);
            this.txtBxMotDePasse.TabIndex = 2;
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(69, 152);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(143, 23);
            this.btnConnexion.TabIndex = 3;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // lblSurnom
            // 
            this.lblSurnom.AutoSize = true;
            this.lblSurnom.Location = new System.Drawing.Point(69, 40);
            this.lblSurnom.Name = "lblSurnom";
            this.lblSurnom.Size = new System.Drawing.Size(52, 13);
            this.lblSurnom.TabIndex = 4;
            this.lblSurnom.Text = "Surnom : ";
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Location = new System.Drawing.Point(69, 97);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(71, 13);
            this.lblMotDePasse.TabIndex = 5;
            this.lblMotDePasse.Text = "Mot de passe";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.lblSurnom);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.txtBxMotDePasse);
            this.Controls.Add(this.txtBxSurnom);
            this.Controls.Add(this.menuInscription);
            this.MainMenuStrip = this.menuInscription;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.menuInscription.ResumeLayout(false);
            this.menuInscription.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuInscription;
        private System.Windows.Forms.ToolStripMenuItem sinscrireToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBxSurnom;
        private System.Windows.Forms.TextBox txtBxMotDePasse;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label lblSurnom;
        private System.Windows.Forms.Label lblMotDePasse;
    }
}