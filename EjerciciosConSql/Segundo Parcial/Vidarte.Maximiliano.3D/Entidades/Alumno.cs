using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        private string _apellido;
        private int _codCurso;
        private int _legajo;

        public Alumno(string apellido, int curso, int legajo)
        {
            this._legajo = legajo;
            this._codCurso = curso;
            this._apellido = apellido;
        }
        public string Apellido { get { return this._apellido; } set { this._apellido = value; } }
        public int Curso { get { return this._codCurso; } set { this._codCurso = value; } }
        public int Legajo { get { return this._legajo; } set { this._legajo = value; } }
    }
}
