using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forumCs
{
    public partial class Login : Form
    {
        VerificationInscriptionConnection verficationConnexion;
        Dao connexionBase;

        public Login()
        {
            InitializeComponent();
            connexionBase = new Dao(ConfigurationManager.AppSettings["dbName"], ConfigurationManager.AppSettings["serveur"], ConfigurationManager.AppSettings["dbUser"], ConfigurationManager.AppSettings["dbPassword"]);
            verficationConnexion = new VerificationInscriptionConnection(connexionBase);
           
        }


        private void sinscrireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inscription frmInscription = new Inscription();
            frmInscription.Show();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            verficationConnexion.Connexion(txtBxSurnom.Text, txtBxMotDePasse.Text);
            this.Close();
        }
    }
}
