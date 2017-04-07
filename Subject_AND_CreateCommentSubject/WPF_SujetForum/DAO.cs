using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_SujetForum
{
    class DAO
    {
        MySqlConnection conn;
        public DAO(string server, string database, string uid, string password)
        {
            conn = new MySqlConnection("SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";");
        }

        //Open connection
        public bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Impossible de se connecter à la base de données");
                        break;

                    case 1045:
                        MessageBox.Show("Nom d'utilisateur ou mot de passe invalides !");
                        break;

                    default:
                        MessageBox.Show("Erreur lors de la connection");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void InsertSubject(string nomSubject)
        {
            string query = "INSERT INTO `subject`(`nomSubject`) VALUES (@nomSubject);";

            //open connection
            if (OpenConnection())
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nomSubject", nomSubject);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                CloseConnection();
            }
        }

        //Select statement
        public Dictionary<string, string> SelectAllSubject()
        {
            string query = "SELECT * FROM subject";

            //Create a list to store the result
            Dictionary<string, string> dictionnaire = new Dictionary<string, string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    dictionnaire.Add(dataReader["idSubject"].ToString(), dataReader["nomSubject"].ToString());
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return dictionnaire;
            }
            else
            {
                return dictionnaire;
            }
        }

        public void DeleteById(string idSubject)
        {
            if (User.IsAdmin)
            {
                string query = "DELETE FROM comment WHERE idSubject = @idSubject; DELETE FROM subject WHERE idSubject = @idSubject;";

                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idSubject", idSubject);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
            }
        }

        public void InsertComment(string comment, string idSubject, string idUser)
        {
            string query = "INSERT INTO `comment`(`textComment`, `idSubject`, `idUser`) VALUES (@textComment, @idSubject, @idUser);";

            //open connection
            if (OpenConnection())
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@textComment", comment);
                cmd.Parameters.AddWithValue("@idSubject", idSubject);
                cmd.Parameters.AddWithValue("@idUser", idUser);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                CloseConnection();
            }
        }
    }
}
