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
using InfoTools.Formulaire;

namespace InfoTools
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

        private void BtnPopUpClose_Click(object sender, RoutedEventArgs e)
        {
            //Ferme l'Application.
            Application.Current.Shutdown();
        }

        private void BtnOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            //Interchange la visibilité des deux boutons.
            BtnOpenMenu.Visibility = Visibility.Collapsed;
            BtnCloseMenu.Visibility = Visibility.Visible;
        }

        private void BtnCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            //Interchange la visibilité des deux boutons.
            BtnOpenMenu.Visibility = Visibility.Visible;
            BtnCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void BtnConnexion_Click(object sender, RoutedEventArgs e)
        {
            ConnexionForm FormulaireConnexion = new ConnexionForm();
            FormulaireConnexion.Show();
            this.Hide();
        }

        private void DragMe(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.DragMove();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void BtnHome_Selected(object sender, RoutedEventArgs e)
        {
            UCAccueil.Visibility = Visibility.Visible;
            UCProduit.Visibility = Visibility.Hidden;
            UCUtilisateur.Visibility = Visibility.Hidden;
            UCRendezVous.Visibility = Visibility.Hidden;
            UCGraphique.Visibility = Visibility.Hidden;
        }

        private void BtnUtilisateur_Selected(object sender, RoutedEventArgs e)
        {
            UCAccueil.Visibility = Visibility.Hidden;
            UCProduit.Visibility = Visibility.Hidden;
            UCUtilisateur.Visibility = Visibility.Visible;
            UCRendezVous.Visibility = Visibility.Hidden;
            UCGraphique.Visibility = Visibility.Hidden;
        }

        private void BtnProduit_Selected(object sender, RoutedEventArgs e)
        {
            UCAccueil.Visibility = Visibility.Hidden;
            UCProduit.Visibility = Visibility.Visible;
            UCUtilisateur.Visibility = Visibility.Hidden;
            UCRendezVous.Visibility = Visibility.Hidden;
            UCGraphique.Visibility = Visibility.Hidden;
        }

        private void BtnRendezVous_Selected(object sender, RoutedEventArgs e)
        {
            UCAccueil.Visibility = Visibility.Hidden;
            UCProduit.Visibility = Visibility.Hidden;
            UCUtilisateur.Visibility = Visibility.Hidden;
            UCRendezVous.Visibility = Visibility.Visible;
            UCGraphique.Visibility = Visibility.Hidden;
        }

        private void BtnGraphique_Selected(object sender, RoutedEventArgs e)
        {
            UCAccueil.Visibility = Visibility.Hidden;
            UCProduit.Visibility = Visibility.Hidden;
            UCUtilisateur.Visibility = Visibility.Hidden;
            UCRendezVous.Visibility = Visibility.Hidden;
            UCGraphique.Visibility = Visibility.Visible;

        }
    }
}
