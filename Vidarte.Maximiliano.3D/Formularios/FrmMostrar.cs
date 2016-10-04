using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmMostrar : Form
    {

        public FrmMostrar()
        {
            InitializeComponent();
        }
        public void ActualizarListado(List<Entidades.CuentaOffShore> milista)
        {
            lst_listado.Items.Clear();
            foreach(Entidades.CuentaOffShore item in milista)
            {
                lst_listado.Items.Add(item);
            }
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            FrmPrincipal miform = (FrmPrincipal)this.Owner;
            
        }
    }
}
