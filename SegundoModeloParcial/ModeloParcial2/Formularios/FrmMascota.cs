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

namespace Formularios
{
    public partial class FrmMascota : FrmAnimal
    {
        private Mascota miMascota;
        public Mascota MiMascota { get { return this.miMascota; } }

        
        public FrmMascota()
        {
            InitializeComponent();
            cmb_Tipo.Items.Add(eTipoDeMascota.exotica);
            cmb_Tipo.Items.Add(eTipoDeMascota.hogareña);
            cmb_Tipo.SelectedIndex = 0;
        }

        public override void Aceptar(object sender, EventArgs e)
        { 
            eTipoDeMascota miEnum ;
            if(cmb_Tipo.SelectedIndex ==0)
                miEnum = eTipoDeMascota.exotica;
            else 
                miEnum = eTipoDeMascota.hogareña;

            miMascota = new Mascota(this.txt_Nombre.Text, miEnum, int.Parse(this.txt_Edad.Text));
        }
            
            
   }
}