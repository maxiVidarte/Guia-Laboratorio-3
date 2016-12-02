using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_del_dataAdapter
{
    public partial class FrmDatos : Form
    {
        public FrmDatos()
        {
            InitializeComponent();
        }

        public string Nombre
        {
            get { return this.txt_Nombre.Text; }
            set { this.txt_Nombre.Text = value; }
        }

        public string Tipo
        {
            get { return this.Txt_Tipo.Text; }
            set { this.Txt_Tipo.Text = value; }
        }
        public string Proveedor
        {
            get { return this.Txt_Proveedor.Text; }
            set { this.Txt_Proveedor.Text = value; }

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void bnt_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
