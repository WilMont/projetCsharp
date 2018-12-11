using projetCsharp.Classes.BDD;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace projetCsharp.Fenetres
{
    /// <summary>
    /// Logique d'interaction pour WindowAjouterAvion.xaml
    /// </summary>
    public partial class WindowAjouterAvion : Window
    {
        public WindowAjouterAvion()
        {
            InitializeComponent();
        }

        private void Button_Click_Annuler(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_Ajouter(object sender, RoutedEventArgs e)
        {
            AvionBDD.AjouterClient(txtbx_nomClient, txtbx_prenomClient, txtbx_mailClient, txtbx_adresseClient, txtbx_sexeClient, txtbx_dateNaissanceClient, txtbx_pointsfClient);
        }

        private void RadioButton_Checked_Oui_pointsfidelite(object sender, RoutedEventArgs e)
        {
            int accesPFidelite = 1;
        }

        private void RadioButton_Checked_Non_pointsfidelite(object sender, RoutedEventArgs e)
        {
            int accesPFidelite = 0;
        }
    }
}
