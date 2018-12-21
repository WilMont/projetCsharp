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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace projetCsharp.Views
{
    /// <summary>
    /// Logique d'interaction pour NouveauVolView.xaml
    /// </summary>
    public partial class NouveauVolView : UserControl
    {
        public NouveauVolView()
        {
            InitializeComponent();
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
