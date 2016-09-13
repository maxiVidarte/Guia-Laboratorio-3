using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio07
{
    public partial class frm_principal : Form
    {
        int num1, num2;

        public frm_principal()
        {
            InitializeComponent();
            this.Load += new EventHandler(Inicializacion);   
        }

        private void Inicializacion(object sender, EventArgs e)
        {
            foreach (Control item in this.grb_numeros.Controls)
            {
                if (item is Button)
                {
                    Button miBoton = item as Button;
                    miBoton.Click += new EventHandler(ManejadorCentral);
                }
            }
        }
     
        private static void Calculadora(int numero1, int numero2)
        {
           
        }

        private void ManejadorCentral(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            txt_Numero.Text = boton.Text;

            foreach (Control item in this.grb_operaciones.Controls)
            {
                if (item is Button)
                {
                    Button miBoton = item as Button;
                    miBoton.Click += new EventHandler(Operacion);
                }
            }
            foreach (Control item in this.grb_numeros.Controls)
            {
                if (item is Button)
                {
                    Button miBoton = item as Button;
                    miBoton.Click -= new EventHandler(ManejadorCentral);
                }
            }
        }
        private void Operacion(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            txt_Numero.Text = boton.Text;

            foreach (Control item in this.grb_operaciones.Controls)
            {
                if (item is Button)
                {
                    Button miBoton = item as Button;
                    miBoton.Click -= new EventHandler(Operacion);
                }
            }
            foreach (Control item in this.grb_numeros.Controls)
            {
                if (item is Button)
                {
                    Button miBoton = item as Button;
                    miBoton.Click += new EventHandler(ManejadorCentral);
                }
            }
        }
    }
}
