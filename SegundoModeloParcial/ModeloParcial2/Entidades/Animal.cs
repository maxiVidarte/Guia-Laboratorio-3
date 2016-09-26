using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Animal
    {
        private int _edad;
        public int Edad { get { return this._edad; } set { this._edad = value; } }
        public Animal(int edad)
        {
            this._edad = edad;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Edad: ");
            sb.AppendLine(this._edad.ToString());
            return sb.ToString();
        }
    }
}
