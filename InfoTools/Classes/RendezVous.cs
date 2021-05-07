using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTools
{
    public class RendezVous
    {
        #region Champs
        private int _idrdv;
        private int _iduti;
        private string _nom;
        private string _prenom;
        private string _mail;
        private string _tel;
        private string _contenu;
        private DateTime _dterdv;
        #endregion

        #region Constructeurs
        public RendezVous(int idrdv, int iduti, string nom, string prenom, string mail, string tel, string contenu, DateTime dterdv)
        {
            this._idrdv = idrdv;
            this._iduti = iduti;
            this._nom = nom;
            this._prenom = prenom;
            this._mail = mail;
            this._tel = tel;
            this._contenu = contenu;
            this._dterdv = dterdv;
        }
        public RendezVous(int iduti, string nom, string prenom, string mail, string tel, string contenu, DateTime dterdv)
        {
            this._iduti = iduti;
            this._nom = nom;
            this._prenom = prenom;
            this._mail = mail;
            this._tel = tel;
            this._contenu = contenu;
            this._dterdv = dterdv;
        }

        #endregion

        #region Get / Set
        public int IdRDV
        {
            get { return _idrdv; }
            set { _idrdv = value; }
        }

        public int IdUti
        {
            get { return _iduti; }
            set { _iduti = value; }
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

        public string Contenu
        {
            get { return _contenu; }
            set { _contenu = value; }
        }

        public DateTime DteRDV
        {
            get { return _dterdv; }
            set { _dterdv = value; }
        }
        #endregion
    }
}
