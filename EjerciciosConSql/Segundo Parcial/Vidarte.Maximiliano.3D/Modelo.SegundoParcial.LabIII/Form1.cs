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
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;

namespace Modelo.SegundoParcial.LabIII
{
    public partial class Form1 : Form
    {
        DataSet _dataSetAlumnos_Cursos;
        SqlDataAdapter _dataAdapterAlumnos;


        public Form1()
        {
            InitializeComponent();
            this.Text = "Este es el formulario principal";
            this._dataSetAlumnos_Cursos = new DataSet("Alumnos_Cursos");
        }

        public DataTable CrearDataTableCursos()
        {
            //Creo la tabla
            DataTable dtCursos = new DataTable("Cursos");
            dtCursos.Columns.Add("Codigo", typeof(Int32));
            dtCursos.Columns.Add("Duracion", typeof(Int32));
            dtCursos.Columns.Add("Nombre", typeof(String));
            //configuro el primarykey y le digo que es autoincrementable empezando de 1000 y yendo de 5 en 5
            dtCursos.PrimaryKey = new DataColumn[] { dtCursos.Columns["Codigo"] };
            dtCursos.Columns[0].AutoIncrement = true;
            dtCursos.Columns[0].AutoIncrementSeed = 1000;
            dtCursos.Columns[0].AutoIncrementStep = 5;

            DataRow fila = dtCursos.NewRow();
            fila[1] = 5;
            fila[2] = "Java";

            DataRow fila1 = dtCursos.NewRow();
            fila1[1] = 10;
            fila1[2] = "C#(Sharp)";

            DataRow fila2 = dtCursos.NewRow();
            fila2[1] = 10;
            fila2[2] = "Visual Basic";

            dtCursos.Rows.Add(fila);
            dtCursos.Rows.Add(fila1);
            dtCursos.Rows.Add(fila2);

            dtCursos.WriteXmlSchema(AppDomain.CurrentDomain.BaseDirectory + "\\CursoEsquemma.XML");
            dtCursos.WriteXml(AppDomain.CurrentDomain.BaseDirectory + "\\CursoDatos.XML");
            return dtCursos;
        }
        public void ConfigurarDataAdapter()
        {
            this._dataAdapterAlumnos = new SqlDataAdapter();

            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cnn);

            //Creo los comandos para el dataadapter
            SqlCommand _Select = new SqlCommand("SELECT * FROM Alumno", conexion);
            SqlCommand _Insert = new SqlCommand("INSERT into Alumno (Apellido,Legajo,Curso) VALUES (@Apellido,@Legajo,@Curso)", conexion);
            SqlCommand _Update = new SqlCommand("UPDATE Alumno SET Apellido = @Apellido, Curso= @Curso WHERE Legajo = @Legajo", conexion);
            SqlCommand _Delete = new SqlCommand("DELETE from Alumno WHERE Legajo = @Legajo", conexion);

            //agrego los comandos en el dataadapter
            _dataAdapterAlumnos.SelectCommand = _Select;
            _dataAdapterAlumnos.InsertCommand = _Insert;
            _dataAdapterAlumnos.UpdateCommand = _Update;
            _dataAdapterAlumnos.DeleteCommand = _Delete;

            //Creo los parameters del insert
            _dataAdapterAlumnos.InsertCommand.Parameters.Add("@Apellido", SqlDbType.VarChar, 50, "Apellido");
            _dataAdapterAlumnos.InsertCommand.Parameters.Add("@Legajo", SqlDbType.Int, 18, "Legajo");
            _dataAdapterAlumnos.InsertCommand.Parameters.Add("@Curso", SqlDbType.Int, 18, "Curso");

            //Creo los parameters del Update
            _dataAdapterAlumnos.UpdateCommand.Parameters.Add("@Apellido", SqlDbType.VarChar, 50, "Apellido");
            _dataAdapterAlumnos.UpdateCommand.Parameters.Add("@Legajo", SqlDbType.Int, 18, "Legajo");
            _dataAdapterAlumnos.UpdateCommand.Parameters.Add("@Curso", SqlDbType.Int, 18, "Curso");

