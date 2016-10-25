namespace EjercicioDataSet
{
    partial class EjercicioDataSet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpb_Inicializacion = new System.Windows.Forms.GroupBox();
            this.btn_CLocalidades = new System.Windows.Forms.Button();
            this.btn_CRelaciones = new System.Windows.Forms.Button();
            this.btn_CProductos = new System.Windows.Forms.Button();
            this.btn_CProveedores = new System.Windows.Forms.Button();
            this.btn_CrearDSyDT = new System.Windows.Forms.Button();
            this.gpb_Mostrar = new System.Windows.Forms.GroupBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btn_MPDLLIEET = new System.Windows.Forms.Button();
            this.lst_lista = new System.Windows.Forms.ListBox();
            this.btn_MPDLLQ = new System.Windows.Forms.Button();
            this.btn_MPCPCSL = new System.Windows.Forms.Button();
            this.btn_MPCSL = new System.Windows.Forms.Button();
            this.btn_MPCSP = new System.Windows.Forms.Button();
            this.gpb_Inicializacion.SuspendLayout();
            this.gpb_Mostrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_Inicializacion
            // 
            this.gpb_Inicializacion.Controls.Add(this.btn_CLocalidades);
            this.gpb_Inicializacion.Controls.Add(this.btn_CRelaciones);
            this.gpb_Inicializacion.Controls.Add(this.btn_CProductos);
            this.gpb_Inicializacion.Controls.Add(this.btn_CProveedores);
            this.gpb_Inicializacion.Controls.Add(this.btn_CrearDSyDT);
            this.gpb_Inicializacion.Location = new System.Drawing.Point(0, 12);
            this.gpb_Inicializacion.Name = "gpb_Inicializacion";
            this.gpb_Inicializacion.Size = new System.Drawing.Size(200, 288);
            this.gpb_Inicializacion.TabIndex = 0;
            this.gpb_Inicializacion.TabStop = false;
            this.gpb_Inicializacion.Text = "Inicializacion";
            // 
            // btn_CLocalidades
            // 
            this.btn_CLocalidades.Location = new System.Drawing.Point(6, 130);
            this.btn_CLocalidades.Name = "btn_CLocalidades";
            this.btn_CLocalidades.Size = new System.Drawing.Size(188, 39);
            this.btn_CLocalidades.TabIndex = 2;
            this.btn_CLocalidades.Text = "Cargar Localidades";
            this.btn_CLocalidades.UseVisualStyleBackColor = true;
            this.btn_CLocalidades.Click += new System.EventHandler(this.btn_CLocalidades_Click);
            // 
            // btn_CRelaciones
            // 
            this.btn_CRelaciones.Location = new System.Drawing.Point(6, 75);
            this.btn_CRelaciones.Name = "btn_CRelaciones";
            this.btn_CRelaciones.Size = new System.Drawing.Size(188, 39);
            this.btn_CRelaciones.TabIndex = 1;
            this.btn_CRelaciones.Text = "Crear Relaciones";
            this.btn_CRelaciones.UseVisualStyleBackColor = true;
            this.btn_CRelaciones.Click += new System.EventHandler(this.btn_CRelaciones_Click);
            // 
            // btn_CProductos
            // 
            this.btn_CProductos.Location = new System.Drawing.Point(6, 235);
            this.btn_CProductos.Name = "btn_CProductos";
            this.btn_CProductos.Size = new System.Drawing.Size(188, 39);
            this.btn_CProductos.TabIndex = 4;
            this.btn_CProductos.Text = "Cargar Productos";
            this.btn_CProductos.UseVisualStyleBackColor = true;
            this.btn_CProductos.Click += new System.EventHandler(this.btn_CProductos_Click);
            // 
            // btn_CProveedores
            // 
            this.btn_CProveedores.Location = new System.Drawing.Point(6, 184);
            this.btn_CProveedores.Name = "btn_CProveedores";
            this.btn_CProveedores.Size = new System.Drawing.Size(188, 39);
            this.btn_CProveedores.TabIndex = 3;
            this.btn_CProveedores.Text = "Cargar Proveedores";
            this.btn_CProveedores.UseVisualStyleBackColor = true;
            this.btn_CProveedores.Click += new System.EventHandler(this.btn_CProveedores_Click);
            // 
            // btn_CrearDSyDT
            // 
            this.btn_CrearDSyDT.Location = new System.Drawing.Point(6, 19);
            this.btn_CrearDSyDT.Name = "btn_CrearDSyDT";
            this.btn_CrearDSyDT.Size = new System.Drawing.Size(188, 39);
            this.btn_CrearDSyDT.TabIndex = 0;
            this.btn_CrearDSyDT.Text = "Crear DataSet y DataTable";
            this.btn_CrearDSyDT.UseVisualStyleBackColor = true;
            this.btn_CrearDSyDT.Click += new System.EventHandler(this.btn_CrearDSyDT_Click);
            // 
            // gpb_Mostrar
            // 
            this.gpb_Mostrar.Controls.Add(this.txtFiltro);
            this.gpb_Mostrar.Controls.Add(this.btn_MPDLLIEET);
            this.gpb_Mostrar.Controls.Add(this.lst_lista);
            this.gpb_Mostrar.Controls.Add(this.btn_MPDLLQ);
            this.gpb_Mostrar.Controls.Add(this.btn_MPCPCSL);
            this.gpb_Mostrar.Controls.Add(this.btn_MPCSL);
            this.gpb_Mostrar.Controls.Add(this.btn_MPCSP);
            this.gpb_Mostrar.Location = new System.Drawing.Point(206, 12);
            this.gpb_Mostrar.Name = "gpb_Mostrar";
            this.gpb_Mostrar.Size = new System.Drawing.Size(382, 288);
            this.gpb_Mostrar.TabIndex = 0;
            this.gpb_Mostrar.TabStop = false;
            this.gpb_Mostrar.Text = "Mostrar";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(198, 205);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(172, 20);
            this.txtFiltro.TabIndex = 6;
            // 
            // btn_MPDLLIEET
            // 
            this.btn_MPDLLIEET.Location = new System.Drawing.Point(7, 205);
            this.btn_MPDLLIEET.Name = "btn_MPDLLIEET";
            this.btn_MPDLLIEET.Size = new System.Drawing.Size(185, 33);
            this.btn_MPDLLIEET.TabIndex = 5;
            this.btn_MPDLLIEET.Text = "5- Mostrar Proveedores de la localidad ingresada en el txtFiltro";
            this.btn_MPDLLIEET.UseCompatibleTextRendering = true;
            this.btn_MPDLLIEET.UseVisualStyleBackColor = true;
            // 
            // lst_lista
            // 
            this.lst_lista.FormattingEnabled = true;
            this.lst_lista.Location = new System.Drawing.Point(6, 91);
            this.lst_lista.Name = "lst_lista";
            this.lst_lista.Size = new System.Drawing.Size(365, 108);
            this.lst_lista.TabIndex = 4;
            // 
            // btn_MPDLLQ
            // 
            this.btn_MPDLLQ.Location = new System.Drawing.Point(188, 55);
            this.btn_MPDLLQ.Name = "btn_MPDLLQ";
            this.btn_MPDLLQ.Size = new System.Drawing.Size(183, 30);
            this.btn_MPDLLQ.TabIndex = 3;
            this.btn_MPDLLQ.Text = "4- Mostrar Proveedores de la localidad \"Quilmes\"";
            this.btn_MPDLLQ.UseCompatibleTextRendering = true;
            this.btn_MPDLLQ.UseVisualStyleBackColor = true;
            this.btn_MPDLLQ.Click += new System.EventHandler(this.btn_MPDLLQ_Click);
            // 
            // btn_MPCPCSL
            // 
            this.btn_MPCPCSL.Location = new System.Drawing.Point(7, 55);
            this.btn_MPCPCSL.Name = "btn_MPCPCSL";
            this.btn_MPCPCSL.Size = new System.Drawing.Size(174, 30);
            this.btn_MPCPCSL.TabIndex = 2;
            this.btn_MPCPCSL.Text = "3- Mostrar Productos con Proveedor con su Localidad";
            this.btn_MPCPCSL.UseCompatibleTextRendering = true;
            this.btn_MPCPCSL.UseVisualStyleBackColor = true;
            this.btn_MPCPCSL.Click += new System.EventHandler(this.btn_MPCPCSL_Click);
            // 
            // btn_MPCSL
            // 
            this.btn_MPCSL.Location = new System.Drawing.Point(188, 19);
            this.btn_MPCSL.Name = "btn_MPCSL";
            this.btn_MPCSL.Size = new System.Drawing.Size(183, 30);
            this.btn_MPCSL.TabIndex = 1;
            this.btn_MPCSL.Text = "2- Mostrar Proveedor con su Localidad";
            this.btn_MPCSL.UseCompatibleTextRendering = true;
            this.btn_MPCSL.UseVisualStyleBackColor = true;
            this.btn_MPCSL.Click += new System.EventHandler(this.btn_MPCSL_Click);
            // 
            // btn_MPCSP
            // 
            this.btn_MPCSP.Location = new System.Drawing.Point(7, 19);
            this.btn_MPCSP.Name = "btn_MPCSP";
            this.btn_MPCSP.Size = new System.Drawing.Size(174, 30);
            this.btn_MPCSP.TabIndex = 0;
            this.btn_MPCSP.Text = "1- Mostrar Productos Con su Proveedor";
            this.btn_MPCSP.UseCompatibleTextRendering = true;
            this.btn_MPCSP.UseVisualStyleBackColor = true;
            this.btn_MPCSP.Click += new System.EventHandler(this.btn_MPCSP_Click);
            // 
            // EjercicioDataSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 304);
            this.Controls.Add(this.gpb_Mostrar);
            this.Controls.Add(this.gpb_Inicializacion);
            this.Name = "EjercicioDataSet";
            this.Text = "Ejercicio DataSet";
            this.gpb_Inicializacion.ResumeLayout(false);
            this.gpb_Mostrar.ResumeLayout(false);
            this.gpb_Mostrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_Inicializacion;
        private System.Windows.Forms.Button btn_CLocalidades;
        private System.Windows.Forms.Button btn_CRelaciones;
        private System.Windows.Forms.Button btn_CProductos;
        private System.Windows.Forms.Button btn_CProveedores;
        private System.Windows.Forms.Button btn_CrearDSyDT;
        private System.Windows.Forms.GroupBox gpb_Mostrar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btn_MPDLLIEET;
        private System.Windows.Forms.ListBox lst_lista;
        private System.Windows.Forms.Button btn_MPDLLQ;
        private System.Windows.Forms.Button btn_MPCPCSL;
        private System.Windows.Forms.Button btn_MPCSL;
        private System.Windows.Forms.Button btn_MPCSP;
    }
}

