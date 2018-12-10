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
        public static void AfficherTout(DataGrid grille)
        {
            String connectionString = "SERVER=localhost;DATABASE=bddairatlantique;UID=root;PASSWORD=Epsi2018!";

            MySqlConnection connection = new MySqlConnection(connectionString);

            MySqlCommand cmd = new SqlCommand("Select * from aeroport", connection);
            connection.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            connection.Close();

            grille.DataContext = dt;
        }

        public static void AfficherNom(DataGrid grille)
        {
            String connectionString = "SERVER=localhost;DATABASE=bddairatlantique;UID=root;PASSWORD=Epsi2018!";

            MySqlConnection connection = new MySqlConnection(connectionString);

            MySqlCommand cmd = new MySqlCommand("Select nom from aeroport", connection);
            connection.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            connection.Close();

            grille.DataContext = dt;
        }

        public static void RajouterAvion(TextBox avion)
        {
            //using (var connexion=new SqlConnection(ConfigurationManager.ConnectionStrings"bddairatlantique"
            //{
            //var mail = ConfigurationManager.AppSettings["mailAdmin"];
            //}
            String connectionString = "SERVER=localhost;DATABASE=bddairatlantique;UID=root;PASSWORD=Epsi2018!";

            MySqlConnection connection = new MySqlConnection(connectionString);

            MySqlCommand cmd = new MySqlCommand("INSERT INTO utilisateur (Modèle) VALUES(@modele)", connection);
            connection.Open();
            TextBox tb = new TextBox();
            MySqlParameter pmodele = cmd.Parameters.Add("@modele", MySqlDbType.VarChar);
            //pmodele.Value = textmodele.Text;
            connection.Close();

        }
    }
}
