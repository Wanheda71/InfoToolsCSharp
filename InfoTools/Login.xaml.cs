using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices.ActiveDirectory;
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
using MaterialDesignColors;
using MaterialDesignThemes.Wpf;
using Database;

namespace InfoTools
{
    /// <summary>
    /// Logique d'interaction pour Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        #region DragMove
        /**
         * Gestion du mouvement de la fenêtre
         */
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
                
        }
        #endregion

        #region Actions
        /**
         * Bouton permettant la connexion via API à Laravel
         * via les identifiants AD renseignés
         */
        private void btnConnect_Click(object sender, RoutedEventArgs e)
        {
            // Définition des variables
            BrushConverter converter = new BrushConverter();

            // Réinitialisation des erreurs
            lblUsername.Content = "";
            lblPassword.Content = "";
            TextFieldAssist.SetUnderlineBrush(txtUsername, (Brush)converter.ConvertFromString("#FFFF5722"));
            TextFieldAssist.SetUnderlineBrush(txtPassword, (Brush)converter.ConvertFromString("#FFFF5722"));


            // Vérification de la validité des informations
            if (AuthValidation(txtUsername.Text, txtPassword.Password))
            {
                if (LdapConnection(txtUsername.Text, txtPassword.Password))
                {
                    Main mainForm = new Main();
                    mainForm.Show();
                    this.Close();
                } else
                {
                    TextFieldAssist.SetUnderlineBrush(txtUsername, (Brush)converter.ConvertFromString(PrimaryColor.Red.ToString()));
                    lblUsername.Content = "Les identifiants sont incorrects.";

                    TextFieldAssist.SetUnderlineBrush(txtPassword, (Brush)converter.ConvertFromString(PrimaryColor.Red.ToString()));
                    lblPassword.Content = "Les identifiants sont incorrects.";
                }
            }
        }
        #endregion

        #region LDAP
        private bool LdapConnection(string user, string password)
        {
            // Définition des variables
            bool isValid = false;

            // Instanciation de la connexion
            PrincipalContext context = new PrincipalContext(ContextType.Domain, Properties.Settings.Default.AD_Domain, Properties.Settings.Default.AD_Container, Properties.Settings.Default.AD_Admin, Properties.Settings.Default.AD_Password);

            try
            {
                // Vérification des identifiants fournit
                isValid = context.ValidateCredentials(user, password);

                // Récupération de l'utilisateur dans l'AD
                if (isValid)
                {
                    UserPrincipal userPrincipal = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, user);

                    if(userPrincipal.GetUnderlyingObjectType() == typeof(DirectoryEntry))
                    {
                        using (DirectoryEntry entry = (DirectoryEntry)userPrincipal.GetUnderlyingObject())
                        {
                            // Créer l'utilisateur s'il n'existe pas dans la DB et l'instancie pour l'application
                            if (entry.Properties["objectGUID"] != null || entry.Properties["sAMAccountName"] != null || entry.Properties["cn"] != null || entry.Properties["userPrincipalName"] != null)
                            {
                                User tempUser = new User((byte[])entry.Properties["objectGUID"].Value, entry.Properties["cn"].Value.ToString(), entry.Properties["sAMAccountName"].Value.ToString(), entry.Properties["userPrincipalName"].Value.ToString());
                                this.LdapUser(tempUser);
                            }
                        }
                    }
                }

            }
            catch (PrincipalException pe)
            {
                MessageBox.Show("une exception est levée : " + pe, "Nous n'arrivons pas à nous connecter à votre serveur AD-DS");
            }
            finally
            {
                context.Dispose();
            }


            return isValid;
        }

        /**
         * Système récupérant l'utilisateur dans la base de données
         * ou l'ajoute s'il n'éxiste pas.
         */
        private async void LdapUser(User tempUser)
        {
            tempUser = await Generic.SelectUser(tempUser);

            if(tempUser.ID == 0)
            {
                Generic.InsertUser(tempUser);
            }
        }

        #region Validation
        private bool AuthValidation(string user, string password)
        {
            bool isValid = false;
            BrushConverter converter = new BrushConverter();

            if (user != "" && password != "")
            {
                isValid = true;
            } else
            {
                if (string.IsNullOrEmpty(user))
                {
                    lblUsername.Content = "Ce champ est obligatoire.";
                    TextFieldAssist.SetUnderlineBrush(txtUsername, (Brush)converter.ConvertFromString(PrimaryColor.Red.ToString()));
                } else if(string.IsNullOrEmpty(password))
                {
                    lblPassword.Content = "Ce champ est obligatoire.";
                    TextFieldAssist.SetUnderlineBrush(txtPassword, (Brush)converter.ConvertFromString(PrimaryColor.Red.ToString()));
                } else
                {
                    lblUsername.Content = "Ce champ est obligatoire.";
                    TextFieldAssist.SetUnderlineBrush(txtUsername, (Brush)converter.ConvertFromString(PrimaryColor.Red.ToString()));

                    lblPassword.Content = "Ce champ est obligatoire.";
                    TextFieldAssist.SetUnderlineBrush(txtPassword, (Brush)converter.ConvertFromString(PrimaryColor.Red.ToString()));
                }
            }

            return isValid;
        } 
        #endregion
        #endregion
    }
}
