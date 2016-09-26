using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mascota : Animal
    {
        string _nombre;
        eTipoDeMascota _tipoDeMascota;
        public string Nombre { get { return this._nombre; } set { this._nombre = value; } }
        public eTipoDeMascota TipoDeMascota { get { return this._tipoDeMascota; } set { this._tipoDeMascota = value; } }
        public int OrdenarPorEdad(Mascota m1, Mascota m2)
        {
            if (m1.Edad < m2.Edad)
            { return 1; }
            else if (m1.Edad > m2.Edad)
            { return -1; }
            else
            { return 0; }
        }
        public int OrdenarPorNombre(Mascota m1, Mascota m2)
        {
            return string.Compare(m1._nombre, m2._nombre);
        }
        public int OrdenarPorTipo(Mascota m1, Mascota m2)
        {
            if (m1._tipoDeMascota > m2._tipoDeMascota)
            { return -1; }
            else if (m1._tipoDeMascota < m2._tipoDeMascota)
            { return 1; }
            else
            { return 0; }
        }
        public Mascota(string nombre, eTipoDeMascota tipo, int edad)
            : base(edad)
        {
            this._nombre = nombre;
            this._tipoDeMascota = tipo;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("nombre: ");
            sb.AppendLine(this._nombre);
            sb.Append("Tipo de mascota: ");
            if (this._tipoDeMascota == eTipoDeMascota.exotica)
                sb.AppendLine("Exotica");
            else
                sb.AppendLine("Hogareña");
            sb.Append(base.ToString());
            return sb.ToString();
        }

    }
}
