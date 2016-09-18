using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion01
{
    public partial class FrmTestDelegados : Form
    {
        public FrmTestDelegados()
        {
            InitializeComponent();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            frmPrincipal miContenedor = (frmPrincipal)this.Owner;
            if (miContenedor.miDelegado != null)
            {
                miContenedor.miDelegado(this.txt_actualizar.Text);
            }
        }
    }
}
