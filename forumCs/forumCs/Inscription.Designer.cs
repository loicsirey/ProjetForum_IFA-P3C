namespace forumCs
{
    partial class Inscription
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
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.lblSurnom = new System.Windows.Forms.Label();
            this.btnInscription = new System.Windows.Forms.Button();
            this.txtBxMotDePasse = new System.Windows.Forms.TextBox();
            this.txtBxSurnom = new System.Windows.Forms.TextBox();
            this.lblConfirmationMotDePasse = new System.Windows.Forms.Label();
            this.txtBxConfirmationMDP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Location = new System.Drawing.Point(69, 89);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(71, 13);
            this.lblMotDePasse.TabIndex = 10;
            this.lblMotDePasse.Text = "Mot de passe";
            // 
            // lblSurnom
            // 
            this.lblSurnom.AutoSize = true;
            this.lblSurnom.Location = new System.Drawing.Point(69, 32);
            this.lblSurnom.Name = "lblSurnom";
            this.lblSurnom.Size = new System.Drawing.Size(52, 13);
            this.lblSurnom.TabIndex = 9;
            this.lblSurnom.Text = "Surnom : ";
            // 
            // btnInscription
            // 
            this.btnInscription.Location = new System.Drawing.Point(69, 189);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.Size = new System.Drawing.Size(146, 23);
            this.btnInscription.TabIndex = 8;
            this.btnInscription.Text = "Inscription";
            this.btnInscription.UseVisualStyleBackColor = true;
            this.btnInscription.Click += new System.EventHandler(this.btnInscription_Click);
            // 
            // txtBxMotDePasse
            // 
            this.txtBxMotDePasse.Location = new System.Drawing.Point(69, 105);
            this.txtBxMotDePasse.Name = "txtBxMotDePasse";
            this.txtBxMotDePasse.PasswordChar = '*';
            this.txtBxMotDePasse.Size = new System.Drawing.Size(146, 20);
            this.txtBxMotDePasse.TabIndex = 7;
            // 
            // txtBxSurnom
            // 
            this.txtBxSurnom.Location = new System.Drawing.Point(69, 51);
            this.txtBxSurnom.Name = "txtBxSurnom";
            this.txtBxSurnom.Size = new System.Drawing.Size(146, 20);
            this.txtBxSurnom.TabIndex = 6;
            // 
            // lblConfirmationMotDePasse
            // 
            this.lblConfirmationMotDePasse.AutoSize = true;
            this.lblConfirmationMotDePasse.Location = new System.Drawing.Point(69, 137);
            this.lblConfirmationMotDePasse.Name = "lblConfirmationMotDePasse";
            this.lblConfirmationMotDePasse.Size = new System.Drawing.Size(146, 13);
            this.lblConfirmationMotDePasse.TabIndex = 12;
            this.lblConfirmationMotDePasse.Text = "Confirmez votre mot de passe";
            // 
            // txtBxConfirmationMDP
            // 
            this.txtBxConfirmationMDP.Location = new System.Drawing.Point(69, 153);
            this.txtBxConfirmationMDP.Name = "txtBxConfirmationMDP";
            this.txtBxConfirmationMDP.PasswordChar = '*';
            this.txtBxConfirmationMDP.Size = new System.Drawing.Size(146, 20);
            this.txtBxConfirmationMDP.TabIndex = 11;
            this.txtBxConfirmationMDP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblConfirmationMotDePasse);
            this.Controls.Add(this.txtBxConfirmationMDP);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.lblSurnom);
            this.Controls.Add(this.btnInscription);
            this.Controls.Add(this.txtBxMotDePasse);
            this.Controls.Add(this.txtBxSurnom);
            this.Name = "Inscription";
            this.Text = "Inscription";
            this.Load += new System.EventHandler(this.Inscription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.Label lblSurnom;
        private System.Windows.Forms.Button btnInscription;
        private System.Windows.Forms.TextBox txtBxMotDePasse;
        private System.Windows.Forms.TextBox txtBxSurnom;
        private System.Windows.Forms.Label lblConfirmationMotDePasse;
        private System.Windows.Forms.TextBox txtBxConfirmationMDP;
    }
}