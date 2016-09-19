using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Aplicacion01
{

    public partial class frmDatos : Form
    {
        public frmDatos()
        {
            InitializeComponent();
        }

        private void frmDatos_Load(object sender, EventArgs e)
        {
            frmPrincipal dueño = (frmPrincipal)this.Owner;
            dueño.miStream = new DelegadoStream(this.ActualizarFoto);
            dueño.miDelegado = new DelegadoString(this.ActualizarNombre);
            

        }
        public void ActualizarFoto(string str)
        {
            this.pictureBox1.ImageLocation = str;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public void ActualizarNombre(string daT)
        {
            label1.Text = daT;
        }
    }
}
