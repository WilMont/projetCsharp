﻿using System;
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
using projetCsharp.ViewModels;

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
        }

        private void Gestiondesvols_click(object sender, RoutedEventArgs e)
        {


            DataContext = new GestionVolsViewModel();


        }

        private void Gestiondesclients_click(object sender, RoutedEventArgs e)
        {
            DataContext = new ClientViewModel();

        }

        private void AjoutVol_click(object sender, RoutedEventArgs e)
        {
            DataContext = new NouveauVolViewModel();
        }

        private void ModifierVol_click(object sender, RoutedEventArgs e)
        {
            DataContext = new ModifierVolViewModel();
        }

        private void NouveauClient_click(object sender, RoutedEventArgs e)
        {
            DataContext = new NouveauClientViewModel();
        }

        private void ModifierClient_click(object sender, RoutedEventArgs e)
        {
            DataContext = new ModifierClientViewModel();
        }


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
