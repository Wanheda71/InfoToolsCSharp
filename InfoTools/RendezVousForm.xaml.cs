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
    /// Logique d'interaction pour RendezVousForm.xaml
    /// </summary>
    public partial class RendezVousForm : UserControl
    {
        public RendezVousForm()
        {
            InitializeComponent();
            dbInit();
        }

        private async void dbInit()
        {
            List<RendezVous> cRdv = await BDD.SelectRdv();
            DtgRDV.ItemsSource = cRdv;

            List<Utilisateur> cUtilisateur = await BDD.SelectUtilisateur();
            CboUtilisateur.ItemsSource = cUtilisateur;

        }

        private void DtgRDV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RendezVous RdvSelected = (RendezVous)DtgRDV.SelectedItem;

            if (DtgRDV.SelectedIndex > -1)
            {
                //Le foreach permet d'afficher dans la combobox le numRole
                foreach (var item in CboUtilisateur.Items)
                {
                    if (((Utilisateur)item).IdUti == RdvSelected.IdUti)
                    {
                        CboUtilisateur.SelectedItem = item;
                    }
                }

                TxtNom.Text = Convert.ToString(RdvSelected.Nom);
                TxtPrenom.Text = Convert.ToString(RdvSelected.Prenom);
                TxtMail.Text = Convert.ToString(RdvSelected.Mail);
                TxtTel.Text = Convert.ToString(RdvSelected.Tel);
                TxtContenu.Text = Convert.ToString(RdvSelected.Contenu);
                DpRDV.Text = Convert.ToString(RdvSelected.DteRDV);
            }
        }

        private void BtnAjouter_Click(object sender, RoutedEventArgs e)
        {

            // Ajout d'un Client sur un clique boutton Ajouter
            RendezVous ajoutrdv = new RendezVous(((Utilisateur)CboUtilisateur.SelectedItem).IdUti, TxtNom.Text, TxtPrenom.Text, TxtMail.Text, TxtTel.Text, TxtContenu.Text, Convert.ToDateTime(DpRDV.Text));

            BDD.InsertRdv(ajoutrdv);

            //Permet de réinitialiser les textbox lors d'un ajout
            TxtNom.Text = "";
            TxtPrenom.Text = "";
            TxtMail.Text = "";
            TxtTel.Text = "";
            TxtContenu.Text = "";
            DpRDV.Text = "";

            dbInit();
        }

        private void BtnModifier_Click(object sender, RoutedEventArgs e)
        {
            //Non Fonctionnel
            RendezVous ModificationRdv = new RendezVous(
            Convert.ToInt32(((RendezVous)DtgRDV.SelectedItem).IdRDV),
            Convert.ToInt32(((Utilisateur)CboUtilisateur.SelectedItem).IdUti),
            Convert.ToString(TxtNom.Text),
            Convert.ToString(TxtPrenom.Text),
            Convert.ToString(TxtMail.Text),
            Convert.ToString(TxtTel.Text),
            Convert.ToString(TxtContenu.Text),
            Convert.ToDateTime(DpRDV.Text));

            BDD.UpdateRdv(ModificationRdv);

            //Permet de réinitialiser les textbox lors d'un ajout
            TxtNom.Text = "";
            TxtPrenom.Text = "";
            TxtMail.Text = "";
            TxtTel.Text = "";
            TxtContenu.Text = "";
            DpRDV.Text = "";

            dbInit();
        }

        private void BtnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BDD.DeleteRdv(((RendezVous)DtgRDV.SelectedItem).IdRDV);
                dbInit();
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Une erreur s'est produite :\n" + Ex.Message);
            }
        }
    }
}
