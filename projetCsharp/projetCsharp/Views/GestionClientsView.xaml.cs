using projetCsharp.Models.DAL;
using projetCsharp.Models.DAO;
using projetCsharp.Models.ORM;
using projetCsharp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace projetCsharp.Views
{
    /// <summary>
    /// Logique d'interaction pour GestionClientsView.xaml
    /// </summary>
    public partial class GestionClientsView : UserControl
    {
        int selectedClientId;
        ClientViewModel myDataObject; // Objet de liaison
        ClientDAL c = new ClientDAL();
        //MetierDAL m = new MetierDAL();
        ObservableCollection<ClientViewModel> lc;
        int compteur = 0;

        public GestionClientsView()
        {
            InitializeComponent();
            // LIEN AVEC LA DAL
            DALConnexion.OpenConnection(); // Connection BDD MySQL

            // Initialisation de la liste des personnes via la BDD.
            lc = ClientORM.listeClients();
            //LIEN AVEC la VIEW
            listeClients.ItemsSource = lc; // bind de la liste avec la source, permettant le binding.
                                           // this.DataContext = lp; // bind de la liste avec la source, permettant le binding mais de façon globale sur toute la fenetre

        }

        // FONCTIONS
        private void supprimerClientButton_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ClientViewModel toRemove = (ClientViewModel)listeClients.SelectedItem;
            lc.Remove(toRemove);
            listeClients.Items.Refresh();
            ClientDAO.supprimerClient(selectedClientId);
        }

        private void listeClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*if (listeClients.SelectedItem != null)
            {

                selectedClientId = ((ClientViewModel)listeClients.SelectedCells[0].Item).idClientProperty;
            }
            selectedClientId = (lc.ElementAt<ClientViewModel>(listeClients.SelectedIndex)).idClientProperty; */
        }

        // INTERFACE
        private void BoutonCouleur_over(object sender, MouseEventArgs e)
        {
            SolidColorBrush RedBrush = new SolidColorBrush();

            RedBrush.Color = Colors.Red;

            SolidColorBrush WhiteBrush = new SolidColorBrush();

            WhiteBrush.Color = Colors.White;


            Button overButton = (Button)sender;
            overButton.Background = WhiteBrush;
            overButton.Foreground = RedBrush;

        }

        private void BoutonCouleurBack_over(object sender, MouseEventArgs e)
        {
            SolidColorBrush RedBrush = new SolidColorBrush();

            RedBrush.Color = Colors.Red;

            SolidColorBrush WhiteBrush = new SolidColorBrush();

            WhiteBrush.Color = Colors.White;


            Button overButton = (Button)sender;
            overButton.Background = RedBrush;
            overButton.Foreground = WhiteBrush;


        }
    }
}
