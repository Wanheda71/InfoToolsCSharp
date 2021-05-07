using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTools
{
    public class Produit
    {

        #region Champs
        private int _idProd;
        private string _numCat;
        private string _nomProd;
        private string _descProd;
        private string _prixProd;
        private string _imgsrc;
        #endregion

        #region Constructeurs
        public Produit(int idProd, string numCat, string nomProd, string descProd, string prixProd, string imgsrc)
        {
            this._idProd = idProd;
            this._numCat = numCat;
            this._nomProd = nomProd;
            this._descProd = descProd;
            this._prixProd = prixProd;
            this._imgsrc = imgsrc;
        }

        public Produit(string numCat, string nomProd, string descProd, string prixProd, string imgsrc)
        {
            this._numCat = numCat;
            this._nomProd = nomProd;
            this._descProd = descProd;
            this._prixProd = prixProd;
            this._imgsrc = imgsrc;
        }
        #endregion

        #region Get / Set
        public int IdProd
        {
            get { return _idProd; }
            set { _idProd = value; }
        }

        public string NumCat
        {
            get { return _numCat; }
            set { _numCat = value; }
        }

        public string NomProd
        {
            get { return _nomProd; }
            set { _nomProd = value; }
        }

        public string DescProd
        {
            get { return _descProd; }
            set { _descProd = value; }
        }

        public string PrixProd
        {
            get { return _prixProd; }
            set { _prixProd = value; }
        }

        public string Imgsrc
        {
            get { return _imgsrc; }
            set { _imgsrc = value; }
        }
        #endregion

    }
}
