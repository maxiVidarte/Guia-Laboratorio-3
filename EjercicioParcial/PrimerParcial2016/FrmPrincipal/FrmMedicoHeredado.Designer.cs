namespace FrmPrincipal
{
    partial class FrmMedicoHeredado:FrmMedico
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Salario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmb_Especialidad
            // 
            this.cmb_Especialidad.Enabled = false;
            // 
            // txt_Legajo
            // 
            this.txt_Legajo.ReadOnly = true;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pago";
            // 
            // txt_Salario
            // 
            this.txt_Salario.Location = new System.Drawing.Point(119, 163);
            this.txt_Salario.Name = "txt_Salario";
            this.txt_Salario.ReadOnly = true;
            this.txt_Salario.Size = new System.Drawing.Size(121, 20);
            this.txt_Salario.TabIndex = 9;
            // 
            // FrmMedicoHeredado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txt_Salario);
            this.Controls.Add(this.label1);
            this.Name = "FrmMedicoHeredado";
            this.Text = "FrmMedicoHeredado";
            this.Controls.SetChildIndex(this.btn_Aceptar, 0);
            this.Controls.SetChildIndex(this.btn_Cancelar, 0);
            this.Controls.SetChildIndex(this.lbl_Legajo, 0);
            this.Controls.SetChildIndex(this.lbl_Nombre, 0);
            this.Controls.SetChildIndex(this.lbl_Especialidad, 0);
            this.Controls.SetChildIndex(this.txt_Legajo, 0);
            this.Controls.SetChildIndex(this.txt_Nombre, 0);
            this.Controls.SetChildIndex(this.cmb_Especialidad, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txt_Salario, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.TextBox txt_Salario;
    }
}