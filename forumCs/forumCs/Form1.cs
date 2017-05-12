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
    public partial class FrmPincipale : Form
    {
        Dao connexionBase;

        public FrmPincipale()
        {
            InitializeComponent();
            
            connexionBase = new Dao(ConfigurationManager.AppSettings["dbName"], ConfigurationManager.AppSettings["serveur"], ConfigurationManager.AppSettings["dbUser"], ConfigurationManager.AppSettings["dbPassword"]);
        }

        private void FrmPincipale_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FrmPincipale_Load(object sender, EventArgs e)
        {
            foreach (string commentaire in connexionBase.SelectCommentaire())
            {
                lstBCommentaire.Items.Add(commentaire);
            }
        }
    }
}
