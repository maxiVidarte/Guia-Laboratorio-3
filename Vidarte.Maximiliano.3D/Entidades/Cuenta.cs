using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuenta
    {
        int _nroCuenta;
        string _titular;

        public int NroCuenta { get { return this._nroCuenta; } set { this._nroCuenta = value; } }
        public string Titular { get { return this._titular; } set { this._titular = value; } }

        public Cuenta(int numero, string titular)
        {
            this._titular = titular;
            this._nroCuenta = numero;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" Titular: ");
            sb.AppendLine(this._titular);
            sb.Append(" Numero de cuenta: ");
            sb.AppendLine(this._nroCuenta.ToString());
            return sb.ToString();
        }
    }
}
