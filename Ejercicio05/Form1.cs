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
            int pares= 0;
            int impares = 0;
            int auxMax = 0;
            int auxMin = 10;

            bool estaOk;
            estaOk = int.TryParse(txt_Numero.Text,out numero);
            if (estaOk == true)
            {
                
                for (int i = 0; i < txt_Numero.TextLength; i++)
                {
                    if (txt_Numero.Text[i] % 2 == 0)
                    {
                        pares += int.Parse(txt_Numero.Text[i].ToString());
                    }
                    else
                        impares += int.Parse(txt_Numero.Text[i].ToString());

                    if (int.Parse(txt_Numero.Text[i].ToString()) > auxMax)
                    {
                        auxMax = int.Parse(txt_Numero.Text[i].ToString());
                    }
                    if (int.Parse(txt_Numero.Text[i].ToString()) < auxMin)
                    {
                        auxMin = int.Parse(txt_Numero.Text[i].ToString());
                    }
                   
                }
                lst_listaDiv.Items.Clear();
                for (int i = 1; i <= int.Parse(txt_Numero.Text.ToString()) ; i++)
                {
                    if (int.Parse(txt_Numero.Text.ToString()) % i == 0)
                    {
                        lst_listaDiv.Items.Add(i);
                    }
                }
                txt_CDC.Text = txt_Numero.TextLength.ToString();
                txt_STC.Text = (pares + impares).ToString();
                txt_SCP.Text = pares.ToString();
                txt_SCI.Text = impares.ToString();
                txt_CMayor.Text = auxMax.ToString();
                txt_CMenor.Text = auxMin.ToString();

                   
                
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
