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
    public partial class FrmGestion : Form
    {
        protected List<Medico> listaEntrada;
        protected List<MedicoSalida> listaSalida;

        public FrmGestion()
        {
            this.listaEntrada = new List<Medico>();
            this.listaSalida = new List<MedicoSalida>();

            InitializeComponent();
        }

        private void btn_Ingreso_Click(object sender, EventArgs e)
        {
            //DialogResult hola = new System.Windows.Forms.DialogResult();
            FrmMedico frmM = new FrmMedico();
            //hola = frmM.ShowDialog(this);
            if (frmM.ShowDialog(this) == DialogResult.OK)
            {
                Medico unMedico = new Medico(frmM.txt_Nombre.Text, frmM.txt_Legajo.Text, eEspecialidades.Cardiologo);
                lst_Medicos.Items.Add(unMedico);
            }
        }

        private void cmb_especialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
