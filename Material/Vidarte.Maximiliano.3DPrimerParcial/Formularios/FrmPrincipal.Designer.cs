namespace Formularios
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCmb_Ordenar = new System.Windows.Forms.ToolStripComboBox();
            this.mostrarListadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lst_listado = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.bajaToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.toolStripCmb_Ordenar,
            this.mostrarListadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(427, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(40, 23);
            this.altaToolStripMenuItem.Text = "Alta";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // bajaToolStripMenuItem
            // 
            this.bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            this.bajaToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.bajaToolStripMenuItem.Text = "Baja";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 23);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // toolStripCmb_Ordenar
            // 
            this.toolStripCmb_Ordenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripCmb_Ordenar.Name = "toolStripCmb_Ordenar";
            this.toolStripCmb_Ordenar.Size = new System.Drawing.Size(121, 23);
            this.toolStripCmb_Ordenar.Click += new System.EventHandler(this.toolStripCmb_Ordenar_Click);
            // 
            // mostrarListadoToolStripMenuItem
            // 
            this.mostrarListadoToolStripMenuItem.Name = "mostrarListadoToolStripMenuItem";
            this.mostrarListadoToolStripMenuItem.Size = new System.Drawing.Size(101, 23);
            this.mostrarListadoToolStripMenuItem.Text = "Mostrar Listado";
            this.mostrarListadoToolStripMenuItem.Click += new System.EventHandler(this.mostrarListadoToolStripMenuItem_Click);
            // 
            // lst_listado
            // 
            this.lst_listado.FormattingEnabled = true;
            this.lst_listado.Location = new System.Drawing.Point(0, 30);
            this.lst_listado.Name = "lst_listado";
            this.lst_listado.Size = new System.Drawing.Size(427, 225);
            this.lst_listado.TabIndex = 1;
            //this.lst_listado.SelectedIndexChanged += new System.EventHandler(this.lst_listado_SelectedIndexChanged);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 262);
            this.Controls.Add(this.lst_listado);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.MenuStrip menuStrip1;
        protected System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        protected System.Windows.Forms.ToolStripComboBox toolStripCmb_Ordenar;
        protected System.Windows.Forms.ToolStripMenuItem mostrarListadoToolStripMenuItem;
        protected System.Windows.Forms.ListBox lst_listado;
    }
}

