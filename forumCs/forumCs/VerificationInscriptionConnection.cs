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
           string verificationSurnom = _connexionBase.SelectUser(surnom);
            if (surnom == verificationSurnom)
                Debug.Print("Error");
            else
                _connexionBase.InsertUserInscription(surnom, motdepasse,false);
        }

        public bool Connexion(string surnom, string motdepasse)
        {
            string verificationSurnom = _connexionBase.SelectUser(surnom);
            if (surnom == verificationSurnom && _connexionBase.Hash(motdepasse)==_connexionBase.SelectPassword(surnom))
            {
                User.IdUser = _connexionBase.SelectIdUser(surnom);
                User.Username = surnom;
                User.IsAdmin = _connexionBase.SelectIsAdmin(surnom);
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
