namespace Ejemplo_del_dataAdapter
{
    partial class FrmDatos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_Tipo = new System.Windows.Forms.TextBox();
            this.Txt_Proveedor = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.bnt_Cancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.Txt_Proveedor);
            this.panel1.Controls.Add(this.Txt_Tipo);
            this.panel1.Controls.Add(this.txt_Nombre);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 207);
            this.panel1.TabIndex = 0;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(119, 29);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 0;
            // 
            // Txt_Tipo
            // 
            this.Txt_Tipo.Location = new System.Drawing.Point(119, 55);
            this.Txt_Tipo.Name = "Txt_Tipo";
            this.Txt_Tipo.Size = new System.Drawing.Size(100, 20);
            this.Txt_Tipo.TabIndex = 1;
            // 
            // Txt_Proveedor
            // 
            this.Txt_Proveedor.Location = new System.Drawing.Point(119, 81);
            this.Txt_Proveedor.Name = "Txt_Proveedor";
            this.Txt_Proveedor.Size = new System.Drawing.Size(100, 20);
            this.Txt_Proveedor.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(40, 32);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(44, 13);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Proveedor";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(12, 236);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 6;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // bnt_Cancelar
            // 
            this.bnt_Cancelar.Location = new System.Drawing.Point(197, 236);
            this.bnt_Cancelar.Name = "bnt_Cancelar";
            this.bnt_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.bnt_Cancelar.TabIndex = 7;
            this.bnt_Cancelar.Text = "Cancelar";
            this.bnt_Cancelar.UseVisualStyleBackColor = true;
            this.bnt_Cancelar.Click += new System.EventHandler(this.bnt_Cancelar_Click);
            // 
            // FrmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.bnt_Cancelar);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDatos";
            this.Text = "FrmDatos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox Txt_Proveedor;
        private System.Windows.Forms.TextBox Txt_Tipo;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button bnt_Cancelar;
    }
}