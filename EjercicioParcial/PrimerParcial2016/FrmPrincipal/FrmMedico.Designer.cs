namespace FrmPrincipal
{
    partial class FrmMedico
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
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_Legajo = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Especialidad = new System.Windows.Forms.Label();
            this.cmb_Especialidad = new System.Windows.Forms.ComboBox();
            this.txt_Legajo = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(19, 218);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 0;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(165, 218);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // lbl_Legajo
            // 
            this.lbl_Legajo.AutoSize = true;
            this.lbl_Legajo.Location = new System.Drawing.Point(32, 35);
            this.lbl_Legajo.Name = "lbl_Legajo";
            this.lbl_Legajo.Size = new System.Drawing.Size(39, 13);
            this.lbl_Legajo.TabIndex = 2;
            this.lbl_Legajo.Text = "Legajo";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(32, 81);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_Nombre.TabIndex = 3;
            this.lbl_Nombre.Text = "Nombre ";
            // 
            // lbl_Especialidad
            // 
            this.lbl_Especialidad.AutoSize = true;
            this.lbl_Especialidad.Location = new System.Drawing.Point(32, 124);
            this.lbl_Especialidad.Name = "lbl_Especialidad";
            this.lbl_Especialidad.Size = new System.Drawing.Size(67, 13);
            this.lbl_Especialidad.TabIndex = 4;
            this.lbl_Especialidad.Text = "Especialidad";
            // 
            // cmb_Especialidad
            // 
            this.cmb_Especialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Especialidad.FormattingEnabled = true;
            this.cmb_Especialidad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmb_Especialidad.Location = new System.Drawing.Point(119, 121);
            this.cmb_Especialidad.Name = "cmb_Especialidad";
            this.cmb_Especialidad.Size = new System.Drawing.Size(121, 21);
            this.cmb_Especialidad.Sorted = true;
            this.cmb_Especialidad.TabIndex = 5;
            this.cmb_Especialidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Especialidad_KeyPress);
            // 
            // txt_Legajo
            // 
            this.txt_Legajo.Location = new System.Drawing.Point(119, 32);
            this.txt_Legajo.Name = "txt_Legajo";
            this.txt_Legajo.Size = new System.Drawing.Size(121, 20);
            this.txt_Legajo.TabIndex = 6;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(119, 78);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(121, 20);
            this.txt_Nombre.TabIndex = 7;
            // 
            // FrmMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cmb_Especialidad);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Legajo);
            this.Controls.Add(this.lbl_Especialidad);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_Legajo);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Name = "FrmMedico";
            this.Text = "FrmMedico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lbl_Legajo;
        protected System.Windows.Forms.Label lbl_Nombre;
        protected System.Windows.Forms.Label lbl_Especialidad;
        protected System.Windows.Forms.Button btn_Aceptar;
        protected System.Windows.Forms.Button btn_Cancelar;
        protected internal System.Windows.Forms.ComboBox cmb_Especialidad;
        protected internal System.Windows.Forms.TextBox txt_Legajo;
        protected internal System.Windows.Forms.TextBox txt_Nombre;
    }
}