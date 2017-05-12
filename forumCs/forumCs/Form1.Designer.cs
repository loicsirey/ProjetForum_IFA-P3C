namespace forumCs
{
    partial class FrmPincipale
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
            this.lstBCommentaire = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstBCommentaire
            // 
            this.lstBCommentaire.FormattingEnabled = true;
            this.lstBCommentaire.Location = new System.Drawing.Point(12, 155);
            this.lstBCommentaire.Name = "lstBCommentaire";
            this.lstBCommentaire.Size = new System.Drawing.Size(260, 95);
            this.lstBCommentaire.TabIndex = 0;
            // 
            // FrmPincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lstBCommentaire);
            this.Name = "FrmPincipale";
            this.Text = "Forum";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPincipale_FormClosing);
            this.Load += new System.EventHandler(this.FrmPincipale_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBCommentaire;
    }
}

