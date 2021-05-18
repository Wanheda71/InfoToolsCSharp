using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ajout des Packages MySql.Data & System.Data
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace InfoTools
{
    public static class BDD
    {
        //Temps Variable de Connexion
        private static string _host = "127.0.0.1";
        private static string _user = "root";
        private static string _password = "root";
        private static string _database = "infotools";

        private static MySqlConnection dbInit()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = _host;
            builder.Database = _database;
            builder.UserID = _user;
            builder.Password = _password;

            return new MySqlConnection(builder.ToString());
        }

        #region Utilisateur
        public static async Task<List<Utilisateur>> SelectUtilisateur()
        {
            string query = "select * from utilisateur";
            string queryCommercial = string.Format("select * from utilisateur where idUti = {0}", Global.UtilisateurActuel.IdUti);

            List<Utilisateur> dbUtilisateur = new List<Utilisateur>();
            MySqlConnection sqlConnection = dbInit();

            try
            {
                // Ouverture de la connexion
                await sqlConnection.OpenAsync();

                MySqlCommand sqlCommand;

                if (Global.UtilisateurActuel.NumRole == 1) {
                sqlCommand = new MySqlCommand(queryCommercial, sqlConnection);
                } 
                else {
                sqlCommand = new MySqlCommand(query, sqlConnection);
                }

                DbDataReader dataReader = await sqlCommand.ExecuteReaderAsync();

                while (await dataReader.ReadAsync())
                {
                    Utilisateur utilisateur = new Utilisateur(Convert.ToInt32(dataReader["IdUti"]), Convert.ToInt32(dataReader["NumRole"]), Convert.ToString(dataReader["Nom"]), Convert.ToString(dataReader["Prenom"]), Convert.ToString(dataReader["Mdp"]), Convert.ToString(dataReader["Mail"]), Convert.ToString(dataReader["Tel"]), Convert.ToString(dataReader["Adresse"]), Convert.ToString(dataReader["CP"]), Convert.ToString(dataReader["Ville"]), Convert.ToString(dataReader["Pseudo"]));
                    dbUtilisateur.Add(utilisateur);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                await sqlConnection.CloseAsync();
                sqlConnection.Dispose();
            }

            return dbUtilisateur;
        }

        public static async void InsertUtilisateur(Utilisateur utilisateur)
        {
            string query = string.Format("insert into utilisateur (NumRole, Nom, Prenom, Mdp, Mail, Tel, Adresse, CP, Ville, Pseudo) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')", utilisateur.NumRole, utilisateur.Nom, utilisateur.Prenom, utilisateur.Mdp, utilisateur.Mail, utilisateur.Tel, utilisateur.Adresse, utilisateur.CP, utilisateur.Ville, utilisateur.Pseudo);
            MySqlConnection sqlConnection = dbInit();

            try
            {
                // Ouverture de la connexion
                await sqlConnection.OpenAsync();

                MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection);

                await sqlCommand.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                await sqlConnection.CloseAsync();
                sqlConnection.Dispose();
            }
        }

        public static async void UpdateUtilisateur(Utilisateur utilisateur)
        {
            string query = string.Format("update utilisateur set NumRole='{0}', Nom='{1}', Prenom='{2}', Mdp='{3}', Mail='{4}', Tel='{5}', Adresse='{6}', CP='{7}', Ville='{8}', Pseudo='{9}' where IdUti={10}", utilisateur.NumRole, utilisateur.Nom, utilisateur.Prenom, utilisateur.Mdp, utilisateur.Mail, utilisateur.Tel, utilisateur.Adresse, utilisateur.CP, utilisateur.Ville, utilisateur.Pseudo, utilisateur.IdUti);
            MySqlConnection sqlConnection = dbInit();

            try
            {
                // Ouverture de la connexion
                await sqlConnection.OpenAsync();

                MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection);

                await sqlCommand.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                await sqlConnection.CloseAsync();
                sqlConnection.Dispose();
            }
        }

        public static async void DeleteUtilisateur(int id)
        {
            string query = string.Format("delete from utilisateur where IdUti={0}", id);
            MySqlConnection sqlConnection = dbInit();

            try
            {
                // Ouverture de la connexion
                await sqlConnection.OpenAsync();

                MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection);

                await sqlCommand.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally

            {
                await sqlConnection.CloseAsync();
                sqlConnection.Dispose();
            }
        }
        #endregion

        #region LDAP
        public static async Task<Utilisateur> SelectLDAP(Utilisateur user)
        {
            string query = string.Format("select * from utilisateur where ObjectGuid='{0}'", user.ObjectGuid);
            Utilisateur dbUser = user;
            MySqlConnection sqlConnection = dbInit();

            try
            {
                // Ouverture de la connexion
                await sqlConnection.OpenAsync();

                MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection);
                DbDataReader dataReader = await sqlCommand.ExecuteReaderAsync();

                while (await dataReader.ReadAsync())
                {
                    dbUser = new Utilisateur(
                        Convert.ToInt32(dataReader["IdUti"]),
                        Convert.ToString(dataReader["ObjectGuid"]),
                        Convert.ToInt32(dataReader["NumRole"]),
                        Convert.ToString(dataReader["Nom"]),
                        Convert.ToString(dataReader["Prenom"]),
                        Convert.ToString(dataReader["Username"]),
                        Convert.ToString(dataReader["Mail"]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                await sqlConnection.CloseAsync();
                sqlConnection.Dispose();
            }
            Global.UtilisateurActuel = dbUser;
            return dbUser;
        }

        public static async void InsertLDAP(Utilisateur user)
        {
            string query = string.Format("insert into utilisateur (ObjectGuid, NumRole, Prenom, Nom, Username, Mail) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                user.ObjectGuid,
                user.NumRole,
                user.Prenom,
                user.Nom,
                user.Username,
                user.Mail);
            MySqlConnection sqlConnection = dbInit();

            try
            {
                // Ouverture de la connexion
                await sqlConnection.OpenAsync();

                MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection);

                await sqlCommand.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                await sqlConnection.CloseAsync();
                sqlConnection.Dispose();
            }
            Global.UtilisateurActuel = user;
        }
        #endregion

        #region Prospect
        public static async Task<List<Prospect>> SelectProspect()
        {
            string query = "select * from prospect";
            string queryCommercial = string.Format("select * from prospects inner join rdv on prospects.IdRdv = rdv.IdRdv inner join rdv_commercial on rdv.IdRDV = rdv_commercial.IdRdv where rdv_commercial.IdUti = {0}", Global.UtilisateurActuel.IdUti);

            List<Prospect> dbProspect = new List<Prospect>();
            MySqlConnection sqlConnection = dbInit();

            try
            {
                // Ouverture de la connexion
                await sqlConnection.OpenAsync();

                MySqlCommand sqlCommand;

                if (Global.UtilisateurActuel.NumRole == 1)
                {
                    sqlCommand = new MySqlCommand(queryCommercial, sqlConnection);
                }
                else
                {
                    sqlCommand = new MySqlCommand(query, sqlConnection);
                }

                DbDataReader dataReader = await sqlCommand.ExecuteReaderAsync();

                while (await dataReader.ReadAsync())
                {
                    Prospect prospect = new Prospect(Convert.ToInt32(dataReader["IdProsp"]), Convert.ToInt32(dataReader["IdRDV"]), Convert.ToString(dataReader["Nom"]), Convert.ToString(dataReader["Prenom"]), Convert.ToString(dataReader["Mail"]), Convert.ToString(dataReader["Tel"]));
                    dbProspect.Add(prospect);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                await sqlConnection.CloseAsync();
                sqlConnection.Dispose();
            }

            return dbProspect;
        }

        /*public static async void InsertUtilisateur(Utilisateur utilisateur)
        {
            string query = string.Format("insert into utilisateur (NumRole, Nom, Prenom, Mdp, Mail, Tel, Adresse, CP, Ville, Pseudo) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')", utilisateur.NumRole, utilisateur.Nom, utilisateur.Prenom, utilisateur.Mdp, utilisateur.Mail, utilisateur.Tel, utilisateur.Adresse, utilisateur.CP, utilisateur.Ville, utilisateur.Pseudo);
            MySqlConnection sqlConnection = dbInit();

            try
            {
                // Ouverture de la connexion
                await sqlConnection.OpenAsync();

                MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection);

                await sqlCommand.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                await sqlConnection.CloseAsync();
                sqlConnection.Dispose();
            }
        }

        public static async void UpdateUtilisateur(Utilisateur utilisateur)
        {
            string query = string.Format("update utilisateur set NumRole='{0}', Nom='{1}', Prenom='{2}', Mdp='{3}', Mail='{4}', Tel='{5}', Adresse='{6}', CP='{7}', Ville='{8}', Pseudo='{9}' where IdUti={10}", utilisateur.NumRole, utilisateur.Nom, utilisateur.Prenom, utilisateur.Mdp, utilisateur.Mail, utilisateur.Tel, utilisateur.Adresse, utilisateur.CP, utilisateur.Ville, utilisateur.Pseudo, utilisateur.IdUti);
            MySqlConnection sqlConnection = dbInit();

            try
            {
                // Ouverture de la connexion
                await sqlConnection.OpenAsync();

                MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection);

                await sqlCommand.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                await sqlConnection.CloseAsync();
                sqlConnection.Dispose();
            }
        }

        public static async void DeleteUtilisateur(int id)
        {
            string query = string.Format("delete from utilisateur where IdUti={0}", id);
            MySqlConnection sqlConnection = dbInit();

            try
            {
                // Ouverture de la connexion
                await sqlConnection.OpenAsync();

                MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection);

                await sqlCommand.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally

            {
                await sqlConnection.CloseAsync();
                sqlConnection.Dispose();
            }
        }*/
        #endregion

        #region Role
        public static async Task<List<Role>> SelectRole()
        {
            string query = "select * from Role";
            List<Role> dbRole = new List<Role>();
            MySqlConnection sqlConnection = dbInit();

            try
            {
                // Ouverture de la connexion
                await sqlConnection.OpenAsync();

                MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection);
                DbDataReader dataReader = await sqlCommand.ExecuteReaderAsync();

                while (await dataReader.ReadAsync())
                {
                    Role roles = new Role(Convert.ToInt32(dataReader["NumRole"]), Convert.ToString(dataReader["LibRole"]));
                    dbRole.Add(roles);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                await sqlConnection.CloseAsync();
                sqlConnection.Dispose();
            }

            return dbRole;
        }
        #endregion

        #region Produits
        public static async Task<List<Produit>> SelectProduit()
        {
            string query = "select * from produit";
            List<Produit> dbProduits = new List<Produit>();
            MySqlConnection sqlConnection = dbInit();

            try
            {
                // Ouverture de la connexion
                await sqlConnection.OpenAsync();

                MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection);
                DbDataReader dataReader = await sqlCommand.ExecuteReaderAsync();

                while (await dataReader.ReadAsync())
                {
                    Produit produits = new Produit(Convert.ToInt32(dataReader["IdProd"]), Convert.ToString(dataReader["NumCat"]), Convert.ToString(dataReader["NomProd"]), Convert.ToString(dataReader["DescProd"]), Convert.ToString(dataReader["PrixProd"]), Convert.ToString(dataReader["Imgsrc"]));
                    dbProduits.Add(produits);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                await sqlConnection.CloseAsync();
                sqlConnection.Dispose();
            }

            return dbProduits;
        }

        public static async void InsertProduit(Produit produit)
        {
            string query = string.Format("insert into produit (IdProd, NumCat, NomProd, DescProd, PrixProd, Imgsrc) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", produit.IdProd, produit.NumCat, produit.NomProd, produit.DescProd, produit.PrixProd, produit.Imgsrc);
            MySqlConnection sqlConnection = dbInit();

            try
            {
                // Ouverture de la connexion
                await sqlConnection.OpenAsync();

                MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection);

                await sqlCommand.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                await sqlConnection.CloseAsync();
                sqlConnection.Dispose();
            }
        }

        public static async void UpdateProduit(Produit produit)
        {
            string query = string.Format("update produit set NumCat='{0}', NomProd='{1}', DescProd='{2}', PrixProd='{3}', Imgsrc='{4}' where IdProd={5}", produit.NumCat, produit.NomProd, produit.DescProd, produit.PrixProd, produit.Imgsrc, produit.IdProd);
            MySqlConnection sqlConnection = dbInit();

            try
            {
                // Ouverture de la connexion
                await sqlConnection.OpenAsync();

                MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection);

                await sqlCommand.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                await sqlConnection.CloseAsync();
                sqlConnection.Dispose();
            }
        }

        public static async void DeleteProduit(int id)
        {
            string query = string.Format("delete from produit where IdProd={0}", id);
            MySqlConnection sqlConnection = dbInit();

            try
            {
                // Ouverture de la connexion
                await sqlConnection.OpenAsync();

                MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection);

                await sqlCommand.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally

            {
                await sqlConnection.CloseAsync();
                sqlConnection.Dispose();
            }
        }
        #endregion

        #region Categorie

        public static async Task<List<Categorie>> SelectCategorie()
        {
            string query = "select * from categorie";
            List<Categorie> dbCategorie = new List<Categorie>();
            MySqlConnection sqlConnection = dbInit();

            try
            {
                // Ouverture de la connexion
                await sqlConnection.OpenAsync();

                MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection);
                DbDataReader dataReader = await sqlCommand.ExecuteReaderAsync();

                while (await dataReader.ReadAsync())
                {
                    Categorie categorie = new Categorie(Convert.ToString(dataReader["NumCat"]), Convert.ToString(dataReader["LibCat"]));
                    dbCategorie.Add(categorie);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                await sqlConnection.CloseAsync();
                sqlConnection.Dispose();
            }

            return dbCategorie;
        }

        #endregion

        #region RDV
        public static async Task<List<RendezVous>> SelectRdv()
        {
            string query = "select * from rdv";
            string queryCommercial = string.Format("SELECT * FROM rdv INNER JOIN utilisateur ON rdv.IdUti = utilisateur.IdUti WHERE NumRole = 1 AND utilisateur.IdUti = {0}", Global.UtilisateurActuel.IdUti);

            List<RendezVous> dbRdv = new List<RendezVous>();
            MySqlConnection sqlConnection = dbInit();

            try
            {
                // Ouverture de la connexion
                await sqlConnection.OpenAsync();

                MySqlCommand sqlCommand;

                if (Global.UtilisateurActuel.NumRole == 1){
                    sqlCommand = new MySqlCommand(queryCommercial, sqlConnection);
                } else
                {
                    sqlCommand = new MySqlCommand(query, sqlConnection);
                }

                DbDataReader dataReader = await sqlCommand.ExecuteReaderAsync();

                while (await dataReader.ReadAsync())
                {
                    RendezVous rdv = new RendezVous(Convert.ToInt32(dataReader["IdRDV"]), Convert.ToInt32(dataReader["IdUti"]), Convert.ToString(dataReader["Nom"]), Convert.ToString(dataReader["Prenom"]), Convert.ToString(dataReader["Mail"]), Convert.ToString(dataReader["Tel"]), Convert.ToString(dataReader["Contenu"]), Convert.ToDateTime(dataReader["DteRDV"]));
                    dbRdv.Add(rdv);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                await sqlConnection.CloseAsync();
                sqlConnection.Dispose();
            }

            return dbRdv;
        }

        public static async void InsertRdv(RendezVous rdv)
        {
            string query = string.Format("insert into rdv (IdRDV, IdUti, Nom, Prenom, Mail, Tel, Contenu, DteRDV) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", rdv.IdRDV, rdv.IdUti, rdv.Nom, rdv.Prenom, rdv.Mail, rdv.Tel, rdv.Contenu, rdv.DteRDV.ToString("yyyy-MM-dd HH:mm:ss"));
            MySqlConnection sqlConnection = dbInit();

            try
            {
                // Ouverture de la connexion
                await sqlConnection.OpenAsync();

                MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection);

                await sqlCommand.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                await sqlConnection.CloseAsync();
                sqlConnection.Dispose();
            }
        }

        public static async void UpdateRdv(RendezVous rdv)
        {
            string query = string.Format("update rdv set IdUti='{0}', Nom='{1}', Prenom='{2}', Mail='{3}', Tel='{4}', Contenu='{5}', DteRDV='{6}' where IdRDV={7}", rdv.IdUti, rdv.Nom, rdv.Prenom, rdv.Mail, rdv.Tel, rdv.Contenu, rdv.DteRDV.ToString("yyyy-MM-dd HH:mm:ss"), rdv.IdRDV);
            MySqlConnection sqlConnection = dbInit();

            try
            {
                // Ouverture de la connexion
                await sqlConnection.OpenAsync();

                MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection);

                await sqlCommand.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                await sqlConnection.CloseAsync();
                sqlConnection.Dispose();
            }
        }

        public static async void DeleteRdv(int id)
        {
            string query = string.Format("delete from rdv where IdRDV={0}", id);
            MySqlConnection sqlConnection = dbInit();

            try
            {
                // Ouverture de la connexion
                await sqlConnection.OpenAsync();

                MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection);

                await sqlCommand.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                await sqlConnection.CloseAsync();
                sqlConnection.Dispose();
            }
        }
        #endregion

    }
}
