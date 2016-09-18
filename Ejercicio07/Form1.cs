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
        int num1 = 10, num2 = 10, cont = 0;
        char op;
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

        private static float Calculadora(int numero1, int numero2, char op)
        {
            float resultado = 0;
            switch (op)
            {
                case '+':
                    resultado = numero1 + numero2;
                    break;
                case '-':
                    resultado = numero1 - numero2;
                    break;
                case '*':
                    resultado = numero1 * numero2;
                    break;
                case '/':
                    if (numero2 == 0)
                    {
                        MessageBox.Show("error al dividir por 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else
                    {
                        resultado = (float)numero1 / (float)numero2;
                        break;
                    }
            }
            return resultado;
        }

        private void ManejadorCentral(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (cont < 2)
                if (cont < 1)
                    txt_Numero.Clear();
            txt_Numero.Text += boton.Text;
            if (num1 == 10)
                this.num1 = int.Parse(txt_Numero.Text);
            else
                this.num2 = int.Parse(txt_Numero.Text[2].ToString());

            if (num2 == 10)
            {
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
            else
            {
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
                        miBoton.Click -= new EventHandler(ManejadorCentral);
                    }
                }
                this.btn_igual.Click += new EventHandler(Igual);
            }


            cont++;
        }
        private void Igual(object sender, EventArgs e)
        {
            txt_Numero.Clear();
            txt_Numero.Text = Calculadora(this.num1, this.num2, this.op).ToString();
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
            this.btn_igual.Click -= new EventHandler(Igual);
            num1 = 10; num2 = 10; cont = 0;


        }
        private void Operacion(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (cont < 2)
            {
                txt_Numero.Text += boton.Text;
                this.op = txt_Numero.Text[1];
            }

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
