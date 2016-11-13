using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vidarte.Maximiliano
{
    public partial class Form1 : Form
    {
        DataSet dsInscripcion = new DataSet("Inscripcion");
        DataTable dtMatricula = new DataTable("Matriculas");
        DataTable dtCurso = new DataTable("Cursos");
        DataTable dtLocalidad = new DataTable("Localidades");

        public Form1()
        {
            InitializeComponent();
            CargarListboxs();

        }

        private void Lst_Cursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txt_curso.Text = Lst_Cursos.SelectedItem.ToString();
        }

        private void lst_Localidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txt_localidad.Text = lst_Localidad.SelectedItem.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void CargarListboxs()
        {
            Lst_Cursos.Items.Add("Borland C");
            Lst_Cursos.Items.Add("Borland C++");
            Lst_Cursos.Items.Add("Microsoft C#(Sharp) Nivel I");
            Lst_Cursos.Items.Add("Microsoft C#(Sharp) Nivel II");
            Lst_Cursos.Items.Add("Microsoft SqlServer 2008 Nivel II");
            Lst_Cursos.Items.Add("Java");
            lst_Localidad.Items.Add("Avellaneda");
            lst_Localidad.Items.Add("Capital Federal");
            lst_Localidad.Items.Add("Quilmes");
            lst_Localidad.Items.Add("Berazategui");
            lst_Localidad.Items.Add("Lanus");
            lst_Localidad.Items.Add("Banfield");
        }
        public void CargarDtYDs()
        {
            this.dtCurso.Columns.Add("codCurso", typeof(Int32));
            this.dtCurso.Columns.Add("Descripcion", typeof(string));
            this.dtCurso.PrimaryKey = new DataColumn[] { this.dtCurso.Columns["codCurso"] };

            this.dtLocalidad.Columns.Add("codLocalidad", typeof(Int32));
            this.dtLocalidad.Columns.Add("Descripcion", typeof(String));
            this.dtLocalidad.PrimaryKey = new DataColumn[] { this.dtLocalidad.Columns["codLocalidad"] };

        }
    }
}
