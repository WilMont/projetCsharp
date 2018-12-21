using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetCsharp
{
    class DALConnexion
    {
        private static string server;
        private static string database;
        private static string uid;
        private static string password;
        public static MySqlConnection connection;

        public static Boolean OpenConnection()
        {
            server = "localhost";
            database = "airatlantique";
            uid = "root";
            password = "Epsi2018!";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            if (connection == null)
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            return true;
        }
    }
}
