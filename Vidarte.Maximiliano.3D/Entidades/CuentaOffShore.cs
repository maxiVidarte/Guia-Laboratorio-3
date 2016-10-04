using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CuentaOffShore : Cuenta
    {
        eParaisoFiscal _paraisoFiscal;
        public eParaisoFiscal ParaisoFiscal { get { return this._paraisoFiscal; } set { this._paraisoFiscal = value; } }

        public CuentaOffShore(eParaisoFiscal paraiso, int cuenta, string titular)
            : base(cuenta, titular)
        {
            this._paraisoFiscal = paraiso;
        }
        public int OrdenarNumeroCuenta(CuentaOffShore c1, CuentaOffShore c2)
        {
            if (c1.NroCuenta > c2.NroCuenta)
                return -1;
            else if (c1.NroCuenta < c2.NroCuenta)
                return 1;
            else
                return 0;
        }
        public int OrdenarPorParaiso(CuentaOffShore c1, CuentaOffShore c2)
        {
            if (c1.ParaisoFiscal > c2.ParaisoFiscal)
                return -1;
            else if (c1.ParaisoFiscal < c2.ParaisoFiscal)
                return 1;
            else
                return 0;
        }

        public int OrdenarPorTitular(CuentaOffShore c1, CuentaOffShore c2)
        {
            return string.Compare(c1.Titular, c2.Titular);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append(  "Paraiso Fiscal: ");
            if (this.ParaisoFiscal == eParaisoFiscal.Belice)
            { sb.AppendLine("belice"); }
            else if (this.ParaisoFiscal == eParaisoFiscal.Panama)
            { sb.AppendLine("Panama"); }
            else if (this.ParaisoFiscal == eParaisoFiscal.Seichelles)
            { sb.AppendLine("Seichelles"); }
            else
            { sb.AppendLine("VirginIslands"); }
            return sb.ToString();
        }
    }
}
