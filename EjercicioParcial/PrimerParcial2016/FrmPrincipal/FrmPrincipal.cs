using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FrmPrincipal
{
    public delegate void DelegadoList(List<Medico> dato1,List<MedicoSalida> dato2);
    public partial class FrmPrincipal : Form
    {
        public DelegadoList miDelegado;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void gestionDiariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestion frmG = new FrmGestion();
            frmG.ShowDialog(this);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
             //DialogResult chau =  MessageBox.Show("Desea Salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             //if (chau == DialogResult.Yes)
             //{
             //    e.Cancel = false;
             //}
             //else
             //    e.Cancel = true;
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMos = new FrmMostrar();
            frmMos.Owner = this;
            frmMos.Show();
        }      
    }
}
