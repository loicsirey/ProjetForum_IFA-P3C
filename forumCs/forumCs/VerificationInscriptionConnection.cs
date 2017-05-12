using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forumCs
{
    public class VerificationInscriptionConnection
    {
        Dao _connexionBase;

        public VerificationInscriptionConnection(Dao connexionBase)
        {
            this._connexionBase = connexionBase;
        }

        public void inscription(string surnom,string motdepasse)
        {

            if (_connexionBase.SelectUser(surnom).Count == 0)
            {
                _connexionBase.InsertUserInscription(surnom, motdepasse, false);
                MessageBox.Show("Vous êtes inscrit !");
            }
            else
                MessageBox.Show("Surnom déjà utilisé");
        }

        public bool Connexion(string surnom, string motdepasse)
        {
            if (_connexionBase.SelectUser(surnom).Count != 0)
            {
                if (_connexionBase.SelectUser(surnom)[0] == surnom && _connexionBase.Hash(motdepasse) == _connexionBase.SelectUser(surnom)[1])
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
    }
}
