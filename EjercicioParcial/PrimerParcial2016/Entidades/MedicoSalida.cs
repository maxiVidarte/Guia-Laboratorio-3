using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MedicoSalida : Medico
    {
        private double _salario;
        private DateTime Egreso;

        public double Salario { get { return this.CalcularSalario(); } }
        public DateTime _horarioSalida { get { return this.Egreso; } set { this.Egreso = value; } }

        public MedicoSalida(Medico unMedico)
            : base(unMedico.Nombre, unMedico.Legajo, unMedico.Especialidad)
        {
            this.Egreso = DateTime.Now;
        }

        private double CalcularSalario()
        {
            TimeSpan intervalo1 = this.Egreso.Subtract(base.Ingreso);
            if (base.Especialidad == eEspecialidades.Cardiologo)
            {
                return intervalo1.Seconds * 55;
            }
            else if (base.Especialidad == eEspecialidades.Clinico)
            {
                return intervalo1.Seconds * 50;
            }
            else
                return intervalo1.Seconds * 45;
        }
    }
}
