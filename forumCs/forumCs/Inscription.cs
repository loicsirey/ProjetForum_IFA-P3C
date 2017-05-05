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
    public partial class Inscription : Form
    {
        VerificationInscriptionConnection verificationInscription;
        Dao connexionBase;

        public Inscription()
        {
            InitializeComponent();
            connexionBase = new Dao(ConfigurationManager.AppSettings["dbName"], ConfigurationManager.AppSettings["serveur"], ConfigurationManager.AppSettings["dbUser"], ConfigurationManager.AppSettings["dbPassword"]);
            verificationInscription = new VerificationInscriptionConnection(connexionBase);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Inscription_Load(object sender, EventArgs e)
        {

        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            if (txtBxMotDePasse.Text == txtBxConfirmationMDP.Text)
            {
                verificationInscription.inscription(txtBxSurnom.Text,txtBxMotDePasse.Text);
            }
        }
    }
}
