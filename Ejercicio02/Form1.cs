using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtMonto.Text) >= 30 && int.Parse(txtMonto.Text) <= 50)
            {
                txtDescuento.Text = (int.Parse(txtMonto.Text) * 10 / 100).ToString();
            }
            else if (int.Parse(txtMonto.Text) > 50)
            {
                txtDescuento.Text = (int.Parse(txtMonto.Text) * 20 / 100).ToString();
            }
            else
            {
                txtDescuento.Text = "0";
            }
            txtTotal.Text = (int.Parse(txtMonto.Text) - int.Parse(txtDescuento.Text)).ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDescuento.Text = "";
            txtMonto.Text = "";
            txtTotal.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
      
    }
}
