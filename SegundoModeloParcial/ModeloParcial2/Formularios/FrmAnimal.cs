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
    public partial class FrmAnimal : Form
    {
        public FrmAnimal()
        {
            InitializeComponent();
            btn_Aceptar.Click += new EventHandler(Aceptar);
            btn_Cancelar.Click += new EventHandler(btn_Cancelar_Click);
        }

        public virtual void Aceptar(object sender, EventArgs e)
        {
            Accion(DialogResult.OK);
        }
       
        public static DialogResult Accion(DialogResult resultado)
        {
            if (resultado == DialogResult.OK)
                return DialogResult.OK;
            else
                return DialogResult.Cancel;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Accion(DialogResult.Cancel);
        }

    }
}
