using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public FrmPincipale()
        {
            InitializeComponent();
        }

        private void FrmPincipale_Load(object sender, EventArgs e)
        {
            textBox1.Text = User.IdUser;
            textBox2.Text = User.Username;
            textBox3.Text = User.IsAdmin.ToString();
        }
    }
}
