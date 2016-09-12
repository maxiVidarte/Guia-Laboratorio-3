using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio06
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

        private void frmPrincipal_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Realmente quiere salir?", "Confirmación Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
            //{
            //    e.Cancel = true;
            //}
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            int numero;
            bool estaOk = int.TryParse(txt_dinero.Text.ToString(), out numero);
            if (estaOk)
            {
                this.Calcular(numero);
            }
            else
            {
                MessageBox.Show("Ingrese la cantidad a retirar", "Error", MessageBoxButtons.OK);
                txt_dinero.Focus(true);
            }
        }
        public void Calcular(int numero)
        {
            if (numero > 100)
            {
                txt_billete100.Text = (numero / 100).ToString();
                numero = numero - (numero / 100) * 100;
            }
            if (numero > 50)
            {
                txt_billete50.Text = (numero / 50).ToString();
                numero = numero - (numero / 50) * 50;
            }
            if (numero > 20)
            {
                txt_billete20.Text = (numero / 20).ToString();
                numero = numero - (numero / 20) * 20;
            }
            if (numero > 10)
            {
                txt_billete10.Text = (numero / 10).ToString();
                numero = numero - (numero / 10) * 10;
            }
            if (numero > 5)
            {
                txt_billete5.Text = (numero / 5).ToString();
                numero = numero - (numero / 5) * 5;
            }
            if (numero > 2)
            {
                txt_billete2.Text = (numero / 2).ToString();
                numero = numero - (numero / 2) * 2;
            }
            if (numero == 1)
            {
                MessageBox.Show("Le queda $1", "Vuelto", MessageBoxButtons.OK);
            }
        }

        private void txt_dinero_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is GroupBox)
                    foreach (Control item1 in item.Controls)
                    {
                        if (item1 is TextBox)
                        {
                            TextBox text = item1 as TextBox;
                            text.Clear();
                        }
                        else if (item1 is ListBox)
                        {
                            ListBox lista = item1 as ListBox;
                            lista.Items.Clear();
                        }
                    }
            }
        }

    }
}
