using MySql.Data.MySqlClient;
using projetCsharp.Models.DAO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetCsharp.Models.DAL
{
    class ClientDAL
    {

        private static MySqlConnection connection;
        public ClientDAL()
        {
            DALConnexion.OpenConnection();
            connection = DALConnexion.connection;
        }

        public static ObservableCollection<ClientDAO> selectClient()
        {
            ObservableCollection<ClientDAO> l = new ObservableCollection<ClientDAO>();
            string query = "SELECT idclient,nom,prenom,mail,adresse,pointsf FROM client;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ClientDAO p = new ClientDAO(reader.GetInt32(0), reader.GetString(1).ToString(), reader.GetString(2).ToString(), reader.GetString(3).ToString(), reader.GetString(4).ToString(), reader.GetInt32(5));
                l.Add(p);
            }
            reader.Close();
            return l;
        }

        public static void updateClient(int idClientProperty, string nomClientProperty, string prenomClientProperty, string mailClientProperty, string adresseClientProperty, int pointsfClientProperty)
        {
            string query = "UPDATE client set nom=\"" + nomClientProperty + "\", prenom=\"" + prenomClientProperty + "\", mail=\"" + mailClientProperty + "\", adresse=\"" + adresseClientProperty + "\", pointsf=\"" + pointsfClientProperty + "\" where idclient=" + idClientProperty + ";";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static void insertClient(ClientDAO c)
        {
            int idClient = getMaxIdClient() + 1;
            string query = "INSERT INTO client VALUES (\"" + idClient + "\",\"" + c.nomClientDAO + "\",\"" + c.prenomClientDAO + "\",\"" + c.mailClientDAO + "\",\"" + c.adresseClientDAO + "\",\"" + c.pointsfClientDAO + "\");";
            MySqlCommand cmd2 = new MySqlCommand(query, connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd2);
            cmd2.ExecuteNonQuery();
        }
        public static void supprimerClient(int idClient)
        {
            string query = "DELETE FROM client WHERE idclient = \"" + idClient + "\";";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static int getMaxIdClient()
        {
            string query = "SELECT MAX(idclient) FROM client;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int maxIdClient = reader.GetInt32(0);
            reader.Close();
            return maxIdClient;
        }

        public static ClientDAO getClient(int idClient)
        {
            string query = "SELECT idclient,nom,prenom,mail,adresse,pointsf FROM client WHERE idclient=" + idClient + ";";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            ClientDAO cli = new ClientDAO(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(5));
            reader.Close();
            return cli;
        }

    }
}
