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
            
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "jpg images(*.jpg)|*.jpg|All files(*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            frmPrincipal miContenedor = (frmPrincipal)this.Owner;
            miContenedor.miDelegado(this.txt_actualizar.Text);
         
        }
    }
}
