namespace Vidarte.Maximiliano
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Gb_ingresodatos = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rdb_masc = new System.Windows.Forms.RadioButton();
            this.rdb_Fem = new System.Windows.Forms.RadioButton();
            this.txt_localidad = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_Alumno = new System.Windows.Forms.TextBox();
            this.txt_curso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_curso = new System.Windows.Forms.Label();
            this.Gb__opciones = new System.Windows.Forms.GroupBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.Gb_cursos = new System.Windows.Forms.GroupBox();
            this.Lst_Cursos = new System.Windows.Forms.ListBox();
            this.Gb_Localidad = new System.Windows.Forms.GroupBox();
            this.lst_Localidad = new System.Windows.Forms.ListBox();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ = new System.Windows.Forms.Button();
            this.txt_IngresoLocalidad = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Gb_ingresodatos.SuspendLayout();
            this.Gb__opciones.SuspendLayout();
            this.Gb_cursos.SuspendLayout();
            this.Gb_Localidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gb_ingresodatos
            // 
            this.Gb_ingresodatos.Controls.Add(this.dateTimePicker1);
            this.Gb_ingresodatos.Controls.Add(this.rdb_masc);
            this.Gb_ingresodatos.Controls.Add(this.rdb_Fem);
            this.Gb_ingresodatos.Controls.Add(this.txt_localidad);
            this.Gb_ingresodatos.Controls.Add(this.txt_direccion);
            this.Gb_ingresodatos.Controls.Add(this.txt_Alumno);
            this.Gb_ingresodatos.Controls.Add(this.txt_curso);
            this.Gb_ingresodatos.Controls.Add(this.label1);
            this.Gb_ingresodatos.Controls.Add(this.label5);
            this.Gb_ingresodatos.Controls.Add(this.label4);
            this.Gb_ingresodatos.Controls.Add(this.label3);
            this.Gb_ingresodatos.Controls.Add(this.label2);
            this.Gb_ingresodatos.Controls.Add(this.lbl_curso);
            this.Gb_ingresodatos.ForeColor = System.Drawing.Color.Blue;
            this.Gb_ingresodatos.Location = new System.Drawing.Point(12, 12);
            this.Gb_ingresodatos.Name = "Gb_ingresodatos";
            this.Gb_ingresodatos.Size = new System.Drawing.Size(332, 204);
            this.Gb_ingresodatos.TabIndex = 0;
            this.Gb_ingresodatos.TabStop = false;
            this.Gb_ingresodatos.Text = "Ingreso de datos";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // rdb_masc
            // 
            this.rdb_masc.AutoSize = true;
            this.rdb_masc.Location = new System.Drawing.Point(226, 119);
            this.rdb_masc.Name = "rdb_masc";
            this.rdb_masc.Size = new System.Drawing.Size(73, 17);
            this.rdb_masc.TabIndex = 12;
            this.rdb_masc.TabStop = true;
            this.rdb_masc.Text = "Masculino";
            this.rdb_masc.UseVisualStyleBackColor = true;
            // 
            // rdb_Fem
            // 
            this.rdb_Fem.AutoSize = true;
            this.rdb_Fem.Location = new System.Drawing.Point(127, 119);
            this.rdb_Fem.Name = "rdb_Fem";
            this.rdb_Fem.Size = new System.Drawing.Size(71, 17);
            this.rdb_Fem.TabIndex = 11;
            this.rdb_Fem.TabStop = true;
            this.rdb_Fem.Text = "Femenino";
            this.rdb_Fem.UseVisualStyleBackColor = true;
            // 
            // txt_localidad
            // 
            this.txt_localidad.Enabled = false;
            this.txt_localidad.Location = new System.Drawing.Point(127, 173);
            this.txt_localidad.Name = "txt_localidad";
            this.txt_localidad.Size = new System.Drawing.Size(196, 20);
            this.txt_localidad.TabIndex = 10;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(127, 143);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(196, 20);
            this.txt_direccion.TabIndex = 9;
            // 
            // txt_Alumno
            // 
            this.txt_Alumno.Location = new System.Drawing.Point(127, 84);
            this.txt_Alumno.Name = "txt_Alumno";
            this.txt_Alumno.Size = new System.Drawing.Size(196, 20);
            this.txt_Alumno.TabIndex = 8;
            // 
            // txt_curso
            // 
            this.txt_curso.Enabled = false;
            this.txt_curso.Location = new System.Drawing.Point(127, 25);
            this.txt_curso.Name = "txt_curso";
            this.txt_curso.Size = new System.Drawing.Size(196, 20);
            this.txt_curso.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Localidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(13, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sexo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de matricula";
            // 
            // lbl_curso
            // 
            this.lbl_curso.AutoSize = true;
            this.lbl_curso.ForeColor = System.Drawing.Color.Black;
            this.lbl_curso.Location = new System.Drawing.Point(13, 28);
            this.lbl_curso.Name = "lbl_curso";
            this.lbl_curso.Size = new System.Drawing.Size(34, 13);
            this.lbl_curso.TabIndex = 0;
            this.lbl_curso.Text = "Curso";
            // 
            // Gb__opciones
            // 
            this.Gb__opciones.Controls.Add(this.btn_salir);
            this.Gb__opciones.Controls.Add(this.btn_limpiar);
            this.Gb__opciones.Controls.Add(this.btn_guardar);
            this.Gb__opciones.ForeColor = System.Drawing.Color.Blue;
            this.Gb__opciones.Location = new System.Drawing.Point(350, 12);
            this.Gb__opciones.Name = "Gb__opciones";
            this.Gb__opciones.Size = new System.Drawing.Size(139, 204);
            this.Gb__opciones.TabIndex = 0;
            this.Gb__opciones.TabStop = false;
            this.Gb__opciones.Text = "Opciones";
            // 
            // btn_salir
            // 
            this.btn_salir.ForeColor = System.Drawing.Color.Red;
            this.btn_salir.Location = new System.Drawing.Point(6, 132);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(127, 41);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_limpiar.Location = new System.Drawing.Point(6, 73);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(127, 41);
            this.btn_limpiar.TabIndex = 1;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.ForeColor = System.Drawing.Color.Gray;
            this.btn_guardar.Location = new System.Drawing.Point(6, 19);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(127, 41);
            this.btn_guardar.TabIndex = 0;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gb_cursos
            // 
            this.Gb_cursos.Controls.Add(this.Lst_Cursos);
            this.Gb_cursos.ForeColor = System.Drawing.Color.Blue;
            this.Gb_cursos.Location = new System.Drawing.Point(12, 222);
            this.Gb_cursos.Name = "Gb_cursos";
            this.Gb_cursos.Size = new System.Drawing.Size(271, 173);
            this.Gb_cursos.TabIndex = 0;
            this.Gb_cursos.TabStop = false;
            this.Gb_cursos.Text = "Cursos";
            // 
            // Lst_Cursos
            // 
            this.Lst_Cursos.FormattingEnabled = true;
            this.Lst_Cursos.Location = new System.Drawing.Point(16, 19);
            this.Lst_Cursos.Name = "Lst_Cursos";
            this.Lst_Cursos.Size = new System.Drawing.Size(240, 147);
            this.Lst_Cursos.TabIndex = 0;
            this.Lst_Cursos.SelectedIndexChanged += new System.EventHandler(this.Lst_Cursos_SelectedIndexChanged);
            // 
            // Gb_Localidad
            // 
            this.Gb_Localidad.Controls.Add(this.lst_Localidad);
            this.Gb_Localidad.ForeColor = System.Drawing.Color.Blue;
            this.Gb_Localidad.Location = new System.Drawing.Point(289, 222);
            this.Gb_Localidad.Name = "Gb_Localidad";
            this.Gb_Localidad.Size = new System.Drawing.Size(200, 173);
            this.Gb_Localidad.TabIndex = 0;
            this.Gb_Localidad.TabStop = false;
            this.Gb_Localidad.Text = "Localidad";
            // 
            // lst_Localidad
            // 
            this.lst_Localidad.FormattingEnabled = true;
            this.lst_Localidad.Location = new System.Drawing.Point(16, 20);
            this.lst_Localidad.Name = "lst_Localidad";
            this.lst_Localidad.Size = new System.Drawing.Size(169, 147);
            this.lst_Localidad.TabIndex = 0;
            this.lst_Localidad.SelectedIndexChanged += new System.EventHandler(this.lst_Localidad_SelectedIndexChanged);
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(495, 16);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(178, 41);
            this.btn_mostrar.TabIndex = 1;
            this.btn_mostrar.Text = "todos los alumnos";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(495, 201);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(850, 134);
            this.listBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(679, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "todos los alumnos con antiguedad superior a dos años";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_
            // 
            this.btn_.Location = new System.Drawing.Point(499, 71);
            this.btn_.Name = "btn_";
            this.btn_.Size = new System.Drawing.Size(174, 41);
            this.btn_.TabIndex = 4;
            this.btn_.Text = "alumnos por localidad ingresada mediante un inputbox";
            this.btn_.UseVisualStyleBackColor = true;
            // 
            // txt_IngresoLocalidad
            // 
            this.txt_IngresoLocalidad.Location = new System.Drawing.Point(679, 82);
            this.txt_IngresoLocalidad.Name = "txt_IngresoLocalidad";
            this.txt_IngresoLocalidad.Size = new System.Drawing.Size(185, 20);
            this.txt_IngresoLocalidad.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(499, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 46);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 407);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_IngresoLocalidad);
            this.Controls.Add(this.btn_);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.Gb__opciones);
            this.Controls.Add(this.Gb_cursos);
            this.Controls.Add(this.Gb_Localidad);
            this.Controls.Add(this.Gb_ingresodatos);
            this.Name = "Form1";
            this.Text = "Ingreso de Matricula";
            this.Gb_ingresodatos.ResumeLayout(false);
            this.Gb_ingresodatos.PerformLayout();
            this.Gb__opciones.ResumeLayout(false);
            this.Gb_cursos.ResumeLayout(false);
            this.Gb_Localidad.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gb_ingresodatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_curso;
        private System.Windows.Forms.GroupBox Gb__opciones;
        private System.Windows.Forms.GroupBox Gb_cursos;
        private System.Windows.Forms.ListBox Lst_Cursos;
        private System.Windows.Forms.GroupBox Gb_Localidad;
        private System.Windows.Forms.ListBox lst_Localidad;
        private System.Windows.Forms.RadioButton rdb_masc;
        private System.Windows.Forms.RadioButton rdb_Fem;
        private System.Windows.Forms.TextBox txt_localidad;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_Alumno;
        private System.Windows.Forms.TextBox txt_curso;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_;
        private System.Windows.Forms.TextBox txt_IngresoLocalidad;
        private System.Windows.Forms.Button button2;
    }
}

