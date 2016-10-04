using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    public class Cuenta
    {
        protected int _nroCuenta;

        public int NroCuenta
        {
            get { return _nroCuenta; }
            set { _nroCuenta = value; }
        }

        protected string _titular;

        public string Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }

        public Cuenta(int nroCuenta, string titular)
        {
            this._nroCuenta = nroCuenta;
            this._titular = titular;
        }

        public Cuenta()
        {
        }
    }
}
