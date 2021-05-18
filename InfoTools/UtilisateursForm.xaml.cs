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
    /// Logique d'interaction pour UtilisateursForm.xaml
    /// </summary>
    public partial class UtilisateursForm : UserControl
    {
        public UtilisateursForm()
        {
            InitializeComponent();
            dbInit();
        }

        private async void dbInit()
        {

            List<Utilisateur> cUtilisateur = await BDD.SelectUtilisateur();
            DtgUtilisateur.ItemsSource = cUtilisateur;

            List<Role> cRole = await BDD.SelectRole();
            CboNumRole.ItemsSource = cRole;

        }

        private void DtgUtilisateur_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Utilisateur UtilisateurSelected = (Utilisateur)DtgUtilisateur.SelectedItem;

            if (DtgUtilisateur.SelectedIndex > -1)
            {
                //Le foreach permet d'afficher dans la combobox le numRole
                foreach (var item in CboNumRole.Items)
                {
                    if (((Role)item).NumRole == UtilisateurSelected.NumRole)
                    {
                        CboNumRole.SelectedItem = item;
                    }
                }
                TxtNom.Text = Convert.ToString(UtilisateurSelected.Nom);
                TxtPrenom.Text = Convert.ToString(UtilisateurSelected.Prenom);
                TxtMdp.Text = Convert.ToString(UtilisateurSelected.Mdp);
                TxtMail.Text = Convert.ToString(UtilisateurSelected.Mail);
                TxtTel.Text = Convert.ToString(UtilisateurSelected.Tel);
                TxtAdresse.Text = Convert.ToString(UtilisateurSelected.Adresse);
                TxtCP.Text = Convert.ToString(UtilisateurSelected.CP);
                TxtVille.Text = Convert.ToString(UtilisateurSelected.Ville);
                TxtPseudo.Text = Convert.ToString(UtilisateurSelected.Pseudo);
            }
        }

        private void BtnAjouter_Click(object sender, RoutedEventArgs e)
        {
            // Ajout d'un Utilisateur sur un clique boutton Ajouter
            Utilisateur ajoutUti = new Utilisateur(((Role)CboNumRole.SelectedItem).NumRole, TxtNom.Text, TxtPrenom.Text, TxtMdp.Text, TxtMail.Text, TxtTel.Text, TxtAdresse.Text, TxtCP.Text, TxtVille.Text, TxtPseudo.Text);

            BDD.InsertUtilisateur(ajoutUti);

            //Permet de réinitialiser les textbox lors d'un ajout
            TxtNom.Text = "";
            TxtPrenom.Text = "";
            TxtMdp.Text = "";
            TxtMail.Text = "";
            TxtTel.Text = "";
            TxtAdresse.Text = "";
            TxtCP.Text = "";
            TxtVille.Text = "";
            TxtPseudo.Text = "";

            dbInit();
        }

        private void BtnModifier_Click(object sender, RoutedEventArgs e)
        {
            Utilisateur ModificationUtilisateur = new Utilisateur(
            Convert.ToInt32(((Utilisateur)DtgUtilisateur.SelectedItem).IdUti),
            Convert.ToInt32(((Role)CboNumRole.SelectedItem).NumRole),
            Convert.ToString(TxtNom.Text),
            Convert.ToString(TxtPrenom.Text),
            Convert.ToString(TxtMdp.Text),
            Convert.ToString(TxtMail.Text),
            Convert.ToString(TxtTel.Text),
            Convert.ToString(TxtAdresse.Text),
            Convert.ToString(TxtCP.Text),
            Convert.ToString(TxtVille.Text),
            Convert.ToString(TxtPseudo.Text));

            BDD.UpdateUtilisateur(ModificationUtilisateur);

            TxtNom.Text = "";
            TxtPrenom.Text = "";
            TxtMdp.Text = "";
            TxtMail.Text = "";
            TxtTel.Text = "";
            TxtAdresse.Text = "";
            TxtCP.Text = "";
            TxtVille.Text = "";
            TxtPseudo.Text = "";


            dbInit();
        }

        private void BtnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BDD.DeleteUtilisateur(((Utilisateur)DtgUtilisateur.SelectedItem).IdUti);
                dbInit();
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Une erreur s'est produite :\n" + Ex.Message);
            }
        }
    }
}
