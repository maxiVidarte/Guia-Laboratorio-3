namespace Formularios
{
    partial class FrmCuentaOffShore
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
            this.cmb_EParaiso = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.TabIndex = 3;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.TabIndex = 4;
            // 
            // txt_NroCuenta
            // 
            this.txt_NroCuenta.TabIndex = 0;
            // 
            // txt_Titular
            // 
            this.txt_Titular.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Paraiso Fiscal:";
            // 
            // cmb_EParaiso
            // 
            this.cmb_EParaiso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_EParaiso.FormattingEnabled = true;
            this.cmb_EParaiso.Location = new System.Drawing.Point(93, 149);
            this.cmb_EParaiso.Name = "cmb_EParaiso";
            this.cmb_EParaiso.Size = new System.Drawing.Size(100, 21);
            this.cmb_EParaiso.TabIndex = 2;
            // 
            // FrmCuentaOffShore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cmb_EParaiso);
            this.Controls.Add(this.label1);
            this.Name = "FrmCuentaOffShore";
            this.Text = "FrmCuentaOffShore";
            this.Controls.SetChildIndex(this.btn_Aceptar, 0);
            this.Controls.SetChildIndex(this.btn_Cancelar, 0);
            this.Controls.SetChildIndex(this.lbl_NroCuenta, 0);
            this.Controls.SetChildIndex(this.lbl_Titular, 0);
            this.Controls.SetChildIndex(this.txt_NroCuenta, 0);
            this.Controls.SetChildIndex(this.txt_Titular, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cmb_EParaiso, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.ComboBox cmb_EParaiso;
    }
}