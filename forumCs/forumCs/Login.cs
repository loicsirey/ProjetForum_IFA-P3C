using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forumCs
{
    public partial class Login : Form
    {
        VerificationInscriptionConnection verificationConnexion;
        Dao connexionBase;
        public Login()
        {
            connexionBase = new Dao(ConfigurationManager.AppSettings["dbName"], ConfigurationManager.AppSettings["serveur"], ConfigurationManager.AppSettings["dbUser"], ConfigurationManager.AppSettings["dbPassword"]);
            verificationConnexion = new VerificationInscriptionConnection(connexionBase);
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void sinscrireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inscription frmInscription = new Inscription();
            frmInscription.Show();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (verificationConnexion.Connexion(txtBxSurnom.Text, txtBxMotDePasse.Text) == true)
            {
                this.Hide();
                FrmPincipale Frmpricipale = new FrmPincipale();
                Frmpricipale.Show();
            }
            else
            {
                MessageBox.Show("Mauvais username ou mot de passe","Alert",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            
        }
    }
}
