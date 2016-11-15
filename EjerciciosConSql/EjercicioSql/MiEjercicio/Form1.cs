using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace MiEjercicio
{
    public partial class Form1 : Form
    {
        private DataSet _dataset;
        private SqlDataAdapter _dataAdapter;
        private SqlCommand _Select;
        private SqlCommand _Insert;
        private SqlCommand _Update;
        private SqlCommand _Delete;
        private SqlConnection _Connection;

        public Form1()
        {
            InitializeComponent();
            //Inicializo la conexion y los comandos para el dataadapter
            this._Connection = new SqlConnection(Properties.Settings.Default.connUTN_Negocio);
            this._Select = new SqlCommand("SELECT * FROM Productos", this._Connection);
            this._Insert = new SqlCommand("INSERT INTO Productos(Nombre,Tipo,Proveedor) VALUES(@Nombre,@Tipo,@Proveedor)", this._Connection);
            this._Update = new SqlCommand("UPDATE Productos SET Nombre = @Nombre, Tìpo= @Tipo, Proveedor = @Proveedor WHERE Id_Producto = @Id_Producto", this._Connection);
            this._Delete = new SqlCommand("DELETE FROM Productos WHERE Id_Producto = @Id_Producto", this._Connection);

            //Creo el dataadapter
            this._dataAdapter = new SqlDataAdapter();

            //Agrego los comandos del dataadapter
            this._dataAdapter.SelectCommand = this._Select;
            this._dataAdapter.InsertCommand = this._Insert;
            this._dataAdapter.UpdateCommand = this._Update;
            this._dataAdapter.DeleteCommand = this._Delete;

            this._dataAdapter.InsertCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre");
            this._dataAdapter.InsertCommand.Parameters.Add("@Tipo", SqlDbType.VarChar, 50, "Tipo");
            this._dataAdapter.InsertCommand.Parameters.Add("@Proveedor", SqlDbType.VarChar, 50, "Proveedor");

            this._dataAdapter.UpdateCommand.Parameters.Add("@Id_Producto", SqlDbType.Int, 18, "Id_Producto");
            this._dataAdapter.UpdateCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre");
            this._dataAdapter.UpdateCommand.Parameters.Add("@Tipo", SqlDbType.VarChar, 50, "Tipo");
            this._dataAdapter.UpdateCommand.Parameters.Add("@Proveedor", SqlDbType.VarChar, 50, "Proveedor");

            this._dataAdapter.DeleteCommand.Parameters.Add("@Id_Producto", SqlDbType.Int, 18, "Id_Producto");


        }
        private void TraerDatos()
        {
            try
            {
                this._dataset = new DataSet();
                this._dataAdapter.Fill(this._dataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error", ex.Message);
            }
        }

        private void MostrarDatos()
        {
            this.lstDatos.Items.Clear();
            foreach (DataRow fila in this._dataset.Tables[0].Rows)
            {
                if (fila.RowState != DataRowState.Deleted)
                {
                    this.lstDatos.Items.Add("Nombre: " + fila[1].ToString() + " Tipo: " + fila[2].ToString() + " Proveedor: " + fila[3].ToString());
                }
            }
        }
        private void EliminarDatos()
        {
            try
            {
                this._dataset.Tables[0].Rows[this.lstDatos.SelectedIndex].Delete();
                this.MostrarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error", ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TraerDatos();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            frm_Modificar frm = new frm_Modificar();
            frm.Text = "Modificar Datos";

            frm.Nombre = this._dataset.Tables[0].Rows[this.lstDatos.SelectedIndex]["Nombre"].ToString();
            frm.Tipo = this._dataset.Tables[0].Rows[this.lstDatos.SelectedIndex]["Tipo"].ToString();
            frm.Proveedor = this._dataset.Tables[0].Rows[this.lstDatos.SelectedIndex]["Proveedor"].ToString();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                int indice = this.lstDatos.SelectedIndex;

                this._dataset.Tables[0].Rows[indice]["Nombre"] = frm.Nombre;
                this._dataset.Tables[0].Rows[indice]["Tipo"] = frm.Tipo;
                this._dataset.Tables[0].Rows[indice]["Proveedor"] = frm.Proveedor;

                this.MostrarDatos();


            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            frm_Modificar frm = new frm_Modificar();
            frm.Text = "Agregar";

            if (frm.ShowDialog() == DialogResult.OK)
            {
                DataRow fila = this._dataset.Tables[0].NewRow();
                fila[0] = lstDatos.Items.Count + 1;
                fila[1] = frm.Nombre;
                fila[2] = frm.Tipo;
                fila[3] = frm.Proveedor;

                this._dataset.Tables[0].Rows.Add(fila);

                this.MostrarDatos();
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                this._dataAdapter.Update(_dataset);
                MessageBox.Show("Sincronizacion Exitosa!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error al sincronizar",ex.Message);
            }
        }
        private void btnContar_Click(object sender, EventArgs e)
        {
            int contador = 0;
            SqlCommand comando = new SqlCommand("Select * from Productos", this._Connection);

            try
            {
                this._Connection.Open();

                SqlDataReader lector = comando.ExecuteReader();

                while ( lector.Read())
                {
                    contador++;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this._Connection.Close();
            }
        }
        public void MostrarEstadoFilas(DataSet dataset)
        {
            frmEstados frmEst = new frmEstados();
            frmEst.Text = "Estados de las filas";

            int contador = 0;
            foreach (DataRow fila in dataset.Tables[0].Rows)
            {
                frmEst.lstEstados.Items.Add("fila : " + contador + " Estado: " + fila.RowState.ToString());
                contador++;
            }
            frmEst.ShowDialog();
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            this.MostrarDatos();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            this.EliminarDatos();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.MostrarEstadoFilas(this._dataset);
        }
    }
}
