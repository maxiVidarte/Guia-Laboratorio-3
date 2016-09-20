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
        protected List<Medico> lista;
        public FrmGestion()
        {
            this.lista = new List<Medico>();
            InitializeComponent();
        }
    }
}
