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

namespace Formularios
{
    public delegate List<CuentaOffShore> MiDelegadoList(List<CuentaOffShore> lista);
    public partial class FrmPrincipal : Form
    {
       public MiDelegadoList miContenedor;
        List<CuentaOffShore> MiOffShore = new List<CuentaOffShore>();
        public FrmPrincipal()
        {
            InitializeComponent();
            toolStripCmb_Ordenar.Items.Add(eTipoOrdenamiento.PorNroCuenta);
            toolStripCmb_Ordenar.Items.Add(eTipoOrdenamiento.PorParaisoFiscal);
            toolStripCmb_Ordenar.Items.Add(eTipoOrdenamiento.PorTitular);
            toolStripCmb_Ordenar.SelectedIndex = 0; 
            this.lst_listado.SelectedIndexChanged += new EventHandler(lst_listado_SelectedIndexChanged);
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCuentaOffShore miFormCuenta = new FrmCuentaOffShore();
            miFormCuenta.ShowDialog(this);
            if(miFormCuenta.DialogResult == DialogResult.OK)
            {
                eParaisoFiscal miParaiso;
                if(miFormCuenta.cmb_EParaiso.SelectedIndex == 0)
                miParaiso = eParaisoFiscal.Belice;
                else if(miFormCuenta.cmb_EParaiso.SelectedIndex ==1)
                miParaiso= eParaisoFiscal.Panama;
                else if(miFormCuenta.cmb_EParaiso.SelectedIndex ==2)
                miParaiso = eParaisoFiscal.Seichelles;
                else 
                miParaiso = eParaisoFiscal.VirginIslands;
                    CuentaOffShore miCuenta = new CuentaOffShore(miParaiso, int.Parse(miFormCuenta.txt_NroCuenta.Text), miFormCuenta.txt_Titular.Text);
                    lst_listado.Items.Add(miCuenta);
                    MiOffShore.Add(miCuenta);
            }
        }

        private void toolStripCmb_Ordenar_Click(object sender, EventArgs e)
        {
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea Cerrar la aplicacion???", "Salir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }

        private void lst_listado_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.bajaToolStripMenuItem.Click += new EventHandler(ManejadorCentral);
            this.modificarToolStripMenuItem.Click += new EventHandler(ManejadorCentral);
            this.lst_listado.SelectedIndexChanged -= new EventHandler(lst_listado_SelectedIndexChanged);
        }
        public void ManejadorCentral(object sender, EventArgs e)
        {
            ToolStripMenuItem miOpcion = (ToolStripMenuItem)sender;
            this.bajaToolStripMenuItem.Click -= new EventHandler(ManejadorCentral);
            this.modificarToolStripMenuItem.Click -= new EventHandler(ManejadorCentral);
            this.lst_listado.SelectedIndexChanged += new EventHandler(lst_listado_SelectedIndexChanged);

            if (miOpcion.Text == "Baja")
            {
                FrmCuentaOffShore miForm = new FrmCuentaOffShore();
                foreach (CuentaOffShore item in MiOffShore)
                {
                    if (item == lst_listado.SelectedItem)
                    {
                        miForm.txt_Titular.Text = item.Titular;
                        miForm.txt_Titular.Enabled = false;
                        miForm.txt_NroCuenta.Text = item.NroCuenta.ToString();
                        miForm.txt_NroCuenta.Enabled = false;
                        if (item.ParaisoFiscal == eParaisoFiscal.Belice)
                        { miForm.cmb_EParaiso.SelectedIndex = 0; }
                        else if (item.ParaisoFiscal == eParaisoFiscal.Panama)
                        { miForm.cmb_EParaiso.SelectedIndex = 1; }
                        else if (item.ParaisoFiscal == eParaisoFiscal.Seichelles)
                        { miForm.cmb_EParaiso.SelectedIndex = 2; }
                        else if (item.ParaisoFiscal == eParaisoFiscal.VirginIslands)
                        { miForm.cmb_EParaiso.SelectedIndex = 3; }
                        miForm.cmb_EParaiso.Enabled = false;
                    }
                }
                miForm.ShowDialog();
                if (miForm.DialogResult == DialogResult.OK)
                {
                    foreach (CuentaOffShore item in MiOffShore)
                    {
                        if (item == lst_listado.SelectedItem)
                        {
                            lst_listado.Items.Remove(item);
                            MiOffShore.Remove(item);
                            break;
                        }
                    }
                   
                }
            }
            else if (miOpcion.Text == "Modificar")
            {
                FrmCuentaOffShore miForm = new FrmCuentaOffShore();
                foreach (CuentaOffShore item in MiOffShore)
                {
                    if (item == lst_listado.SelectedItem)
                    {
                        miForm.txt_Titular.Text = item.Titular;
                        miForm.txt_NroCuenta.Text = item.NroCuenta.ToString();
                        if (item.ParaisoFiscal == eParaisoFiscal.Belice)
                        { miForm.cmb_EParaiso.SelectedIndex = 0; }
                        else if (item.ParaisoFiscal == eParaisoFiscal.Panama)
                        { miForm.cmb_EParaiso.SelectedIndex = 1; }
                        else if (item.ParaisoFiscal == eParaisoFiscal.Seichelles)
                        { miForm.cmb_EParaiso.SelectedIndex = 2; }
                        else if (item.ParaisoFiscal == eParaisoFiscal.VirginIslands)
                        { miForm.cmb_EParaiso.SelectedIndex = 3; }
                    }
                }
                miForm.ShowDialog();
                if (miForm.DialogResult == DialogResult.OK)
                {
                    eParaisoFiscal miParaiso;
                    if (miForm.cmb_EParaiso.SelectedIndex == 0)
                        miParaiso = eParaisoFiscal.Belice;
                    else if (miForm.cmb_EParaiso.SelectedIndex == 1)
                        miParaiso = eParaisoFiscal.Panama;
                    else if (miForm.cmb_EParaiso.SelectedIndex == 2)
                        miParaiso = eParaisoFiscal.Seichelles;
                    else
                        miParaiso = eParaisoFiscal.VirginIslands;
                    CuentaOffShore miCuenta = new CuentaOffShore(miParaiso, int.Parse(miForm.txt_NroCuenta.Text), miForm.txt_Titular.Text);
                    foreach (CuentaOffShore item in MiOffShore)
                    {
                        if (item == lst_listado.SelectedItem)
                        {
                            lst_listado.Items.Remove(item);
                            MiOffShore.Remove(item);
                            lst_listado.Items.Add(miCuenta);
                            MiOffShore.Add(miCuenta);
                            break;
                        }
                    }
                }
            }
        }

        private void mostrarListadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrar miMostrar = new FrmMostrar();
            miMostrar.Show();
        }

        

        
    }
}
