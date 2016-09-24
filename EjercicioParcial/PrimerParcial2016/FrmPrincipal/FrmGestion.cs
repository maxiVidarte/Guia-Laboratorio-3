﻿using System;
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
            eEspecialidades miEspecialidad ;
            if (frmM.ShowDialog(this) == DialogResult.OK)
            {
                if (frmM.cmb_Especialidad.SelectedIndex == 0)
                    miEspecialidad = eEspecialidades.Cardiologo;
                else if (frmM.cmb_Especialidad.SelectedIndex == 1)
                    miEspecialidad = eEspecialidades.Clinico;
                else
                    miEspecialidad = eEspecialidades.Pediatra;
               Medico unMedico = new Medico(frmM.txt_Nombre.Text, frmM.txt_Legajo.Text,miEspecialidad);
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
                miComparador = new Comparison<Medico>(Entidades.Medico.OrdenarPorLegajo);
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
            lst_Medicos.Items.Clear();
            foreach (Medico item in listaEntrada)
            {
                lst_Medicos.Items.Add(item);
            }
        }
        public int OrdenarPorLegajo(Medico m1, Medico m2)
        {
            return string.Compare(m1.Legajo, m2.Legajo);
        }
        public int OrdenarPorNombre(Medico m1, Medico m2)
        {
            return string.Compare(m1.Nombre, m2.Nombre);
        }
        public int OrdenarPorEspecialidad(Medico m1, Medico m2)
        {
            return string.Compare(m1.Especialidad.ToString(), m2.Especialidad.ToString());
        }

        private void lst_Medicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Modificacion.Click += new EventHandler(Manejador);
            btn_Egreso.Click += new EventHandler(Manejador);
        }

        public void Manejador(object sender, EventArgs e)
        { 
            Button miBoton = (Button) sender;
            
            if(miBoton.Text =="Modificacion")
            {
                FrmMedico formulario = new FrmMedico ();
                formulario.ShowDialog();
            }
            
            if (miBoton.Text == "Egreso")
            {
                FrmMedicoHeredado formulario = new FrmMedicoHeredado();
                formulario.ShowDialog();
            }
            

        }
        public void Modificacion(object sender, EventArgs e)
        {
            this.btn_Modificacion.Click -= new EventHandler(Modificacion);
            this.btn_Modificacion.Click -= new EventHandler(Egreso);
            FrmMedico frmM = new FrmMedico();
            frmM.Show();
        }
        public void Egreso(object sender, EventArgs e)
        {
            this.btn_Modificacion.Click -= new EventHandler(Modificacion);
            this.btn_Modificacion.Click -= new EventHandler(Egreso);
            FrmMedicoHeredado frmE = new FrmMedicoHeredado();
            frmE.Show();
        }
    }
}
