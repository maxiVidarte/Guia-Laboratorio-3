using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Entidades;
namespace FrmPrincipal
{
    public partial class FrmMostrar : Form
    {
        public FrmMostrar()
        {
            InitializeComponent();
            
        }

        public void ActualizarListas(List<Medico> miMedicoentrada, List<MedicoSalida> miMedicoSalida)
        {

            lst_MedicoOn.Items.Clear();
            lst_MedicoOff.Items.Clear();
                foreach (Medico item in miMedicoentrada)
                {
                    lst_MedicoOn.Items.Add(item);
                }
                foreach (MedicoSalida item in miMedicoSalida)
                {
                    lst_MedicoOff.Items.Add(item);
                }

        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            FrmPrincipal dueño = (FrmPrincipal)this.Owner;
            dueño.miDelegado = new DelegadoList(this.ActualizarListas);
        }
    }
}
