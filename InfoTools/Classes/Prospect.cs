using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTools
{
    public class Prospect
    {
        #region Champs
        private int _IdProsp;
        private int _IdRDV;
        private string _Nom;
        private string _Prenom;
        private string _Mail;
        private string _Tel;
        #endregion

        #region Constructeur

        public Prospect(int IdProsp, int IdRDV, string Nom, string Prenom, string Mail, string Tel)
        {
            this._IdProsp = IdProsp;
            this._IdRDV = IdRDV;
            this._Nom = Nom;
            this._Prenom = Prenom;
            this._Mail = Mail;
            this._Tel = Tel;
        }

        #endregion

        #region GET / SET

        public int IdProsp
        {
            get { return _IdProsp; }
            set { _IdProsp = value; }
        }
        public int IdRDV
        {
            get { return _IdRDV; }
            set { _IdRDV = value; }
        }

        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }

        public string Prenom
        {
            get { return _Prenom; }
            set { _Prenom = value; }
        }

        public string Mail
        {
            get { return _Mail; }
            set { _Mail = value; }
        }

        public string Tel
        {
            get { return _Tel; }
            set { _Tel = value; }
        }

        #endregion
    }
}
