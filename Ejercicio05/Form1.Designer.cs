namespace Ejercicio05
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_CDC = new System.Windows.Forms.TextBox();
            this.txt_SCP = new System.Windows.Forms.TextBox();
            this.txt_SCI = new System.Windows.Forms.TextBox();
            this.txt_CMayor = new System.Windows.Forms.TextBox();
            this.txt_CMenor = new System.Windows.Forms.TextBox();
            this.txt_STC = new System.Windows.Forms.TextBox();
            this.lbl_CMenor = new System.Windows.Forms.Label();
            this.lbl_CMayor = new System.Windows.Forms.Label();
            this.lbl_STC = new System.Windows.Forms.Label();
            this.lbl_SCP = new System.Windows.Forms.Label();
            this.lbl_SCI = new System.Windows.Forms.Label();
            this.lbl_CDC = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lst_listaDiv = new System.Windows.Forms.ListBox();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Numero);
            this.groupBox1.Controls.Add(this.lbl_numero);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_Numero
            // 
            this.txt_Numero.Location = new System.Drawing.Point(124, 19);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(70, 20);
            this.txt_Numero.TabIndex = 1;
            this.txt_Numero.TextChanged += new System.EventHandler(this.txt_Numero_TextChanged);
            this.txt_Numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Numero_KeyPress);
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(6, 22);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(101, 13);
            this.lbl_numero.TabIndex = 0;
            this.lbl_numero.Text = "Ingrese un número: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_CDC);
            this.groupBox2.Controls.Add(this.txt_SCP);
            this.groupBox2.Controls.Add(this.txt_SCI);
            this.groupBox2.Controls.Add(this.txt_CMayor);
            this.groupBox2.Controls.Add(this.txt_CMenor);
            this.groupBox2.Controls.Add(this.txt_STC);
            this.groupBox2.Controls.Add(this.lbl_CMenor);
            this.groupBox2.Controls.Add(this.lbl_CMayor);
            this.groupBox2.Controls.Add(this.lbl_STC);
            this.groupBox2.Controls.Add(this.lbl_SCP);
            this.groupBox2.Controls.Add(this.lbl_SCI);
            this.groupBox2.Controls.Add(this.lbl_CDC);
            this.groupBox2.Location = new System.Drawing.Point(12, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 177);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // txt_CDC
            // 
            this.txt_CDC.Location = new System.Drawing.Point(128, 13);
            this.txt_CDC.Name = "txt_CDC";
            this.txt_CDC.Size = new System.Drawing.Size(66, 20);
            this.txt_CDC.TabIndex = 4;
            // 
            // txt_SCP
            // 
            this.txt_SCP.Location = new System.Drawing.Point(128, 65);
            this.txt_SCP.Name = "txt_SCP";
            this.txt_SCP.Size = new System.Drawing.Size(66, 20);
            this.txt_SCP.TabIndex = 5;
            // 
            // txt_SCI
            // 
            this.txt_SCI.Location = new System.Drawing.Point(128, 39);
            this.txt_SCI.Name = "txt_SCI";
            this.txt_SCI.Size = new System.Drawing.Size(66, 20);
            this.txt_SCI.TabIndex = 2;
            // 
            // txt_CMayor
            // 
            this.txt_CMayor.Location = new System.Drawing.Point(128, 117);
            this.txt_CMayor.Name = "txt_CMayor";
            this.txt_CMayor.Size = new System.Drawing.Size(66, 20);
            this.txt_CMayor.TabIndex = 6;
            // 
            // txt_CMenor
            // 
            this.txt_CMenor.Location = new System.Drawing.Point(128, 143);
            this.txt_CMenor.Name = "txt_CMenor";
            this.txt_CMenor.Size = new System.Drawing.Size(66, 20);
            this.txt_CMenor.TabIndex = 7;
            // 
            // txt_STC
            // 
            this.txt_STC.Location = new System.Drawing.Point(128, 91);
            this.txt_STC.Name = "txt_STC";
            this.txt_STC.Size = new System.Drawing.Size(66, 20);
            this.txt_STC.TabIndex = 3;
            // 
            // lbl_CMenor
            // 
            this.lbl_CMenor.AutoSize = true;
            this.lbl_CMenor.Location = new System.Drawing.Point(6, 146);
            this.lbl_CMenor.Name = "lbl_CMenor";
            this.lbl_CMenor.Size = new System.Drawing.Size(60, 13);
            this.lbl_CMenor.TabIndex = 6;
            this.lbl_CMenor.Text = "Cifra menor";
            // 
            // lbl_CMayor
            // 
            this.lbl_CMayor.AutoSize = true;
            this.lbl_CMayor.Location = new System.Drawing.Point(6, 120);
            this.lbl_CMayor.Name = "lbl_CMayor";
            this.lbl_CMayor.Size = new System.Drawing.Size(59, 13);
            this.lbl_CMayor.TabIndex = 5;
            this.lbl_CMayor.Text = "Cifra mayor";
            // 
            // lbl_STC
            // 
            this.lbl_STC.AutoSize = true;
            this.lbl_STC.Location = new System.Drawing.Point(6, 94);
            this.lbl_STC.Name = "lbl_STC";
            this.lbl_STC.Size = new System.Drawing.Size(100, 13);
            this.lbl_STC.TabIndex = 4;
            this.lbl_STC.Text = "Suma total de cifras";
            // 
            // lbl_SCP
            // 
            this.lbl_SCP.AutoSize = true;
            this.lbl_SCP.Location = new System.Drawing.Point(6, 68);
            this.lbl_SCP.Name = "lbl_SCP";
            this.lbl_SCP.Size = new System.Drawing.Size(106, 13);
            this.lbl_SCP.TabIndex = 3;
            this.lbl_SCP.Text = "Suma de cifras pares";
            // 
            // lbl_SCI
            // 
            this.lbl_SCI.AutoSize = true;
            this.lbl_SCI.Location = new System.Drawing.Point(6, 42);
            this.lbl_SCI.Name = "lbl_SCI";
            this.lbl_SCI.Size = new System.Drawing.Size(116, 13);
            this.lbl_SCI.TabIndex = 2;
            this.lbl_SCI.Text = "Suma de cifras impares";
            // 
            // lbl_CDC
            // 
            this.lbl_CDC.AutoSize = true;
            this.lbl_CDC.Location = new System.Drawing.Point(6, 16);
            this.lbl_CDC.Name = "lbl_CDC";
            this.lbl_CDC.Size = new System.Drawing.Size(92, 13);
            this.lbl_CDC.TabIndex = 1;
            this.lbl_CDC.Text = "Cantidad de cifras";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lst_listaDiv);
            this.groupBox3.Location = new System.Drawing.Point(218, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 177);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Divisores";
            // 
            // lst_listaDiv
            // 
            this.lst_listaDiv.FormattingEnabled = true;
            this.lst_listaDiv.Location = new System.Drawing.Point(3, 16);
            this.lst_listaDiv.Name = "lst_listaDiv";
            this.lst_listaDiv.Size = new System.Drawing.Size(191, 147);
            this.lst_listaDiv.TabIndex = 0;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(262, 24);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar.TabIndex = 1;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(343, 24);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 2;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 271);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Informacion Del Numero";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_CDC;
        private System.Windows.Forms.TextBox txt_SCP;
        private System.Windows.Forms.TextBox txt_SCI;
        private System.Windows.Forms.TextBox txt_CMayor;
        private System.Windows.Forms.TextBox txt_CMenor;
        private System.Windows.Forms.TextBox txt_STC;
        private System.Windows.Forms.Label lbl_CMenor;
        private System.Windows.Forms.Label lbl_CMayor;
        private System.Windows.Forms.Label lbl_STC;
        private System.Windows.Forms.Label lbl_SCP;
        private System.Windows.Forms.Label lbl_SCI;
        private System.Windows.Forms.Label lbl_CDC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.ListBox lst_listaDiv;
    }
}

