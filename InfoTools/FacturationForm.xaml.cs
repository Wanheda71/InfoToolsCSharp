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

namespace InfoTools
{
    /// <summary>
    /// Logique d'interaction pour FacturationForm.xaml
    /// </summary>
    public partial class FacturationForm : UserControl
    {
        public FacturationForm()
        {
            InitializeComponent();
            dbInit();
        }

        private async void dbInit()
        {
            List<Facturation> cFacturation = await BDD.SelectFacturation();
            DtgFacturation.ItemsSource = cFacturation;

            List<Utilisateur> cUtilisateur = await BDD.SelectUtilisateur();
            CboUtilisateur.ItemsSource = cUtilisateur;

            List<Produit> cProduit = await BDD.SelectProduit();
            CboProduit.ItemsSource = cProduit;
        }

        private void DtgRDV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Facturation FacturationSelected = (Facturation)DtgFacturation.SelectedItem;

            if (DtgFacturation.SelectedIndex > -1)
            {
                foreach (var item in CboUtilisateur.Items)
                {
                    if (((Utilisateur)item).IdUti == FacturationSelected.IdUti)
                    {
                        CboUtilisateur.SelectedItem = item;
                    }
                }
                foreach (var item2 in CboProduit.Items)
                {
                    if (((Produit)item2).IdProd == FacturationSelected.IdProd)
                    {
                        CboProduit.SelectedItem = item2;
                    }
                }
                TxtQuantite.Text = Convert.ToString(FacturationSelected.Quantite);
            }
        }

        private void BtnAjouter_Click(object sender, RoutedEventArgs e)
        {
            //Ajout d'une Facturation par un clic sur le bouton Ajouter
            Facturation ajoutfact = new Facturation(((Produit)CboProduit.SelectedItem).IdProd, ((Utilisateur)CboUtilisateur.SelectedItem).IdUti, Convert.ToInt32(TxtQuantite.Text));

            BDD.InsertFacturation(ajoutfact);

            //Permet de réinitialiser les textbox lors d'un ajout
            TxtQuantite.Text = "";
            dbInit();
        }

        private void BtnModifier_Click(object sender, RoutedEventArgs e)
        {
            Facturation ModificationFact = new Facturation(
            Convert.ToInt32(((Facturation)DtgFacturation.SelectedItem).IdFact),
            Convert.ToInt32(((Produit)CboProduit.SelectedItem).IdProd),
            Convert.ToInt32(((Utilisateur)CboUtilisateur.SelectedItem).IdUti),
            Convert.ToInt32(TxtQuantite.Text));

            BDD.UpdateFacturation(ModificationFact);

            TxtQuantite.Text = "";
            dbInit();
        }

        private void BtnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BDD.DeleteFacturation(((Facturation)DtgFacturation.SelectedItem).IdFact);
                dbInit();
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Une erreur s'est produite :\n" + Ex.Message);
            }
        }
    }
}
