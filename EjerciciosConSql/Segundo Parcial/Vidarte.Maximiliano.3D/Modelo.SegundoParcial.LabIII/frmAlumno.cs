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

namespace Modelo.SegundoParcial.LabIII
{
    public partial class frmAlumno : Form
    {
        public frmAlumno()
        {
            InitializeComponent();
            cmb_Curso.Items.Add("Java");
            cmb_Curso.Items.Add("C#");
            cmb_Curso.Items.Add("Visual Basic");
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            Alumno miAlumno = new Alumno(txt_Apellido.Text, cmb_Curso.SelectedIndex, int.Parse(txt_Legajo.Text));
            this.DialogResult = DialogResult.OK; 
        }
    }
}
