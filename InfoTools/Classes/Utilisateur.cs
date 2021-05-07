using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTools
{
    public class Utilisateur
    {
        #region Champs
        private int _idUti;
        private string _ObjectGuid;
        private int _numRole;
        private string _username;
        private string _nom;
        private string _prenom;
        private string _mdp;
        private string _mail;
        private string _tel;
        private string _adresse;
        private string _cp;
        private string _ville;
        private string _pseudo;

        #endregion

        #region Constructeur
        public Utilisateur(int idUti, int numRole, string nom, string prenom, string mdp, string mail, string tel, string adresse, string cp, string ville, string pseudo)
        {
            this._idUti = idUti;
            this._numRole = numRole;
            this._nom = nom;
            this._prenom = prenom;
            this._mdp = mdp;
            this._mail = mail;
            this._tel = tel;
            this._adresse = adresse;
            this._cp = cp;
            this._ville = ville;
            this._pseudo = pseudo;
        }
        public Utilisateur(int numRole, string nom, string prenom, string mdp, string mail, string tel, string adresse, string cp, string ville, string pseudo)
        {
            this._numRole = numRole;
            this._nom = nom;
            this._prenom = prenom;
            this._mdp = mdp;
            this._mail = mail;
            this._tel = tel;
            this._adresse = adresse;
            this._cp = cp;
            this._ville = ville;
            this._pseudo = pseudo;
        }

        public Utilisateur(byte[] u_objectGuid, string u_name, string u_username, string u_email)
        {
            string[] FullName = u_name.Split(' ');

            _ObjectGuid = new Guid(u_objectGuid).ToString();
            _nom = FullName[1];
            _prenom = FullName[0];
            _username = u_username;
            _numRole = 1;
            _mail = u_email;
        }

        public Utilisateur(int u_iduti, string u_objectGuid, int u_numrole, string u_name, string u_prenom, string u_username, string u_email)
        {
            _idUti = u_iduti;
            _ObjectGuid = new Guid(u_objectGuid).ToString();
            _nom = u_name;
            _prenom = u_prenom;
            _username = u_username;
            _numRole = u_numrole;
            _mail = u_email;
        }

        #endregion

        #region Get / Set
        public int IdUti
        {
            get { return _idUti; }
            set { _idUti = value; }
        }
        public string ObjectGuid
        {
            get { return _ObjectGuid; }
            set { _ObjectGuid = value; }
        }

        public int NumRole
        {
            get { return _numRole; }
            set { _numRole = value; }
        }
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        public string Mdp
        {
            get { return _mdp; }
            set { _mdp = value; }
        }

        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

        public string Tel
        {
            get { return _tel; }
            set { _tel = value; }
        }

        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        public string CP
        {
            get { return _cp; }
            set { _cp = value; }
        }

        public string Ville
        {
            get { return _ville; }
            set { _ville = value; }
        }

        public string Pseudo
        {
            get { return _pseudo; }
            set { _pseudo = value; }
        }
        #endregion
    }
}
