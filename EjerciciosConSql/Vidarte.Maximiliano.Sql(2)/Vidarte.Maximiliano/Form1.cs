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
            CargarDtYDs();
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.CustomFormat = " dd/MM/yyyy";
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
            Lst_Cursos.Items.Add("Microsoft Visual Basic .Net Nivel I");
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
            //creo las columnas de la tabla cursos
            this.dtCurso.Columns.Add("codCurso", typeof(Int32));
            this.dtCurso.Columns.Add("Descripcion", typeof(string));
            this.dtCurso.PrimaryKey = new DataColumn[] { this.dtCurso.Columns["codCurso"] };
            //creo las columnas de la tabla localidades
            this.dtLocalidad.Columns.Add("codLocalidad", typeof(Int32));
            this.dtLocalidad.Columns.Add("Descripcion", typeof(String));
            this.dtLocalidad.PrimaryKey = new DataColumn[] { this.dtLocalidad.Columns["codLocalidad"] };
            //creo las columnas de la tabla matriculas
            this.dtMatricula.Columns.Add("codCurso", typeof(Int32));
            this.dtMatricula.Columns.Add("Fecha", typeof(String));
            this.dtMatricula.Columns.Add("Alumno", typeof(String));
            this.dtMatricula.Columns.Add("Sexo", typeof(String));
            this.dtMatricula.Columns.Add("Direccion", typeof(String));
            this.dtMatricula.Columns.Add("codLocalidad", typeof(Int32));
            //agrego las tablas creadas al dataset
            this.dsInscripcion.Tables.Add(dtCurso);
            this.dsInscripcion.Tables.Add(dtLocalidad);
            this.dsInscripcion.Tables.Add(dtMatricula);
            //creo las relaciones entre las tablas para luego agregarlas al dataset
            DataRelation mirelacion1 = new DataRelation("Fk_Matricula_Curso", dsInscripcion.Tables["Cursos"].Columns["codCurso"], dsInscripcion.Tables["Matriculas"].Columns["codCurso"]);
            DataRelation mirelacion2 = new DataRelation("Fk_Matricula_Localidad", dsInscripcion.Tables["Localidades"].Columns["codLocalidad"], dsInscripcion.Tables["Matriculas"].Columns["codLocalidad"]);
            //Agrego las relaciones
            this.dsInscripcion.Relations.Add(mirelacion1);
            this.dsInscripcion.Relations.Add(mirelacion2);

            //creo los registros de Localidad
            DataRow fila1 = this.dtLocalidad.NewRow(); fila1[0] = 0; fila1[1] = "Avellaneda";
            DataRow fila2 = this.dtLocalidad.NewRow(); fila2[0] = 1; fila2[1] = "Capital Federal";
            DataRow fila3 = this.dtLocalidad.NewRow(); fila3[0] = 2; fila3[1] = "Quilmes";
            DataRow fila4 = this.dtLocalidad.NewRow(); fila4[0] = 3; fila4[1] = "Berazategui";
            DataRow fila5 = this.dtLocalidad.NewRow(); fila5[0] = 4; fila5[1] = "Lanus";
            DataRow fila6 = this.dtLocalidad.NewRow(); fila6[0] = 5; fila6[1] = "Banfield";
            //creo los registros de curso
            DataRow f1 = this.dtCurso.NewRow(); f1[0] = 0; f1[1] = "Borland C";
            DataRow f2 = this.dtCurso.NewRow(); f2[0] = 1; f2[1] = "Borland C++";
            DataRow f3 = this.dtCurso.NewRow(); f3[0] = 2; f3[1] = "Microsoft C# (Sharp) Nivel I";
            DataRow f4 = this.dtCurso.NewRow(); f4[0] = 3; f4[1] = "Microsoft C# (Sharp) Nivel II";
            DataRow f5 = this.dtCurso.NewRow(); f5[0] = 4; f5[1] = "Microsoft Visual Basic .Net Nivel I";
            DataRow f6 = this.dtCurso.NewRow(); f6[0] = 5; f6[1] = "Microsoft SqlServer 2008 Nivel II";
            DataRow f7 = this.dtCurso.NewRow(); f7[0] = 6; f7[1] = "Java";
            //Agrego los registros de curso y localidad
            this.dtCurso.Rows.Add(f1);
            this.dtCurso.Rows.Add(f2);
            this.dtCurso.Rows.Add(f3);
            this.dtCurso.Rows.Add(f4);
            this.dtCurso.Rows.Add(f5);
            this.dtCurso.Rows.Add(f6);
            this.dtCurso.Rows.Add(f7);
            this.dtLocalidad.Rows.Add(fila1);
            this.dtLocalidad.Rows.Add(fila2);
            this.dtLocalidad.Rows.Add(fila3);
            this.dtLocalidad.Rows.Add(fila4);
            this.dtLocalidad.Rows.Add(fila5);
            this.dtLocalidad.Rows.Add(fila6);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string hola = dateTimePicker1.Value.ToString("dd/MMMM/yyyy");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow fila = this.dtMatricula.NewRow();
            fila[0] = this.Lst_Cursos.SelectedIndex;
            fila[1] = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            fila[2] = this.txt_Alumno.Text;
            if (rdb_Fem.Checked == true)
                fila[3] = "Femenino";
            else
                fila[3] = "Masculino";
            fila[4] = this.txt_direccion.Text;
            fila[5] = this.lst_Localidad.SelectedIndex;
            this.dtMatricula.Rows.Add(fila);
            
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            foreach (DataRow item in dsInscripcion.Tables["Matriculas"].Rows)
            {
                DataRow filaPadre = item.GetParentRow("Fk_Matricula_Curso");
                DataRow filaPadre2 = item.GetParentRow("Fk_Matricula_Localidad");
                this.listBox1.Items.Add(filaPadre["Descripcion"].ToString() + " - " + item["Fecha"].ToString() + " - " + item["Alumno"].ToString() + " - " + item["Sexo"].ToString() + " - " + item["Direccion"].ToString() + " - " + filaPadre2["Descripcion"].ToString());
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            foreach (Control item in this.Gb_ingresodatos.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is RadioButton)
                {
                    RadioButton item1 = (RadioButton)item;
                    item1.Checked = false;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void btn__Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DataRow[] filaLocalidad = dsInscripcion.Tables["Localidades"].Select("Descripcion = '" + txt_IngresoLocalidad.Text + "'");
            DataRow[] filashijas = filaLocalidad[0].GetChildRows("Fk_Matricula_Localidad");
            foreach (DataRow f in filashijas)
            {
                this.listBox1.Items.Add(f["Alumno"].ToString());
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                string curso = Lst_Cursos.SelectedItem.ToString();
                DataRow[] filaCurso = dsInscripcion.Tables["Cursos"].Select("Descripcion = '" + curso + "'");
                DataRow[] filashijas = filaCurso[0].GetChildRows("Fk_Matricula_Curso");
                foreach (DataRow f in filashijas)
                {
                    this.listBox1.Items.Add(f["Alumno"].ToString());
                }
            }
            catch (Exception ex)
            {
            }
        }

    }
}
