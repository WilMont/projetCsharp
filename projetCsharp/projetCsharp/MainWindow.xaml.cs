using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using projetCsharp.Classes;
using projetCsharp.Classes.BDD;
using projetCsharp.Fenetres;

namespace projetCsharp
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            AvionBDD.AfficherAeroports(dataGrid_aeroport);
            AvionBDD.AfficherAvions(dataGrid_avion);
            AvionBDD.AfficherClients(dataGrid_client);

        }

        private void Button_Click_AjouterAvion(object sender, RoutedEventArgs e)
        {
            WindowAjouterAvion nouvelAvion = new WindowAjouterAvion();
            nouvelAvion.ShowDialog();
        }
    }
}
