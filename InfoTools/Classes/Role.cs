using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTools
{
    public class Role
    {
        #region Champs
        private int _numRole;
        private string _libRole;
        #endregion

        #region Constructeurs
        public Role(int numRole, string libRole)
        {
            this._numRole = numRole;
            this._libRole = libRole;
        }
        #endregion

        #region Get / Set
        public int NumRole
        {
            get { return _numRole; }
            set { _numRole = value; }
        }

        public string LibRole
        {
            get { return _libRole; }
            set { _libRole = value; }
        }
        #endregion
    }
}
