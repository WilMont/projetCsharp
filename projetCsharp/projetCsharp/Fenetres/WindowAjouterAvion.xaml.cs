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
    }
}
