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
    public partial class FrmTestDelegados : Form
    {
        public FrmTestDelegados()
        {
            InitializeComponent();
            
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            frmPrincipal miContenedor = (frmPrincipal)this.Owner;
            miContenedor.miDelegado(this.txt_actualizar.Text);
         
        }

        private void FrmTestDelegados_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            frmPrincipal miContenedor = (frmPrincipal)this.Owner;
            //Con esto buscamos la imagen
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //Filtros
            openFileDialog1.InitialDirectory = @"C:\Users\Casa\Pictures";
            openFileDialog1.Filter = "jpg images(*.jpg)|*.jpg|All files(*.jpg*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
           
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    miContenedor.miStream(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
