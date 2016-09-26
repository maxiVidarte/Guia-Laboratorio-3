namespace FrmPrincipal
{
    partial class FrmMostrar
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
            this.label2 = new System.Windows.Forms.Label();
            this.lst_MedicoOff = new System.Windows.Forms.ListBox();
            this.lst_MedicoOn = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trabajando";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Retirados";
            // 
            // lst_MedicoOff
            // 
            this.lst_MedicoOff.FormattingEnabled = true;
            this.lst_MedicoOff.Location = new System.Drawing.Point(489, 59);
            this.lst_MedicoOff.Name = "lst_MedicoOff";
            this.lst_MedicoOff.Size = new System.Drawing.Size(501, 186);
            this.lst_MedicoOff.TabIndex = 2;
            // 
            // lst_MedicoOn
            // 
            this.lst_MedicoOn.FormattingEnabled = true;
            this.lst_MedicoOn.Location = new System.Drawing.Point(12, 59);
            this.lst_MedicoOn.Name = "lst_MedicoOn";
            this.lst_MedicoOn.Size = new System.Drawing.Size(471, 186);
            this.lst_MedicoOn.TabIndex = 3;
            // 
            // FrmMostrar
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1035, 262);
            this.ControlBox = false;
            this.Controls.Add(this.lst_MedicoOn);
            this.Controls.Add(this.lst_MedicoOff);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMostrar";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMostrar";
            this.Load += new System.EventHandler(this.FrmMostrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_MedicoOff;
        private System.Windows.Forms.ListBox lst_MedicoOn;
    }
}