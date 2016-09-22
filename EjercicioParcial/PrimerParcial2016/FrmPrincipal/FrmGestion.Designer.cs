namespace FrmPrincipal
{
    partial class FrmGestion
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
            this.lst_Medicos = new System.Windows.Forms.ListBox();
            this.cmb_Ordenamiento = new System.Windows.Forms.ComboBox();
            this.btn_Modificacion = new System.Windows.Forms.Button();
            this.btn_Egreso = new System.Windows.Forms.Button();
            this.btn_Ingreso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_Medicos
            // 
            this.lst_Medicos.FormattingEnabled = true;
            this.lst_Medicos.Location = new System.Drawing.Point(12, 22);
            this.lst_Medicos.Name = "lst_Medicos";
            this.lst_Medicos.Size = new System.Drawing.Size(549, 186);
            this.lst_Medicos.TabIndex = 0;
            // 
            // cmb_Ordenamiento
            // 
            this.cmb_Ordenamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Ordenamiento.FormattingEnabled = true;
            this.cmb_Ordenamiento.Location = new System.Drawing.Point(474, 229);
            this.cmb_Ordenamiento.Name = "cmb_Ordenamiento";
            this.cmb_Ordenamiento.Size = new System.Drawing.Size(87, 21);
            this.cmb_Ordenamiento.TabIndex = 1;
            this.cmb_Ordenamiento.SelectedIndexChanged += new System.EventHandler(this.cmb_Ordenamiento_SelectedIndexChanged);
            this.cmb_Ordenamiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_especialidad_KeyPress);
            // 
            // btn_Modificacion
            // 
            this.btn_Modificacion.Location = new System.Drawing.Point(157, 227);
            this.btn_Modificacion.Name = "btn_Modificacion";
            this.btn_Modificacion.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificacion.TabIndex = 2;
            this.btn_Modificacion.Text = "Modificacion";
            this.btn_Modificacion.UseVisualStyleBackColor = true;
            // 
            // btn_Egreso
            // 
            this.btn_Egreso.Location = new System.Drawing.Point(329, 227);
            this.btn_Egreso.Name = "btn_Egreso";
            this.btn_Egreso.Size = new System.Drawing.Size(75, 23);
            this.btn_Egreso.TabIndex = 3;
            this.btn_Egreso.Text = "Egreso";
            this.btn_Egreso.UseVisualStyleBackColor = true;
            // 
            // btn_Ingreso
            // 
            this.btn_Ingreso.Location = new System.Drawing.Point(12, 227);
            this.btn_Ingreso.Name = "btn_Ingreso";
            this.btn_Ingreso.Size = new System.Drawing.Size(75, 23);
            this.btn_Ingreso.TabIndex = 4;
            this.btn_Ingreso.Text = "Ingreso";
            this.btn_Ingreso.UseVisualStyleBackColor = true;
            this.btn_Ingreso.Click += new System.EventHandler(this.btn_Ingreso_Click);
            // 
            // FrmGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.btn_Ingreso);
            this.Controls.Add(this.btn_Egreso);
            this.Controls.Add(this.btn_Modificacion);
            this.Controls.Add(this.cmb_Ordenamiento);
            this.Controls.Add(this.lst_Medicos);
            this.Name = "FrmGestion";
            this.Text = "FrmGestion";
            this.Load += new System.EventHandler(this.FrmGestion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.ComboBox cmb_Ordenamiento;
        protected System.Windows.Forms.Button btn_Modificacion;
        protected System.Windows.Forms.Button btn_Egreso;
        protected System.Windows.Forms.Button btn_Ingreso;
        protected System.Windows.Forms.ListBox lst_Medicos;

    }
}