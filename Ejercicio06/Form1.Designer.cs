namespace Ejercicio06
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.gpb_dinero = new System.Windows.Forms.GroupBox();
            this.txt_dinero = new System.Windows.Forms.TextBox();
            this.lbl_dinero = new System.Windows.Forms.Label();
            this.gpb_Billetes = new System.Windows.Forms.GroupBox();
            this.txt_billete100 = new System.Windows.Forms.TextBox();
            this.txt_billete50 = new System.Windows.Forms.TextBox();
            this.txt_billete20 = new System.Windows.Forms.TextBox();
            this.txt_billete10 = new System.Windows.Forms.TextBox();
            this.txt_billete5 = new System.Windows.Forms.TextBox();
            this.txt_billete2 = new System.Windows.Forms.TextBox();
            this.lbl_billete100 = new System.Windows.Forms.Label();
            this.lbl_billete50 = new System.Windows.Forms.Label();
            this.lbl_billete20 = new System.Windows.Forms.Label();
            this.lbl_billete10 = new System.Windows.Forms.Label();
            this.lbl_billete5 = new System.Windows.Forms.Label();
            this.lbl_billete2 = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.gpb_dinero.SuspendLayout();
            this.gpb_Billetes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_dinero
            // 
            this.gpb_dinero.Controls.Add(this.txt_dinero);
            this.gpb_dinero.Controls.Add(this.lbl_dinero);
            this.gpb_dinero.Location = new System.Drawing.Point(12, 12);
            this.gpb_dinero.Name = "gpb_dinero";
            this.gpb_dinero.Size = new System.Drawing.Size(216, 100);
            this.gpb_dinero.TabIndex = 0;
            this.gpb_dinero.TabStop = false;
            this.gpb_dinero.Text = "Cantidad a Retirar";
            // 
            // txt_dinero
            // 
            this.txt_dinero.Location = new System.Drawing.Point(105, 40);
            this.txt_dinero.Name = "txt_dinero";
            this.txt_dinero.Size = new System.Drawing.Size(100, 20);
            this.txt_dinero.TabIndex = 1;
            this.txt_dinero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dinero_KeyPress);
            // 
            // lbl_dinero
            // 
            this.lbl_dinero.AutoSize = true;
            this.lbl_dinero.Location = new System.Drawing.Point(6, 43);
            this.lbl_dinero.Name = "lbl_dinero";
            this.lbl_dinero.Size = new System.Drawing.Size(93, 13);
            this.lbl_dinero.TabIndex = 0;
            this.lbl_dinero.Text = "Cantidad a retirar :";
            // 
            // gpb_Billetes
            // 
            this.gpb_Billetes.Controls.Add(this.txt_billete100);
            this.gpb_Billetes.Controls.Add(this.txt_billete50);
            this.gpb_Billetes.Controls.Add(this.txt_billete20);
            this.gpb_Billetes.Controls.Add(this.txt_billete10);
            this.gpb_Billetes.Controls.Add(this.txt_billete5);
            this.gpb_Billetes.Controls.Add(this.txt_billete2);
            this.gpb_Billetes.Controls.Add(this.lbl_billete100);
            this.gpb_Billetes.Controls.Add(this.lbl_billete50);
            this.gpb_Billetes.Controls.Add(this.lbl_billete20);
            this.gpb_Billetes.Controls.Add(this.lbl_billete10);
            this.gpb_Billetes.Controls.Add(this.lbl_billete5);
            this.gpb_Billetes.Controls.Add(this.lbl_billete2);
            this.gpb_Billetes.Location = new System.Drawing.Point(12, 118);
            this.gpb_Billetes.Name = "gpb_Billetes";
            this.gpb_Billetes.Size = new System.Drawing.Size(216, 199);
            this.gpb_Billetes.TabIndex = 0;
            this.gpb_Billetes.TabStop = false;
            this.gpb_Billetes.Text = "Cantidad De Billetes";
            // 
            // txt_billete100
            // 
            this.txt_billete100.Enabled = false;
            this.txt_billete100.Location = new System.Drawing.Point(105, 165);
            this.txt_billete100.Name = "txt_billete100";
            this.txt_billete100.Size = new System.Drawing.Size(100, 20);
            this.txt_billete100.TabIndex = 11;
            this.txt_billete100.Text = "0";
            // 
            // txt_billete50
            // 
            this.txt_billete50.Enabled = false;
            this.txt_billete50.Location = new System.Drawing.Point(105, 139);
            this.txt_billete50.Name = "txt_billete50";
            this.txt_billete50.Size = new System.Drawing.Size(100, 20);
            this.txt_billete50.TabIndex = 10;
            this.txt_billete50.Text = "0";
            // 
            // txt_billete20
            // 
            this.txt_billete20.Enabled = false;
            this.txt_billete20.Location = new System.Drawing.Point(105, 113);
            this.txt_billete20.Name = "txt_billete20";
            this.txt_billete20.Size = new System.Drawing.Size(100, 20);
            this.txt_billete20.TabIndex = 9;
            this.txt_billete20.Text = "0";
            // 
            // txt_billete10
            // 
            this.txt_billete10.Enabled = false;
            this.txt_billete10.Location = new System.Drawing.Point(105, 87);
            this.txt_billete10.Name = "txt_billete10";
            this.txt_billete10.Size = new System.Drawing.Size(100, 20);
            this.txt_billete10.TabIndex = 8;
            this.txt_billete10.Text = "0";
            // 
            // txt_billete5
            // 
            this.txt_billete5.Enabled = false;
            this.txt_billete5.Location = new System.Drawing.Point(105, 61);
            this.txt_billete5.Name = "txt_billete5";
            this.txt_billete5.Size = new System.Drawing.Size(100, 20);
            this.txt_billete5.TabIndex = 7;
            this.txt_billete5.Text = "0";
            // 
            // txt_billete2
            // 
            this.txt_billete2.Enabled = false;
            this.txt_billete2.Location = new System.Drawing.Point(105, 35);
            this.txt_billete2.Name = "txt_billete2";
            this.txt_billete2.Size = new System.Drawing.Size(100, 20);
            this.txt_billete2.TabIndex = 6;
            this.txt_billete2.Text = "0";
            // 
            // lbl_billete100
            // 
            this.lbl_billete100.AutoSize = true;
            this.lbl_billete100.Location = new System.Drawing.Point(11, 168);
            this.lbl_billete100.Name = "lbl_billete100";
            this.lbl_billete100.Size = new System.Drawing.Size(88, 13);
            this.lbl_billete100.TabIndex = 5;
            this.lbl_billete100.Text = "Billetes de $100 :";
            // 
            // lbl_billete50
            // 
            this.lbl_billete50.AutoSize = true;
            this.lbl_billete50.Location = new System.Drawing.Point(17, 142);
            this.lbl_billete50.Name = "lbl_billete50";
            this.lbl_billete50.Size = new System.Drawing.Size(82, 13);
            this.lbl_billete50.TabIndex = 4;
            this.lbl_billete50.Text = "Billetes de $50 :";
            // 
            // lbl_billete20
            // 
            this.lbl_billete20.AutoSize = true;
            this.lbl_billete20.Location = new System.Drawing.Point(17, 116);
            this.lbl_billete20.Name = "lbl_billete20";
            this.lbl_billete20.Size = new System.Drawing.Size(82, 13);
            this.lbl_billete20.TabIndex = 3;
            this.lbl_billete20.Text = "Billetes de $20 :";
            // 
            // lbl_billete10
            // 
            this.lbl_billete10.AutoSize = true;
            this.lbl_billete10.Location = new System.Drawing.Point(17, 90);
            this.lbl_billete10.Name = "lbl_billete10";
            this.lbl_billete10.Size = new System.Drawing.Size(82, 13);
            this.lbl_billete10.TabIndex = 2;
            this.lbl_billete10.Text = "Billetes de $10 :";
            // 
            // lbl_billete5
            // 
            this.lbl_billete5.AutoSize = true;
            this.lbl_billete5.Location = new System.Drawing.Point(23, 64);
            this.lbl_billete5.Name = "lbl_billete5";
            this.lbl_billete5.Size = new System.Drawing.Size(76, 13);
            this.lbl_billete5.TabIndex = 1;
            this.lbl_billete5.Text = "Billetes de $5 :";
            // 
            // lbl_billete2
            // 
            this.lbl_billete2.AutoSize = true;
            this.lbl_billete2.Location = new System.Drawing.Point(23, 38);
            this.lbl_billete2.Name = "lbl_billete2";
            this.lbl_billete2.Size = new System.Drawing.Size(76, 13);
            this.lbl_billete2.TabIndex = 0;
            this.lbl_billete2.Text = "Billetes de $2 :";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(297, 75);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 1;
            this.btn_Aceptar.Text = "&Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(297, 130);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar.TabIndex = 2;
            this.btn_Limpiar.Text = "&Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(297, 182);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 3;
            this.btn_Salir.Text = "&Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 326);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.gpb_Billetes);
            this.Controls.Add(this.gpb_dinero);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Cajero Automatico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing_1);
            this.gpb_dinero.ResumeLayout(false);
            this.gpb_dinero.PerformLayout();
            this.gpb_Billetes.ResumeLayout(false);
            this.gpb_Billetes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_dinero;
        private System.Windows.Forms.TextBox txt_dinero;
        private System.Windows.Forms.Label lbl_dinero;
        private System.Windows.Forms.GroupBox gpb_Billetes;
        private System.Windows.Forms.TextBox txt_billete100;
        private System.Windows.Forms.TextBox txt_billete50;
        private System.Windows.Forms.TextBox txt_billete20;
        private System.Windows.Forms.TextBox txt_billete10;
        private System.Windows.Forms.TextBox txt_billete5;
        private System.Windows.Forms.TextBox txt_billete2;
        private System.Windows.Forms.Label lbl_billete100;
        private System.Windows.Forms.Label lbl_billete50;
        private System.Windows.Forms.Label lbl_billete20;
        private System.Windows.Forms.Label lbl_billete10;
        private System.Windows.Forms.Label lbl_billete5;
        private System.Windows.Forms.Label lbl_billete2;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Salir;
    }
}