            //Creo el parameters del Delete
            _dataAdapterAlumnos.DeleteCommand.Parameters.Add("@Legajo", SqlDbType.Int, 18, "Legajo");

        }
        public void TraerDatos()
        {
            try
            {
                
                if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\CursosEsquema.XML") && !File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\CursosDatos.XML"))
                {
                    DataTable nuevoDt = this.CrearDataTableCursos();
                    this._dataSetAlumnos_Cursos.Tables.Add(nuevoDt);
                }
                else
                {
                    DataTable nuevoDt = new DataTable();
                    nuevoDt.ReadXmlSchema(AppDomain.CurrentDomain.BaseDirectory + "\\CursosEsquema.XML");
                    nuevoDt.ReadXml(AppDomain.CurrentDomain.BaseDirectory + "\\CursosDatos.XML");
                }
                

                this.ConfigurarDataAdapter();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cnn);
                SqlCommand comando = new SqlCommand("Select * From Alumno", conexion);

                conexion.Open();

                SqlDataReader dataReader = comando.ExecuteReader();
                DataTable dtAlumno = new DataTable("dtAlumno");
                dtAlumno.Load(dataReader);

                this._dataSetAlumnos_Cursos.Tables.Add(dtAlumno);
                conexion.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);

            }
        }

        public void EstablecerRelacion()
        {
            this._dataSetAlumnos_Cursos.Relations.Add("FK_Cursos_Alumnos", this._dataSetAlumnos_Cursos.Tables["Cursos"].Columns["Codigo"], this._dataSetAlumnos_Cursos.Tables["dtAlumno"].Columns["codCurso"]);
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumno frmAlta = new frmAlumno();
            frmAlta.Text = "Alta de alumno";
            try
            {
                foreach (DataRow fila in this._dataSetAlumnos_Cursos.Tables["Cursos"].Rows)
                {
                    frmAlta.cmb_Curso.Items.Add(fila["Nombre"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error desconocido: " + ex.Message);
            }
            if (frmAlta.ShowDialog() == DialogResult.OK)
            {
                DataRow nuevo = this._dataSetAlumnos_Cursos.Tables["dtAlumno"].NewRow();

                nuevo["codCurso"] = ((frmAlta.cmb_Curso.SelectedIndex) * 5 + 1000);
                nuevo["Apellido"] = frmAlta.txt_Apellido.Text;
                nuevo["Legajo"] = int.Parse(frmAlta.txt_Legajo.Text);
               
                this._dataSetAlumnos_Cursos.Tables["dtAlumno"].Rows.Add(nuevo);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TraerDatos();
            this.EstablecerRelacion();
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int bandera = 0;
            string legajo = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el legajo que quiere dar de baja", "Baja", "*******");
            foreach (DataRow item in this._dataSetAlumnos_Cursos.Tables["dtAlumno"].Rows)
            {
                if (item["Legajo"].ToString() == legajo)
                {
                    item.Delete();
                    bandera = 1;
                    break;
                }
            }
            if (bandera == 0)
            {
                MessageBox.Show("No se encontro el legajo");
            }
            else
                MessageBox.Show("Alumno borrado");
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrar frm = new frmMostrar();
           
            foreach (DataRow item in this._dataSetAlumnos_Cursos.Tables["dtAlumno"].Rows)
            {
                frm.listBox1.Items.Add(item["Apellido"].ToString() + " - " + item["Legajo"].ToString() + " - " + item["codCurso"].ToString());
            }
            frm.Show();
        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumno frm = new frmAlumno();
            frm.Text = "Modificacion de alumno";
            int rownumber = 0;

            string legajo = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el legajo que quiere dar de baja", "Baja", "*******");
            foreach (DataRow item in this._dataSetAlumnos_Cursos.Tables["dtAlumno"].Rows)
            {
                
                if (item["Legajo"].ToString() == legajo)
                {
                    int indice = int.Parse(item["codCurso"].ToString());
                    frm.txt_Apellido.Text = item["Apellido"].ToString();
                    frm.txt_Legajo.Text = item["Legajo"].ToString();
                    frm.cmb_Curso.SelectedIndex = (indice - 1000) / 5;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {

                        this._dataSetAlumnos_Cursos.Tables["dtAlumno"].Rows[rownumber]["Apellido"] = frm.txt_Apellido.Text;
                        this._dataSetAlumnos_Cursos.Tables["dtAlumno"].Rows[rownumber]["codCurso"] = (frm.cmb_Curso.SelectedIndex * 5) + 1000;

                    }
                }
                rownumber++;
            }
     }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this._dataAdapterAlumnos.Update(this._dataSetAlumnos_Cursos.Tables["dtAlumno"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
