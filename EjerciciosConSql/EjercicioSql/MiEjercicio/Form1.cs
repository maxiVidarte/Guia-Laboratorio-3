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
            this._Insert = new SqlCommand("INSERT INTO Productos(Nombre,Tipo,Proveedor) VALUES(@Nombre,@Tipo,@Proveedores)", this._Connection);
            this._Update = new SqlCommand("UPDATE Productos SET Nombre = @Nombre, Tìpo= @Tipo, Proveedor = @Proveedor WHERE Id_Producto = @Id_Producto", this._Connection);
            this._Delete = new SqlCommand("DELETE FROM Productos WHERE Id_Producto = @Id_Producto", this._Connection);

            //Creo el dataadapter
            this._dataAdapter = new SqlDataAdapter();

            //Agrego los comandos del dataadapter
            this._dataAdapter.SelectCommand = this._Select;
            this._dataAdapter.InsertCommand = this._Insert;
            this._dataAdapter.UpdateCommand = this._Update;
            this._dataAdapter.DeleteCommand = this._Delete;


        }
    }
}
