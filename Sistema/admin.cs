using MenuDesplegable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
   
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        public bool esCaracter = false;
        private void button1_Click(object sender, EventArgs e)
        {

            var usuario = textBox1.Text;
            var contra = textBox2.Text;

            var respuesta = funcioneslocker.login(usuario,contra);

            if (respuesta)
            {
                MessageBox.Show("Bienvenido administrador");
               
                this.Visible = false;
                
               

            }
            else
            {
                MessageBox.Show("El usuario y/o contraseña no son correctos");
            }

        }
      
    }
}
