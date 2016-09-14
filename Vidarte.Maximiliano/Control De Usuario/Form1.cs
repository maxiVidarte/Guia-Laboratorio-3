using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace Control_De_Usuario
{
    public partial class Form1 : Form
    {

        MiEntidad[] miArray = new MiEntidad[10];
        MiEntidad unE = new MiEntidad(2, "pepito", 15);
        MiEntidad dosE = new MiEntidad(3, "petraccio", 20);
        MiEntidad tresE = new MiEntidad(2, "pedro", 20);
        MiEntidad cuatroE = new MiEntidad(1, "beto", 10);
        MiEntidad cincoE = new MiEntidad(5, "hola", 40);
        MiEntidad seisE = new MiEntidad(6, "mundo", 50);
        MiEntidad sieteE = new MiEntidad(7, "carlo", 2);
        MiEntidad ochoE = new MiEntidad(0, "n n ", 20);
        MiEntidad nueveE = new MiEntidad(9, "yui", 90);
        MiEntidad diezE = new MiEntidad(70, "erdfs", 40);
        
        public void Ordenamiento()
        {
            Array.Sort(miArray, MiEntidad.ComparaAtributo);
             
        }

        public Form1()
        {
            InitializeComponent();
            
        
            this.miArray.SetValue(unE, 0);
            this.miArray.SetValue(dosE, 1);
            this.miArray.SetValue(tresE, 2);
            this.miArray.SetValue(cuatroE,3);
            this.miArray.SetValue(cincoE,4);
            this.miArray.SetValue(seisE,5);
            this.miArray.SetValue(sieteE,6);
            this.miArray.SetValue(ochoE, 7);
            this.miArray.SetValue(nueveE, 8);
            this.miArray.SetValue(diezE, 9);
            this.Ordenamiento();
            this.lst_lista.Items.AddRange(miArray);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(miArray.GetValue(0).ToString(), "Informacion");
        }
    }
}
