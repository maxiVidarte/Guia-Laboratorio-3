using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploSQL
{
    public partial class Form1 : Form
    {
        private SqlConnection _miConexion;
        private SqlDataAdapter _da;
        private DataSet _ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //instancio la conexion
            this._miConexion = new SqlConnection(Properties.Settings.Default.connDBAdapter);
            //instancio el dataset
            this._ds = new DataSet();
            //Camino explicado para ingresar el comando
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "Select * from Clientes";
            comando.Connection = this._miConexion;
            //instancio el dataadapter
            this._da = new SqlDataAdapter(comando);
            //Para instanciar el dataadapter de la forma resumida es de la siguiente forma
            //this._da = new SqlDataAdapter("Select * from Clientes", this._miConexion);
        }

        private void accionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this._da.Fill(this._ds, "Clientes");
                this.dataGridView1.DataSource = this._ds.Tables["Clientes"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
/*
 * sqlCommando c = "insert into dbo.Persona(Nombre, Dni) values (@Nombre, @Dni)"
 * sqlParameter p = new sqlParameter("@Dni", dtyp.varchar, 50 , "Dni_P");
 * c.Parameters.Add(p);
 * 
 */