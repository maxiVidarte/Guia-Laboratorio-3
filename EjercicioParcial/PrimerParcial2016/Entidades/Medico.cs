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
        }
        public int OrdenarPorHorarioEntrada(Medico m1, Medico m2)
        {
           return DateTime.Compare(m1._horarioEntrada, m2._horarioEntrada);
        }
        public int OrdenarPorLegajo(Medico m1, Medico m2)
        {
           return string.Compare(m1._legajo, m2._legajo);
        }
    }
}
