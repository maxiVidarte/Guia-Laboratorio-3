using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        public string _apellido;
        public int _codCurso;
        public int _legajo;

        public String Apellido { get { return this._apellido; } set { this._apellido = value; } }
        public int Curso { get { return this._codCurso; } set { this._codCurso = value; } }

        public int Legajo { get { return this._legajo; } set { this._legajo = value; } }
        public Alumno(string apellido, int codigo, int legajo)
        {
            this._apellido = apellido;
            this._codCurso = codigo;
            this._legajo = legajo;

        }
    }
}
