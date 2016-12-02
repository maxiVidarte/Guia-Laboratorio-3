namespace Ejemplo_del_dataAdapter
{
    partial class FrmEstados
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
            this.button1 = new System.Windows.Forms.Button();
            this.lst_estados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Continuar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lst_estados
            // 
            this.lst_estados.FormattingEnabled = true;
            this.lst_estados.Location = new System.Drawing.Point(12, 12);
            this.lst_estados.Name = "lst_estados";
            this.lst_estados.Size = new System.Drawing.Size(460, 199);
            this.lst_estados.TabIndex = 1;
            // 
            // FrmEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.lst_estados);
            this.Controls.Add(this.button1);
            this.Name = "FrmEstados";
            this.Text = "FrmEstados";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListBox lst_estados;
    }
}