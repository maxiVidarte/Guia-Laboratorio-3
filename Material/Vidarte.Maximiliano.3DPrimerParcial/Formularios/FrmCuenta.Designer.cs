namespace Formularios
{
    partial class FrmCuenta
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
            this.lbl_NroCuenta = new System.Windows.Forms.Label();
            this.lbl_Titular = new System.Windows.Forms.Label();
            this.txt_NroCuenta = new System.Windows.Forms.TextBox();
            this.txt_Titular = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(12, 227);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 0;
            this.btn_Aceptar.Text = "&Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(197, 227);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "&Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // lbl_NroCuenta
            // 
            this.lbl_NroCuenta.AutoSize = true;
            this.lbl_NroCuenta.Location = new System.Drawing.Point(20, 54);
            this.lbl_NroCuenta.Name = "lbl_NroCuenta";
            this.lbl_NroCuenta.Size = new System.Drawing.Size(67, 13);
            this.lbl_NroCuenta.TabIndex = 2;
            this.lbl_NroCuenta.Text = "Nro Cuenta: ";
            // 
            // lbl_Titular
            // 
            this.lbl_Titular.AutoSize = true;
            this.lbl_Titular.Location = new System.Drawing.Point(45, 104);
            this.lbl_Titular.Name = "lbl_Titular";
            this.lbl_Titular.Size = new System.Drawing.Size(42, 13);
            this.lbl_Titular.TabIndex = 3;
            this.lbl_Titular.Text = "Titular: ";
            // 
            // txt_NroCuenta
            // 
            this.txt_NroCuenta.Location = new System.Drawing.Point(93, 51);
            this.txt_NroCuenta.Name = "txt_NroCuenta";
            this.txt_NroCuenta.Size = new System.Drawing.Size(100, 20);
            this.txt_NroCuenta.TabIndex = 4;
            // 
            // txt_Titular
            // 
            this.txt_Titular.Location = new System.Drawing.Point(93, 101);
            this.txt_Titular.Name = "txt_Titular";
            this.txt_Titular.Size = new System.Drawing.Size(100, 20);
            this.txt_Titular.TabIndex = 5;
            // 
            // FrmCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txt_Titular);
            this.Controls.Add(this.txt_NroCuenta);
            this.Controls.Add(this.lbl_Titular);
            this.Controls.Add(this.lbl_NroCuenta);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Name = "FrmCuenta";
            this.Text = "FrmCuenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btn_Aceptar;
        protected System.Windows.Forms.Button btn_Cancelar;
        protected System.Windows.Forms.Label lbl_NroCuenta;
        protected System.Windows.Forms.Label lbl_Titular;
        protected internal System.Windows.Forms.TextBox txt_NroCuenta;
        protected internal System.Windows.Forms.TextBox txt_Titular;
    }
}