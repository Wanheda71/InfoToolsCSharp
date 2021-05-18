using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTools
{
    public class Facturation
    {
        #region Champs
        private int _idFact;
        private int _idProd;
        private int _idUti;
        private int _quantite;

        #endregion

        #region Constructeur
        public Facturation(int idFact, int idProd, int idUti, int quantite)
        {
            this._idFact = idFact;
            this._idProd = idProd;
            this._idUti = idUti;
            this._quantite = quantite;
        }

        public Facturation(int idProd, int idUti, int quantite)
        {
            this._idProd = idProd;
            this._idUti = idUti;
            this._quantite = quantite;
        }
        #endregion

        #region Get / Set
        public int IdFact
        {
            get { return _idFact; }
            set { _idFact = value; }
        }
        public int IdProd
        {
            get { return _idProd; }
            set { _idProd = value; }
        }
        public int IdUti
        {
            get { return _idUti; }
            set { _idUti = value; }
        }
        public int Quantite
        {
            get { return _quantite; }
            set { _quantite = value; }
        }
        #endregion
    }
}
