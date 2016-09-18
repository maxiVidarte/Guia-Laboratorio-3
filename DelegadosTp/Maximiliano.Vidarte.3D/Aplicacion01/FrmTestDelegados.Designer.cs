namespace Aplicacion01
{
    partial class FrmTestDelegados
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
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.txt_actualizar = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(85, 130);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(100, 23);
            this.btn_actualizar.TabIndex = 0;
            this.btn_actualizar.Text = "&Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // txt_actualizar
            // 
            this.txt_actualizar.Location = new System.Drawing.Point(85, 72);
            this.txt_actualizar.Name = "txt_actualizar";
            this.txt_actualizar.Size = new System.Drawing.Size(100, 20);
            this.txt_actualizar.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmTestDelegados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txt_actualizar);
            this.Controls.Add(this.btn_actualizar);
            this.Name = "FrmTestDelegados";
            this.Text = "FrmTestDelegados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.TextBox txt_actualizar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}