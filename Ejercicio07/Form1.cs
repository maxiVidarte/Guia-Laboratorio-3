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
            this.Load += new EventHandler(Iniciacion);   
        }
        private void Iniciacion(object sender, EventArgs e)
        {
            
        }

        private void Numeros(object sender, KeyEventArgs  e)
        { 
            
        }
        private void txt_Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
        private static void Calculadora(int numero1, int numero2)
        {
            
        }
       
    }
}
