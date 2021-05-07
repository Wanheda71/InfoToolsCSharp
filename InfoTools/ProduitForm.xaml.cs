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
    /// Logique d'interaction pour ProduitForm.xaml
    /// </summary>
    public partial class ProduitForm : UserControl
    {
        public ProduitForm()
        {
            InitializeComponent();
            dbInit();
        }

        private async void dbInit()
        {
            List<Produit> cProduit = await BDD.SelectProduit();
            DtgProduit.ItemsSource = cProduit;

            List<Categorie> cCategorie = await BDD.SelectCategorie();
            CboNumCat.ItemsSource = cCategorie;

        }

        private void DtgProduit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Produit ProduitSelected = (Produit)DtgProduit.SelectedItem;

            if (DtgProduit.SelectedIndex > -1)
            {
                foreach(var item in CboNumCat.Items)
                {
                    if (((Categorie)item).NumCat == ProduitSelected.NumCat) {
                        CboNumCat.SelectedItem = item;
                    }
                }

                TxtNomProd.Text = Convert.ToString(ProduitSelected.NomProd);
                TxtDescProd.Text = Convert.ToString(ProduitSelected.DescProd);
                TxtPrixProd.Text = Convert.ToString(ProduitSelected.PrixProd);
                TxtImgSrc.Text = Convert.ToString(ProduitSelected.Imgsrc);
            }
        }

        private void BtnAjouter_Click(object sender, RoutedEventArgs e)
        {
            //Ajout d'un Produi sur un clique boutton Ajouter
            Produit ajoutproduit = new Produit(((Categorie)CboNumCat.SelectedItem).NumCat, TxtNomProd.Text, TxtDescProd.Text, TxtPrixProd.Text, TxtImgSrc.Text);

            BDD.InsertProduit(ajoutproduit);
            dbInit();
        }

        private void BtnModifier_Click(object sender, RoutedEventArgs e)
        {
           

            if (CboNumCat.SelectedIndex == -1 || TxtNomProd.Text == null || TxtDescProd.Text == null || TxtPrixProd.Text == null || TxtImgSrc.Text == null)
            {
                MessageBox.Show("Merci de selectionner une ligne avant de modifier.");
            } else {
                Produit ModificationProduit = new Produit(
                   Convert.ToInt32(((Produit)DtgProduit.SelectedItem).IdProd),
                   Convert.ToString(((Categorie)CboNumCat.SelectedItem).NumCat),
                   Convert.ToString(TxtNomProd.Text),
                   Convert.ToString(TxtDescProd.Text),
                   Convert.ToString(TxtPrixProd.Text),
                   Convert.ToString(TxtImgSrc.Text));

                BDD.UpdateProduit(ModificationProduit);
            }

            TxtNomProd.Text = "";
            TxtDescProd.Text = "";
            TxtPrixProd.Text = "";
            TxtImgSrc.Text = "";
            dbInit();
        }

        private void BtnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BDD.DeleteProduit(((Produit)DtgProduit.SelectedItem).IdProd);
                dbInit();
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Une erreur s'est produite :\n" + Ex.Message);
            }
        }
    }
}
