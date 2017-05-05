using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumCs
{
     public class Dao
    {
        private MySqlConnection _connection;
        private string _connectionString;

        public Dao(string nomBase, string source, string nomUtilisateur, string motDePasse)
        {
            _connectionString = "Database=" + nomBase + ";Data Source=" + source + ";User Id=" + nomUtilisateur + ";Password=" + motDePasse;
            _connection = new MySqlConnection(_connectionString);
        }

        public void InsertUserInscription(string surnom, string motDePasse, bool admin)
        {
            _connection.Open();

            MySqlCommand command = new MySqlCommand("INSERT INTO `forumcs`.`user` (`username`, `password`, `isAdmin`) VALUES('" + surnom + "','" + Hash(motDePasse) + "','" + admin + "')", _connection);
            command.ExecuteNonQuery();

            _connection.Close();

        }

        public List<string> SelectUser(string username)
        {
            _connection.Open();
            List<string> resultat = new List<string>();
            MySqlCommand command = new MySqlCommand("SELECT username,password FROM `User` WHERE `username` = '" + username + "'", _connection);
            command.ExecuteNonQuery();
            MySqlDataReader myReader;
            myReader = command.ExecuteReader();
            while (myReader.Read())
            {
                resultat.Add(myReader.GetString(0));
                resultat.Add(myReader.GetString(1));
            }
            myReader.Close();
            _connection.Close();
            return resultat;
        }

        public string Hash(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            var hashBytes = System.Security.Cryptography.MD5.Create().ComputeHash(bytes);
            return Convert.ToBase64String(hashBytes);
        }
    }
}
