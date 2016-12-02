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
            this._ds = new DataSet("Canutos");
            //Camino explicado para ingresar el comando
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "Select * from Canutos";
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
                this._da.Fill(this._ds,"Canutos");
                this.dataGridView1.DataSource = this._ds.Tables["Canutos"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this._ds.Tables["Canutos"];
            this._da.Update(this._ds);
        }

        private void verEstadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstados frm = new FrmEstados();
            frm.Text = "Estado de las filas";

            int contador = 0;

            foreach (DataRow fila in _ds.Tables[0].Rows)
            {
                frm.listBox1.Items.Add("Fila: " + contador + "Estado: " + fila.RowState.ToString());
                contador ++;
            }
            frm.ShowDialog();
        }
    }
}
/*
 * sqlCommando c = "insert into dbo.Persona(Nombre, Dni) values (@Nombre, @Dni)"
 * sqlParameter p = new sqlParameter("@Dni", dtyp.varchar, 50 , "Dni_P");
 * c.Parameters.Add(p);
 * 
 */