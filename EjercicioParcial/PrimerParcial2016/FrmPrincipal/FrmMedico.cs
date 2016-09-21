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
    public partial class FrmMedico : Form
    {
        
        public FrmMedico()
        {
            InitializeComponent();
           
        }


        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            //Medico unMedico = new Medico();   
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_Especialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
