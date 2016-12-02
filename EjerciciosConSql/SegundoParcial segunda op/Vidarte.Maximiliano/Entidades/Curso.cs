using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        public int _codigoCurso;
        public int _duracion;
        public string _nombre;

        public int CodigoCurso { get { return this._codigoCurso; } set { this._codigoCurso = value; } }
        public int Duracion { get { return this._duracion; } set { this._duracion = value; } }
        public string Nombre { get { return this._nombre; } set { this._nombre = value; } }

        public Curso(int codigo, int duracion,string nombre)
        {
            this._codigoCurso = codigo;
            this._duracion = duracion;
            this._nombre = nombre;
        }
    }
}
