using System;
using System.Globalization;
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
               this.ActualizarLista(listaEntrada);
               FrmPrincipal miContenedor = (FrmPrincipal)this.Owner;
               miContenedor.miDelegado(listaEntrada, listaSalida);
               //lst_Medicos.Items.Add(unMedico);
            }
        }

        private void FrmGestion_Load(object sender, EventArgs e)
        {
            lst_Medicos.SelectedIndexChanged += new EventHandler(lst_Medicos_SelectedIndexChanged);
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
            this.ActualizarLista(listaEntrada);
            FrmPrincipal miContenedor = (FrmPrincipal)this.Owner;
            miContenedor.miDelegado(listaEntrada, listaSalida);
            //foreach (Medico item in listaEntrada)
            //{
            //    lst_Medicos.Items.Add(item);
            //}
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
            lst_Medicos.SelectedIndexChanged -= new EventHandler(lst_Medicos_SelectedIndexChanged);
        }

        public void Manejador(object sender, EventArgs e)
        { 
            Button miBoton = (Button) sender;
            btn_Modificacion.Click -= new EventHandler(Manejador);
            btn_Egreso.Click -= new EventHandler(Manejador);
            
            
            if(miBoton.Text =="Modificacion")
            {
                FrmMedico formulario = new FrmMedico ();
                Medico miMedico = (Medico)lst_Medicos.SelectedItem;
                if (miMedico != null)
                {
                    formulario.txt_Legajo.Text = miMedico.Legajo;
                    formulario.txt_Nombre.Text = miMedico.Nombre;
                    
                    if (miMedico.Especialidad == eEspecialidades.Cardiologo)
                        formulario.cmb_Especialidad.SelectedIndex = 0;
                    else if (miMedico.Especialidad == eEspecialidades.Clinico)
                        formulario.cmb_Especialidad.SelectedIndex = 1;
                    else
                        formulario.cmb_Especialidad.SelectedIndex = 2;
                    if (formulario.ShowDialog(this) == DialogResult.OK)
                    {
                        eEspecialidades miEspecialidad;
                        if (formulario.cmb_Especialidad.SelectedIndex == 0)
                            miEspecialidad = eEspecialidades.Cardiologo;
                        else if (formulario.cmb_Especialidad.SelectedIndex == 1)
                            miEspecialidad = eEspecialidades.Clinico;
                        else
                            miEspecialidad = eEspecialidades.Pediatra;
                        listaEntrada.Remove((Medico)lst_Medicos.SelectedItem);
                        Medico unMedico = new Medico(formulario.txt_Nombre.Text, formulario.txt_Legajo.Text, miEspecialidad);
                        listaEntrada.Add(unMedico);
                        ActualizarLista(listaEntrada);
                    }
                }
            }
            
            if (miBoton.Text == "Egreso")
            {
                FrmMedicoHeredado formulario2 = new FrmMedicoHeredado();
                MedicoSalida miMedicoSalida = new MedicoSalida((Medico)this.lst_Medicos.SelectedItem);
                formulario2.txt_Legajo.Text = miMedicoSalida.Legajo;
                formulario2.txt_Nombre.Text = miMedicoSalida.Nombre;
                if (miMedicoSalida.Especialidad == eEspecialidades.Cardiologo)
                {
                    formulario2.cmb_Especialidad.SelectedIndex = 0;
                }
                else if (miMedicoSalida.Especialidad == eEspecialidades.Clinico)
                {
                    formulario2.cmb_Especialidad.SelectedIndex = 1;
                }
                else
                    formulario2.cmb_Especialidad.SelectedIndex = 2;
                miMedicoSalida._horarioSalida = DateTime.Now;
                formulario2.txt_Salario.Text = miMedicoSalida.Salario.ToString("N",new CultureInfo("en-us"));
                if (formulario2.ShowDialog(this) == DialogResult.OK)
                {
                    eEspecialidades miEspecialidad;
                    if (formulario2.cmb_Especialidad.SelectedIndex == 0)
                    {
                        miEspecialidad = eEspecialidades.Cardiologo;
                    }
                    else if (formulario2.cmb_Especialidad.SelectedIndex == 1)
                    {
                        miEspecialidad = eEspecialidades.Clinico;
                    }
                    else
                        miEspecialidad = eEspecialidades.Pediatra;
                    
                   
                    listaSalida.Add(miMedicoSalida);
                    listaEntrada.Remove((Medico)lst_Medicos.SelectedItem);
                    this.ActualizarLista(listaEntrada);
                    
                }
                
            }
            FrmPrincipal miContenedor = (FrmPrincipal)this.Owner;
            miContenedor.miDelegado(listaEntrada, listaSalida);
            lst_Medicos.SelectedIndexChanged += new EventHandler(lst_Medicos_SelectedIndexChanged);
        }
        public void ActualizarLista(List<Medico> miMedico)
        {
            lst_Medicos.Items.Clear();
            foreach (Medico item in miMedico)
            {
                lst_Medicos.Items.Add(item);
            }
        }
    }
}
