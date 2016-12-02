using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;

namespace Modelo.SegundoParcial.LabIII
{
    public partial class Form1 : Form
    {
        DataSet _dataSetAlumnos;
        SqlDataAdapter _dataAdapterAlumnos;
        string schema = AppDomain.CurrentDomain.BaseDirectory + "CursosEsquema.XML";
        string datos = AppDomain.CurrentDomain.BaseDirectory + "CursosDatos.XML";

        public Form1()
        {
            InitializeComponent();
        }

        public DataTable CrearDataTableCursos()
        {
            DataTable dtCursos = new DataTable("Cursos");
            dtCursos.Columns.Add(new DataColumn("Codigo", typeof(int)));
            dtCursos.Columns.Add(new DataColumn("Duracion", typeof(int)));
            dtCursos.Columns.Add(new DataColumn("Nombre", typeof(String)));

            dtCursos.Columns[0].AutoIncrement = true;
            dtCursos.Columns[0].AutoIncrementSeed = 1000;
            dtCursos.Columns[0].AutoIncrementStep = 5;

            DataRow fila = dtCursos.NewRow();
            fila[1] = 25;
            fila[2] = "Laboratorio";
            dtCursos.Rows.Add(fila);

            DataRow fila2 = dtCursos.NewRow();
            fila[1] = 30;
            fila[2] = "Programacion";
            dtCursos.Rows.Add(fila2);

            DataRow fila3 = dtCursos.NewRow();
            fila[1] = 10;
            fila[2] = "Ingles";
            dtCursos.Rows.Add(fila3);

            dtCursos.WriteXml(datos);
            dtCursos.WriteXmlSchema(schema);

            return dtCursos;
        }

        public void ConfigurarDataAdapter()
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.MiBase);
            this._dataAdapterAlumnos = new SqlDataAdapter();

            SqlCommand _Select = new SqlCommand("Select Apellido as Ap,CodCurso as CC,Legajo as Leg from Parcial", conexion);

            SqlCommand _Insert = new SqlCommand("Insert Into Alumnos(Id,Apellido,CodCurso,Legajo) values (@Id,@Apellido,@CodCurso,@Legajo)", conexion);
            _Insert.Parameters.Add("@Id", SqlDbType.Int, 18, "Id");
            _Insert.Parameters.Add("@Apellido", SqlDbType.VarChar, 50, "Apellido");
            _Insert.Parameters.Add("@CodCurso", SqlDbType.Int, 18, "CodCurso");
            _Insert.Parameters.Add("@Legajo", SqlDbType.VarChar, 50, "Legajo");

            SqlCommand _Update = new SqlCommand("Update Alumnos set Apellido = @Apellido, CodCurso = @CodCurso, Legajo = @Legajo where Id = @Id", conexion);
            _Update.Parameters.Add("@Id", SqlDbType.Int, 18, "Id");
            _Update.Parameters.Add("@Apellido", SqlDbType.VarChar, 50, "Apellido");
            _Update.Parameters.Add("@CodCurso", SqlDbType.Int, 18, "CodCurso");
            _Update.Parameters.Add("@Legajo", SqlDbType.VarChar, 50, "Legajo");

            SqlCommand _Delete = new SqlCommand("Delete from Alumnos where Id = @Id", conexion);
            _Delete.Parameters.Add("@Id", SqlDbType.Int, 18, "Id");

            _dataAdapterAlumnos.SelectCommand = _Select;
            _dataAdapterAlumnos.InsertCommand = _Insert;
            _dataAdapterAlumnos.UpdateCommand = _Update;
            _dataAdapterAlumnos.DeleteCommand = _Delete;
        }

        public void TraerDatos()
        {

        }
    }
}
