using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio04
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                lst_Lista.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void btn_Ordenar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                lst_Lista.Sorted = true;
        }

       
    }
}
