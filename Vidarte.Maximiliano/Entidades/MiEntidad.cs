using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MiEntidad
    {
        private int _numero;
        private string _nombre;
        private float _valor;

        public MiEntidad(int num, string nom, float val)
        {
            this._nombre = nom;
            this._numero = num;
            this._valor = val;
        }
            public int Numero 
        { 
            get{return this._numero;}
            set { this._numero = value; }
        }
        public string Nombre 
        { 
            get { return this._nombre; }
            set { this._nombre = value; }
        }
        public float Valor
        { 
            get { return this._valor; } 
            set { this._valor = value; } 
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("numero: ");
            sb.AppendLine(this._numero.ToString());
            sb.Append("Nombre: ");
            sb.AppendLine(this._nombre);
            sb.Append("Valor: ");
            sb.AppendLine(this._valor.ToString());
            return sb.ToString();
        }

        public delegate int Comparison<in MiEntidad>(MiEntidad uno, MiEntidad dos);

        public static int ComparaAtributo(MiEntidad a, MiEntidad b)
        {
            if (a._numero > b._numero)
                return 1;
            else if (a._numero == b._numero)
                return 0;
            else
                return -1;

        }

    }
}
