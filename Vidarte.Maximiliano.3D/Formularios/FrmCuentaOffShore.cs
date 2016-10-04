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
    
    public partial class FrmCuentaOffShore : FrmCuenta
    {
        CuentaOffShore miCuenta;
        public CuentaOffShore Cuenta { get { return this.miCuenta; } }

        public FrmCuentaOffShore()
        {
            InitializeComponent();
            cmb_EParaiso.Items.Add(eParaisoFiscal.Belice);
            cmb_EParaiso.Items.Add(eParaisoFiscal.Panama);
            cmb_EParaiso.Items.Add(eParaisoFiscal.Seichelles);
            cmb_EParaiso.Items.Add(eParaisoFiscal.VirginIslands);
            cmb_EParaiso.SelectedIndex = 0;
        }
        public override void btn_Aceptar_Click(object sender, EventArgs e)
        {
            eParaisoFiscal miParaiso;
            if(cmb_EParaiso.SelectedIndex == 0)
                miParaiso = eParaisoFiscal.Belice;
            else if(cmb_EParaiso.SelectedIndex ==1)
                miParaiso= eParaisoFiscal.Panama;
            else if(cmb_EParaiso.SelectedIndex ==2)
                miParaiso = eParaisoFiscal.Seichelles;
            else 
                miParaiso = eParaisoFiscal.VirginIslands;
            if (txt_NroCuenta.Text != "" && txt_Titular.Text != "")
            {
                this.miCuenta = new CuentaOffShore(miParaiso, int.Parse(this.txt_NroCuenta.Text), this.txt_Titular.Text);
                base.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Debe ingresar datos");
            
        }


    }
}
