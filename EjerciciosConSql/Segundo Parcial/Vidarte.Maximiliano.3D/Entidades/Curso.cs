using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Curso
    {
        private int _codigoCurso;
        private int _duracion;
        private string _nombre;

        public Curso(int codigo, int duracion, string nombre)
        {
            this._nombre = nombre;
            this._duracion = duracion;
            this._codigoCurso = codigo;
        }
        public int CodigoCurso { get { return this._codigoCurso; } set { this._codigoCurso = value; } }
        public int Duracion { get { return this._duracion; } set { this._duracion = value; } }
        public string Nombre { get { return this._nombre; } set { this._nombre = value; } }
    }
}
