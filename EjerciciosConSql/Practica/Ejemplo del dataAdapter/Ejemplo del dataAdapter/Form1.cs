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


namespace Ejemplo_del_dataAdapter
{
    public partial class Form1 : Form
    {
        private DataSet _dataset;
        private SqlDataAdapter _dataAdapter;
        private SqlCommand _Select;
        private SqlCommand _Insert;
        private SqlCommand _Update;
        private SqlCommand _Delete;
        private SqlConnection _connection;
        int contador;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this._connection = new SqlConnection(Properties.Settings.Default.miBase);

            this._Select = new SqlCommand("Select * from Productos", this._connection);

            this._Insert = new SqlCommand("Insert into Productos(Id_Producto,Nombre,Tipo,Proveedor) Values(@Id_Producto,@Nombre,@Tipo,@Proveedor)", this._connection);

            this._Update = new SqlCommand("Update Productos Set Nombre = @Nombre, Tipo =@Tipo, Proveedor = @Proveedor where Id_Producto = @Id_Producto", this._connection);

            this._Delete = new SqlCommand("Delete from Productos where Id_Producto = @Id_Producto", this._connection);
            this._dataAdapter = new SqlDataAdapter();
            this._dataAdapter.SelectCommand = this._Select;
            this._dataAdapter.InsertCommand = this._Insert;
            this._dataAdapter.UpdateCommand = this._Update;
            this._dataAdapter.DeleteCommand = this._Delete;

            this._dataAdapter.InsertCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre");
            this._dataAdapter.InsertCommand.Parameters.Add("@Tipo", SqlDbType.VarChar, 50, "Tipo");
            this._dataAdapter.InsertCommand.Parameters.Add("@Proveedor", SqlDbType.VarChar, 50, "Proveedor");
            this._dataAdapter.InsertCommand.Parameters.Add("@Id_Producto", SqlDbType.Int, 18, "Id_Producto");

            this._dataAdapter.UpdateCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre");
            this._dataAdapter.UpdateCommand.Parameters.Add("@Tipo", SqlDbType.VarChar, 50, "Tipo");
            this._dataAdapter.UpdateCommand.Parameters.Add("@Proveedor", SqlDbType.VarChar, 50, "Proveedor");
            this._dataAdapter.UpdateCommand.Parameters.Add("@Id_Producto", SqlDbType.Int, 18, "Id_Producto");

            this._dataAdapter.DeleteCommand.Parameters.Add("@Id_Producto", SqlDbType.Int, 18, "Id_Producto");
            this.TraerDatos();
            this.MostrarDatos();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDatos frm = new FrmDatos();
            frm.Text = "Agregar";

            if(frm.ShowDialog() == DialogResult.OK)
            {
                contador = this._dataset.Tables[0].Rows.Count + 1;
                DataRow fila = this._dataset.Tables[0].NewRow();
                fila[0] = contador++;
                fila[1] = frm.Nombre;
                fila[2] = frm.Tipo;
                fila[3] = frm.Proveedor;

                this._dataset.Tables[0].Rows.Add(fila);

                this.MostrarDatos();

            }
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
                MessageBox.Show(ex.Message);
            }
        }
        private void MostrarDatos()
        {
            this.listBox1.Items.Clear();
            foreach (DataRow fila in this._dataset.Tables[0].Rows)
            {
                if (fila.RowState != DataRowState.Deleted)
                {
                    this.listBox1.Items.Add("Nombre: " + fila[1].ToString() + "Tipo: " + fila[2].ToString() + "Proveedor: " + fila[3].ToString());
                }
            }
        }
        private void EliminarDatos()
        {
            try
            {
                this._dataset.Tables[0].Rows[this.listBox1.SelectedIndex].Delete();
                this.MostrarDatos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FrmDatos frm = new FrmDatos();
            frm.Text = "Modificar Datos";
            try
            {
                frm.Nombre = this._dataset.Tables[0].Rows[this.listBox1.SelectedIndex]["Nombre"].ToString();
                frm.Tipo = this._dataset.Tables[0].Rows[this.listBox1.SelectedIndex]["Tipo"].ToString();
                frm.Proveedor = this._dataset.Tables[0].Rows[this.listBox1.SelectedIndex]["Proveedor"].ToString();

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    int indice = this.listBox1.SelectedIndex;

                    this._dataset.Tables[0].Rows[indice]["Nombre"] = frm.Nombre;
                    this._dataset.Tables[0].Rows[indice]["Tipo"] = frm.Tipo;
                    this._dataset.Tables[0].Rows[indice]["Proveedor"] = frm.Proveedor;

                    this.MostrarDatos();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Ocurrio un error. Corré");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                this._dataAdapter.Update(this._dataset);
                MessageBox.Show("Se guardo");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "No se guardo");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.EliminarDatos();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void MostrarEstadoFilas(DataSet dataset)
        {
            FrmEstados frmEst = new FrmEstados();
            frmEst.Text = "Estados de las filas ";

            int contador1 = 0;
            foreach (DataRow fila in dataset.Tables[0].Rows)
            {
                frmEst.lst_estados.Items.Add("Fila : " + contador1 + "Estado: " + fila.RowState.ToString());
                contador1++;
            }
            frmEst.ShowDialog();

        }
        private void button6_Click(object sender, EventArgs e)
        {
            MostrarEstadoFilas(this._dataset);
        }
    }
}
