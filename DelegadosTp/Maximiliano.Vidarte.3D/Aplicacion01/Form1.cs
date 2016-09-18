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
    public delegate void DelegadoString(string dato);

    public partial class frmPrincipal : Form
    {
        public DelegadoString miDelegado;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTestDelegados frmTD = new FrmTestDelegados();
            frmTD.Owner = this;
            frmTD.Show();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatos frmD = new frmDatos();
            frmD.Owner = this;
            frmD.Show();
        }

    }
}
