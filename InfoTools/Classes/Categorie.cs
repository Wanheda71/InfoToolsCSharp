using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTools
{
    public class Categorie
    {
        #region Champs
        private string _numCat;
        private string _libCat;
        #endregion

        #region Constructeurs
        public Categorie(string numCat, string libCat)
        {
            this._numCat = numCat;
            this._libCat = libCat;
        }
        #endregion

        #region Get / Set
        public string NumCat
        {
            get { return _numCat; }
            set { _numCat = value; }
        }

        public string LibCat
        {
            get { return _libCat; }
            set { _libCat = value; }
        }
        #endregion

        #region Méthodes
        public override string ToString()
        {
            return _libCat;
        }
        #endregion

    }
}
