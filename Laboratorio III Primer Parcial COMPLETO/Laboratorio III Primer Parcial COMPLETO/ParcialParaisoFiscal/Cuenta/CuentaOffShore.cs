using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
     public class CuentaOffShore:Cuenta
    {
        private eParaisoFiscal _paraisoFiscal;

        public eParaisoFiscal ParaisoFiscal
        {
            get { return _paraisoFiscal; }
            set { _paraisoFiscal = value; }
        }


        public CuentaOffShore() 
        {
            this._paraisoFiscal = 0;
        }

        public CuentaOffShore(int nroCuenta, string titular, eParaisoFiscal paraisofiscal) : base()
        {
            this._paraisoFiscal = paraisofiscal;
            this._nroCuenta = nroCuenta;
            this._titular = titular;
        }

        public static int ordernarPorParaiso(CuentaOffShore c1, CuentaOffShore c2)
        {
            return c1.ParaisoFiscal.CompareTo(c2.ParaisoFiscal);
        }

        public static int ordernarPorNroCuenta(CuentaOffShore c1, CuentaOffShore c2)
        {
            return c1.NroCuenta.CompareTo(c2.NroCuenta);
        }

        public static int ordernarPorTitular(CuentaOffShore c1, CuentaOffShore c2)
        {
            return c1.Titular.CompareTo(c2.Titular);
        }

        public override string ToString()
        {
            return " Titular: " + this._titular + " Nro Cuenta: " + this._nroCuenta + " ParaisoFiscal: " + this._paraisoFiscal;
        }
    }
}
