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
            FrmMedico frmM = new FrmMedico();
            if (frmM.ShowDialog(this) == DialogResult.OK)
            {
                Medico unMedico = new Medico(frmM.txt_Nombre.Text, frmM.txt_Legajo.Text, eEspecialidades.Cardiologo);
                listaEntrada.Add(unMedico);
                lst_Medicos.Items.Add(unMedico);
            }
        }

        private void FrmGestion_Load(object sender, EventArgs e)
        {
            cmb_Ordenamiento.Items.Add("legajo");
            cmb_Ordenamiento.Items.Add("nombre");
            cmb_Ordenamiento.Items.Add("especialidad");
            cmb_Ordenamiento.SelectedIndex = 0;
        }

        private void cmb_especialidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmb_Ordenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Comparison<Medico> miComparador = null;
            if (cmb_Ordenamiento.SelectedIndex == 0)
            {
                miComparador = new Comparison<Medico>(OrdenarPorLegajo);
            }
            else if (cmb_Ordenamiento.SelectedIndex == 1)
            {
                miComparador = new Comparison<Medico>(OrdenarPorNombre);
            }
            else
            {
                miComparador = new Comparison<Medico>(OrdenarPorEspecialidad);
            }
            listaEntrada.Sort(miComparador);
        }
        public static int OrdenarPorLegajo(Medico m1, Medico m2)
        {
            return string.Compare(m1.Legajo, m2.Legajo);
        }
        public static int OrdenarPorNombre(Medico m1, Medico m2)
        {
            return string.Compare(m1.Nombre, m2.Nombre);
        }
        public static int OrdenarPorEspecialidad(Medico m1, Medico m2)
        {
            return string.Compare(m1.Especialidad.ToString(), m2.Especialidad.ToString());
        }
    }
}
