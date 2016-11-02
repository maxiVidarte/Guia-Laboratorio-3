using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioDataSet
{
    public partial class EjercicioDataSet : Form
    {
        private DataSet MiBase = new DataSet("Almacen");
        private DataTable _dtLocalidades = new DataTable("Localidades");
        private DataTable _dtProveedores = new DataTable("Proveedores");
        private DataTable _dtProductos = new DataTable("Productos");
        
        public EjercicioDataSet()
        {
            InitializeComponent();
        }

        private void btn_CrearDSyDT_Click(object sender, EventArgs e)
        {
           this._dtLocalidades.Columns.Add("IdLocalidad", typeof(Int32));
           this._dtLocalidades.Columns.Add("Localidad", typeof(String));
           this._dtLocalidades.PrimaryKey = new DataColumn[] { _dtLocalidades.Columns["IdLocalidad"] };

           this._dtProveedores.Columns.Add("IdProveedor", typeof(Int32));
           this._dtProveedores.Columns.Add("Nombre", typeof(String));
           this._dtProveedores.Columns.Add("IdLocalidad", typeof(Int32));
           this._dtProveedores.PrimaryKey = new DataColumn[] { _dtProveedores.Columns["IdProveedor"] };

           this._dtProductos.Columns.Add("idProductos", typeof(Int32));
           this._dtProductos.Columns.Add("Descripcion", typeof(String));
           this._dtProductos.Columns.Add("IdProveedor", typeof(Int32));
           this._dtProductos.PrimaryKey = new DataColumn[] { _dtProductos.Columns["ID"] };

           this.MiBase.Tables.Add(_dtLocalidades);
           this.MiBase.Tables.Add(_dtProductos);
           this.MiBase.Tables.Add(_dtProveedores);

           MessageBox.Show("Se creo el dataset y datatable");
        }

        private void btn_CRelaciones_Click(object sender, EventArgs e)
        {
            DataRelation miRelacion1 = new DataRelation("Fk_Proveedores_Localidad", MiBase.Tables["Localidades"].Columns["IdLocalidad"], MiBase.Tables["Proveedores"].Columns["IDLocalidad"]);
            DataRelation miRelacion2 = new DataRelation("Fk_Productos_Proveedores", MiBase.Tables["Proveedores"].Columns["IdProveedor"], MiBase.Tables["Productos"].Columns["IdProveedor"]);
            MiBase.Relations.Add(miRelacion1);
            MiBase.Relations.Add(miRelacion2);
            MessageBox.Show("Se crearon las relaciones");
        }

        private void btn_CLocalidades_Click(object sender, EventArgs e)
        {
            DataRow fila1 = this._dtLocalidades.NewRow();
            fila1[0] = 1;
            fila1[1] = "Lanus";
            DataRow fila2 = this._dtLocalidades.NewRow();
            fila2[0] = 2;
            fila2[1] = "Quilmes";
            DataRow fila3 = this._dtLocalidades.NewRow();
            fila3[0] = 3;
            fila3[1] = "Bernal";
            this._dtLocalidades.Rows.Add(fila1);
            this._dtLocalidades.Rows.Add(fila2);
            this._dtLocalidades.Rows.Add(fila3);

            MessageBox.Show("Se agregaron las localidades");
        }

        private void btn_CProveedores_Click(object sender, EventArgs e)
        {
            DataRow fila1 = this._dtProveedores.NewRow();
            fila1[0] = 1;
            fila1[1] = "Gomez";
            fila1[2] = 1;
            DataRow fila2 = this._dtProveedores.NewRow();
            fila2[0] = 2;
            fila2[1] = "Perez";
            fila2[2] = 2;
            DataRow fila3 = this._dtProveedores.NewRow();
            fila3[0] = 3;
            fila3[1] = "Gonzales";
            fila3[2] = 3;

            this._dtProveedores.Rows.Add(fila1);
            this._dtProveedores.Rows.Add(fila2);
            this._dtProveedores.Rows.Add(fila3);

            MessageBox.Show("Se cargaron los proveedores");
        }
        private void btn_CProductos_Click(object sender, EventArgs e)
        {
            DataRow fila1 = this._dtProductos.NewRow();
            fila1[0] = 1;
            fila1[1] = "leche";
            fila1[2] = 1;
            DataRow fila2 = this._dtProductos.NewRow();
            fila2[0] = 2;
            fila2[1] = "manteca";
            fila2[2] = 1;
            DataRow fila3 = this._dtProductos.NewRow();
            fila3[0] = 3;
            fila3[1] = "harina";
            fila3[2] = 3;
            DataRow fila4 = this._dtProductos.NewRow();
            fila4[0] = 4;
            fila4[1] = "huevo";
            fila4[2] = 2;
            DataRow fila5 = this._dtProductos.NewRow();
            fila5[0] = 5;
            fila5[1] = "fideos";
            fila5[2] = 3;
            DataRow fila6 = this._dtProductos.NewRow();
            fila6[0] = 6;
            fila6[1] = "gaseosa";
            fila6[2] = 3;
            DataRow fila7 = this._dtProductos.NewRow();
            fila7[0] = 7;
            fila7[1] = "mermelada";
            fila7[2] = 1;
            DataRow fila8 = this._dtProductos.NewRow();
            fila8[0] = 8;
            fila8[1] = "jabon";
            fila8[2] = 2;
            DataRow fila9 = this._dtProductos.NewRow();
            fila9[0] = 9;
            fila9[1] = "papel de cocina";
            fila9[2] = 2;

            this._dtProductos.Rows.Add(fila1);
            this._dtProductos.Rows.Add(fila2);
            this._dtProductos.Rows.Add(fila3);
            this._dtProductos.Rows.Add(fila4);
            this._dtProductos.Rows.Add(fila5);
            this._dtProductos.Rows.Add(fila6);
            this._dtProductos.Rows.Add(fila7);
            this._dtProductos.Rows.Add(fila8);
            this._dtProductos.Rows.Add(fila9);

            MessageBox.Show("Se cargaron los productos");
        }

        private void btn_MPCSP_Click(object sender, EventArgs e)
        {
            this.ActualizarLista();
            foreach (DataRow fila in MiBase.Tables["Productos"].Rows)
             {
             //Estoy hace traer la fila padre
                 DataRow filapadre = fila.GetParentRow("Fk_Productos_Proveedores");
              this.lst_lista.Items.Add(fila["Descripcion"].ToString()+" "+filapadre["Nombre"].ToString());
              //  this.lsblista.items.add(fila["Descripcion"].toString()+" "+filapadre["nombredeproveedor"].toString());
              
             }
        }

        private void btn_MPDLLQ_Click(object sender, EventArgs e)
        {
            /*datarow[] filaLocalidad = miBase.tables["Localidades"].select("descripcion = Quilmes");
             datarow[] filashijas = filaLocalidad[0].getchildrows("fk_Localidad_proveedores");
             foreach (datarow f in filashijas)
             {
                this.lsbLista.items.add(f["nombreProveedor"].tostring());
             }
             * 
             */
            this.ActualizarLista();
            DataRow[] filaLocalidad = MiBase.Tables["Localidades"].Select("Localidad = 'Quilmes'");
            DataRow[] filashijas = filaLocalidad[0].GetChildRows("Fk_Proveedores_Localidad");
            foreach (DataRow f in filashijas)
            {
                this.lst_lista.Items.Add(f["Nombre"].ToString());
            }
        }

        private void btn_MPCSL_Click(object sender, EventArgs e)
        {
            this.ActualizarLista();
            foreach (DataRow fila in MiBase.Tables["Proveedores"].Rows)
            {
                DataRow filapadre = fila.GetParentRow("Fk_Proveedores_Localidad");
                this.lst_lista.Items.Add(fila["Nombre"].ToString() + "   " + filapadre["Localidad"].ToString());

            }
        }

        private void ActualizarLista()
        {
            this.lst_lista.Items.Clear();
        }

        private void btn_MPCPCSL_Click(object sender, EventArgs e)
        {
            this.ActualizarLista();
            foreach (DataRow fila in MiBase.Tables["Productos"].Rows)
            {
               
            }
        }

        private void btn_MPDLLIEET_Click(object sender, EventArgs e)
        {
            this.ActualizarLista();
            DataRow[] filaLocalidad = MiBase.Tables["Localidades"].Select("Localidad = "+txtFiltro.Text.Replace("'","''"));
            DataRow[] filashijas = filaLocalidad[0].GetChildRows("Fk_Proveedores_Localidad");
            foreach (DataRow f in filashijas)
            {
                this.lst_lista.Items.Add(f["Nombre"].ToString());
            }
        }

        

    }
}
