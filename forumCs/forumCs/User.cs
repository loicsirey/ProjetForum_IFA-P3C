using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumCs
{
    static class User
    {
        private static string _username;
        private static bool _isAdmin;
        private static string _idUser;

        public static string Username
        {
            get
            {
                return _username;
            }

            set
            {
                _username = value;
            }
        }

        public static bool IsAdmin
        {
            get
            {
                return _isAdmin;
            }

            set
            {
                _isAdmin = value;
            }
        }

        public static string IdUser
        {
            get
            {
                return _idUser;
            }

            set
            {
                _idUser = value;
            }
        }
    }
}
