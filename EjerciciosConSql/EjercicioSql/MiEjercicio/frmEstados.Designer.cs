namespace MiEjercicio
{
    partial class frmEstados
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
            this.lstEstados = new System.Windows.Forms.ListBox();
            this.btn_continuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstEstados
            // 
            this.lstEstados.FormattingEnabled = true;
            this.lstEstados.Location = new System.Drawing.Point(72, 27);
            this.lstEstados.Name = "lstEstados";
            this.lstEstados.Size = new System.Drawing.Size(120, 95);
            this.lstEstados.TabIndex = 0;
            // 
            // btn_continuar
            // 
            this.btn_continuar.Location = new System.Drawing.Point(89, 176);
            this.btn_continuar.Name = "btn_continuar";
            this.btn_continuar.Size = new System.Drawing.Size(75, 23);
            this.btn_continuar.TabIndex = 1;
            this.btn_continuar.Text = "Continuar";
            this.btn_continuar.UseVisualStyleBackColor = true;
            // 
            // frmEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_continuar);
            this.Controls.Add(this.lstEstados);
            this.Name = "frmEstados";
            this.Text = "frmEstados";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_continuar;
        public System.Windows.Forms.ListBox lstEstados;
    }
}