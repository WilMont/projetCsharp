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
    /// Logique d'interaction pour NouveauClientView.xaml
    /// </summary>
    public partial class NouveauClientView : UserControl
    {
        int selectedClientId;
        ClientViewModel myDataObject; // Objet de liaison
        ClientDAL c = new ClientDAL();
        //MetierDAL m = new MetierDAL();
        ObservableCollection<ClientViewModel> lc;
        int compteur = 0;

        public NouveauClientView()
        {
            InitializeComponent();
            // LIEN AVEC LA DAL
            DALConnexion.OpenConnection(); // Connectin BDD MySQL

            // Initialisation de la liste des personnes via la BDD.
            lc = ClientORM.listeClients();
            //LIEN AVEC la VIEW
            //listeClients.ItemsSource = lc; // bind de la liste avec la source, permettant le binding.
                                           // this.DataContext = lp; // bind de la liste avec la source, permettant le binding mais de façon globale sur toute la fenetre


            // Association entre une méthode (commande) et un évènement (TextChanged)
            prenomTextBox.TextChanged += new TextChangedEventHandler(prenomChanged);
            nomTextBox.TextChanged += new TextChangedEventHandler(nomChanged);


            // On crée une nouvelle personne pour être le contexte du binding entre les textbox et le bouton.
            int pointsfValue = 0;

            compteur = lc.Count();
            myDataObject = new ClientViewModel(compteur + 1, nomTextBox.Text, prenomTextBox.Text, mailTextBox.Text, adresseTextBox.Text, pointsfClient: pointsfValue);
            Binding myBindingNomText = new Binding("nomClientProperty");
            myBindingNomText.Source = myDataObject.nomClientProperty;
            nomTextBox.SetBinding(Button.ContentProperty, myBindingNomText);

            // BINDING
            Binding myBinding = new Binding("concatProperty");
            // Source du binding
            myBinding.Source = myDataObject;
            // Associer le bouton au binding
            enregistrerClientButton.SetBinding(Button.ContentProperty, myBinding);
        }
        public void prenomChanged(object sender, TextChangedEventArgs e)
        {
            myDataObject.prenomClientProperty = prenomTextBox.Text;
        }
        public void nomChanged(object sender, TextChangedEventArgs e)
        {
            myDataObject.nomClientProperty = nomTextBox.Text;
        }
        public void mailChanged(object sender, TextChangedEventArgs e)
        {
            myDataObject.mailClientProperty = mailTextBox.Text;
        }
        public void adresseChanged(object sender, TextChangedEventArgs e)
        {
            myDataObject.adresseClientProperty = adresseTextBox.Text;
        }
        public void pointsfChanged(object sender, TextChangedEventArgs e)
        {
            myDataObject.pointsfClientProperty = Convert.ToInt32(pointsfTextBox.Text.Trim());
        }


        // FONCTIONS
        private void enregistrerClientButton_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ClientViewModel nouveau = new ClientViewModel(ClientDAL.getMaxIdClient() + 1, myDataObject.nomClientProperty, myDataObject.prenomClientProperty, myDataObject.mailClientProperty, myDataObject.adresseClientProperty, myDataObject.pointsfClientProperty);
            lc.Add(nouveau);
            ClientDAO.insertClient(nouveau);
            //listeClients.Items.Refresh();
            compteur = lc.Count();
            myDataObject = new ClientViewModel(ClientDAL.getMaxIdClient() + 1, "", "", "", "", 0);
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
