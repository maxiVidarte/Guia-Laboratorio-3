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

            cmb_Especialidad.Items.Add(eEspecialidades.Cardiologo);
            cmb_Especialidad.Items.Add(eEspecialidades.Pediatra);
            cmb_Especialidad.Items.Add(eEspecialidades.Clinico);
            cmb_Especialidad.SelectedIndex = 0;
        }


        public virtual void btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_Especialidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

    }
}
