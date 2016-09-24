using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medico
    {
        private eEspecialidades _especialidad;
        private DateTime _horarioEntrada;
        private string _legajo;
        private string _nombre;

        public eEspecialidades Especialidad { get { return this._especialidad; } set { this._especialidad = value; } }
        public DateTime Ingreso { get { return this._horarioEntrada; } set { this._horarioEntrada = value; } }
        public string Legajo { get { return this._legajo; } set { this._legajo= value; }}
        public string Nombre { get { return this._nombre; } set { this._nombre = value; } }

        public Medico(string nombre, string legajo, eEspecialidades especialidad)
        {
            this._nombre = nombre;
            this._legajo = legajo;
            this._especialidad = especialidad;
            this._horarioEntrada = DateTime.Now;
        }
        public static int OrdenarPorHorarioEntrada(Medico m1, Medico m2)
        {
           return DateTime.Compare(m1._horarioEntrada, m2._horarioEntrada);
        }
        public static int OrdenarPorLegajo(Medico m1, Medico m2)
        {
           return string.Compare(m1._legajo, m2._legajo);
        }
         public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("nombre: ");
            sb.Append(this._nombre);
            sb.AppendLine("     Legajo: ");
            sb.Append(this._legajo);
            sb.AppendLine("     Especialidad: ");
            sb.Append(this._especialidad);
            sb.AppendLine("     horario Entrada: ");
            sb.Append(this._horarioEntrada);
            return sb.ToString();
        }
    }
}
