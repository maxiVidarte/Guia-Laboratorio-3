using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String inv = "",cadena = txtCadena.Text;
            for (int i = cadena.Length - 1; i >= 0; i--)
            {
                inv = inv + cadena.Substring(i, 1);
            }
            txtInvertida.Text = inv;

          txtOrden.Text = new string(txtCadena.Text.ToCharArray().OrderBy(x => x).ToArray<char>()); 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCadena.Clear();
            txtInvertida.Clear();
            txtOrden.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AboutBox1 acercade = new AboutBox1();
            acercade.Show();
        }
    }
}
