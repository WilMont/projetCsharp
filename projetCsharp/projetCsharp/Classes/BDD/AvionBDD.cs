using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace projetCsharp.Classes.BDD
{
    public class AvionBDD
    {
        public static void AfficherAeroports(DataGrid grille)
        {
            String connectionString = "SERVER=localhost;DATABASE=airatlantique;UID=root;PASSWORD=Epsi2018!";

            MySqlConnection connection = new MySqlConnection(connectionString);

            MySqlCommand cmd = new MySqlCommand("Select * from aeroport", connection);
            connection.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            connection.Close();

            grille.DataContext = dt;
        }

        public static void AfficherAvions(DataGrid grille)
        {
            String connectionString = "SERVER=localhost;DATABASE=airatlantique;UID=root;PASSWORD=Epsi2018!";

            MySqlConnection connection = new MySqlConnection(connectionString);

            MySqlCommand cmd = new MySqlCommand("Select * from avion", connection);
            connection.Open();
            DataTable dataTable = new DataTable();
            dataTable.Load(cmd.ExecuteReader());
            connection.Close();

            grille.DataContext = dataTable;
        }

        public static void AfficherClients(DataGrid grille)
        {
            String connectionString = "SERVER=localhost;DATABASE=airatlantique;UID=root;PASSWORD=Epsi2018!";

            MySqlConnection connection = new MySqlConnection(connectionString);

            MySqlCommand cmd = new MySqlCommand("Select * from client", connection);
            connection.Open();
            DataTable dataTable = new DataTable();
            dataTable.Load(cmd.ExecuteReader());
            connection.Close();

            grille.DataContext = dataTable;
        }

        public static int AjouterClient(TextBox nom_client, TextBox prenom_client, TextBox mail_client, TextBox adresse_client, TextBox sexe_client, TextBox date_naissance_client, TextBox pfidelite_client)
        {
            String connectionString = "SERVER=localhost;DATABASE=airatlantique;UID=root;PASSWORD=Epsi2018!";

            MySqlConnection connection = new MySqlConnection(connectionString);

            MySqlCommand MyCommand = new MySqlCommand("INSERT INTO client (nom, prenom, mail, adresse, sexe, date_naissance, pfidelite, pointsf) " +
                "Values (@nom_client, @prenom_client, @mail_client, @adresse_client, @sexe_client, @date_naissance_client, @pointsf_client)", connection);
            MyCommand.Parameters.AddWithValue("@nom_client", nom_client.Text);
            MyCommand.Parameters.AddWithValue("@prenom_client", prenom_client.Text);
            MyCommand.Parameters.AddWithValue("@mail_client", mail_client.Text);
            MyCommand.Parameters.AddWithValue("@adresse_client", adresse_client.Text);
            MyCommand.Parameters.AddWithValue("@sexe_client", sexe_client.Text);
            MyCommand.Parameters.AddWithValue("@date_naissance_client", date_naissance_client.Text);
            MyCommand.Parameters.AddWithValue("@pointsf_client", pfidelite_client.Text);
            connection.Open();
            return MyCommand.ExecuteNonQuery();

        }
    }
}
