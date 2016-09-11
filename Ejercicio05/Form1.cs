using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio05
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Realmente quiere salir?", "Confirmación Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
            {

                e.Cancel = true;

                this.txt_Numero.Focus();

            }
        }

        public void Calcular(int numero)
        {
        }
        private void txt_Numero_TextChanged(object sender, EventArgs e)
        {
            int numero;
            bool estaOk;
            estaOk = int.TryParse(txt_Numero.Text,out numero);
            if (estaOk == true)
            {
                txt_CDC.Text = numero.ToString();
            }

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if(item is GroupBox)
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
