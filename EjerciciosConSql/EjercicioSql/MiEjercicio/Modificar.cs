using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiEjercicio
{
    public partial class frm_Modificar : Form
    {
        public frm_Modificar()
        {
            InitializeComponent();
        }
        public String Nombre
        {
                get { return this.txt_Nombre.Text; }
                set { this.txt_Nombre.Text = value; }
        }
        public String Tipo
        {
            get { return this.txt_Tipo.Text; }
            set { this.txt_Tipo.Text = value; }
        }
        public String Proveedor
        {
            get { return this.txt_Proveedor.Text; }
            set { this.txt_Proveedor.Text = value; }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
